namespace PRL
{
    partial class GenSPFrm
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
            ptb_Img = new PictureBox();
            lb_Name = new Label();
            lb_Gia = new Label();
            lb_Giamoi = new Label();
            lb_Giavalue = new Label();
            lb_mota = new Label();
            lb_soluong = new Label();
            lb_xuatxu = new Label();
            lb_Sl_value = new Label();
            txt_SlBan = new TextBox();
            btn_mua = new Button();
            ((System.ComponentModel.ISupportInitialize)ptb_Img).BeginInit();
            SuspendLayout();
            // 
            // ptb_Img
            // 
            ptb_Img.Location = new Point(12, 12);
            ptb_Img.Name = "ptb_Img";
            ptb_Img.Size = new Size(202, 232);
            ptb_Img.SizeMode = PictureBoxSizeMode.Zoom;
            ptb_Img.TabIndex = 0;
            ptb_Img.TabStop = false;
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lb_Name.Location = new Point(234, 9);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(45, 25);
            lb_Name.TabIndex = 1;
            lb_Name.Text = "Keo";
            // 
            // lb_Gia
            // 
            lb_Gia.AutoSize = true;
            lb_Gia.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lb_Gia.Location = new Point(234, 45);
            lb_Gia.Name = "lb_Gia";
            lb_Gia.Size = new Size(78, 25);
            lb_Gia.TabIndex = 1;
            lb_Gia.Text = "Gia Ban";
            // 
            // lb_Giamoi
            // 
            lb_Giamoi.AutoSize = true;
            lb_Giamoi.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lb_Giamoi.Location = new Point(234, 81);
            lb_Giamoi.Name = "lb_Giamoi";
            lb_Giamoi.Size = new Size(72, 25);
            lb_Giamoi.TabIndex = 1;
            lb_Giamoi.Text = "100000";
            // 
            // lb_Giavalue
            // 
            lb_Giavalue.AutoSize = true;
            lb_Giavalue.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lb_Giavalue.Location = new Point(234, 113);
            lb_Giavalue.Name = "lb_Giavalue";
            lb_Giavalue.Size = new Size(52, 25);
            lb_Giavalue.TabIndex = 1;
            lb_Giavalue.Text = "1000";
            // 
            // lb_mota
            // 
            lb_mota.AutoSize = true;
            lb_mota.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lb_mota.Location = new Point(26, 267);
            lb_mota.Name = "lb_mota";
            lb_mota.Size = new Size(62, 25);
            lb_mota.TabIndex = 2;
            lb_mota.Text = "Mo ta";
            // 
            // lb_soluong
            // 
            lb_soluong.AutoSize = true;
            lb_soluong.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lb_soluong.Location = new Point(234, 145);
            lb_soluong.Name = "lb_soluong";
            lb_soluong.Size = new Size(92, 25);
            lb_soluong.TabIndex = 1;
            lb_soluong.Text = "So luong ";
            // 
            // lb_xuatxu
            // 
            lb_xuatxu.AutoSize = true;
            lb_xuatxu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lb_xuatxu.Location = new Point(26, 316);
            lb_xuatxu.Name = "lb_xuatxu";
            lb_xuatxu.Size = new Size(78, 25);
            lb_xuatxu.TabIndex = 2;
            lb_xuatxu.Text = "Xuat xu";
            // 
            // lb_Sl_value
            // 
            lb_Sl_value.AutoSize = true;
            lb_Sl_value.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lb_Sl_value.Location = new Point(234, 184);
            lb_Sl_value.Name = "lb_Sl_value";
            lb_Sl_value.Size = new Size(52, 25);
            lb_Sl_value.TabIndex = 1;
            lb_Sl_value.Text = "1000";
            // 
            // txt_SlBan
            // 
            txt_SlBan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txt_SlBan.Location = new Point(233, 232);
            txt_SlBan.Name = "txt_SlBan";
            txt_SlBan.PlaceholderText = "Nhap so luong mua";
            txt_SlBan.Size = new Size(176, 31);
            txt_SlBan.TabIndex = 3;
            // 
            // btn_mua
            // 
            btn_mua.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn_mua.Location = new Point(252, 285);
            btn_mua.Name = "btn_mua";
            btn_mua.Size = new Size(131, 47);
            btn_mua.TabIndex = 4;
            btn_mua.Text = "Mua";
            btn_mua.UseVisualStyleBackColor = true;
            // 
            // GenSPFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 370);
            Controls.Add(btn_mua);
            Controls.Add(txt_SlBan);
            Controls.Add(lb_xuatxu);
            Controls.Add(lb_mota);
            Controls.Add(lb_soluong);
            Controls.Add(lb_Sl_value);
            Controls.Add(lb_Giavalue);
            Controls.Add(lb_Giamoi);
            Controls.Add(lb_Gia);
            Controls.Add(lb_Name);
            Controls.Add(ptb_Img);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GenSPFrm";
            Text = "GenSPFrm";
            ((System.ComponentModel.ISupportInitialize)ptb_Img).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptb_Img;
        private Label lb_Name;
        private Label lb_Gia;
        private Label lb_Giamoi;
        private Label lb_Giavalue;
        private Label lb_mota;
        private Label lb_soluong;
        private Label lb_xuatxu;
        private Label lb_Sl_value;
        private TextBox txt_SlBan;
        private Button btn_mua;
    }
}