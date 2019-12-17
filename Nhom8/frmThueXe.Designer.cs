namespace Nhom8
{
    partial class frmThueXe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtgvXe = new System.Windows.Forms.DataGridView();
            this.btnThueXe = new System.Windows.Forms.Button();
            this.btnTraXe = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbTheThueXe = new System.Windows.Forms.ComboBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenXE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvXe)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvXe
            // 
            this.dtgvXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TenXE,
            this.TinhTrangXe,
            this.GiaThue,
            this.Hinh});
            this.dtgvXe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvXe.Location = new System.Drawing.Point(0, 117);
            this.dtgvXe.Name = "dtgvXe";
            this.dtgvXe.Size = new System.Drawing.Size(611, 225);
            this.dtgvXe.TabIndex = 2;
            this.dtgvXe.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvXe_RowHeaderMouseClick);
            // 
            // btnThueXe
            // 
            this.btnThueXe.Location = new System.Drawing.Point(36, 25);
            this.btnThueXe.Name = "btnThueXe";
            this.btnThueXe.Size = new System.Drawing.Size(75, 23);
            this.btnThueXe.TabIndex = 3;
            this.btnThueXe.Text = "Thuê Xe";
            this.btnThueXe.UseVisualStyleBackColor = true;
            this.btnThueXe.Click += new System.EventHandler(this.btnThueXe_Click);
            // 
            // btnTraXe
            // 
            this.btnTraXe.Location = new System.Drawing.Point(156, 27);
            this.btnTraXe.Name = "btnTraXe";
            this.btnTraXe.Size = new System.Drawing.Size(75, 23);
            this.btnTraXe.TabIndex = 4;
            this.btnTraXe.Text = "Trả Xe";
            this.btnTraXe.UseVisualStyleBackColor = true;
            this.btnTraXe.Click += new System.EventHandler(this.btnTraXe_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 95);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(611, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // cbTheThueXe
            // 
            this.cbTheThueXe.FormattingEnabled = true;
            this.cbTheThueXe.Location = new System.Drawing.Point(260, 27);
            this.cbTheThueXe.Name = "cbTheThueXe";
            this.cbTheThueXe.Size = new System.Drawing.Size(121, 21);
            this.cbTheThueXe.TabIndex = 6;
            this.cbTheThueXe.Text = "Mã thẻ thuê xe";
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Mã Xe";
            this.Id.Name = "Id";
            // 
            // TenXE
            // 
            this.TenXE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenXE.DataPropertyName = "TenXE";
            this.TenXE.FillWeight = 61.74594F;
            this.TenXE.HeaderText = "Tên Xe";
            this.TenXE.Name = "TenXE";
            // 
            // TinhTrangXe
            // 
            this.TinhTrangXe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TinhTrangXe.DataPropertyName = "TinhTrangXe";
            this.TinhTrangXe.FillWeight = 61.74594F;
            this.TinhTrangXe.HeaderText = "Trạng Thái";
            this.TinhTrangXe.Name = "TinhTrangXe";
            // 
            // GiaThue
            // 
            this.GiaThue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaThue.DataPropertyName = "GiaThue";
            this.GiaThue.FillWeight = 61.74594F;
            this.GiaThue.HeaderText = "Giá Thuê";
            this.GiaThue.Name = "GiaThue";
            // 
            // Hinh
            // 
            this.Hinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Hinh.DataPropertyName = "Hinh";
            this.Hinh.HeaderText = "Hình Ảnh";
            this.Hinh.Name = "Hinh";
            // 
            // frmThueXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 342);
            this.Controls.Add(this.cbTheThueXe);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnTraXe);
            this.Controls.Add(this.btnThueXe);
            this.Controls.Add(this.dtgvXe);
            this.Name = "frmThueXe";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvXe)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvXe;
        private System.Windows.Forms.Button btnThueXe;
        private System.Windows.Forms.Button btnTraXe;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox cbTheThueXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenXE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaThue;
        private System.Windows.Forms.DataGridViewImageColumn Hinh;
    }
}

