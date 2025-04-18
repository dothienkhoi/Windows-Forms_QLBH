namespace PRL
{
    partial class SanPhamfrm
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
            groupBox1 = new GroupBox();
            lb_next = new Label();
            lb_sotrang = new Label();
            lb_back = new Label();
            tableLayoutPanel_sp = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            lb_tongtienmoi = new Label();
            button1 = new Button();
            txt_sotien = new TextBox();
            label3 = new Label();
            button_clear = new Button();
            button2 = new Button();
            btn_addhd = new Button();
            btn_hoantra = new Button();
            btn_thanhtoan = new Button();
            label8 = new Label();
            label7 = new Label();
            comboBox_hinhthuctt = new ComboBox();
            lb_mahdvalue = new Label();
            comboBox_phone = new ComboBox();
            combobx_voucher = new ComboBox();
            txt_phone = new TextBox();
            txt_tenkh = new TextBox();
            lb_tongtien = new Label();
            lb_tinhtongtienhdct = new Label();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dataGridView_hdct = new DataGridView();
            datagr_hoadon = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_hdct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagr_hoadon).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_next);
            groupBox1.Controls.Add(lb_sotrang);
            groupBox1.Controls.Add(lb_back);
            groupBox1.Controls.Add(tableLayoutPanel_sp);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(882, 825);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản Phẩm";
            // 
            // lb_next
            // 
            lb_next.AutoSize = true;
            lb_next.Cursor = Cursors.Hand;
            lb_next.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lb_next.Location = new Point(488, 779);
            lb_next.Name = "lb_next";
            lb_next.Size = new Size(46, 23);
            lb_next.TabIndex = 1;
            lb_next.Text = ">>>";
            lb_next.Click += lb_next_Click;
            // 
            // lb_sotrang
            // 
            lb_sotrang.AutoSize = true;
            lb_sotrang.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lb_sotrang.Location = new Point(433, 779);
            lb_sotrang.Name = "lb_sotrang";
            lb_sotrang.Size = new Size(20, 23);
            lb_sotrang.TabIndex = 1;
            lb_sotrang.Text = "1";
            // 
            // lb_back
            // 
            lb_back.AutoSize = true;
            lb_back.Cursor = Cursors.Hand;
            lb_back.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lb_back.Location = new Point(358, 779);
            lb_back.Name = "lb_back";
            lb_back.Size = new Size(46, 23);
            lb_back.TabIndex = 1;
            lb_back.Text = "<<<";
            lb_back.Click += lb_back_Click;
            // 
            // tableLayoutPanel_sp
            // 
            tableLayoutPanel_sp.BackColor = SystemColors.InactiveCaption;
            tableLayoutPanel_sp.ColumnCount = 2;
            tableLayoutPanel_sp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_sp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_sp.Location = new Point(6, 26);
            tableLayoutPanel_sp.Name = "tableLayoutPanel_sp";
            tableLayoutPanel_sp.RowCount = 2;
            tableLayoutPanel_sp.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_sp.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_sp.Size = new Size(870, 740);
            tableLayoutPanel_sp.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.InactiveCaption;
            groupBox2.Controls.Add(lb_tongtienmoi);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(txt_sotien);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(button_clear);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(btn_addhd);
            groupBox2.Controls.Add(btn_hoantra);
            groupBox2.Controls.Add(btn_thanhtoan);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(comboBox_hinhthuctt);
            groupBox2.Controls.Add(lb_mahdvalue);
            groupBox2.Controls.Add(comboBox_phone);
            groupBox2.Controls.Add(combobx_voucher);
            groupBox2.Controls.Add(txt_phone);
            groupBox2.Controls.Add(txt_tenkh);
            groupBox2.Controls.Add(lb_tongtien);
            groupBox2.Controls.Add(lb_tinhtongtienhdct);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dataGridView_hdct);
            groupBox2.Controls.Add(datagr_hoadon);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(888, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(565, 825);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn";
            // 
            // lb_tongtienmoi
            // 
            lb_tongtienmoi.AutoSize = true;
            lb_tongtienmoi.Location = new Point(267, 206);
            lb_tongtienmoi.Name = "lb_tongtienmoi";
            lb_tongtienmoi.Size = new Size(55, 23);
            lb_tongtienmoi.TabIndex = 18;
            lb_tongtienmoi.Text = ".........";
            // 
            // button1
            // 
            button1.Location = new Point(491, 195);
            button1.Name = "button1";
            button1.Size = new Size(62, 34);
            button1.TabIndex = 17;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_sotien
            // 
            txt_sotien.Location = new Point(151, 500);
            txt_sotien.Name = "txt_sotien";
            txt_sotien.PlaceholderText = "Nhập số tiền khách đưa";
            txt_sotien.Size = new Size(170, 30);
            txt_sotien.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 552);
            label3.Name = "label3";
            label3.Size = new Size(304, 23);
            label3.TabIndex = 15;
            label3.Text = "Danh Sách Sản Phẩm trong Hóa Đơn";
            // 
            // button_clear
            // 
            button_clear.BackgroundImage = Properties.Resources.clear;
            button_clear.BackgroundImageLayout = ImageLayout.Zoom;
            button_clear.Location = new Point(433, 195);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(51, 34);
            button_clear.TabIndex = 14;
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.delete;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(435, 20);
            button2.Name = "button2";
            button2.Size = new Size(52, 34);
            button2.TabIndex = 13;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btn_addhd
            // 
            btn_addhd.BackgroundImage = Properties.Resources.add;
            btn_addhd.BackgroundImageLayout = ImageLayout.Zoom;
            btn_addhd.Location = new Point(493, 19);
            btn_addhd.Name = "btn_addhd";
            btn_addhd.Size = new Size(60, 34);
            btn_addhd.TabIndex = 12;
            btn_addhd.UseVisualStyleBackColor = true;
            btn_addhd.Click += btn_addhd_Click;
            // 
            // btn_hoantra
            // 
            btn_hoantra.Location = new Point(345, 492);
            btn_hoantra.Name = "btn_hoantra";
            btn_hoantra.Size = new Size(150, 45);
            btn_hoantra.TabIndex = 12;
            btn_hoantra.Text = "Hoàn Trả";
            btn_hoantra.UseVisualStyleBackColor = true;
            btn_hoantra.Click += btn_hoantra_Click;
            // 
            // btn_thanhtoan
            // 
            btn_thanhtoan.Location = new Point(345, 433);
            btn_thanhtoan.Name = "btn_thanhtoan";
            btn_thanhtoan.Size = new Size(150, 45);
            btn_thanhtoan.TabIndex = 12;
            btn_thanhtoan.Text = "Thanh Toán";
            btn_thanhtoan.UseVisualStyleBackColor = true;
            btn_thanhtoan.Click += btn_thanhtoan_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(48, 504);
            label8.Name = "label8";
            label8.Size = new Size(71, 23);
            label8.TabIndex = 11;
            label8.Text = "Số tiền ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 444);
            label7.Name = "label7";
            label7.Size = new Size(92, 23);
            label7.TabIndex = 11;
            label7.Text = "Hình Thức";
            // 
            // comboBox_hinhthuctt
            // 
            comboBox_hinhthuctt.FormattingEnabled = true;
            comboBox_hinhthuctt.Location = new Point(151, 440);
            comboBox_hinhthuctt.Name = "comboBox_hinhthuctt";
            comboBox_hinhthuctt.Size = new Size(170, 31);
            comboBox_hinhthuctt.TabIndex = 10;
            // 
            // lb_mahdvalue
            // 
            lb_mahdvalue.AutoSize = true;
            lb_mahdvalue.Location = new Point(130, 26);
            lb_mahdvalue.Name = "lb_mahdvalue";
            lb_mahdvalue.Size = new Size(65, 23);
            lb_mahdvalue.TabIndex = 9;
            lb_mahdvalue.Text = "HD......";
            // 
            // comboBox_phone
            // 
            comboBox_phone.FormattingEnabled = true;
            comboBox_phone.Location = new Point(327, 58);
            comboBox_phone.Name = "comboBox_phone";
            comboBox_phone.Size = new Size(226, 31);
            comboBox_phone.TabIndex = 8;
            comboBox_phone.SelectedIndexChanged += comboBox_phone_SelectedIndexChanged;
            comboBox_phone.TextChanged += comboBox_phone_TextChanged;
            // 
            // combobx_voucher
            // 
            combobx_voucher.FormattingEnabled = true;
            combobx_voucher.Location = new Point(127, 158);
            combobx_voucher.Name = "combobx_voucher";
            combobx_voucher.Size = new Size(426, 31);
            combobx_voucher.TabIndex = 7;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(127, 58);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(194, 30);
            txt_phone.TabIndex = 6;
            txt_phone.TextChanged += txt_phone_TextChanged;
            // 
            // txt_tenkh
            // 
            txt_tenkh.Location = new Point(127, 108);
            txt_tenkh.Name = "txt_tenkh";
            txt_tenkh.Size = new Size(426, 30);
            txt_tenkh.TabIndex = 5;
            // 
            // lb_tongtien
            // 
            lb_tongtien.AutoSize = true;
            lb_tongtien.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Strikeout, GraphicsUnit.Point, 0);
            lb_tongtien.Location = new Point(120, 206);
            lb_tongtien.Name = "lb_tongtien";
            lb_tongtien.Size = new Size(64, 23);
            lb_tongtien.TabIndex = 4;
            lb_tongtien.Text = "xxxxxx";
            // 
            // lb_tinhtongtienhdct
            // 
            lb_tinhtongtienhdct.AutoSize = true;
            lb_tinhtongtienhdct.Cursor = Cursors.Hand;
            lb_tinhtongtienhdct.Location = new Point(8, 206);
            lb_tinhtongtienhdct.Name = "lb_tinhtongtienhdct";
            lb_tinhtongtienhdct.Size = new Size(90, 23);
            lb_tinhtongtienhdct.TabIndex = 4;
            lb_tinhtongtienhdct.Text = "Tổng Tiền";
            lb_tinhtongtienhdct.Click += lb_tinhtongtienhdct_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 158);
            label1.Name = "label1";
            label1.Size = new Size(77, 23);
            label1.TabIndex = 4;
            label1.Text = "VouCher";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 109);
            label6.Name = "label6";
            label6.Size = new Size(66, 23);
            label6.TabIndex = 4;
            label6.Text = "Tên KH";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 64);
            label5.Name = "label5";
            label5.Size = new Size(116, 23);
            label5.TabIndex = 3;
            label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 25);
            label4.Name = "label4";
            label4.Size = new Size(111, 23);
            label4.TabIndex = 2;
            label4.Text = "Mã Hóa Đơn";
            // 
            // dataGridView_hdct
            // 
            dataGridView_hdct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_hdct.Location = new Point(8, 592);
            dataGridView_hdct.Name = "dataGridView_hdct";
            dataGridView_hdct.RowHeadersWidth = 51;
            dataGridView_hdct.Size = new Size(545, 220);
            dataGridView_hdct.TabIndex = 1;
            dataGridView_hdct.CellClick += dataGridView_hdct_CellClick;
            // 
            // datagr_hoadon
            // 
            datagr_hoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagr_hoadon.Location = new Point(8, 240);
            datagr_hoadon.Name = "datagr_hoadon";
            datagr_hoadon.RowHeadersWidth = 51;
            datagr_hoadon.Size = new Size(545, 183);
            datagr_hoadon.TabIndex = 0;
            datagr_hoadon.CellClick += datagr_hoadon_CellClick;
            // 
            // SanPhamfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1453, 825);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "SanPhamfrm";
            Text = "SanPhamfrm";
            Load += SanPhamfrm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_hdct).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagr_hoadon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lb_next;
        private Label lb_sotrang;
        private Label lb_back;
        private TableLayoutPanel tableLayoutPanel_sp;
        private GroupBox groupBox2;
        private DataGridView datagr_hoadon;
        private DataGridView dataGridView_hdct;
        private TextBox txt_phone;
        private TextBox txt_tenkh;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lb_mahdvalue;
        private ComboBox comboBox_phone;
        private ComboBox combobx_voucher;
        private Label label1;
        private Button btn_thanhtoan;
        private Label label7;
        private ComboBox comboBox_hinhthuctt;
        private Label lb_tongtien;
        private Label lb_tinhtongtienhdct;
        private Button btn_addhd;
        private Button button2;
        private Button button_clear;
        private Label label3;
        private TextBox txt_sotien;
        private Button button1;
        private Button btn_hoantra;
        private Label label8;
        private Label lb_tongtienmoi;
    }
}