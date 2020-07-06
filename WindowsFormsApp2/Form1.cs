using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using System.Threading;
//Giao tiep cong COM
using System.IO;
using System.IO.Ports;
using System.Xml;


namespace WindowsFormsApp2
{
    public partial class Giaodien : Form
    {
        int iSTT = 1; //số thứ tự trên dataGridView
        long tickStart1 = 0; //biến thời gian trục X nhiệt độ
        long tickStart2 = 0; //biến thời gian trục X độ ẩm
        ContextMenuStrip contextMenu;
        string InputData = String.Empty; // Khai báo string dùng cho hiển thị dữ liệu sau này.
        delegate void SetTextCallback(string text); // Khai bao delegate SetTextCallBack voi tham so string
        int loi = 0; //Khai báo biến lỗi gặp phải khi nhận dữ liệu trên cổng COM
        public Giaodien()
        {
            InitializeComponent();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
            GetOffset();
        }
        void Setup_NhietDo()
        {
            GraphPane myPane = graphNhietDo.GraphPane;//khai bóa sử dụng đối tượng Graphpane
            myPane.Title.Text = "ĐỒ THỊ NHIỆT ĐỘ TỪ CẢM BIẾN DHT11";
            myPane.XAxis.Title.Text = "Thời Gian";//tên trục hoành
            myPane.YAxis.Title.Text = "NHIỆT ĐỘ (℃)";//tên trục tung
            RollingPointPairList list = new RollingPointPairList(60000);//số điểm có thể lưu trong đồ thị này

            LineItem curve = myPane.AddCurve("", list, Color.Red, SymbolType.None);//đường để vẽ đồ thị nhiệt độ

            myPane.XAxis.Scale.Min = 1;  // Min = 1;
            myPane.XAxis.Scale.Max = 10; // Max = 10;
            myPane.XAxis.Scale.MinorStep = 1;  // Đơn vị chia nhỏ nhất 1
            myPane.XAxis.Scale.MajorStep = 2; // Đơn vị chia lớn 2
            myPane.YAxis.Scale.Min = 0;  // Min = 0;
            myPane.YAxis.Scale.Max = 50; // Max = 50;
            myPane.YAxis.Scale.MinorStep = 1;  // Đơn vị chia nhỏ nhất 1
            myPane.YAxis.Scale.MajorStep = 5; // Đơn vị chia lớn 5
            //scale the axes
            graphNhietDo.AxisChange();
            graphNhietDo.Invalidate();
        }
        void Setup_DoAm()
        {
            GraphPane myPane = graphDoAm.GraphPane; //Khai báo sử dụng đối tượng Graphpane
            myPane.Title.Text = "ĐỒ THỊ ĐỘ ẨM TỪ CẢM BIẾN DHT11";
            myPane.XAxis.Title.Text = "Thời Gian";//tên trục hoành
            myPane.YAxis.Title.Text = "ĐỘ ẨM (%)";//tên trục tung
            RollingPointPairList list = new RollingPointPairList(60000);//số điểm có thể lưu trong đồ thị này

            LineItem curve = myPane.AddCurve("", list, Color.Blue, SymbolType.None);//đường để vẽ đồ thị

            myPane.XAxis.Scale.Min = 1;  // Min = 1;
            myPane.XAxis.Scale.Max = 11; // Max = 11;
            myPane.XAxis.Scale.MinorStep = 1;  // Đơn vị chia nhỏ nhất 1
            myPane.XAxis.Scale.MajorStep = 2; // Đơn vị chia lớn 2
            myPane.YAxis.Scale.Min = 20;  // Min = 20;
            myPane.YAxis.Scale.Max = 100; // Max = 100;
            myPane.YAxis.Scale.MinorStep = 2;  // Đơn vị chia nhỏ nhất 2
            myPane.YAxis.Scale.MajorStep = 10; // Đơn vị chia lớn 10
            //scale the axes
            graphDoAm.AxisChange();
            graphDoAm.Invalidate();
        }
        void DrawNhietDo(double setpoint1)
        {
            if (graphNhietDo.GraphPane.CurveList.Count <= 0)
                return; // Kiểm tra việc khởi tạo các đường curve

            LineItem curve = graphNhietDo.GraphPane.CurveList[0] as LineItem;
            if (curve == null)
                return;
            IPointListEdit list = curve.Points as IPointListEdit;
            if (list == null)
                return;

            tickStart1++;
            double time = tickStart1;

            list.Add(time, setpoint1);// Đây chính là hàm hiển thị dữ liệu của mình lên đồ thị

            //keep the X scale at a rolling 30 seconed interval, with one major step
            //between the max X value and the end of the axis
            Scale xScale = graphNhietDo.GraphPane.XAxis.Scale;
            if (time > xScale.Max - xScale.MajorStep)
            {
                if (btnViewNhietDo.Text == "Scroll")
                {
                    xScale.Max = time + xScale.MajorStep;
                    xScale.Min = xScale.Max - 10.0;
                }
                else
                {
                    xScale.Max = time + xScale.MajorStep;
                    xScale.Min = 1;
                }
            }
            graphNhietDo.Invalidate();
        }
        void ClearGraphNhietDo()
        {
            graphNhietDo.GraphPane.CurveList.Clear();
            graphNhietDo.GraphPane.GraphObjList.Clear();
            Setup_NhietDo();
            tickStart1 = 0; //trả lại biến thời gian
        }

