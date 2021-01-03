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


namespace DoAn6
{
    public partial class QuanLy : Form
    {
        ServiceReference2.WebService1SoapClient hi = new ServiceReference2.WebService1SoapClient();
        public QuanLy()
        {
            InitializeComponent();
        }

        
        private void QuanLy_Load(object sender, EventArgs e)
        {

        }
        int i = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
            DataSet ds = new DataSet();
            ds = hi.getdata();
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            foreach(DataRow rows in dt.Rows)
            {
                listView1.Items.Add(rows["MANV"].ToString());
                listView1.Items[i].SubItems.Add(rows["TENNV"].ToString());
                listView1.Items[i].SubItems.Add(rows["GIOITINH"].ToString());
                listView1.Items[i].SubItems.Add(rows["TRINHDO"].ToString());
                listView1.Items[i].SubItems.Add(rows["NGAYSINH"].ToString());
                listView1.Items[i].SubItems.Add(rows["HONNHAN"].ToString());
                listView1.Items[i].SubItems.Add(rows["SOCMND"].ToString());
                listView1.Items[i].SubItems.Add(rows["QUEQUAN"].ToString());
                listView1.Items[i].SubItems.Add(rows["PHONE"].ToString());
                listView1.Items[i].SubItems.Add(rows["EMAIL"].ToString());
                listView1.Items[i].SubItems.Add(rows["TEN"].ToString());
                listView1.Items[i].SubItems.Add(rows["TEN"].ToString());
                i++;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                manv.Text = item.SubItems[0].Text;
                tennv.Text = item.SubItems[1].Text;
                if (item.SubItems[2].Text.Equals("NAM"))
                {
                    nam.Checked=true;
                }
                else
                {
                    nu.Checked = true;
                }
                trinhdo.Text = item.SubItems[3].Text;
                honnhan.Text = item.SubItems[5].Text;
                socmnd.Text = item.SubItems[6].Text;
                que.Text = item.SubItems[7].Text;
                sodt.Text = item.SubItems[8].Text;
                email.Text = item.SubItems[9].Text;
                phonban.Text = item.SubItems[10].Text;
                chucvu.Text = item.SubItems[11].Text;
            }
        }

        private void uer_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
