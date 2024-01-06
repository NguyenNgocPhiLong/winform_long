using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;


namespace GUI
{
    public partial class DangNhap : Form
    {
        TaiKhoan taiKhoan = new TaiKhoan();
        TaiKhoanBLL TKBLL = new TaiKhoanBLL();
        public DangNhap()
        {
            InitializeComponent();
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void btnLogic_Click(object sender, EventArgs e)
        {
            taiKhoan.sTaiKhoan = txtTaiKhoan.Text;
            taiKhoan.sMatKhau = txtMatKhau.Text;
            string getuser = TKBLL.CheckLogic(taiKhoan);
            // the hien tra lai ket qua neu khong dung
            switch (getuser)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Tai khoan khong duoc de trong ");
                    return;

                case "requeid_matkhau":
                    MessageBox.Show("Mat khau khong duoc de trong ");
                    return;

                case "Tai khoan hoac mat khau khong chinh xac!":
                    MessageBox.Show("Tai khoan hoac mat khau khong chinh xac !");
                    return;
            }
            MessageBox.Show("Ban da dang nhap thanh cong he thong !");

        }
    }
}
    