        void DrawDoAm(double setpoint)
        {
            if (graphDoAm.GraphPane.CurveList.Count <= 0)
                return; // Kiểm tra việc khởi tạo các đường curve

            LineItem curve = graphDoAm.GraphPane.CurveList[0] as LineItem;
            if (curve == null)
                return;
            IPointListEdit list = curve.Points as IPointListEdit;
            if (list == null)
                return;

            tickStart2++;
            double time = tickStart2;

            list.Add(time, setpoint);// Đây chính là hàm hiển thị dữ liệu của mình lên đồ thị
                                     //list2.Add(time, setpoint1);

            //keep the X scale at a rolling 30 seconed interval, with one major step
            //between the max X value and the end of the axis
            Scale xScale = graphDoAm.GraphPane.XAxis.Scale;
            if (time > xScale.Max - xScale.MajorStep)
            {
                if (btnViewDoAm.Text == "Scroll")
                {
                    xScale.Max = time + xScale.MajorStep;
                    xScale.Min = xScale.Max - 10.0;
                }
                else
                {
                    xScale.Max = time + xScale.MajorStep;
                    xScale.Min = 1;
                }
            }
            graphDoAm.Invalidate();  //Cập nhật cho GraphPane
        }
        void ClearGraphDoAm()
        {
            graphDoAm.GraphPane.CurveList.Clear();
            graphDoAm.GraphPane.GraphObjList.Clear();
            Setup_DoAm();
            tickStart2 = 0; //trả lại biến thời gian
        }
        //Thread mới để nhận dữ liệu
        private void DataReceive(object obj, SerialDataReceivedEventArgs e)
        {
            InputData = serialPort1.ReadLine();
            if (InputData.StartsWith("Nhiet Do:"))
            {
                loi = 0;
                // txtbox2.Text = InputData; // Ko dùng đc như thế này vì khác threads .
                //vì textbox1 là text box nhận dữ liệu k nằm trong luồng(thread) của công com vì thế k 
                //gán dữ liệu từ cổng com đọc được vào textbox2 nên phải dùng delegate ủy quyền 

                SettxbNhietDo(InputData); // Chính vì vậy phải sử dụng ủy quyền tại đây. Gọi delegate đã khai báo trước đó.

            }
            else if (InputData.StartsWith("Do Am:"))
            {
                loi = 0;
                // txtbox2.Text = InputData; // Ko dùng đc như thế này vì khác threads .
                //vì textbox1 là text box nhận dữ liệu k nằm trong luồng(thread) của công com vì thế k 
                //gán dữ liệu từ cổng com đọc được vào textbox2 nên phải dùng delegate ủy quyền 

                SettxbDoAm(InputData); // Chính vì vậy phải sử dụng ủy quyền tại đây. Gọi delegate đã khai báo trước đó.
                // hàm add vào Cột
                BeginInvoke(new Action(() =>
                {
                    if (double.TryParse(txbNhietDo.Text, out double num1))
                    {
                        DrawNhietDo(num1);

                        if (double.TryParse(txbDoAm.Text, out double num2)) DrawDoAm(num2);
                        string[] dulieu = new string[]
                          {
                        iSTT.ToString(),
                        txbNhietDo.Text,
                        txbDoAm.Text
                          };
                        dataGridView1.Rows.Add(dulieu);
                        iSTT++;
                    }

                }));
            }
            else if (InputData.StartsWith("Loi"))
            {
                loi++;
            }


        }

