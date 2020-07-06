using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class CanhBao : Form
    {
        public CanhBao()
        {
            InitializeComponent();
        }

        private void CanhBao_Load(object sender, EventArgs e)
        {
            string s1 = "NHIỆT ĐỘ QUÁ CAO";
            string s2 = "ĐỘ ẨM QUÁ CAO";
            string s3 = "NHIỆT ĐỘ QUÁ THẤP";
            string s4 = "ĐỘ ẨM QUÁ THẤP";
            string s5 = "Cảnh báo này sẽ mất đi khi nhiệt độ, độ ẩm đo được trong khoảng cho phép";


            if (Giaodien.canhBaoNhietDoMax == 1)
            {
                if (Giaodien.canhBaoDoAmMax == 1)
                    txbCanhBao.Text = s1 + "\n" + s2 + "\n" + s5;
                else if (Giaodien.canhBaoDoAmMin == 1)
                    txbCanhBao.Text = s1 + "\n" + s4 + "\n" + s5;
                else txbCanhBao.Text = s1 + "\n" + s5;
            }
            else if (Giaodien.canhBaoNhietDoMin == 1)
            {
                if (Giaodien.canhBaoDoAmMax == 1)
                    txbCanhBao.Text = s3 +"\n" + s2+"\n" + s5;
                else if (Giaodien.canhBaoDoAmMin == 1)
                    txbCanhBao.Text = s3 + "\n" + s4 + "\n" + s5;
                else txbCanhBao.Text = s3 + "\n" + s5;
            }
            else if (Giaodien.canhBaoDoAmMax == 1)
            {
                if (Giaodien.canhBaoNhietDoMax == 1)
                    txbCanhBao.Text = s1 +"\n" + s2 + "\n" + s5;
                else if (Giaodien.canhBaoNhietDoMin == 1)
                    txbCanhBao.Text = s3 + "\n" + s2 + "\n" + s5;
                else txbCanhBao.Text = s2 + "\n" + s5;
            }
            else if (Giaodien.canhBaoDoAmMax == 1)
            {
                if (Giaodien.canhBaoDoAmMax == 1)
                    txbCanhBao.Text = s1 +"\n" + s4 + "\n" + s5;
                else if (Giaodien.canhBaoDoAmMin == 1)
                    txbCanhBao.Text = s3 + "\n" + s4 + "\n"+ s5;
                else txbCanhBao.Text = s4 + "\n" + s5;
            }
        }
    }
}
