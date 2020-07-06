namespace WindowsFormsApp2
{
    partial class Giaodien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnViewDoAm = new System.Windows.Forms.Button();
            this.btnViewNhietDo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.cbCongCom = new System.Windows.Forms.ComboBox();
            this.btnNgatKetNoi = new System.Windows.Forms.Button();
            this.BtnKetNoi = new System.Windows.Forms.Button();
            this.txbDoAm = new System.Windows.Forms.TextBox();
            this.txbNhietDo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbViewTime = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.graphDoAm = new ZedGraph.ZedGraphControl();
            this.graphNhietDo = new ZedGraph.ZedGraphControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SoThuTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhietDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoAm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.btnMenu);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnViewDoAm);
            this.groupBox1.Controls.Add(this.btnViewNhietDo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lbTrangThai);
            this.groupBox1.Controls.Add(this.cbBaudrate);
            this.groupBox1.Controls.Add(this.cbCongCom);
            this.groupBox1.Controls.Add(this.btnNgatKetNoi);
            this.groupBox1.Controls.Add(this.BtnKetNoi);
            this.groupBox1.Controls.Add(this.txbDoAm);
            this.groupBox1.Controls.Add(this.txbNhietDo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(0, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 696);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Yellow;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Location = new System.Drawing.Point(64, 619);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(159, 46);
            this.btnMenu.TabIndex = 56;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 428);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 25);
            this.label14.TabIndex = 55;
            this.label14.Text = "Chế độ xem đồ thị";
            // 
            // btnViewDoAm
            // 
            this.btnViewDoAm.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnViewDoAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDoAm.Location = new System.Drawing.Point(128, 549);
            this.btnViewDoAm.Name = "btnViewDoAm";
            this.btnViewDoAm.Size = new System.Drawing.Size(159, 46);
            this.btnViewDoAm.TabIndex = 54;
            this.btnViewDoAm.Text = "Scroll";
            this.btnViewDoAm.UseVisualStyleBackColor = false;
            this.btnViewDoAm.Click += new System.EventHandler(this.btnViewDoAm_Click);
            // 
            // btnViewNhietDo
            // 
            this.btnViewNhietDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnViewNhietDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewNhietDo.Location = new System.Drawing.Point(128, 477);
            this.btnViewNhietDo.Name = "btnViewNhietDo";
            this.btnViewNhietDo.Size = new System.Drawing.Size(159, 46);
            this.btnViewNhietDo.TabIndex = 53;
            this.btnViewNhietDo.Text = "Scroll";
            this.btnViewNhietDo.UseVisualStyleBackColor = false;
            this.btnViewNhietDo.Click += new System.EventHandler(this.btnViewNhietDo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 487);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 25);
            this.label12.TabIndex = 52;
            this.label12.Text = "Nhiệt độ\r\n";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 559);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 25);
            this.label13.TabIndex = 51;
            this.label13.Text = "Độ ẩm";
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.ForeColor = System.Drawing.Color.Red;
            this.lbTrangThai.Location = new System.Drawing.Point(50, 246);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(218, 31);
            this.lbTrangThai.TabIndex = 50;
            this.lbTrangThai.Text = "Chưa kết nối";
            this.lbTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Location = new System.Drawing.Point(150, 83);
            this.cbBaudrate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(137, 33);
            this.cbBaudrate.TabIndex = 49;
            // 
            // cbCongCom
            // 
            this.cbCongCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCongCom.FormattingEnabled = true;
            this.cbCongCom.Location = new System.Drawing.Point(150, 25);
            this.cbCongCom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCongCom.Name = "cbCongCom";
            this.cbCongCom.Size = new System.Drawing.Size(137, 33);
            this.cbCongCom.TabIndex = 48;
            // 
            // btnNgatKetNoi
            // 
            this.btnNgatKetNoi.BackColor = System.Drawing.Color.Red;
            this.btnNgatKetNoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNgatKetNoi.Location = new System.Drawing.Point(146, 142);
            this.btnNgatKetNoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNgatKetNoi.Name = "btnNgatKetNoi";
            this.btnNgatKetNoi.Size = new System.Drawing.Size(139, 46);
            this.btnNgatKetNoi.TabIndex = 47;
            this.btnNgatKetNoi.Text = "Ngắt kết nối";
            this.btnNgatKetNoi.UseVisualStyleBackColor = false;
            this.btnNgatKetNoi.Click += new System.EventHandler(this.btnNgatketnoi_Click);
            // 
            // BtnKetNoi
            // 
            this.BtnKetNoi.BackColor = System.Drawing.Color.Lime;
            this.BtnKetNoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKetNoi.Location = new System.Drawing.Point(23, 142);
            this.BtnKetNoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnKetNoi.Name = "BtnKetNoi";
            this.BtnKetNoi.Size = new System.Drawing.Size(99, 46);
            this.BtnKetNoi.TabIndex = 46;
            this.BtnKetNoi.Text = "Kết nối";
            this.BtnKetNoi.UseVisualStyleBackColor = false;
            this.BtnKetNoi.Click += new System.EventHandler(this.btnKetnoi_Click);
            // 
            // txbDoAm
            // 
            this.txbDoAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDoAm.Location = new System.Drawing.Point(115, 366);
            this.txbDoAm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDoAm.Name = "txbDoAm";
            this.txbDoAm.ReadOnly = true;
            this.txbDoAm.Size = new System.Drawing.Size(135, 30);
            this.txbDoAm.TabIndex = 45;
            this.txbDoAm.TextChanged += new System.EventHandler(this.txbDoAm_TextChanged);
            // 
            // txbNhietDo
            // 
            this.txbNhietDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNhietDo.Location = new System.Drawing.Point(116, 308);
            this.txbNhietDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNhietDo.Name = "txbNhietDo";
            this.txbNhietDo.ReadOnly = true;
            this.txbNhietDo.Size = new System.Drawing.Size(135, 30);
            this.txbNhietDo.TabIndex = 44;
            this.txbNhietDo.TextChanged += new System.EventHandler(this.txbNhietDo_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(257, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 29);
            this.label9.TabIndex = 43;
            this.label9.Text = "℃";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(260, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 25);
            this.label8.TabIndex = 42;
            this.label8.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Nhiệt độ\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Độ ẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "Cổng COM\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Baudrate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Trạng thái:";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.Menu;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(67, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(258, 118);
            this.label11.TabIndex = 5;
            this.label11.Text = "TRƯỜNG ĐẠI HỌC BÁCH KHOA HÀ NỘI";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(2, 860);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nguyễn Thành Đô - 20161016";
            // 
            // lbViewTime
            // 
            this.lbViewTime.BackColor = System.Drawing.SystemColors.GrayText;
            this.lbViewTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbViewTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViewTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbViewTime.Location = new System.Drawing.Point(3, 907);
            this.lbViewTime.Name = "lbViewTime";
            this.lbViewTime.Size = new System.Drawing.Size(319, 27);
            this.lbViewTime.TabIndex = 58;
            this.lbViewTime.Text = "ViewTime";
            this.lbViewTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbViewTime);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 937);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.tải_xuống2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // graphDoAm
            // 
            this.graphDoAm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphDoAm.AutoScroll = true;
            this.graphDoAm.Location = new System.Drawing.Point(333, 462);
            this.graphDoAm.Margin = new System.Windows.Forms.Padding(5);
            this.graphDoAm.Name = "graphDoAm";
            this.graphDoAm.ScrollGrace = 0D;
            this.graphDoAm.ScrollMaxX = 0D;
            this.graphDoAm.ScrollMaxY = 0D;
            this.graphDoAm.ScrollMaxY2 = 0D;
            this.graphDoAm.ScrollMinX = 0D;
            this.graphDoAm.ScrollMinY = 0D;
            this.graphDoAm.ScrollMinY2 = 0D;
            this.graphDoAm.Size = new System.Drawing.Size(900, 460);
            this.graphDoAm.TabIndex = 5;
            // 
            // graphNhietDo
            // 
            this.graphNhietDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphNhietDo.AutoScroll = true;
            this.graphNhietDo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.graphNhietDo.Location = new System.Drawing.Point(333, 0);
            this.graphNhietDo.Margin = new System.Windows.Forms.Padding(5);
            this.graphNhietDo.Name = "graphNhietDo";
            this.graphNhietDo.ScrollGrace = 0D;
            this.graphNhietDo.ScrollMaxX = 0D;
            this.graphNhietDo.ScrollMaxY = 0D;
            this.graphNhietDo.ScrollMaxY2 = 0D;
            this.graphNhietDo.ScrollMinX = 0D;
            this.graphNhietDo.ScrollMinY = 0D;
            this.graphNhietDo.ScrollMinY2 = 0D;
            this.graphNhietDo.Size = new System.Drawing.Size(900, 460);
            this.graphNhietDo.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoThuTu,
            this.NhietDo,
            this.DoAm});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(1240, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(392, 937);
            this.dataGridView1.TabIndex = 59;
            // 
            // SoThuTu
            // 
            this.SoThuTu.HeaderText = "STT";
            this.SoThuTu.Name = "SoThuTu";
            this.SoThuTu.ReadOnly = true;
            this.SoThuTu.Width = 50;
            // 
            // NhietDo
            // 
            this.NhietDo.HeaderText = "Nhiệt Độ";
            this.NhietDo.Name = "NhietDo";
            this.NhietDo.ReadOnly = true;
            // 
            // DoAm
            // 
            this.DoAm.HeaderText = "Độ Ẩm";
            this.DoAm.Name = "DoAm";
            this.DoAm.ReadOnly = true;
            // 
            // Giaodien
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1632, 937);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.graphDoAm);
            this.Controls.Add(this.graphNhietDo);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Giaodien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Giao diện thu thập dữ liệu từ cảm biến DHT11";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Giaodien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnViewDoAm;
        private System.Windows.Forms.Button btnViewNhietDo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.ComboBox cbCongCom;
        private System.Windows.Forms.Button btnNgatKetNoi;
        private System.Windows.Forms.Button BtnKetNoi;
        private System.Windows.Forms.TextBox txbDoAm;
        private System.Windows.Forms.TextBox txbNhietDo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbViewTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private ZedGraph.ZedGraphControl graphDoAm;
        private ZedGraph.ZedGraphControl graphNhietDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoThuTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhietDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoAm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