        // hàm nhận dữ liệu Nhiệt Độ từ cổng COM
        private void SettxbNhietDo(string text1)
        {
            if (this.txbNhietDo.InvokeRequired)
            {
                SetTextCallback method = new SetTextCallback(SettxbNhietDo); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(method, new object[] { text1 });
            }
            else
            {
                string textDuLieu = text1.Replace("Nhiet Do:", "");
                double giaTriDo = double.Parse(textDuLieu);
                double giaTriOffSet = a1 * giaTriDo*giaTriDo + b1 * giaTriDo + c1;
                this.txbNhietDo.Text = giaTriOffSet.ToString();
            }
        }

        // hàm nhận dữ liệu Độ Ẩm từ cổng COM
        private void SettxbDoAm(string text1)
        {
            if (this.txbDoAm.InvokeRequired)
            {
                SetTextCallback method = new SetTextCallback(SettxbDoAm); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(method, new object[] { text1 });
            }
            else
            {
                string textDuLieu = text1.Replace("Do Am:", "");
                double giaTriDo = double.Parse(textDuLieu);
                double giaTriOffSet = a2 * giaTriDo * giaTriDo + b2 * giaTriDo + c2;
                this.txbDoAm.Text = giaTriOffSet.ToString();
            }
        }

        private void Giaodien_Load(object sender, EventArgs e)
        {
            Setup_DoAm();
            Setup_NhietDo();
            Setup_contextMenu();
            //Cập nhật cổng COM
            cbCongCom.DataSource = SerialPort.GetPortNames();
            int count = cbCongCom.Items.Count;
            if (count == 1) cbCongCom.SelectedIndex = 0;
            else  cbCongCom.SelectedIndex = 1;

            string[] Baudrate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            cbBaudrate.Items.AddRange(Baudrate);
            cbBaudrate.SelectedIndex = 3;
        }
        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            //Check kết nối
            if (serialPort1.IsOpen)
            {
                lbTrangThai.Text = "Đang thu thập dữ liệu";
                lbTrangThai.ForeColor = Color.Lime;
                btnMenu.Enabled = false;
            }
            else
            {
                lbTrangThai.Text = "Chưa kết nối";
                lbTrangThai.ForeColor = Color.Red;
                btnMenu.Enabled = true;
            }
            //HIển thị thời gian thực
            lbViewTime.Text = DateTime.Now.ToString();

        }

