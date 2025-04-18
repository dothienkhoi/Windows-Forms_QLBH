namespace PRL
{
    partial class HoadonchiTietFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoadonchiTietFrm));
            label5 = new Label();
            label3 = new Label();
            txt_mahd_ct = new TextBox();
            btn_close_hdctf = new Button();
            clear_hdct = new Button();
            btn_delete_hdctf = new Button();
            dataGridView_hoadonCTf = new DataGridView();
            txt_masp_ct = new TextBox();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label1 = new Label();
            txt_giasp_ct = new TextBox();
            txt_mact = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            pictureBox_hoadonchitiet = new PictureBox();
            label4 = new Label();
            txt_soluong_ct = new TextBox();
            datagrihoadon = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_hoadonCTf).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_hoadonchitiet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagrihoadon).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 145);
            label5.Name = "label5";
            label5.Size = new Size(119, 23);
            label5.TabIndex = 0;
            label5.Text = "Mã Sản Phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 85);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 0;
            label3.Text = "Mã Hóa Đơn";
            // 
            // txt_mahd_ct
            // 
            txt_mahd_ct.Location = new Point(190, 83);
            txt_mahd_ct.Name = "txt_mahd_ct";
            txt_mahd_ct.ReadOnly = true;
            txt_mahd_ct.Size = new Size(384, 30);
            txt_mahd_ct.TabIndex = 1;
            // 
            // btn_close_hdctf
            // 
            btn_close_hdctf.BackgroundImage = Properties.Resources.close;
            btn_close_hdctf.BackgroundImageLayout = ImageLayout.Zoom;
            btn_close_hdctf.Location = new Point(197, 272);
            btn_close_hdctf.Name = "btn_close_hdctf";
            btn_close_hdctf.Size = new Size(93, 51);
            btn_close_hdctf.TabIndex = 0;
            btn_close_hdctf.UseVisualStyleBackColor = true;
            btn_close_hdctf.Click += btn_close_hdctf_Click;
            // 
            // clear_hdct
            // 
            clear_hdct.BackgroundImage = Properties.Resources.clear;
            clear_hdct.BackgroundImageLayout = ImageLayout.Zoom;
            clear_hdct.Location = new Point(39, 272);
            clear_hdct.Name = "clear_hdct";
            clear_hdct.Size = new Size(93, 51);
            clear_hdct.TabIndex = 0;
            clear_hdct.UseVisualStyleBackColor = true;
            // 
            // btn_delete_hdctf
            // 
            btn_delete_hdctf.BackgroundImage = Properties.Resources.delete;
            btn_delete_hdctf.BackgroundImageLayout = ImageLayout.Zoom;
            btn_delete_hdctf.Location = new Point(111, 79);
            btn_delete_hdctf.Name = "btn_delete_hdctf";
            btn_delete_hdctf.Size = new Size(93, 51);
            btn_delete_hdctf.TabIndex = 0;
            btn_delete_hdctf.UseVisualStyleBackColor = true;
            btn_delete_hdctf.Click += btn_delete_hdctf_Click;
            // 
            // dataGridView_hoadonCTf
            // 
            dataGridView_hoadonCTf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_hoadonCTf.Location = new Point(0, 575);
            dataGridView_hoadonCTf.Name = "dataGridView_hoadonCTf";
            dataGridView_hoadonCTf.RowHeadersWidth = 51;
            dataGridView_hoadonCTf.Size = new Size(1114, 250);
            dataGridView_hoadonCTf.TabIndex = 22;
            dataGridView_hoadonCTf.CellClick += dataGridView_hoadonCTf_CellClick;
            // 
            // txt_masp_ct
            // 
            txt_masp_ct.Location = new Point(189, 146);
            txt_masp_ct.Name = "txt_masp_ct";
            txt_masp_ct.ReadOnly = true;
            txt_masp_ct.Size = new Size(384, 30);
            txt_masp_ct.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(128, 255, 128);
            groupBox1.Controls.Add(btn_close_hdctf);
            groupBox1.Controls.Add(clear_hdct);
            groupBox1.Controls.Add(btn_delete_hdctf);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(1120, 216);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 609);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức Năng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1241, 26);
            label8.Name = "label8";
            label8.Size = new Size(148, 23);
            label8.TabIndex = 4;
            label8.Text = "Hóa Đơn Chi Tiết";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(636, 30);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 0;
            label1.Text = "Giá Sản Phẩm";
            // 
            // txt_giasp_ct
            // 
            txt_giasp_ct.Location = new Point(770, 27);
            txt_giasp_ct.Name = "txt_giasp_ct";
            txt_giasp_ct.ReadOnly = true;
            txt_giasp_ct.Size = new Size(384, 30);
            txt_giasp_ct.TabIndex = 1;
            // 
            // txt_mact
            // 
            txt_mact.Location = new Point(190, 23);
            txt_mact.Name = "txt_mact";
            txt_mact.ReadOnly = true;
            txt_mact.Size = new Size(384, 30);
            txt_mact.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 26);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 0;
            label2.Text = "Mã Chi Tiết";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(128, 255, 128);
            groupBox2.Controls.Add(pictureBox_hoadonchitiet);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txt_masp_ct);
            groupBox2.Controls.Add(txt_mahd_ct);
            groupBox2.Controls.Add(txt_soluong_ct);
            groupBox2.Controls.Add(txt_giasp_ct);
            groupBox2.Controls.Add(txt_mact);
            groupBox2.Controls.Add(label2);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1453, 216);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin";
            // 
            // pictureBox_hoadonchitiet
            // 
            pictureBox_hoadonchitiet.BackgroundImage = (Image)resources.GetObject("pictureBox_hoadonchitiet.BackgroundImage");
            pictureBox_hoadonchitiet.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox_hoadonchitiet.Location = new Point(1266, 90);
            pictureBox_hoadonchitiet.Name = "pictureBox_hoadonchitiet";
            pictureBox_hoadonchitiet.Size = new Size(80, 79);
            pictureBox_hoadonchitiet.TabIndex = 7;
            pictureBox_hoadonchitiet.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(636, 82);
            label4.Name = "label4";
            label4.Size = new Size(87, 23);
            label4.TabIndex = 0;
            label4.Text = "Số Lượng";
            // 
            // txt_soluong_ct
            // 
            txt_soluong_ct.Location = new Point(770, 79);
            txt_soluong_ct.Name = "txt_soluong_ct";
            txt_soluong_ct.ReadOnly = true;
            txt_soluong_ct.Size = new Size(384, 30);
            txt_soluong_ct.TabIndex = 1;
            // 
            // datagrihoadon
            // 
            datagrihoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrihoadon.Location = new Point(12, 231);
            datagrihoadon.Name = "datagrihoadon";
            datagrihoadon.RowHeadersWidth = 51;
            datagrihoadon.Size = new Size(1102, 256);
            datagrihoadon.TabIndex = 23;
            datagrihoadon.CellContentClick += dataGridView1_CellContentClick;
            // 
            // HoadonchiTietFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1453, 825);
            Controls.Add(datagrihoadon);
            Controls.Add(dataGridView_hoadonCTf);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "HoadonchiTietFrm";
            Text = "HoadonchiTietFrm";
            Load += HoadonchiTietFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_hoadonCTf).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_hoadonchitiet).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagrihoadon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label5;
        private Label label3;
        private TextBox txt_mahd_ct;
        private Button btn_close_hdctf;
        private Button clear_hdct;
        private Button btn_delete_hdctf;
        private DataGridView dataGridView_hoadonCTf;
        private TextBox txt_masp_ct;
        private GroupBox groupBox1;
        private Label label8;
        private Label label1;
        private TextBox txt_giasp_ct;
        private TextBox txt_mact;
        private Label label2;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txt_soluong_ct;
        private PictureBox pictureBox_hoadonchitiet;
        private DataGridView datagrihoadon;
    }
}