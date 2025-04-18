namespace PRL
{
    partial class HoaDonFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDonFrm));
            comboBox_trangthaif = new ComboBox();
            label1 = new Label();
            txt_sdtf = new TextBox();
            txt_mahdf = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            txt_lstt_sreach = new TextBox();
            btn_close_hdf = new Button();
            clear_hd = new Button();
            btn_delete_hdf = new Button();
            btn_xuatexcel = new Button();
            label8 = new Label();
            label7 = new Label();
            dataGridView_hoadonf = new DataGridView();
            label3 = new Label();
            groupBox2 = new GroupBox();
            pictureBox_hoadon = new PictureBox();
            dtime_hoadon = new DateTimePicker();
            comboBox_voucher = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            txt_matkf = new TextBox();
            txt_tongtienf = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_hoadonf).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_hoadon).BeginInit();
            SuspendLayout();
            // 
            // comboBox_trangthaif
            // 
            comboBox_trangthaif.FormattingEnabled = true;
            comboBox_trangthaif.Items.AddRange(new object[] { "Chưa Thanh Toán", "Đã Thanh Toán" });
            comboBox_trangthaif.Location = new Point(761, 129);
            comboBox_trangthaif.Name = "comboBox_trangthaif";
            comboBox_trangthaif.Size = new Size(384, 31);
            comboBox_trangthaif.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 264);
            label1.Name = "label1";
            label1.Size = new Size(121, 23);
            label1.TabIndex = 0;
            label1.Text = "Số Điện Thoại";
            // 
            // txt_sdtf
            // 
            txt_sdtf.Location = new Point(170, 261);
            txt_sdtf.Name = "txt_sdtf";
            txt_sdtf.ReadOnly = true;
            txt_sdtf.Size = new Size(384, 30);
            txt_sdtf.TabIndex = 1;
            // 
            // txt_mahdf
            // 
            txt_mahdf.Location = new Point(170, 33);
            txt_mahdf.Name = "txt_mahdf";
            txt_mahdf.ReadOnly = true;
            txt_mahdf.Size = new Size(384, 30);
            txt_mahdf.TabIndex = 1;
            txt_mahdf.TextChanged += txt_mahdf_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 36);
            label2.Name = "label2";
            label2.Size = new Size(111, 23);
            label2.TabIndex = 0;
            label2.Text = "Mã Hóa Đơn";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(128, 255, 128);
            groupBox1.Controls.Add(txt_lstt_sreach);
            groupBox1.Controls.Add(btn_close_hdf);
            groupBox1.Controls.Add(clear_hd);
            groupBox1.Controls.Add(btn_delete_hdf);
            groupBox1.Controls.Add(btn_xuatexcel);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(1120, 315);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 510);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức Năng";
            // 
            // txt_lstt_sreach
            // 
            txt_lstt_sreach.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_lstt_sreach.Location = new Point(12, 232);
            txt_lstt_sreach.Multiline = true;
            txt_lstt_sreach.Name = "txt_lstt_sreach";
            txt_lstt_sreach.PlaceholderText = "Tìm Kiếm ở Đây";
            txt_lstt_sreach.Size = new Size(315, 41);
            txt_lstt_sreach.TabIndex = 1;
            txt_lstt_sreach.TextChanged += txt_lstt_sreach_TextChanged;
            // 
            // btn_close_hdf
            // 
            btn_close_hdf.BackgroundImage = Properties.Resources.close;
            btn_close_hdf.BackgroundImageLayout = ImageLayout.Zoom;
            btn_close_hdf.Location = new Point(193, 372);
            btn_close_hdf.Name = "btn_close_hdf";
            btn_close_hdf.Size = new Size(93, 51);
            btn_close_hdf.TabIndex = 0;
            btn_close_hdf.UseVisualStyleBackColor = true;
            btn_close_hdf.Click += btn_close_hdf_Click;
            // 
            // clear_hd
            // 
            clear_hd.BackgroundImage = Properties.Resources.clear;
            clear_hd.BackgroundImageLayout = ImageLayout.Zoom;
            clear_hd.Location = new Point(31, 372);
            clear_hd.Name = "clear_hd";
            clear_hd.Size = new Size(93, 51);
            clear_hd.TabIndex = 0;
            clear_hd.UseVisualStyleBackColor = true;
            clear_hd.Click += clear_hd_Click;
            // 
            // btn_delete_hdf
            // 
            btn_delete_hdf.BackgroundImage = Properties.Resources.delete;
            btn_delete_hdf.BackgroundImageLayout = ImageLayout.Zoom;
            btn_delete_hdf.Location = new Point(209, 66);
            btn_delete_hdf.Name = "btn_delete_hdf";
            btn_delete_hdf.Size = new Size(93, 51);
            btn_delete_hdf.TabIndex = 0;
            btn_delete_hdf.UseVisualStyleBackColor = true;
            btn_delete_hdf.Click += btn_delete_hdf_Click;
            // 
            // btn_xuatexcel
            // 
            btn_xuatexcel.BackgroundImage = (Image)resources.GetObject("btn_xuatexcel.BackgroundImage");
            btn_xuatexcel.BackgroundImageLayout = ImageLayout.Zoom;
            btn_xuatexcel.Location = new Point(47, 66);
            btn_xuatexcel.Name = "btn_xuatexcel";
            btn_xuatexcel.Size = new Size(93, 51);
            btn_xuatexcel.TabIndex = 0;
            btn_xuatexcel.UseVisualStyleBackColor = true;
            btn_xuatexcel.Click += btn_xuatexcel_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1272, 40);
            label8.Name = "label8";
            label8.Size = new Size(81, 23);
            label8.TabIndex = 4;
            label8.Text = "Hóa Đơn";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(600, 56);
            label7.Name = "label7";
            label7.Size = new Size(86, 23);
            label7.TabIndex = 0;
            label7.Text = "Ngày Tạo";
            // 
            // dataGridView_hoadonf
            // 
            dataGridView_hoadonf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_hoadonf.Location = new Point(0, 321);
            dataGridView_hoadonf.Name = "dataGridView_hoadonf";
            dataGridView_hoadonf.RowHeadersWidth = 51;
            dataGridView_hoadonf.Size = new Size(1114, 504);
            dataGridView_hoadonf.TabIndex = 19;
            dataGridView_hoadonf.CellClick += dataGridView_hoadonf_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 118);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 0;
            label3.Text = "Tổng Tiền";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(128, 255, 128);
            groupBox2.Controls.Add(pictureBox_hoadon);
            groupBox2.Controls.Add(dtime_hoadon);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(comboBox_voucher);
            groupBox2.Controls.Add(comboBox_trangthaif);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txt_matkf);
            groupBox2.Controls.Add(txt_tongtienf);
            groupBox2.Controls.Add(txt_sdtf);
            groupBox2.Controls.Add(txt_mahdf);
            groupBox2.Controls.Add(label2);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1453, 315);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin";
            // 
            // pictureBox_hoadon
            // 
            pictureBox_hoadon.BackgroundImage = (Image)resources.GetObject("pictureBox_hoadon.BackgroundImage");
            pictureBox_hoadon.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox_hoadon.Location = new Point(1272, 118);
            pictureBox_hoadon.Name = "pictureBox_hoadon";
            pictureBox_hoadon.Size = new Size(80, 79);
            pictureBox_hoadon.TabIndex = 7;
            pictureBox_hoadon.TabStop = false;
            // 
            // dtime_hoadon
            // 
            dtime_hoadon.Location = new Point(761, 51);
            dtime_hoadon.Name = "dtime_hoadon";
            dtime_hoadon.Size = new Size(384, 30);
            dtime_hoadon.TabIndex = 5;
            // 
            // comboBox_voucher
            // 
            comboBox_voucher.FormattingEnabled = true;
            comboBox_voucher.Items.AddRange(new object[] { "Không Hoạt Động", "Hoạt Động" });
            comboBox_voucher.Location = new Point(761, 216);
            comboBox_voucher.Name = "comboBox_voucher";
            comboBox_voucher.Size = new Size(384, 31);
            comboBox_voucher.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 196);
            label5.Name = "label5";
            label5.Size = new Size(118, 23);
            label5.TabIndex = 0;
            label5.Text = "Mã Tài Khoản";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(594, 224);
            label6.Name = "label6";
            label6.Size = new Size(104, 23);
            label6.TabIndex = 0;
            label6.Text = "Mã Voucher";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(598, 133);
            label4.Name = "label4";
            label4.Size = new Size(95, 23);
            label4.TabIndex = 0;
            label4.Text = "Trạng Thái";
            // 
            // txt_matkf
            // 
            txt_matkf.Location = new Point(170, 189);
            txt_matkf.Name = "txt_matkf";
            txt_matkf.ReadOnly = true;
            txt_matkf.Size = new Size(384, 30);
            txt_matkf.TabIndex = 1;
            // 
            // txt_tongtienf
            // 
            txt_tongtienf.Location = new Point(170, 113);
            txt_tongtienf.Name = "txt_tongtienf";
            txt_tongtienf.ReadOnly = true;
            txt_tongtienf.Size = new Size(384, 30);
            txt_tongtienf.TabIndex = 1;
            // 
            // HoaDonFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1453, 825);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView_hoadonf);
            Controls.Add(groupBox2);
            Name = "HoaDonFrm";
            Text = "HoaDonFrm";
            Load += HoaDonFrm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_hoadonf).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_hoadon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox_trangthaif;
        private Label label1;
        private TextBox txt_sdtf;
        private TextBox txt_mahdf;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txt_lstt_sreach;
        private Button btn_close_hdf;
        private Button clear_hd;
        private Button btn_delete_hdf;
        private Button btn_xuatexcel;
        private Label label8;
        private Label label7;
        private DataGridView dataGridView_hoadonf;
        private Label label3;
        private GroupBox groupBox2;
        private DateTimePicker dtime_hoadon;
        private ComboBox comboBox_voucher;
        private Label label5;
        private TextBox txt_tongtienf;
        private Label label6;
        private Label label4;
        private TextBox txt_matkf;
        private PictureBox pictureBox_hoadon;
    }
}