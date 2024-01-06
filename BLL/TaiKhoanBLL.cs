using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanAccess tkAccess = new TaiKhoanAccess();
        public string CheckLogic(TaiKhoan taiKhoan)
        {
            // kiem tra nghiep vu
            if(taiKhoan.sTaiKhoan =="")
            {
                return "requeid_taikhoan";
            }
            if(taiKhoan.sMatKhau == "")
            {
                return "requeid_matkhau";
            }
            string info = tkAccess.CheckLogic(taiKhoan);
            return info;
        }
    }
}
