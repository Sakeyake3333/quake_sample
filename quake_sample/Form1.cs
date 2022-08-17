using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quake_sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public readonly HttpClient client = new HttpClient();
        string last_eventid_ = "0";
        string lase_datetime_ = "0";
        string p2p_ = "https://api.p2pquake.net/v2/history?codes=551&limit=1&offset=0";
        private void Form1_Load(object sender, EventArgs e) => timer1_Tick(sender, e);
        private async void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                var json = await client.GetStringAsync(p2p_);
                var root = JsonConvert.DeserializeObject<quake.Root>(json.Trim('[', ']'));

                //随時地震情報
                var title = root.issue.type;
                var titles = root.issue.correct;
                var title_list = new Dictionary<string, string>()
                {
                    {"ScalePrompt","震度速報" },
                    {"Destination","震源に関する情報" },
                    {"ScaleAndDestination","震度・震源に関する情報" },
                    {"DetailScale","各地の震度に関する情報" },
                    {"Foreign","遠地地震に関する情報" },
                    {"Other","その他の情報" },
                };
                var titles_list = new Dictionary<string, string>()
                {
                    {"None","情報無" },
                    {"Unknown","不明" },
                    {"ScaleOnly","震度速報" },
                    {"DestinationOnly","震源に関する情報" },
                    {"ScaleAndDestination","震源・震度に関する情報" },
                };
                var maxint_list = new Dictionary<int, string>()
                {
                    {-1,"不明" },
                    {10,"1" },
                    {20,"2" },
                    {30,"3" },
                    {40,"4" },
                    {45,"5弱" },
                    {50,"5強" },
                    {55,"6弱" },
                    {60,"6強" },
                    {70,"7" },
                };

                var time = root.time;

                var id = root.id;
                if (time == lase_datetime_) return;

                var epicenter = root.earthquake.hypocenter.name;
                var depth = root.earthquake.hypocenter.depth;
                var magunitude = root.earthquake.hypocenter.magnitude;

                string int1 = "", int2 = "", int3 = "", int4 = "", int5m = "", int5p = "", int6m = "", int6p = "", int7 = "", intnull = "";
                //随時地震情報
                int_box.Text = "";

                title_lbl.Text = title_list[title];

                if (titles_list[titles] != "震源に関する情報")
                {
                    var maxintensity = root.earthquake.maxScale;
                    maxintensity_lbl.Text = "最大震度" + maxint_list[maxintensity];

                    if (title_list[title] == "震度速報")
                    {
                        epicenter_lbl.Text = "震源地名　調査中";
                        depth_lbl.Text = "深さ　調査中";
                        magunitude_lbl.Text = "規模　調査中";
                    }
                    else
                    {
                        epicenter_lbl.Text = "震源地名　" + epicenter;
                        depth_lbl.Text = "深さ　" + depth + "km";
                        magunitude_lbl.Text = "規模　M" + magunitude;
                    }

                    var pref = root.points;

                    foreach (var area in pref)
                    {
                        switch (maxint_list[area.scale])
                        {
                            case "1":
                                int1 += area.addr + "　";
                                break;
                            case "2":
                                int2 += area.addr + "　";
                                break;
                            case "3":
                                int3 += area.addr + "　";
                                break;
                            case "4":
                                int4 += area.addr + "　";
                                break;
                            case "5-":
                                int5m += area.addr + "　";
                                break;
                            case "5+":
                                int5p += area.addr + "　";
                                break;
                            case "6-":
                                int6m += area.addr + "　";
                                break;
                            case "6+":
                                int6p += area.addr + "　";
                                break;
                            case "7":
                                int7 += area.addr + "　";
                                break;
                            case "震度５弱以上未入電":
                                intnull += area.addr + "　";
                                break;
                        }
                    }
                    if (int7 != "") { int_box.Text += "【震度７】" + int7; }
                    if (int6p != "") { int_box.Text += "【震度６強】" + int6p; }
                    if (int6m != "") { int_box.Text += "【震度６弱】" + int6m; }
                    if (int5p != "") { int_box.Text += "【震度５強】" + int5p; }
                    if (int5m != "") { int_box.Text += "【震度５弱】" + int5m; }
                    if (int4 != "") { int_box.Text += "【震度４】" + int4; }
                    if (int3 != "") { int_box.Text += "【震度３】" + int3; }
                    if (int2 != "") { int_box.Text += "【震度２】" + int2; }
                    if (int1 != "") { int_box.Text += "【震度１】" + int1; }
                    if (intnull != "") { int_box.Text += "【震度５弱以上（推定）】 " + intnull; }
                }
                else if (titles_list[titles] == "震源に関する情報")
                {
                    epicenter_lbl.Text = "震源地名　" + epicenter;
                    depth_lbl.Text = "深さ　" + depth + "km";
                    magunitude_lbl.Text = "規模　M" + magunitude;

                    int_box.Text = "";
                }


                lase_datetime_ = time;
                last_eventid_ = id;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
