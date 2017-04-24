using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Net;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Web;
using System.Runtime.InteropServices;
using System.Drawing;
using OneSet.EffectsWindow;

namespace mDictWFM
{
    public partial class Form1 : MaterialForm
    {
        ToolTip toolTipMn1 = new ToolTip()
            , toolTipMn2 = new ToolTip()
            , toolTipMn3 = new ToolTip()
            , toolTipMn4 = new ToolTip();
        Icon ico = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        bool epType = false;
        bool bingEpType = false;

        dictDataBing deserBingDict;
        dictDataYoodao deserYoodaoDict;
        dictDataYoodaoPho deserYoodaoDictPho;
        string voicePath;
        string bingDictPath = "http://xtk.azurewebsites.net/BingService.aspx";
        string yoodaoDictPath = "http://fanyi.youdao.com/openapi.do?keyfrom=mdict-milione&key=900659837&type=data&doctype=json&version=1.1";

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, KeyModifiers fsModifiers, Keys vk);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [Flags()]
        public enum KeyModifiers
        {
            None = 0,
            CtrlAlt = 3,
            Alt = 1,
            Control = 2,
            Shift = 4,
            Windows = 8
        }

        public Form1()
        {
            InitializeComponent();

            MaximizeBox = false;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan500, Primary.Cyan600, Primary.Cyan600, Accent.Cyan400, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            RegisterHotKey(Handle, 233, KeyModifiers.CtrlAlt, Keys.M);
            RegisterHotKey(Handle, 234, KeyModifiers.CtrlAlt, Keys.N);
            btnSpeech.Hide();
            btnCopy.Hide();
            Divider2.Hide();
            Fx.EffectsWindow(Handle, 100, Fx.AW_BLEND);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (isChinese(wordText.Text))
            {
                backgroundWorkerYoodaoDict.RunWorkerAsync();
            }
            else
            {
                backgroundWorkerBingDict.RunWorkerAsync();
            }

            labelWord.Text = "请稍等…";
            labelEp.Text = "";
            labelPos1.Text = "";
            labelMn1.Text = "";
            labelPos2.Text = "";
            labelMn2.Text = "";
            labelPos3.Text = "";
            labelMn3.Text = "";
            labelPos4.Text = "";
            labelMn4.Text = "";

            btnSearch.Enabled = false;
            Divider2.Hide();
            btnSpeech.Hide();
            btnCopy.Hide();
        }

