using QuanLyChiTieu2.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChiTieu2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        // khởi tạođ database
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-MQ3E0HG\SQLEXPRESS;Initial Catalog=QuanLyChiTieu2;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {

            command = connection.CreateCommand();
            command.CommandText = " select * from thongtinchitieu";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table; // đổ dữ liệu lên bảng 
        }

        //void loadgird()
        //{
        //    command = connection.CreateCommand();
        //    command.CommandText = "select * from thongtinchitieu where tenchitieu like '" + textBox4.Text + "'";
        //    adapter.SelectCommand = command;
        //    table.Clear();
        //    adapter.Fill(table);
        //    dataGridView1.DataSource = table;
        //}



        int i = 0;





        private Account loginAccount;

        public Account LoginAccount 
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
            }

        public FormMain(Account acc)
        {
            InitializeComponent();
            this.loginAccount = acc;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBox1.ReadOnly = true;
            i = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            int sum = 0;
            for (i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            textBox3.Text = sum.ToString();

        }

        void ChangeAccount(int type)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ")";
        }

        private void FormDangnhap_Load(object sender, EventArgs e)
        {
            //datagridview
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        

        private void thôngTinCáNhânToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormProfile formProfile = new FormProfile(loginAccount);
            this.Hide();
            formProfile.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            table.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = " insert into thongtinchitieu values('" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + textBox2.Text + "')"; //xli câu truy vấn
            command.ExecuteNonQuery();  //trả về kết quả câu truy vấn
            loaddata();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update thongtinchitieu set tenchitieu = '" + textBox1.Text + "' , sotien = " + textBox2.Text + " where ngaythang = '" + dateTimePicker1.Text + "' ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = " delete from thongtinchitieu where ngaythang = '" + dateTimePicker1.Text + "' ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            int sum = 0;
            for (i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            textBox3.Text = sum.ToString();
        }

        private void biểuĐồToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bieu_do bieudo = new Bieu_do();
            bieudo.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin dangnhap = new FormLogin();
            dangnhap.Show();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
            this.Hide();
            FormLogin dangnhap = new FormLogin();
            dangnhap.Show();
        }


        private void lênSựKiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKehoachchitieu kehoachchitieu = new FormKehoachchitieu();
            kehoachchitieu.Show();
        }

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    loadgird();
        //}
    }
}
