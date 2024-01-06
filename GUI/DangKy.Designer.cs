namespace GUI
{
    partial class DangKy
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbnDangKy = new Button();
            txtDKTaiKhoan = new TextBox();
            txtDKMatKhau = new TextBox();
            txtDKXNMatKhau = new TextBox();
            txtDKEmail = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(150, 22);
            label1.Name = "label1";
            label1.Size = new Size(315, 41);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÝ HỆ THỐNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(35, 98);
            label2.Name = "label2";
            label2.Size = new Size(116, 28);
            label2.TabIndex = 1;
            label2.Text = "Tài Khoản :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(36, 158);
            label3.Name = "label3";
            label3.Size = new Size(115, 28);
            label3.TabIndex = 2;
            label3.Text = "Mật Khẩu :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(35, 221);
            label4.Name = "label4";
            label4.Size = new Size(212, 28);
            label4.TabIndex = 3;
            label4.Text = "Xác Nhận Mật Khẩu :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(35, 280);
            label5.Name = "label5";
            label5.Size = new Size(75, 28);
            label5.TabIndex = 4;
            label5.Text = "Email :";
            // 
            // tbnDangKy
            // 
            tbnDangKy.BackColor = SystemColors.AppWorkspace;
            tbnDangKy.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tbnDangKy.ForeColor = SystemColors.Window;
            tbnDangKy.Location = new Point(253, 339);
            tbnDangKy.Name = "tbnDangKy";
            tbnDangKy.Size = new Size(161, 48);
            tbnDangKy.TabIndex = 5;
            tbnDangKy.Text = "Đăng Ký";
            tbnDangKy.UseVisualStyleBackColor = false;
            // 
            // txtDKTaiKhoan
            // 
            txtDKTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDKTaiKhoan.Location = new Point(253, 98);
            txtDKTaiKhoan.Name = "txtDKTaiKhoan";
            txtDKTaiKhoan.Size = new Size(347, 34);
            txtDKTaiKhoan.TabIndex = 6;
            // 
            // txtDKMatKhau
            // 
            txtDKMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDKMatKhau.Location = new Point(253, 158);
            txtDKMatKhau.Name = "txtDKMatKhau";
            txtDKMatKhau.Size = new Size(347, 34);
            txtDKMatKhau.TabIndex = 7;
            // 
            // txtDKXNMatKhau
            // 
            txtDKXNMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDKXNMatKhau.Location = new Point(253, 221);
            txtDKXNMatKhau.Name = "txtDKXNMatKhau";
            txtDKXNMatKhau.Size = new Size(347, 34);
            txtDKXNMatKhau.TabIndex = 8;
            // 
            // txtDKEmail
            // 
            txtDKEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDKEmail.Location = new Point(253, 280);
            txtDKEmail.Name = "txtDKEmail";
            txtDKEmail.Size = new Size(347, 34);
            txtDKEmail.TabIndex = 9;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 450);
            Controls.Add(txtDKEmail);
            Controls.Add(txtDKXNMatKhau);
            Controls.Add(txtDKMatKhau);
            Controls.Add(txtDKTaiKhoan);
            Controls.Add(tbnDangKy);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DangKy";
            Text = "DangKy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button tbnDangKy;
        private TextBox txtDKTaiKhoan;
        private TextBox txtDKMatKhau;
        private TextBox txtDKXNMatKhau;
        private TextBox txtDKEmail;
    }
}