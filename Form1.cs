using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using SPLib;
using DevExpress.DirectX.Common.DirectWrite;
using System.IO.Ports;

namespace WinSPort
{
    public partial class FrmMain : UIForm
    {
        private SeriePortHelper SeriesPortObj;
        private List<byte> buffer = new List<byte>(4096);
        private byte[] ReceiveBytes = new byte[7];  //这里定义协议规定的数据长度
        public FrmMain()
        {
            InitializeComponent();
            SeriesPortObj = new SeriePortHelper();
            //串口参数初始化
            cbBaudRate.SelectedIndex = 1;
            cbBaudRate1.SelectedIndex = 1;
            cbCheckBit1.SelectedIndex = 0;
            cbCheckBite.SelectedIndex = 0;
            cbSetSerPort.Items.Clear();
            cbSetSerPort.Items.AddRange(SeriesPortObj.PortsNames);
            SeriesPortObj.SerialPortObject.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SerialPort_DataReceived);
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try {
                ReceiveData(SeriesPortObj.ReceiveData());

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void ReceiveData(byte[] byteData) {

            if (byteData == null) return;
            string str = SeriesPortObj.AlgorithmHelperObject.BytesTo16(byteData, Enum16Hex.None);
            this.Invoke((Action)async delegate {
                await Task.Delay(1);
                string s = str.Substring(6, 4);
                string sWD = string.Format("{0:0.0}",Convert.ToInt32(s,16)/10);//把字节数据转换成16进制字符串
                string s1 = str.Substring(10,4);
                string sSD =string.Format("{0:0.0}",Convert.ToInt32(s1,16)/10);//GetDataStr(s1);
                tbWD.Text = sWD;
                tbSD.Text = sSD;
              
                this.lbDebug.ListBox.Items.Add(str);
                this.lbDebug.ListBox.SelectedIndex = this.lbDebug.ListBox.Items.Count-1;
            });
            
        }
        private string GetDataStr(string sData) {
            double n = GetData(sData[0].ToString()) * 16 * 16 * 16 + GetData(sData[1].ToString()) * 16 * 16
                + GetData(sData[2].ToString()) * 16 + GetData(sData[3].ToString());
            n = n / 10;
            return string.Format("{0:0.0}",n);
        }
      
        private int GetData(string sValue) {
            int num = 0;
            switch (sValue) {
                case "F":
                    num = 15; break;
                case "E":
                    num=14; break;
                case "D":
                    num = 13;break;
                case "C":
                    num = 12;break;
                case "B":
                    num = 11;break;
                case "A":
                    num = 10;break;
                default:
                    num = Convert.ToInt32(sValue);
                    break;

            }
            return num;

        }

        private void SendData(string data) {
            try {
                SeriesPortObj.SendData(data, SeriePortHelper.SendFormat.Hex);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void uiPanel2_Click(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cbSetSerPort.Text.Trim() == "") {
                MessageBox.Show("请选择串口!");
                cbSetSerPort.Focus();
                return;
            }
            if (cbBaudRate.Text.Trim() == "") {
                MessageBox.Show("请选择波特率!");
                cbBaudRate.Focus();
                return;
            }
            if (cbCheckBite.Text.Trim() == "") {
                MessageBox.Show("请选择校验位!");
                cbCheckBite.Focus();
                return;
            }
            SeriesPortObj.SerialPortObject.PortName = cbSetSerPort.Text;
            SeriesPortObj.SerialPortObject.BaudRate = Int32.Parse(cbBaudRate.Text);
            switch (cbCheckBite.Text) { 
              case "NONE":
                SeriesPortObj.SerialPortObject.Parity = System.IO.Ports.Parity.None;
                    break;
                case "ODD":
                    SeriesPortObj.SerialPortObject.Parity = System.IO.Ports.Parity.Odd;
                    break;
                case "EVEN":
                    SeriesPortObj.SerialPortObject.Parity = System.IO.Ports.Parity.Even;
                    break;
            }
            try {
                bool b= SeriesPortObj.OpenSerialPort(cbSetSerPort.Text,1);
                if (b)
                {
                    statusStrip1.Items[1].Text = $"{cbSetSerPort.Text} 打开";
                    btnDisconnect.Enabled = true;
                    btnConnect.Enabled = false;
                    cbSetSerPort.ReadOnly = true;
                    cbBaudRate.ReadOnly = true;
                    cbCheckBite.ReadOnly = true;
                }
                
            }
            catch (Exception ex) {
                UIMessageDialog.ShowErrorDialog(UISelectForm.ActiveForm, ex.Message);
            }

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            SeriesPortObj.SerialPortObject.Close();
            cbSetSerPort.ReadOnly = false;
            cbBaudRate.ReadOnly = false;
            cbCheckBite.ReadOnly = false;
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            statusStrip1.Items[1].Text = "关闭";
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            SendData("01 03 00 00 00 02 C4 0B");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbDebug.Items.Clear();
        }

        private void btnRead1_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(tbHex.Text);
            int d=SeriesPortObj.AlgorithmHelperObject.CalculateCRC16(bytes);
            lbDebug.Items.Add(d.ToString("X"));
            byte[] bs= CRC16Standard.getCRCBytes(bytes);
            string str=SeriesPortObj.AlgorithmHelperObject.BytesTo16(bs,Enum16Hex.Blank);
            lbDebug.Items.Add(str);


        }

        private void chkAutoCapture_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoCapture.Checked)
            {
                timer1.Enabled = true;
            }
            else
            { 
               timer1.Enabled=false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendData("01 03 00 00 00 02 C4 0B");
        }
    }
}