        private void btnKetnoi_Click(object sender, EventArgs e)
        {
            //mo cong com
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.PortName = cbCongCom.Text;
                    serialPort1.BaudRate = Convert.ToInt32(cbBaudrate.Text);
                    serialPort1.Open();
                    timer2.Enabled = true;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Không kết nối được với cổng COM \nChọn cổng COM khác");
                }
            }
        }

        private void btnNgatketnoi_Click(object sender, EventArgs e)
        {
            if (lbTrangThai.Text == "Đang thu thập dữ liệu")
            {
                DialogResult result = MessageBox.Show("Ngắt kết nối", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.OK)
                {
                    timer2.Enabled = false;
                    serialPort1.Close();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (lbTrangThai.Text == "Chưa kết nối")
            {
                timer2.Enabled = false;
                serialPort1.Close();
                MessageBox.Show("Kiểm tra lại kết nối cổng COM", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNhietDo.Text = "";
                txbDoAm.Text = "";
                loi = 0;
            }
            if (loi > 10)
            {
                timer2.Enabled = false;
                serialPort1.Close();
                MessageBox.Show("Kiểm tra lại kết nối cảm biến với Arduino", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNhietDo.Text = "";
                txbDoAm.Text = "";
                loi = 0;
            }
        }

        private void btnViewNhietDo_Click(object sender, EventArgs e)
        {
            if (btnViewNhietDo.Text == "Scroll") btnViewNhietDo.Text = "Compact";
            else btnViewNhietDo.Text = "Scroll";
        }

        private void btnViewDoAm_Click(object sender, EventArgs e)
        {
            if (btnViewDoAm.Text == "Scroll") btnViewDoAm.Text = "Compact";
            else btnViewDoAm.Text = "Scroll";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            contextMenu.Show(this, this.PointToClient(MousePosition));
        }
        void Setup_contextMenu()
        {
            contextMenu = new ContextMenuStrip();
            var lammoi = new ToolStripButton() { Text = "Làm mới" };
            contextMenu.Items.Add(lammoi);
            lammoi.Click += lammoi_click;
            var tinhTB = new ToolStripButton() { Text = "Tính trung bình cộng" };
            contextMenu.Items.Add(tinhTB);
            tinhTB.Click += tinhTB_click;
            var xuatDL = new ToolStripButton() { Text = "Xuất dữ liệu ra Excel" };
            contextMenu.Items.Add(xuatDL);
            xuatDL.Click += xuatDL_click;
            var setChuan = new ToolStripButton() { Text = "Lấy chuẩn" };
            contextMenu.Items.Add(setChuan);
            setChuan.Click += setChuan_click;
        }
        void lammoi_click(object sender, EventArgs e)
        {
            //Làm mới DataGridView 
            int height = dataGridView1.RowCount;
            for (int i = 0; i <= height - 2; i++)
            {
                dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
            }
            iSTT = 1;
            //Làm mới GraphPane
            ClearGraphNhietDo();
            ClearGraphDoAm();
            //Làm mới txb
            txbNhietDo.Text = "";
            txbDoAm.Text = "";

        }
        public static double nhietDoTB = 0;
        public static double doAmTB = 0;
        int CheckDataGridView()
        {
            //Tính trung bình cộng
            int count = dataGridView1.RowCount;
            if (count == 1)
            {
                MessageBox.Show("Chưa có dữ liệu đo");
                return 0;
            }
            else if (dataGridView1[0, count - 2].Value.ToString() == "TB")
            {
                return 1; //Đã có kết quả trung bình
            }
            else
            {
                return 2; //Có kết quả đo và chưa tính trung bình
            }
        }
        void tinhTB_click(object sender, EventArgs e)
        {
            if(CheckDataGridView()==1) MessageBox.Show("Đã có kết quả trung bình");
            if (CheckDataGridView()==2)
            {
                double dulieuDoAm;
                int dem = 0;
                nhietDoTB = 0;
                doAmTB = 0;
                for (int i = 0; i <=dataGridView1.Rows.Count  - 2; i++)
                {
                    double dulieuNhietDo = double.Parse(dataGridView1[1, i].Value.ToString());
                    nhietDoTB += dulieuNhietDo;
                    double.TryParse(dataGridView1[2, i].Value.ToString(), out dulieuDoAm);
                    doAmTB += dulieuDoAm;
                    dem++;
                }
                nhietDoTB =Math.Round(nhietDoTB / dem,2);
                doAmTB = Math.Round(doAmTB / dem,2);
                string[] tb = new string[]
                {
                "TB",
                nhietDoTB.ToString(),
                doAmTB.ToString()
                };
                dataGridView1.Rows.Add(tb);
            }

        }
        void xuatDL_click(object sender, EventArgs e)
        {
            // Xuất dữ liệu ra Excel
            lib.XuatDuLieuSangExcel(dataGridView1);
        }
        void setChuan_click(object sender, EventArgs e)
        {
            //if (CheckDataGridView() == 0) return;
            //else if (CheckDataGridView() == 2)
            //{
            //    tinhTB_click(new object(), new EventArgs());
            //}
            SetChuan setChuan = new SetChuan();
            setChuan.ShowDialog();

        }

        //Set offset (Đọc dữ liệu offset từ file offset.txt)
        public static string linkFileOffset = "offset.txt";
        public static double a1;
        public static double a2;
        public static double b1;
        public static double b2;
        public static double c1;
        public static double c2;

        void GetOffset()
        {
            string[] lines;

            if (File.Exists(linkFileOffset))
            {
                lines = File.ReadAllLines(linkFileOffset);
                a1 = double.Parse(lines[0]);
                b1 = double.Parse(lines[1]);
                c1 = double.Parse(lines[2]);
                a2 = double.Parse(lines[3]);
                b2 = double.Parse(lines[4]);
                c2 = double.Parse(lines[5]);
            }
        }

        //Cảnh báo khi nhiệt độ nằm ngoài giới hạn
        double nhietDoMax = 40;
        double nhietDoMin = 10;
        public static int canhBaoNhietDoMax = 0;
        public static int canhBaoNhietDoMin = 0;
        CanhBao canhBaoNhietDo = new CanhBao();
        private void txbNhietDo_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txbNhietDo.Text, out double nhietDo))
            {
                if (nhietDo > nhietDoMax)
                {
                    if (canhBaoNhietDoMax == 0)
                    {
                        canhBaoNhietDoMax = 1;
                        canhBaoNhietDo.Show();
                    }
                }
                else if (double.Parse(txbNhietDo.Text) <= nhietDoMax && double.Parse(txbNhietDo.Text) >= nhietDoMin)
                {
                    if (canhBaoNhietDoMax == 1)
                    {
                        canhBaoNhietDoMax = 0;
                        canhBaoNhietDo.Hide();
                    }
                    else if (canhBaoNhietDoMin == 1)
                    {
                        canhBaoNhietDoMin = 0;
                        canhBaoNhietDo.Hide();
                    }
                }
                else if (double.Parse(txbNhietDo.Text) < nhietDoMin)
                {
                    if (canhBaoNhietDoMin == 0)
                    {
                        canhBaoNhietDoMin = 1;
                        canhBaoNhietDo.Show();
                    }
                }
            }
        }
        //Cảnh báo khi độ ẩm nằm ngoài giới hạn
        double doAmMax = 90;
        double doAmMin = 30;
        public static int canhBaoDoAmMax = 0;
        public static int canhBaoDoAmMin = 0;
        CanhBao canhBaoDoAm = new CanhBao();
        private void txbDoAm_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txbDoAm.Text, out double doAm))
            {
                if (doAm > doAmMax)
                {
                    if (canhBaoDoAmMax == 0)
                    {
                        canhBaoDoAmMax = 1;
                        canhBaoDoAm.Show();
                    }
                }
                else if (double.Parse(txbDoAm.Text) <= doAmMax && double.Parse(txbDoAm.Text) >= doAmMin)
                {
                    if (canhBaoDoAmMax == 1)
                    {
                        canhBaoDoAmMax = 0;
                        canhBaoDoAm.Hide();
                    }
                    else if (canhBaoDoAmMin == 1)
                    {
                        canhBaoDoAmMin = 0;
                        canhBaoDoAm.Hide();
                    }
                }
                else if (double.Parse(txbDoAm.Text) < doAmMin)
                {
                    if (canhBaoDoAmMin == 0)
                    {
                        canhBaoDoAmMin = 1;
                        canhBaoDoAm.Show();
                    }
                }
            }
        }
    }
}
