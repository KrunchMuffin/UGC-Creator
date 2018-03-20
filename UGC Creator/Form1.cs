using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace UGC_Creator
{
    public partial class mainForm : Form
    {

        public mainForm()
        {
            InitializeComponent();
            Height = 260;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (UgcDialog.ShowDialog() == DialogResult.OK)
            {
                ugcLocation.Text = UgcDialog.SelectedPath;
                if (XMLLocation.Text.Length > 0)
                {
                    btnCreate.Enabled = true;
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "MAME XML File|*.xml"
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XMLLocation.Text = openFileDialog1.FileName;
                if (ugcLocation.Text.Length > 0)
                {
                    btnCreate.Enabled = true;
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e) => Application.Exit();

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Height = 539;
            btnCreate.Enabled = false;

            string umText =
             @"# This is an Ultimarc UltraStik Game Configuration file 
UltraStikGameConfigurationFileFormatVersion=1.0

UltraStik1MapFile=%s%
UltraStik2MapFile=%s%
UltraStik3MapFile=%s%
UltraStik4MapFile=%s%
";

            XmlReaderSettings settings = new XmlReaderSettings
            {
                DtdProcessing = DtdProcessing.Parse
            };

            // Create an XML reader for this file.
            using (XmlReader reader = XmlReader.Create(XMLLocation.Text, settings: settings))
            {
                while (reader.Read())
                {
                    // Only detect start elements.
                    if (reader.IsStartElement())
                    {
                        string newways = "";
                        if (reader.Name == "machine")
                        {
                            string isDevice = reader["isdevice"];
                            if(isDevice == "no") { 
                                string rname = reader["name"];
                                reader.ReadToFollowing("control");
                                string jway = reader.GetAttribute("ways");
                                string jtype = reader.GetAttribute("type");
                                //string newways = "";

                                if (jway != null)
                                {
                                    switch (jway)
                                    {
                                        case "4":
                                            newways = "4-way";
                                            break;

                                        case "2":
                                            newways = "2-way-horizontal";
                                            break;

                                        case "vertical2":
                                            newways = "2-way-vertical";
                                            break;

                                        case "8":
                                            newways = "8-way";
                                            break;
                                    }

                                }
                                else if (jtype != null)
                                {
                                    if (jtype == "stick") newways = "analog";
                                }

                                if (newways != "")
                                {
                                    using (StreamWriter outputFile = new StreamWriter(ugcLocation.Text + @"\" + rname + @".ugc"))
                                    {
                                        string stringOut = umText.Replace("%s%", newways);
                                        outputFile.WriteLine(stringOut);
                                    }
                                    infoBox.Items.Add("Found ROM: " + rname + " setting sticks to " + newways);
                                    infoBox.Update();
                                    infoBox.TopIndex = infoBox.Items.Count - 1;
                                }
                            }
                        }
                    }
                }
            }
            txtDone.Visible = true;
            button3.Visible = true;
            btnCreate.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(ugcLocation.Text);
        }
    }
}


