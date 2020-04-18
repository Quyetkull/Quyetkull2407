using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyChiTieu2
{
    public partial class Form_dangki : Form
    {
        public Form_dangki()
        {
            InitializeComponent();
        }

        FormLogin dangnhap = new FormLogin();
        string chuoiketnoi = @"Data Source=DESKTOP-MQ3E0HG\SQLEXPRESS;Initial Catalog=QuanLyChiTieu2;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;

        public void hienthi()
        {
            ketnoi.Open();
            sql = @" Select UserName, PassWord FROM Account";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();

        }



        private void Form_dangki_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
        }

        private void bt_dangki_Click(object sender, EventArgs e)
        {
            if (txt_hoten.Text == "")
            {
                MessageBox.Show(" Bạn chưa nhập họ tên ");
                txt_hoten.Focus(); // đưa con trỏ về lại ô đó
            }
            else if (txt_email.Text == "")
            {
                MessageBox.Show(" Bạn chưa nhập email ");
                txt_email.Focus(); // đưa con trỏ về lại ô đó
            }
            else if (txt_sdt.Text == "")
            {
                MessageBox.Show(" Bạn chưa nhập số điện thoại  ");
                txt_sdt.Focus(); // đưa con trỏ về lại ô đó
            }
            else if (txt_taikhoan.Text == "")
            {
                MessageBox.Show(" Bạn chưa nhập tên tài khoản");
                txt_taikhoan.Focus(); // đưa con trỏ về lại ô đó
            }
            else if (txt_matkhau.Text == "")
            {
                MessageBox.Show(" Bạn chưa nhập mật khẩu ");
                txt_matkhau.Focus(); // đưa con trỏ về lại ô đó
            }
            else if (txt_xacnhanMK.Text == "")
            {
                MessageBox.Show(" Bạn chưa nhập xác nhận mật khẩu");
                txt_xacnhanMK.Focus(); // đưa con trỏ về lại ô đó
            }
            else if (txt_matkhau.Text != txt_xacnhanMK.Text)
            {
                MessageBox.Show(" Bạn nhập mật khẩu không trùng khớp");
                txt_xacnhanMK.Focus();
                txt_xacnhanMK.SelectAll(); // bôi đen tất cả ô xác nhận mật khẩu để người dùng xóa đi nhanh
            }
            
            else
            {
                Form_Nguoidung nguoidung = new Form_Nguoidung(txt_hoten.Text, txt_email.Text, txt_sdt.Text, txt_taikhoan.Text, txt_matkhau.Text, txt_xacnhanMK.Text);

                if (nguoidung.Ktramatkhau() == true)
                {
                    MessageBox.Show(" Bạn đã tạo tài khoản thành công !! ");

                    ketnoi.Open();
                    sql = @"insert into Account(UserName , PassWord) values ('" + txt_taikhoan.Text + "', '" + txt_matkhau.Text + "') ";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    ketnoi.Close();

                    this.Hide();
                    FormLogin dangnhap = new FormLogin();
                    dangnhap.Show();
                }

                else
                {
                    MessageBox.Show(" Sai rôi bạn eiii, tạo lại tài khoản đê =))) ");
                }

                try
                {
                    n = int.Parse(txt_sdt.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Phải nhập só");
                }

            }

           
        }

        private void bt_quaylaiformdangnhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin dangnhap = new FormLogin();
            dangnhap.Show();
            this.Show();
        }


        int n = 0;
        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                n = int.Parse(txt_sdt.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Phải nhập só");
            }
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                MessageBox.Show(" ban phải nhập số");
            }
        }
    }
}
