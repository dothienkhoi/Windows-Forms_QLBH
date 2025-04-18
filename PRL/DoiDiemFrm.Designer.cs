namespace PRL
{
    partial class DoiDiemFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiDiemFrm));
            dataGridView_doidiem = new DataGridView();
            label8 = new Label();
            dateTime_taodd = new DateTimePicker();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txt_tenkhdd = new TextBox();
            txt_dd_sreach = new TextBox();
            btn_close_doi = new Button();
            clear_doi = new Button();
            btn_delete_doidiem = new Button();
            label1 = new Label();
            txt_diemcandoi = new TextBox();
            txt_madoidiem = new TextBox();
            label2 = new Label();
            btndoi_vou = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            pictureBox_doidiem = new PictureBox();
            comboBox_sdtkhdd = new ComboBox();
            label9 = new Label();
            txt_diemkhdd = new TextBox();
            txt_mavoucherdd = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_doidiem).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_doidiem).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_doidiem
            // 
            dataGridView_doidiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_doidiem.Location = new Point(12, 315);
            dataGridView_doidiem.Name = "dataGridView_doidiem";
            dataGridView_doidiem.RowHeadersWidth = 51;
            dataGridView_doidiem.Size = new Size(1102, 510);
            dataGridView_doidiem.TabIndex = 16;
            dataGridView_doidiem.CellClick += dataGridView_doidiem_CellClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1300, 36);
            label8.Name = "label8";
            label8.Size = new Size(91, 23);
            label8.TabIndex = 4;
            label8.Text = "Đổi Điểm ";
            label8.Click += label8_Click;
            // 
            // dateTime_taodd
            // 
            dateTime_taodd.Location = new Point(813, 129);
            dateTime_taodd.Name = "dateTime_taodd";
            dateTime_taodd.Size = new Size(384, 30);
            dateTime_taodd.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(648, 60);
            label7.Name = "label7";
            label7.Size = new Size(104, 23);
            label7.TabIndex = 0;
            label7.Text = "Mã Voucher";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(648, 132);
            label5.Name = "label5";
            label5.Size = new Size(86, 23);
            label5.TabIndex = 0;
            label5.Text = "Ngày Tạo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 167);
            label4.Name = "label4";
            label4.Size = new Size(143, 23);
            label4.TabIndex = 0;
            label4.Text = "Tên Khách Hàng ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 111);
            label3.Name = "label3";
            label3.Size = new Size(121, 23);
            label3.TabIndex = 0;
            label3.Text = "Số Điện Thoại";
            // 
            // txt_tenkhdd
            // 
            txt_tenkhdd.Location = new Point(190, 164);
            txt_tenkhdd.Name = "txt_tenkhdd";
            txt_tenkhdd.ReadOnly = true;
            txt_tenkhdd.Size = new Size(384, 30);
            txt_tenkhdd.TabIndex = 1;
            // 
            // txt_dd_sreach
            // 
            txt_dd_sreach.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_dd_sreach.Location = new Point(6, 317);
            txt_dd_sreach.Multiline = true;
            txt_dd_sreach.Name = "txt_dd_sreach";
            txt_dd_sreach.PlaceholderText = "Tìm Kiếm ở Đây";
            txt_dd_sreach.Size = new Size(315, 41);
            txt_dd_sreach.TabIndex = 1;
            txt_dd_sreach.TextChanged += txt_dd_sreach_TextChanged;
            // 
            // btn_close_doi
            // 
            btn_close_doi.BackgroundImage = Properties.Resources.close;
            btn_close_doi.BackgroundImageLayout = ImageLayout.Zoom;
            btn_close_doi.Location = new Point(113, 398);
            btn_close_doi.Name = "btn_close_doi";
            btn_close_doi.Size = new Size(127, 75);
            btn_close_doi.TabIndex = 0;
            btn_close_doi.UseVisualStyleBackColor = true;
            // 
            // clear_doi
            // 
            clear_doi.BackgroundImage = Properties.Resources.clear;
            clear_doi.BackgroundImageLayout = ImageLayout.Zoom;
            clear_doi.Location = new Point(197, 180);
            clear_doi.Name = "clear_doi";
            clear_doi.Size = new Size(93, 77);
            clear_doi.TabIndex = 0;
            clear_doi.UseVisualStyleBackColor = true;
            clear_doi.Click += clear_doi_Click;
            // 
            // btn_delete_doidiem
            // 
            btn_delete_doidiem.BackgroundImage = Properties.Resources.delete;
            btn_delete_doidiem.BackgroundImageLayout = ImageLayout.Zoom;
            btn_delete_doidiem.Location = new Point(47, 180);
            btn_delete_doidiem.Name = "btn_delete_doidiem";
            btn_delete_doidiem.Size = new Size(93, 77);
            btn_delete_doidiem.TabIndex = 0;
            btn_delete_doidiem.UseVisualStyleBackColor = true;
            btn_delete_doidiem.Click += btn_delete_doidiem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(592, 207);
            label1.Name = "label1";
            label1.Size = new Size(199, 23);
            label1.TabIndex = 0;
            label1.Text = "Nhập Số Điểm Cần Đổi ";
            // 
            // txt_diemcandoi
            // 
            txt_diemcandoi.Location = new Point(813, 207);
            txt_diemcandoi.Name = "txt_diemcandoi";
            txt_diemcandoi.Size = new Size(384, 30);
            txt_diemcandoi.TabIndex = 1;
            // 
            // txt_madoidiem
            // 
            txt_madoidiem.Location = new Point(190, 50);
            txt_madoidiem.Name = "txt_madoidiem";
            txt_madoidiem.ReadOnly = true;
            txt_madoidiem.Size = new Size(384, 30);
            txt_madoidiem.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 53);
            label2.Name = "label2";
            label2.Size = new Size(116, 23);
            label2.TabIndex = 0;
            label2.Text = "Mã Đổi Điểm";
            // 
            // btndoi_vou
            // 
            btndoi_vou.BackgroundImage = (Image)resources.GetObject("btndoi_vou.BackgroundImage");
            btndoi_vou.BackgroundImageLayout = ImageLayout.Zoom;
            btndoi_vou.Location = new Point(128, 29);
            btndoi_vou.Name = "btndoi_vou";
            btndoi_vou.Size = new Size(93, 94);
            btndoi_vou.TabIndex = 0;
            btndoi_vou.UseVisualStyleBackColor = true;
            btndoi_vou.Click += btndoi_vou_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(128, 255, 128);
            groupBox1.Controls.Add(txt_dd_sreach);
            groupBox1.Controls.Add(btn_close_doi);
            groupBox1.Controls.Add(clear_doi);
            groupBox1.Controls.Add(btn_delete_doidiem);
            groupBox1.Controls.Add(btndoi_vou);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(1120, 315);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 510);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức Năng";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(128, 255, 128);
            groupBox2.Controls.Add(pictureBox_doidiem);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(dateTime_taodd);
            groupBox2.Controls.Add(comboBox_sdtkhdd);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txt_diemkhdd);
            groupBox2.Controls.Add(txt_tenkhdd);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txt_mavoucherdd);
            groupBox2.Controls.Add(txt_diemcandoi);
            groupBox2.Controls.Add(txt_madoidiem);
            groupBox2.Controls.Add(label2);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1453, 315);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin";
            // 
            // pictureBox_doidiem
            // 
            pictureBox_doidiem.BackgroundImage = (Image)resources.GetObject("pictureBox_doidiem.BackgroundImage");
            pictureBox_doidiem.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox_doidiem.Location = new Point(1300, 111);
            pictureBox_doidiem.Name = "pictureBox_doidiem";
            pictureBox_doidiem.Size = new Size(80, 79);
            pictureBox_doidiem.TabIndex = 7;
            pictureBox_doidiem.TabStop = false;
            // 
            // comboBox_sdtkhdd
            // 
            comboBox_sdtkhdd.FormattingEnabled = true;
            comboBox_sdtkhdd.Location = new Point(190, 108);
            comboBox_sdtkhdd.Name = "comboBox_sdtkhdd";
            comboBox_sdtkhdd.Size = new Size(384, 31);
            comboBox_sdtkhdd.TabIndex = 2;
            comboBox_sdtkhdd.SelectedIndexChanged += comboBox_sdtkhdd_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 231);
            label9.Name = "label9";
            label9.Size = new Size(157, 23);
            label9.TabIndex = 0;
            label9.Text = "Số Điểm Khách Có";
            // 
            // txt_diemkhdd
            // 
            txt_diemkhdd.Location = new Point(190, 228);
            txt_diemkhdd.Name = "txt_diemkhdd";
            txt_diemkhdd.ReadOnly = true;
            txt_diemkhdd.Size = new Size(384, 30);
            txt_diemkhdd.TabIndex = 1;
            // 
            // txt_mavoucherdd
            // 
            txt_mavoucherdd.Location = new Point(813, 53);
            txt_mavoucherdd.Name = "txt_mavoucherdd";
            txt_mavoucherdd.Size = new Size(384, 30);
            txt_mavoucherdd.TabIndex = 1;
            // 
            // DoiDiemFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1453, 825);
            Controls.Add(dataGridView_doidiem);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "DoiDiemFrm";
            Text = "DoiDiemFrm";
            Load += DoiDiemFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_doidiem).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_doidiem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_doidiem;
        private Label label8;
        private DateTimePicker dateTime_taodd;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txt_tenkhdd;
        private TextBox txt_dd_sreach;
        private Button btn_close_doi;
        private Button clear_doi;
        private Button btn_delete_doidiem;
        private Label label1;
        private TextBox txt_diemcandoi;
        private TextBox txt_madoidiem;
        private Label label2;
        private Button btndoi_vou;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox comboBox_sdtkhdd;
        private Label label9;
        private TextBox txt_diemkhdd;
        private TextBox txt_mavoucherdd;
        private PictureBox pictureBox_doidiem;
    }
}