using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Nhom8
{
    public partial class frmThueXe : Form
    {
        Form frm = (Form)Application.OpenForms["Form"];
        public frmThueXe()
        {
            InitializeComponent();
        }
        DataTable dt = null;

        public SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=OOAD;Integrated Security=True");


        public void Form1_Load(object sender, EventArgs e)
        {
            displayData();
            loadCombo();
        }


        public void displayData()
        {
            try
            {
                conn.Open();
                string query = "select * from XeDap";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                if (dt == null)
                {
                    dt = new DataTable();
                    da.Fill(dt);
                    dtgvXe.DataSource = dt;
                }
                conn.Close();
            }
            catch { }
        }

        void loadCombo()
        {
            string query = "select Id from TheThueXe";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbTheThueXe.Items.Add(dr[0]).ToString();
            }
            conn.Close();
        }

        string idd;
        int status;
        public void dtgvXe_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idd = dtgvXe.Rows[e.RowIndex].Cells[0].Value.ToString();
            status =Int32.Parse(dtgvXe.Rows[e.RowIndex].Cells[2].Value.ToString());
            
        }

        private void btnThueXe_Click(object sender, EventArgs e)
        {
            if (cbTheThueXe.SelectedIndex < -1)
            {
                MessageBox.Show("Chọn mã thẻ thuê xe");
            }
            else
            {
                try
                {
                    string queryUpdate = "update XeDap set TinhTrangXe = 1 where Id='" + idd + "'";
                    string queryInsert = "insert into PhieuThueXe(ThoiGianMuon, MaTheThueXe, MaXe) values (@ThoiGianMuon, @MaTheThueXe, @MaXe)";
                    //string query = "select TinhTrangXe from XeDap";


                    SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn);
                    SqlCommand cmdInsert = new SqlCommand(queryInsert, conn);
                    //SqlCommand cmd = new SqlCommand(query, conn);

                    cmdInsert.Parameters.AddWithValue("@ThoiGianMuon", toolStripStatusLabel1.ToString());
                    cmdInsert.Parameters.AddWithValue("@MaTheThueXe", cbTheThueXe.SelectedItem.ToString());
                    cmdInsert.Parameters.AddWithValue("@MaXe", idd);

                    conn.Open();


                    //int status = (int)cmd.ExecuteScalar();
                    if (status == 0)
                    {
                        cmdUpdate.ExecuteNonQuery();
                        cmdInsert.ExecuteNonQuery();
                        MessageBox.Show("Thuê xe thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xe đang được thuê, xin chọn xe khác để thuê!");
                    }
                    conn.Close();
                    dtgvXe.Update();
                    dtgvXe.Refresh();

                }
                catch
                {
                    MessageBox.Show("Xin chọn Mã thẻ thuê xe");
                }
            }
        }

        private void btnTraXe_Click(object sender, EventArgs e)
        {

            if (cbTheThueXe.SelectedIndex < -1)
            {
                MessageBox.Show("Chọn mã thẻ thuê xe");
            }
            else
            {
                try
                {
                    string query = "update XeDap set TinhTrangXe = 0 where Id='" + idd + "'";
                    string queryInsert = "insert into PhieuThueXe(ThoiGianTra, MaTheThueXe, MaXe) values (@ThoiGianTra, @MaTheThueXe, @MaXe)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlCommand cmdInsert = new SqlCommand(queryInsert, conn);

                    cmdInsert.Parameters.AddWithValue("@ThoiGianTra", toolStripStatusLabel1.Text);
                    cmdInsert.Parameters.AddWithValue("@MaTheThueXe", cbTheThueXe.SelectedItem.ToString());
                    cmdInsert.Parameters.AddWithValue("@MaXe", idd);


                    conn.Open();
                    if (status == 1)
                    {
                        cmdInsert.ExecuteNonQuery();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Trả xe thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Chọn nhầm mã! Xin mời chọn lại!");
                    }

                    conn.Close();

                }
                catch
                {
                    MessageBox.Show("Xin chọn Mã thẻ thuê xe");

                }
            }
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
    }
}
