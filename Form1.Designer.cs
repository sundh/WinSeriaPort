namespace WinSPort
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.tbHex = new Sunny.UI.UITextBox();
            this.btnDisconnect = new Sunny.UI.UIButton();
            this.btnConnect = new Sunny.UI.UIButton();
            this.cbCheckBite = new Sunny.UI.UIComboBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.cbBaudRate = new Sunny.UI.UIComboBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.cbSetSerPort = new Sunny.UI.UIComboBox();
            this.btnAutoSetAddress = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.btnBrocastAddress = new Sunny.UI.UIButton();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.btnSearchAddress = new Sunny.UI.UIButton();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiGroupBox4 = new Sunny.UI.UIGroupBox();
            this.btnClear = new Sunny.UI.UIButton();
            this.btnCopy = new Sunny.UI.UIButton();
            this.lbDebug = new Sunny.UI.UIListBox();
            this.uiGroupBox3 = new Sunny.UI.UIGroupBox();
            this.btnSet = new Sunny.UI.UIButton();
            this.btnRead1 = new Sunny.UI.UIButton();
            this.cbCheckBit1 = new Sunny.UI.UIComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbBaudRate1 = new Sunny.UI.UIComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.spAddress = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.chkAutoCapture = new Sunny.UI.UICheckBox();
            this.btnRead = new Sunny.UI.UIButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSD = new Sunny.UI.UITextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWD = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericChartRangeControlClient1 = new DevExpress.XtraEditors.NumericChartRangeControlClient();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.uiGroupBox4.SuspendLayout();
            this.uiGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spAddress)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericChartRangeControlClient1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel8});
            this.statusStrip1.Location = new System.Drawing.Point(0, 579);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(756, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "端口状态：";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel2.Text = "关闭";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusLabel3.Text = "模式:";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel5.Text = "通讯状态：";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel6.Text = "正常";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel7.Text = "统计";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(0, 17);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiGroupBox1);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 35);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(270, 544);
            this.uiPanel1.TabIndex = 1;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.tbHex);
            this.uiGroupBox1.Controls.Add(this.btnDisconnect);
            this.uiGroupBox1.Controls.Add(this.btnConnect);
            this.uiGroupBox1.Controls.Add(this.cbCheckBite);
            this.uiGroupBox1.Controls.Add(this.uiLabel3);
            this.uiGroupBox1.Controls.Add(this.cbBaudRate);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Controls.Add(this.cbSetSerPort);
            this.uiGroupBox1.Controls.Add(this.btnAutoSetAddress);
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Controls.Add(this.btnBrocastAddress);
            this.uiGroupBox1.Controls.Add(this.uiTextBox1);
            this.uiGroupBox1.Controls.Add(this.btnSearchAddress);
            this.uiGroupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(13, 5);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(243, 524);
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.Text = "通讯设置";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbHex
            // 
            this.tbHex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbHex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbHex.Location = new System.Drawing.Point(15, 450);
            this.tbHex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbHex.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbHex.Name = "tbHex";
            this.tbHex.Padding = new System.Windows.Forms.Padding(5);
            this.tbHex.ShowText = false;
            this.tbHex.Size = new System.Drawing.Size(224, 29);
            this.tbHex.TabIndex = 12;
            this.tbHex.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbHex.Watermark = "";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDisconnect.Location = new System.Drawing.Point(51, 398);
            this.btnDisconnect.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Radius = 15;
            this.btnDisconnect.Size = new System.Drawing.Size(106, 31);
            this.btnDisconnect.TabIndex = 11;
            this.btnDisconnect.Text = "断开";
            this.btnDisconnect.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConnect.Location = new System.Drawing.Point(51, 348);
            this.btnConnect.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Radius = 15;
            this.btnConnect.Size = new System.Drawing.Size(106, 31);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "连接";
            this.btnConnect.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbCheckBite
            // 
            this.cbCheckBite.DataSource = null;
            this.cbCheckBite.FillColor = System.Drawing.Color.White;
            this.cbCheckBite.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbCheckBite.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbCheckBite.Items.AddRange(new object[] {
            "NONE",
            "ODD",
            "EVEN"});
            this.cbCheckBite.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbCheckBite.Location = new System.Drawing.Point(78, 286);
            this.cbCheckBite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCheckBite.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbCheckBite.Name = "cbCheckBite";
            this.cbCheckBite.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbCheckBite.Size = new System.Drawing.Size(139, 29);
            this.cbCheckBite.TabIndex = 9;
            this.cbCheckBite.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbCheckBite.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(12, 288);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(59, 23);
            this.uiLabel3.TabIndex = 8;
            this.uiLabel3.Text = "校  验";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.DataSource = null;
            this.cbBaudRate.FillColor = System.Drawing.Color.White;
            this.cbBaudRate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBaudRate.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbBaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "115200"});
            this.cbBaudRate.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbBaudRate.Location = new System.Drawing.Point(78, 241);
            this.cbBaudRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBaudRate.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbBaudRate.Size = new System.Drawing.Size(139, 29);
            this.cbBaudRate.TabIndex = 7;
            this.cbBaudRate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbBaudRate.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(12, 243);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(59, 23);
            this.uiLabel2.TabIndex = 6;
            this.uiLabel2.Text = "波特率";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSetSerPort
            // 
            this.cbSetSerPort.DataSource = null;
            this.cbSetSerPort.FillColor = System.Drawing.Color.White;
            this.cbSetSerPort.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSetSerPort.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbSetSerPort.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbSetSerPort.Location = new System.Drawing.Point(78, 200);
            this.cbSetSerPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSetSerPort.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbSetSerPort.Name = "cbSetSerPort";
            this.cbSetSerPort.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbSetSerPort.Size = new System.Drawing.Size(139, 29);
            this.cbSetSerPort.TabIndex = 5;
            this.cbSetSerPort.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbSetSerPort.Watermark = "";
            // 
            // btnAutoSetAddress
            // 
            this.btnAutoSetAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutoSetAddress.Enabled = false;
            this.btnAutoSetAddress.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAutoSetAddress.Location = new System.Drawing.Point(15, 146);
            this.btnAutoSetAddress.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAutoSetAddress.Name = "btnAutoSetAddress";
            this.btnAutoSetAddress.Radius = 15;
            this.btnAutoSetAddress.Size = new System.Drawing.Size(202, 31);
            this.btnAutoSetAddress.TabIndex = 4;
            this.btnAutoSetAddress.Text = "自动设置地址";
            this.btnAutoSetAddress.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(12, 202);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(59, 23);
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "串口号";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBrocastAddress
            // 
            this.btnBrocastAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrocastAddress.Enabled = false;
            this.btnBrocastAddress.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBrocastAddress.Location = new System.Drawing.Point(15, 99);
            this.btnBrocastAddress.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBrocastAddress.Name = "btnBrocastAddress";
            this.btnBrocastAddress.Radius = 15;
            this.btnBrocastAddress.Size = new System.Drawing.Size(202, 31);
            this.btnBrocastAddress.TabIndex = 2;
            this.btnBrocastAddress.Text = "广播设置地址为1";
            this.btnBrocastAddress.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.DoubleValue = 1D;
            this.uiTextBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.IntValue = 1;
            this.uiTextBox1.Location = new System.Drawing.Point(93, 48);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.ReadOnly = true;
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(124, 29);
            this.uiTextBox1.TabIndex = 1;
            this.uiTextBox1.Text = "1";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "";
            // 
            // btnSearchAddress
            // 
            this.btnSearchAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchAddress.Enabled = false;
            this.btnSearchAddress.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearchAddress.Location = new System.Drawing.Point(15, 48);
            this.btnSearchAddress.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearchAddress.Name = "btnSearchAddress";
            this.btnSearchAddress.Radius = 15;
            this.btnSearchAddress.Size = new System.Drawing.Size(71, 31);
            this.btnSearchAddress.TabIndex = 0;
            this.btnSearchAddress.Text = "查地址";
            this.btnSearchAddress.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.uiGroupBox4);
            this.uiPanel2.Controls.Add(this.uiGroupBox3);
            this.uiPanel2.Controls.Add(this.uiGroupBox2);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel2.Location = new System.Drawing.Point(270, 35);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(486, 544);
            this.uiPanel2.TabIndex = 2;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel2.Click += new System.EventHandler(this.uiPanel2_Click);
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.Controls.Add(this.btnClear);
            this.uiGroupBox4.Controls.Add(this.btnCopy);
            this.uiGroupBox4.Controls.Add(this.lbDebug);
            this.uiGroupBox4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox4.Location = new System.Drawing.Point(15, 258);
            this.uiGroupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox4.Size = new System.Drawing.Size(442, 273);
            this.uiGroupBox4.TabIndex = 2;
            this.uiGroupBox4.Text = "调试";
            this.uiGroupBox4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(343, 225);
            this.btnClear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Radius = 15;
            this.btnClear.Size = new System.Drawing.Size(71, 31);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "清除";
            this.btnClear.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCopy.Location = new System.Drawing.Point(243, 225);
            this.btnCopy.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Radius = 15;
            this.btnCopy.Size = new System.Drawing.Size(71, 31);
            this.btnCopy.TabIndex = 9;
            this.btnCopy.Text = "复制";
            this.btnCopy.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // lbDebug
            // 
            this.lbDebug.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDebug.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lbDebug.ItemSelectForeColor = System.Drawing.Color.White;
            this.lbDebug.Location = new System.Drawing.Point(17, 37);
            this.lbDebug.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbDebug.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbDebug.Name = "lbDebug";
            this.lbDebug.Padding = new System.Windows.Forms.Padding(2);
            this.lbDebug.ShowText = false;
            this.lbDebug.Size = new System.Drawing.Size(408, 180);
            this.lbDebug.TabIndex = 0;
            this.lbDebug.Text = "uiListBox1";
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.btnSet);
            this.uiGroupBox3.Controls.Add(this.btnRead1);
            this.uiGroupBox3.Controls.Add(this.cbCheckBit1);
            this.uiGroupBox3.Controls.Add(this.label7);
            this.uiGroupBox3.Controls.Add(this.cbBaudRate1);
            this.uiGroupBox3.Controls.Add(this.label6);
            this.uiGroupBox3.Controls.Add(this.spAddress);
            this.uiGroupBox3.Controls.Add(this.label5);
            this.uiGroupBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox3.Location = new System.Drawing.Point(15, 119);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox3.Size = new System.Drawing.Size(442, 129);
            this.uiGroupBox3.TabIndex = 1;
            this.uiGroupBox3.Text = "设置";
            this.uiGroupBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSet
            // 
            this.btnSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSet.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSet.Location = new System.Drawing.Point(345, 88);
            this.btnSet.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSet.Name = "btnSet";
            this.btnSet.Radius = 15;
            this.btnSet.Size = new System.Drawing.Size(71, 31);
            this.btnSet.TabIndex = 8;
            this.btnSet.Text = "设置";
            this.btnSet.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnRead1
            // 
            this.btnRead1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRead1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRead1.Location = new System.Drawing.Point(245, 88);
            this.btnRead1.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRead1.Name = "btnRead1";
            this.btnRead1.Radius = 15;
            this.btnRead1.Size = new System.Drawing.Size(71, 31);
            this.btnRead1.TabIndex = 7;
            this.btnRead1.Text = "读取";
            this.btnRead1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRead1.Click += new System.EventHandler(this.btnRead1_Click);
            // 
            // cbCheckBit1
            // 
            this.cbCheckBit1.DataSource = null;
            this.cbCheckBit1.FillColor = System.Drawing.Color.White;
            this.cbCheckBit1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbCheckBit1.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbCheckBit1.Items.AddRange(new object[] {
            "NONE",
            "ODD",
            "EVEN"});
            this.cbCheckBit1.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbCheckBit1.Location = new System.Drawing.Point(310, 54);
            this.cbCheckBit1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCheckBit1.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbCheckBit1.Name = "cbCheckBit1";
            this.cbCheckBit1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbCheckBit1.Size = new System.Drawing.Size(104, 26);
            this.cbCheckBit1.TabIndex = 6;
            this.cbCheckBit1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbCheckBit1.Watermark = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "校验";
            // 
            // cbBaudRate1
            // 
            this.cbBaudRate1.DataSource = null;
            this.cbBaudRate1.FillColor = System.Drawing.Color.White;
            this.cbBaudRate1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBaudRate1.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbBaudRate1.Items.AddRange(new object[] {
            "4800",
            "9600",
            "115200"});
            this.cbBaudRate1.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbBaudRate1.Location = new System.Drawing.Point(146, 54);
            this.cbBaudRate1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBaudRate1.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbBaudRate1.Name = "cbBaudRate1";
            this.cbBaudRate1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbBaudRate1.Size = new System.Drawing.Size(104, 26);
            this.cbBaudRate1.TabIndex = 4;
            this.cbBaudRate1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbBaudRate1.Watermark = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "波特率";
            // 
            // spAddress
            // 
            this.spAddress.Location = new System.Drawing.Point(21, 54);
            this.spAddress.Name = "spAddress";
            this.spAddress.Size = new System.Drawing.Size(70, 26);
            this.spAddress.TabIndex = 2;
            this.spAddress.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "地址";
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.chkAutoCapture);
            this.uiGroupBox2.Controls.Add(this.btnRead);
            this.uiGroupBox2.Controls.Add(this.label3);
            this.uiGroupBox2.Controls.Add(this.tbSD);
            this.uiGroupBox2.Controls.Add(this.label4);
            this.uiGroupBox2.Controls.Add(this.label2);
            this.uiGroupBox2.Controls.Add(this.tbWD);
            this.uiGroupBox2.Controls.Add(this.label1);
            this.uiGroupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox2.Location = new System.Drawing.Point(15, 5);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(442, 109);
            this.uiGroupBox2.TabIndex = 0;
            this.uiGroupBox2.Text = "数据";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkAutoCapture
            // 
            this.chkAutoCapture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAutoCapture.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkAutoCapture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.chkAutoCapture.Location = new System.Drawing.Point(345, 70);
            this.chkAutoCapture.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkAutoCapture.Name = "chkAutoCapture";
            this.chkAutoCapture.Size = new System.Drawing.Size(94, 29);
            this.chkAutoCapture.TabIndex = 7;
            this.chkAutoCapture.Text = "连续采集";
            this.chkAutoCapture.CheckedChanged += new System.EventHandler(this.chkAutoCapture_CheckedChanged);
            // 
            // btnRead
            // 
            this.btnRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRead.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRead.Location = new System.Drawing.Point(345, 33);
            this.btnRead.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRead.Name = "btnRead";
            this.btnRead.Radius = 15;
            this.btnRead.Size = new System.Drawing.Size(71, 31);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "读取";
            this.btnRead.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(241, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "rh%";
            // 
            // tbSD
            // 
            this.tbSD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSD.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSD.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbSD.Location = new System.Drawing.Point(167, 57);
            this.tbSD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSD.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbSD.Name = "tbSD";
            this.tbSD.Padding = new System.Windows.Forms.Padding(5);
            this.tbSD.ShowText = false;
            this.tbSD.Size = new System.Drawing.Size(70, 34);
            this.tbSD.TabIndex = 4;
            this.tbSD.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbSD.Watermark = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "湿度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(95, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "℃";
            // 
            // tbWD
            // 
            this.tbWD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbWD.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbWD.ForeColor = System.Drawing.Color.DarkGreen;
            this.tbWD.Location = new System.Drawing.Point(21, 57);
            this.tbWD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbWD.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbWD.Name = "tbWD";
            this.tbWD.Padding = new System.Windows.Forms.Padding(5);
            this.tbWD.ShowText = false;
            this.tbWD.Size = new System.Drawing.Size(70, 34);
            this.tbWD.TabIndex = 1;
            this.tbWD.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbWD.Watermark = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "温度";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(756, 601);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmMain";
            this.Text = "串口通讯";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.uiPanel1.ResumeLayout(false);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.uiGroupBox4.ResumeLayout(false);
            this.uiGroupBox3.ResumeLayout(false);
            this.uiGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spAddress)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericChartRangeControlClient1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIComboBox cbSetSerPort;
        private Sunny.UI.UIButton btnAutoSetAddress;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton btnBrocastAddress;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UIButton btnSearchAddress;
        private Sunny.UI.UIButton btnDisconnect;
        private Sunny.UI.UIButton btnConnect;
        private Sunny.UI.UIComboBox cbCheckBite;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIComboBox cbBaudRate;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UITextBox tbWD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UITextBox tbSD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIGroupBox uiGroupBox3;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UICheckBox chkAutoCapture;
        private Sunny.UI.UIButton btnRead;
        private Sunny.UI.UIGroupBox uiGroupBox4;
        private Sunny.UI.UIListBox lbDebug;
        private Sunny.UI.UIButton btnSet;
        private Sunny.UI.UIButton btnRead1;
        private Sunny.UI.UIComboBox cbCheckBit1;
        private System.Windows.Forms.Label label7;
        private Sunny.UI.UIComboBox cbBaudRate1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown spAddress;
        private DevExpress.XtraEditors.NumericChartRangeControlClient numericChartRangeControlClient1;
        private Sunny.UI.UIButton btnClear;
        private Sunny.UI.UIButton btnCopy;
        private Sunny.UI.UITextBox tbHex;
        private System.Windows.Forms.Timer timer1;
    }
}

