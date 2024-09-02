using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CheatChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Cursor = Cursors.WaitCursor;
            string DiscordID = discordinput.Text;
            string EndPoint = "https://inf.sh/amongus/cheaters.json";
            string json = "";
            Alts.Visible = false;
            invalidid.Visible = false;
            if (System.IO.File.Exists("CheaterList.json") && System.IO.File.GetLastWriteTime("CheaterList.json") >= DateTime.Now.AddMinutes(-240)) // use old file
            {
                json = System.IO.File.ReadAllText("CheaterList.json");
            }
            else // Make and use new file.
            {
                WebResponse Response = WebRequest.Create(EndPoint).GetResponse();
                json = new StreamReader(Response.GetResponseStream()).ReadToEnd();
                System.IO.File.WriteAllText("CheaterList.json", json);
            }
            JArray Cheaters = JArray.Parse(json);
            foreach (var Cheater in Cheaters)
            {
                if ((string)Cheater["discord_id"] == DiscordID) // Compares DiscordID to Discord ID's via inf.sh/amongus/cheaters.json
                { // Sets information to the cheaters
                    cheatername.Text = (string)Cheater["discord_tag"];
                    cheatername.Visible = true;
                    Alts.Text = (string)Cheater["alt_of"];
                    if (Alts.Text != "")
                    {
                        Alts.Visible = true;
                        Alts.Text = "Is an alt account";
                    }
                    cheateravatar.Load((string)Cheater["avatar_url"]);
                    cheateravatar.Visible = true;
                    cheatsused.Text = "Cheats Used: " + (string)Cheater["cheats_used"];
                    cheatsused.Visible = true;
                    cheaterdate.Text = "Last Cheated: " + (string)Cheater["last_cheated"];
                    cheaterdate.Visible = true;
                    notcheater.Visible = false;
                    invalidid.Visible = false;
                    discordinput.ResetText();
                    break;
                }
                else if (DiscordID.Length < 16) // Invalid ID
                {
                    invalidid.Visible = true;
                    cheateravatar.Image = cheateravatar.ErrorImage;
                    discordinput.ResetText();
                    cheatername.Visible = false;
                    Alts.Visible = false;
                    cheatsused.Visible = false;
                    cheaterdate.Visible = false;
                    notcheater.Visible = false;
                }
                else if ((string)Cheater["discord_id"] != DiscordID) // No cheater found.
                {
                    cheatername.Visible = false;
                    cheateravatar.Visible = true;
                    cheateravatar.Image = cheateravatar.InitialImage;
                    cheatsused.Visible = false;
                    cheaterdate.Visible = false;
                    notcheater.Visible = true;
                    discordinput.ResetText();
                }
            }
            panel1.Cursor = Cursors.Default;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void notcheater_Click(object sender, EventArgs e)
        {

        }

        private void cheateravatar_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
