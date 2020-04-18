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
    public partial class Bieu_do : Form
    {
        public Bieu_do()
        {
            InitializeComponent();
        }

        private void Bieu_do_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyChiTieu2;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter(" select ngaythang, sum(sotien) AS sotien from thongtinchitieu group by ngaythang", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            chart1.DataSource = dt;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = " tên chi tiêu";
            chart1.ChartAreas["ChartArea1"].AxisX.Title = " Số tiền";

            chart1.Series["Series1"].XValueMember = " ngaythang";
            chart1.Series["Series1"].YValueMembers = " sotien";
        }
    }
}
