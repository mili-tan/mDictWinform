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
        dictData deserDict;

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
            backgroundWorkerDict.RunWorkerAsync();
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

        class dictData
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

        private void backgroundWorkerDict_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                string wordExplain = bingDictionary(wordText.Text).Result.ToString();
                if (wordExplain != null || wordExplain != "" || wordExplain != " ")
                {
                    JObject bingDictJsonObj = JObject.Parse(wordExplain);
                    deserDict = JsonConvert.DeserializeObject<dictData>(wordExplain);
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

        private void backgroundWorkerDict_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (deserDict != null)
            {
                Divider2.Show();
                labelWord.Text = deserDict.word;
                if (deserDict.amep == "" || deserDict.amep == null)
                {
                    labelEp.Text = "| ω・´) ";
                }
                else
                {
                    labelEp.Text = deserDict.amep;
                }
                labelPos1.Text = deserDict.pos1;
                labelMn1.Text = deserDict.mn1;
                if (deserDict.mn2 != null || deserDict.mn2 != "")
                {
                    labelPos2.Text = deserDict.pos2;
                    labelMn2.Text = deserDict.mn2;
                }
                if (deserDict.mn3 != null || deserDict.mn3 != "")
                {
                    labelPos3.Text = deserDict.pos3;
                    labelMn3.Text = deserDict.mn3;
                }
                if (deserDict.mn4 != null || deserDict.mn4 != "")
                {
                    labelPos4.Text = deserDict.pos4;
                    labelMn4.Text = deserDict.mn4;
                }
            }

            btnSearch.Enabled = true;
        }
    }
}
