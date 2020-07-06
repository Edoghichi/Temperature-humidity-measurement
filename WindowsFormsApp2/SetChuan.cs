using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class SetChuan : Form
    {
        public SetChuan()
        {
            InitializeComponent();
        }
        void LuuChuan()
        {
            string s = "";
            s += Giaodien.a1.ToString() + "\n";
            s += Giaodien.b1.ToString() + "\n";
            s += Giaodien.c1.ToString() + "\n";
            s += Giaodien.a2.ToString() + "\n";
            s += Giaodien.b2.ToString() + "\n";
            s += Giaodien.c2.ToString() + "\n";

            using (StreamWriter sw = new StreamWriter(Giaodien.linkFileOffset))
            {
                sw.Write(s);
            }
        }
        private void BtnOk_Click(object sender, EventArgs e)
        {
            double a1;
            double a2;
            double b1;
            double b2;
            double c1;
            double c2;
            if (double.TryParse(txbA1.Text, out a1) && double.TryParse(txbA2.Text, out a2) && double.TryParse(txbB1.Text, out b1) && double.TryParse(txbB2.Text, out b2) && double.TryParse(txbC1.Text, out c1) && double.TryParse(txbC2.Text, out c2))
            {
                Giaodien.a1 = a1;
                Giaodien.a2 = a2;
                Giaodien.b1 = b1;
                Giaodien.b2 = b2;
                Giaodien.c1 = c1;
                Giaodien.c2 = c2;
                LuuChuan();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nhập vào dữ liệu chuẩn");
            }
               
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            
        }
    }
}
