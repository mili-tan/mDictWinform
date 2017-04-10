using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace mDictWFM
{
    public partial class Form1 : MaterialForm
    {
        dictDataBing deserBingDict;

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
            Divider2.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (isChinese(wordText.Text))
            {

            }
            else
            {
                backgroundWorkerBingDict.RunWorkerAsync();
            }
            btnSearch.Enabled = false;
        }

        async public static Task<string> bingDictionary(string Word)
        {
            string Param;
            byte[] Bytes;
            Param = "Action=search&Format=jsonwv&Word=" + WebUtility.UrlEncode(Word);
            Bytes = System.Text.Encoding.ASCII.GetBytes(Param);
            HttpWebRequest HWR;
            HWR = (HttpWebRequest)HttpWebRequest.Create("http://xtk.azurewebsites.net/BingService.aspx");
            HWR.ContinueTimeout = 2000;
            HWR.Method = "POST";
            HWR.ContentType = "application/x-www-form-urlencoded";
            System.IO.Stream HReqs;
            HReqs = await HWR.GetRequestStreamAsync();
            HReqs.Write(Bytes, 0, Bytes.Length);
            HReqs.Dispose();
            WebResponse WRe = await HWR.GetResponseAsync();
            StreamReader SR = new StreamReader(WRe.GetResponseStream());
            string postResult = await SR.ReadToEndAsync();
            SR.Dispose();
            return postResult;
        }

        public static bool isChinese(string str)
        {
            bool BoolVal = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (Convert.ToInt32(Convert.ToChar(str.Substring(i, 1))) < Convert.ToInt32(Convert.ToChar(128)))
                {
                    BoolVal = false;
                }
                else
                {
                    BoolVal = true;
                }
            }
            return BoolVal;
        }

        class dictDataBing
        {
            public String word { get; set; }
            public String amep { get; set; }
            public String mn1 { get; set; }
            public String mn2 { get; set; }
            public String pos1 { get; set; }
            public String pos2 { get; set; }
            public String mn3 { get; set; }
            public String pos3 { get; set; }
            public String mn4 { get; set; }
            public String pos4 { get; set; }
        }

        private void backgroundWorkerBingDict_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                string wordExplain = bingDictionary(wordText.Text).Result.ToString();
                if (wordExplain != null || wordExplain != "" || wordExplain != " ")
                {
                    JObject bingDictJsonObj = JObject.Parse(wordExplain);
                    deserBingDict = JsonConvert.DeserializeObject<dictDataBing>(wordExplain);
                }
                else
                {
                    MessageBox.Show("很抱歉\n\r查询失败，请重试。");
                }
            }
            catch(Exception errorMsg)
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
            if (deserBingDict != null)
            {
                Divider2.Show();
                labelWord.Text = deserBingDict.word;
                if (deserBingDict.amep == "" || deserBingDict.amep == null)
                {
                    labelEp.Text = "| ω・´) ";
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
                Clipboard.SetDataObject(labelWord.Text+"："+labelMn1.Text+"；"+labelMn2.Text);
            }
        }
    }
}
