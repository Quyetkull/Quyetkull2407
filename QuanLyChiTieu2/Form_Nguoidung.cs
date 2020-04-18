using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChiTieu2
{
    class Form_Nguoidung
    {

        private string hoten, email, sdt, taikhoan, matkhau;

        public Form_Nguoidung()
        {
            hoten = email = sdt = taikhoan = matkhau = "";
        }

        public Form_Nguoidung(string name, string gmail, string phone, string tk, string mk, string text)
        {
            hoten = name;
            gmail = email;
            sdt = phone;
            taikhoan = tk;
            matkhau = mk;
        }

        //Kiểm tra điều kiện mật khẩu
        public bool Ktramatkhau()
        {

            if (matkhau.Length < 6)
            {
                return false;
            }

            // neu ma bang true thi moi di ktra tiep
            //kiểm tra để mật khẩu có cả chữ và số 
            bool ktrachu = false; //coi như chưa có chữ
            bool ktraso = false; // coi như chưa có số

            for (int i = 0; i < matkhau.Length; ++i)
            {
                if (ktrachu == true && ktraso == true)
                {
                    break; // dừng vòng lặp
                }
                // Điều kiện
                // A-Z : Bắt đầu 65
                //a-z : Bắt đầu 97
                if ((matkhau[i] >= 'A' && matkhau[i] <= 'Z') || (matkhau[i] >= 'a' && matkhau[i] <= 'z'))
                {
                    ktrachu = true;
                }

                //ktra số
                if (matkhau[i] >= '0' && matkhau[i] <= '9')
                {
                    ktraso = true;
                }
            }

            if (ktraso == false || ktrachu == false)
            {
                return false; // Mat khau do là không hợp lệ và nhap lại 
            }


            return true; // mạt khẩu hợp lệ

        }
    }
}

