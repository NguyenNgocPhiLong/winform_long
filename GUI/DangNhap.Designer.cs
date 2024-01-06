namespace GUI
{
    partial class DangNhap
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
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            btnLogic = new Button();
            btnThoat = new Button();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 52);
            label1.Name = "label1";
            label1.Size = new Size(104, 22);
            label1.TabIndex = 0;
            label1.Text = "Tài Khoản :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 116);
            label2.Name = "label2";
            label2.Size = new Size(98, 22);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu :";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(132, 44);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(322, 30);
            txtTaiKhoan.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(132, 108);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(322, 30);
            txtMatKhau.TabIndex = 3;
            // 
            // btnLogic
            // 
            btnLogic.BackColor = SystemColors.ButtonShadow;
            btnLogic.Location = new Point(132, 166);
            btnLogic.Name = "btnLogic";
            btnLogic.Size = new Size(107, 47);
            btnLogic.TabIndex = 4;
            btnLogic.Text = "Đăng Nhập";
            btnLogic.UseVisualStyleBackColor = false;
            btnLogic.Click += btnLogic_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.ButtonShadow;
            btnThoat.Location = new Point(365, 166);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(89, 47);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 259);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.png_clipart_login_user_computer_icons_form_password_others_orange_web_application;
            pictureBox1.Location = new Point(3, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 233);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(320, 23);
            label3.Name = "label3";
            label3.Size = new Size(364, 41);
            label3.TabIndex = 7;
            label3.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTaiKhoan);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(txtMatKhau);
            groupBox2.Controls.Add(btnLogic);
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(336, 110);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(544, 250);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin đăng nhập";
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 450);
            Controls.Add(groupBox2);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Name = "DangNhap";
            Text = "Đăng Nhập";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private Button btnLogic;
        private Button btnThoat;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label3;
        private GroupBox groupBox2;
    }
}