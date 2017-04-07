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
            string wordExplain = bingDictionary(wordText.Text).Result.ToString();
            JObject bingDictJsonObj = JObject.Parse(wordExplain);
            deserDict = JsonConvert.DeserializeObject<dictData>(wordExplain);
        }

        private void backgroundWorkerDict_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            labelWord.Text = deserDict.word;
            labelEp.Text = deserDict.amep;

            btnSearch.Enabled = true;
        }
    }
}
