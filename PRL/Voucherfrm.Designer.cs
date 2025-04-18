namespace PRL
{
    partial class Voucherfrm
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
            label1 = new Label();
            label2 = new Label();
            txt_vou_sreach = new TextBox();
            btn_close_vou = new Button();
            clear_vou = new Button();
            btn_delete_vou = new Button();
            label4 = new Label();
            label3 = new Label();
            txt_motavou = new TextBox();
            btn_update_vou = new Button();
            dataGridView_mavou = new DataGridView();
            txt_mavou = new TextBox();
            groupBox1 = new GroupBox();
            comboBox_trthai = new ComboBox();
            groupBox2 = new GroupBox();
            pictureBox_voucher = new PictureBox();
            label8 = new Label();
            dateTime_endtime = new DateTimePicker();
            ngaybatdau_datetime = new DateTimePicker();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_giatrigiam = new TextBox();
            txt_tenvou = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_mavou).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_voucher).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(592, 48);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 0;
            label1.Text = "Giá Trị Giảm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 50);
            label2.Name = "label2";
            label2.Size = new Size(104, 23);
            label2.TabIndex = 0;
            label2.Text = "Mã Voucher";
            // 
            // txt_vou_sreach
            // 
            txt_vou_sreach.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_vou_sreach.Location = new Point(6, 317);
            txt_vou_sreach.Multiline = true;
            txt_vou_sreach.Name = "txt_vou_sreach";
            txt_vou_sreach.PlaceholderText = "Tìm Kiếm ở Đây";
            txt_vou_sreach.Size = new Size(315, 41);
            txt_vou_sreach.TabIndex = 1;
            txt_vou_sreach.TextChanged += txt_vou_sreach_TextChanged;
            // 
            // btn_close_vou
            // 
            btn_close_vou.BackgroundImage = Properties.Resources.close;
            btn_close_vou.BackgroundImageLayout = ImageLayout.Zoom;
            btn_close_vou.Location = new Point(95, 422);
            btn_close_vou.Name = "btn_close_vou";
            btn_close_vou.Size = new Size(145, 51);
            btn_close_vou.TabIndex = 0;
            btn_close_vou.UseVisualStyleBackColor = true;
            btn_close_vou.Click += btn_close_vou_Click;
            // 
            // clear_vou
            // 
            clear_vou.BackgroundImage = Properties.Resources.clear;
            clear_vou.BackgroundImageLayout = ImageLayout.Zoom;
            clear_vou.Location = new Point(197, 166);
            clear_vou.Name = "clear_vou";
            clear_vou.Size = new Size(93, 51);
            clear_vou.TabIndex = 0;
            clear_vou.UseVisualStyleBackColor = true;
            clear_vou.Click += clear_vou_Click;
            // 
            // btn_delete_vou
            // 
            btn_delete_vou.BackgroundImage = Properties.Resources.delete;
            btn_delete_vou.BackgroundImageLayout = ImageLayout.Zoom;
            btn_delete_vou.Location = new Point(48, 166);
            btn_delete_vou.Name = "btn_delete_vou";
            btn_delete_vou.Size = new Size(93, 51);
            btn_delete_vou.TabIndex = 0;
            btn_delete_vou.UseVisualStyleBackColor = true;
            btn_delete_vou.Click += btn_delete_vou_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 199);
            label4.Name = "label4";
            label4.Size = new Size(57, 23);
            label4.TabIndex = 0;
            label4.Text = "Mô tả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 121);
            label3.Name = "label3";
            label3.Size = new Size(106, 23);
            label3.TabIndex = 0;
            label3.Text = "Tên Voucher";
            // 
            // txt_motavou
            // 
            txt_motavou.Location = new Point(154, 196);
            txt_motavou.Name = "txt_motavou";
            txt_motavou.ReadOnly = true;
            txt_motavou.Size = new Size(384, 30);
            txt_motavou.TabIndex = 1;
            // 
            // btn_update_vou
            // 
            btn_update_vou.BackgroundImage = Properties.Resources.update;
            btn_update_vou.BackgroundImageLayout = ImageLayout.Zoom;
            btn_update_vou.Location = new Point(123, 58);
            btn_update_vou.Name = "btn_update_vou";
            btn_update_vou.Size = new Size(93, 51);
            btn_update_vou.TabIndex = 0;
            btn_update_vou.UseVisualStyleBackColor = true;
            btn_update_vou.Click += btn_update_vou_Click;
            // 
            // dataGridView_mavou
            // 
            dataGridView_mavou.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_mavou.Location = new Point(0, 321);
            dataGridView_mavou.Name = "dataGridView_mavou";
            dataGridView_mavou.RowHeadersWidth = 51;
            dataGridView_mavou.Size = new Size(1114, 504);
            dataGridView_mavou.TabIndex = 8;
            dataGridView_mavou.CellClick += dataGridView_mavou_CellClick;
            // 
            // txt_mavou
            // 
            txt_mavou.Location = new Point(154, 50);
            txt_mavou.Name = "txt_mavou";
            txt_mavou.ReadOnly = true;
            txt_mavou.Size = new Size(384, 30);
            txt_mavou.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(128, 255, 128);
            groupBox1.Controls.Add(txt_vou_sreach);
            groupBox1.Controls.Add(btn_close_vou);
            groupBox1.Controls.Add(clear_vou);
            groupBox1.Controls.Add(btn_delete_vou);
            groupBox1.Controls.Add(btn_update_vou);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(1145, 315);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 474);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức Năng";
            // 
            // comboBox_trthai
            // 
            comboBox_trthai.FormattingEnabled = true;
            comboBox_trthai.Items.AddRange(new object[] { "Không Hoạt Động", "Hoạt Động" });
            comboBox_trthai.Location = new Point(753, 260);
            comboBox_trthai.Name = "comboBox_trthai";
            comboBox_trthai.Size = new Size(384, 31);
            comboBox_trthai.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(128, 255, 128);
            groupBox2.Controls.Add(pictureBox_voucher);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(dateTime_endtime);
            groupBox2.Controls.Add(ngaybatdau_datetime);
            groupBox2.Controls.Add(comboBox_trthai);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txt_motavou);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txt_giatrigiam);
            groupBox2.Controls.Add(txt_tenvou);
            groupBox2.Controls.Add(txt_mavou);
            groupBox2.Controls.Add(label2);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1478, 315);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin";
            // 
            // pictureBox_voucher
            // 
            pictureBox_voucher.BackgroundImage = Properties.Resources.voucher;
            pictureBox_voucher.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox_voucher.Location = new Point(1269, 121);
            pictureBox_voucher.Name = "pictureBox_voucher";
            pictureBox_voucher.Size = new Size(80, 79);
            pictureBox_voucher.TabIndex = 5;
            pictureBox_voucher.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1269, 26);
            label8.Name = "label8";
            label8.Size = new Size(74, 23);
            label8.TabIndex = 4;
            label8.Text = "Voucher";
            // 
            // dateTime_endtime
            // 
            dateTime_endtime.Location = new Point(753, 187);
            dateTime_endtime.Name = "dateTime_endtime";
            dateTime_endtime.Size = new Size(384, 30);
            dateTime_endtime.TabIndex = 3;
            // 
            // ngaybatdau_datetime
            // 
            ngaybatdau_datetime.Location = new Point(753, 117);
            ngaybatdau_datetime.Name = "ngaybatdau_datetime";
            ngaybatdau_datetime.Size = new Size(384, 30);
            ngaybatdau_datetime.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(592, 119);
            label7.Name = "label7";
            label7.Size = new Size(121, 23);
            label7.TabIndex = 0;
            label7.Text = "Ngày bắt Đầu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(592, 191);
            label5.Name = "label5";
            label5.Size = new Size(127, 23);
            label5.TabIndex = 0;
            label5.Text = "Ngày Kết Thúc";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(592, 259);
            label6.Name = "label6";
            label6.Size = new Size(95, 23);
            label6.TabIndex = 0;
            label6.Text = "Trạng Thái";
            // 
            // txt_giatrigiam
            // 
            txt_giatrigiam.Location = new Point(753, 43);
            txt_giatrigiam.Name = "txt_giatrigiam";
            txt_giatrigiam.Size = new Size(384, 30);
            txt_giatrigiam.TabIndex = 1;
            // 
            // txt_tenvou
            // 
            txt_tenvou.Location = new Point(154, 121);
            txt_tenvou.Name = "txt_tenvou";
            txt_tenvou.ReadOnly = true;
            txt_tenvou.Size = new Size(384, 30);
            txt_tenvou.TabIndex = 1;
            // 
            // Voucherfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 789);
            Controls.Add(dataGridView_mavou);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Voucherfrm";
            Text = "Voucherfrm";
            Load += Voucherfrm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_mavou).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_voucher).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_vou_sreach;
        private Button btn_close_vou;
        private Button clear_vou;
        private Button btn_delete_vou;
        private Label label4;
        private Label label3;
        private TextBox txt_motavou;
        private Button btn_update_vou;
        private DataGridView dataGridView_mavou;
        private TextBox txt_mavou;
        private GroupBox groupBox1;
        private ComboBox comboBox_trthai;
        private GroupBox groupBox2;
        private Label label7;
        private Label label5;
        private Label label6;
        private TextBox txt_tenvou;
        private DateTimePicker dateTime_endtime;
        private DateTimePicker ngaybatdau_datetime;
        private TextBox txt_giatrigiam;
        private Label label8;
        private PictureBox pictureBox_voucher;
    }
}