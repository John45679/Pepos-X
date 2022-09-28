using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;
namespace Repos_X
{
    public partial class ScriptHub : Form
    {
        ExploitAPI module = new ExploitAPI();
        public ScriptHub()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            WebClient wb = new WebClient();
            string Script = wb.DownloadString("loadstring(game:HttpGet(\"https://pastebin.com/raw/TFyX1vtB\",true))()\r\n");
            module.SendLuaScript(Script);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            WebClient wb = new WebClient();
            string Script = wb.DownloadString("loadstring(game:HttpGet(('https://raw.githubusercontent.com/Cesare0328/my-scripts/main/arsenal%20updated%20invis.lua'),true))()");
            module.SendLuaScript(Script);
        }
    }
}