        public static string postWeb(string url, string postDataStr)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = postDataStr.Length;
            StreamWriter writer = new StreamWriter(request.GetRequestStream(), Encoding.ASCII);
            writer.Write(postDataStr);
            writer.Flush();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string encoding = response.ContentEncoding;
            if (encoding == null || encoding.Length < 1)
            {
                encoding = "UTF-8";
            }
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
            string retString = reader.ReadToEnd();
            return retString;
        }

        public static bool isChinese(string str)
        {
            bool boolVal = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (Convert.ToInt32(Convert.ToChar(str.Substring(i, 1))) < Convert.ToInt32(Convert.ToChar(128)))
                {
                    boolVal = false;
                }
                else
                {
                    boolVal = true;
                }
            }
            return boolVal;
        }

        class dictDataBing
        {
            public String word { get; set; }
            public String amep { get; set; }
            public String ames { get; set; }
            public String mn1 { get; set; }
            public String mn2 { get; set; }
            public String pos1 { get; set; }
            public String pos2 { get; set; }
            public String mn3 { get; set; }
            public String pos3 { get; set; }
            public String mn4 { get; set; }
            public String pos4 { get; set; }
        }

        class dictDataYoodao
        {
            public Object basic { get; set; }
            public Object query { get; set; }
            public JArray translation { get; set; }
        }

        class dictDataYoodaoPho
        {
            public Object phonetic { get; set; }
            public JArray explains { get; set; }
        }

        private void backgroundWorkerBingDict_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                string wordVal = "Action=search&Format=jsonwv&Word=" + wordText.Text;
                string wordExplain = postWeb(bingDictPath, wordVal);
                if (wordExplain != null || wordExplain != "" || wordExplain != " ")
                {
                    deserBingDict = JsonConvert.DeserializeObject<dictDataBing>(wordExplain);
                }
                else
                {
                    MessageBox.Show("很抱歉\n\r查询失败，请重试。");
                }
            }
            catch (Exception errorMsg)
            {
                if (errorMsg.Message == "Error reading JObject from JsonReader. Path '', line 0, position 0.")
                {
                    MessageBox.Show("很抱歉\n\r" + "似乎发生了一些事情？\n\r未查询到任何内容。");
                }
                else if (errorMsg.Message == "发生一个或多个错误。")
                {
                    MessageBox.Show("很抱歉\n\r" + "似乎发生了一些事情？\n\r请重试。");
                }
                else
                {
                    MessageBox.Show("很抱歉\n\r" + errorMsg.Message);
                }
            }
        }

        private void backgroundWorkerBingDict_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            labelWord.Text = " ";
            if (deserBingDict != null)
            {
                Divider2.Show();
                labelWord.Text = deserBingDict.word;
                if (deserBingDict.ames != null || deserBingDict.ames != "" || deserBingDict.ames != " ")
                {
                    voicePath = deserBingDict.ames;
                    bingEpType = true;
                }
                else
                {
                    bingEpType = false;
                }
                if (deserBingDict.amep == "" || deserBingDict.amep == null)
                {
                    labelEp.Text = "| ω・´) ";
                    bingEpType = false;
                }
                else
                {
                    labelEp.Text = deserBingDict.amep;
                }
                labelPos1.Text = deserBingDict.pos1;
                labelMn1.Text = deserBingDict.mn1;
                if (deserBingDict.mn2 != null || deserBingDict.mn2 != "")
                {
                    labelPos2.Text = deserBingDict.pos2;
                    labelMn2.Text = deserBingDict.mn2;
                }
                if (deserBingDict.mn3 != null || deserBingDict.mn3 != "")
                {
                    labelPos3.Text = deserBingDict.pos3;
                    labelMn3.Text = deserBingDict.mn3;
                }
                if (deserBingDict.mn4 != null || deserBingDict.mn4 != "")
                {
                    labelPos4.Text = deserBingDict.pos4;
                    labelMn4.Text = deserBingDict.mn4;
                }
                btnCopy.Show();
                epType = true;
                btnSpeech.Show();
            }

            btnSearch.Enabled = true;
        }

        private void wordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && wordText.Text != "")
            {
                if (btnSearch.Enabled != false)
                {
                    btnSearch_Click(sender, e);
                }
            }
            else if (e.KeyCode == Keys.Delete)
            {
                wordText.Clear();
            }
            else if (e.KeyData == (Keys.Control | Keys.M) && wordText.Text != "")
            {
                Clipboard.SetDataObject(labelWord.Text + "：" + labelMn1.Text + "；" + labelMn2.Text);
            }
        }

        private void backgroundWorkerYoodaoDict_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                string postData = string.Format("q={0}", HttpUtility.UrlEncode(wordText.Text, Encoding.UTF8));
                string wordExplain = postWeb(yoodaoDictPath, postData);
                if (wordExplain != null || wordExplain != "" || wordExplain != " ")
                {
                    deserYoodaoDict = JsonConvert.DeserializeObject<dictDataYoodao>(wordExplain);
                    deserYoodaoDictPho = JsonConvert.DeserializeObject<dictDataYoodaoPho>(deserYoodaoDict.basic.ToString());
                }
                else
                {
                    MessageBox.Show("很抱歉\n\r查询失败，请重试。");
                }
            }
            catch (Exception errorMsg)
            {
                if (errorMsg.Message == "Error reading JObject from JsonReader. Path '', line 0, position 0.")
                {
                    MessageBox.Show("很抱歉\n\r" + "似乎发生了一些事情？\n\r未查询到任何内容。");
                }
                else if (errorMsg.Message == "发生一个或多个错误。")
                {
                    MessageBox.Show("很抱歉\n\r" + "似乎发生了一些事情？\n\r请重试。");
                }
                else
                {

                }
            }
        }

        public static String replaceJson(String replaceStr)
        {
            string Str =  replaceStr.Replace("[", "").Replace("]", "").Replace("\"", "").Replace(",", " ; ");
            return Str;
        }

        private void backgroundWorkerYoodaoDict_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            labelWord.Text = " ";
            if (deserYoodaoDict != null)
            {
                Divider2.Show();
                if (deserYoodaoDict.query != null)
                {
                    labelWord.Text = (string)deserYoodaoDict.query;
                    btnCopy.Show();
                }

                try
                {
                    if (deserYoodaoDictPho.phonetic == null)
                    {
                        labelEp.Text = "| ω・´) ";
                    }
                    else
                    {
                        labelEp.Text = replaceJson(deserYoodaoDictPho.phonetic.ToString());
                    }
                }
                catch (Exception)
                {
                    labelEp.Text = "| ω・´) ";
                }

                if (deserYoodaoDict.translation != null)
                {
                    labelPos1.Text = "基本";
                    labelMn1.Text = replaceJson(deserYoodaoDict.translation[0].ToString());
                    epType = false;
                    btnSpeech.Show();
                }

                if (deserYoodaoDictPho != null)
                {
                    labelPos2.Text = "其他";
                    string ExpStr = "";
                    for (int i = 0; i < deserYoodaoDictPho.explains.Count; i++)
                    {
                        if (i == deserYoodaoDictPho.explains.Count - 1)
                        {
                            ExpStr = ExpStr + deserYoodaoDictPho.explains[i].ToString();
                        }
                        else
                        {
                            ExpStr = ExpStr + deserYoodaoDictPho.explains[i].ToString() + " ; ";
                        }
                    }
                    labelMn2.Text = ExpStr;
                }

                labelPos3.Text = "";
                labelMn3.Text = "";
                labelPos4.Text = "";
                labelMn4.Text = "";
            }

            btnSearch.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Fx.EffectsWindow(Handle, 100, Fx.AW_HIDE + Fx.AW_BLEND);
            UnregisterHotKey(Handle, 233);
            UnregisterHotKey(Handle, 234);
            Application.Exit();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(labelWord.Text + "：" + labelMn1.Text + "；" + labelMn2.Text);
        }

        private void backgroundWorkerSpeech_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                Type spType = Type.GetTypeFromProgID("SAPI.SpVoice");
                dynamic spVoice = Activator.CreateInstance(spType);
                if (epType)
                {
                    spVoice.Speak(labelWord.Text);
                }
                else
                {
                    spVoice.Speak(labelMn1.Text);
                }
            }
            catch
            {
                MessageBox.Show("很抱歉\n\r" + "似乎发生了一些事情？\n\r请检查系统音频设备或TTS软件是否正常。");
            }
        }

        private void backgroundWorkerSpeech_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            btnSpeech.Enabled = true;
        }

        private void btnSpeech_Click(object sender, EventArgs e)
        {
            btnSpeech.Enabled = false;
            if (epType)
            {
                if (bingEpType)
                {
                    windowsMediaPlayer.URL = voicePath;
                    windowsMediaPlayer.Ctlcontrols.play();
                    btnSpeech.Enabled = true;
                }
                else
                {
                    backgroundWorkerSpeech.RunWorkerAsync();
                }
            }
            else
            {
                backgroundWorkerSpeech.RunWorkerAsync();
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0312: 
                    if (m.WParam.ToString() == "233")
                    {
                        IDataObject dataClip = Clipboard.GetDataObject();
                        if (dataClip.GetDataPresent(DataFormats.Text))
                        {

                            wordText.Text = dataClip.GetData(DataFormats.Text).ToString();
                            btnSearch_Click(0, null);
                            Activate();
                            WindowState = FormWindowState.Normal;
                            wordText.Focus();
                        }
                    }
                    if (m.WParam.ToString() == "234")
                    {
                        WindowState = FormWindowState.Minimized;
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        private void timerTip_Tick(object sender, EventArgs e)
        {
            toolTipMn1.SetToolTip(labelMn1, labelMn1.Text);
            toolTipMn2.SetToolTip(labelMn2, labelMn2.Text);
            toolTipMn3.SetToolTip(labelMn3, labelMn3.Text);
            toolTipMn4.SetToolTip(labelMn4, labelMn4.Text);
        }
    }
}
