using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GPXLogInterface
{
    public partial class GPXLogInterface : Form
    {
        //This holds everything required to output a complete GPX log in XML format
        GPXLog log;
        GPXLog log_active;

        //these hold the current files being worked with
        string fn = "";
        string fileA = "";
        string fileB = "";
        string currFile = "";

        //holds current index of HotSpot being displayed
        int currIndex = 0;

        //booleans to determine what filters were changed
        bool ssid_filter_changed = false;
        bool security_filter_changed = false;
        bool channel_filter_changed = false;

        public GPXLogInterface()
        {
            InitializeComponent();
        }

        private void GO_Click(object sender, EventArgs e)
        {
            //only executes code if at least one file exists
            if (fileA == "" && fileB == "")
            {
                MessageBox.Show("Must select at least one file.");
            }
            else
            {
                if (fileA == "")
                {
                    List<HotSpot> temp = readFile(fileB, new List<HotSpot>());

                    log = new GPXLog(temp);
                }
                else if (fileB == "")
                {
                    List<HotSpot> temp = readFile(fileA, new List<HotSpot>());

                    log = new GPXLog(temp);
                }
                else
                {
                    List<HotSpot> temp = readFile(fileA, new List<HotSpot>());
                    List<HotSpot> combined = readFile(fileB, temp);

                    log = new GPXLog(combined);
                }

                log.filterData();

                //create new xml file with the filtered data
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Save new XML file as...";
                sfd.Filter = "XML Files (*.XML)|*.xml";
                sfd.RestoreDirectory = true;

                //forces a valid input for the output file name
                while (sfd.ShowDialog() != DialogResult.OK)
                    sfd = new SaveFileDialog();

                currFile = sfd.FileName;
                writeNewXML(currFile);

                MessageBox.Show("DONE!");

                loadFile(currFile);
            }
        }

        //This takes in a new gpx file and creates a new GPXLog object which contains a list of HotSpot objects.
        List<HotSpot> readFile(string fn, List<HotSpot> hs)
        {
            List<HotSpot> data = hs;

            StreamReader sr = null;
            sr = new StreamReader(File.OpenRead(fn));
            string currentLine = sr.ReadLine();

            //look for beginning of xml
            while (!currentLine.Contains("<?xml"))
                currentLine = sr.ReadLine();

            string lat = "", lon = "", ele = "", tim = "", geo = "", nam = "",
                   cmt = "", des = "", fix = "", sat = "", hdo = "", vdo = "",
                   pdo = "", mac = "", ssi = "", rss = "", cha = "", sec = "",
                   sig = "", net = "", rat = "";

            //loop through entire doc pulling out all records into a HotSpot list
            while (currentLine != "</gpx>")
            {

                currentLine = currentLine.Trim();
                if (currentLine.StartsWith("<wpt lat"))
                {
                    int p1 = currentLine.IndexOf("lat") + 5;
                    int p2 = currentLine.IndexOf("\"", p1);
                    lat = currentLine.Substring(p1, p2 - p1);

                    int q1 = currentLine.IndexOf("lon") + 5;
                    int q2 = currentLine.IndexOf("\"", q1);
                    lon = currentLine.Substring(q1, q2 - q1);
                }
                else if (currentLine.StartsWith("<ele>"))
                {
                    int p = currentLine.IndexOf("</ele>");
                    ele = currentLine.Substring(5, p - 5);
                }
                else if (currentLine.StartsWith("<time>"))
                {
                    int p = currentLine.IndexOf("</time>");
                    tim = currentLine.Substring(6, p - 6);
                }
                else if (currentLine.StartsWith("<geoidheight>"))
                {
                    int p = currentLine.IndexOf("</geoidheight>");
                    geo = currentLine.Substring(13, p - 13);
                }
                else if (currentLine.StartsWith("<name>"))
                {
                    int p = currentLine.IndexOf("</name>");
                    nam = currentLine.Substring(6, p - 6);
                }
                else if (currentLine.StartsWith("<cmt>"))
                {
                    int p = currentLine.IndexOf("</cmt>");
                    cmt = currentLine.Substring(5, p - 5);
                }
                else if (currentLine.StartsWith("<desc>"))
                {
                    des = (currentLine.Substring(6) + "\n");
                    while (!currentLine.Contains("</desc>"))
                    {
                        currentLine = sr.ReadLine();
                        des += (currentLine + "\n");
                    }
                    int p = currentLine.IndexOf("</desc>");
                }
                else if (currentLine.StartsWith("<fix>"))
                {
                    int p = currentLine.IndexOf("</fix>");
                    fix = currentLine.Substring(5, p - 5);
                }
                else if (currentLine.StartsWith("<sat>"))
                {
                    int p = currentLine.IndexOf("</sat>");
                    sat = currentLine.Substring(5, p - 5);
                }
                else if (currentLine.StartsWith("<hdop>"))
                {
                    int p = currentLine.IndexOf("</hdop>");
                    hdo = currentLine.Substring(6, p - 6);
                }
                else if (currentLine.StartsWith("<vdop>"))
                {
                    int p = currentLine.IndexOf("</vdop>");
                    vdo = currentLine.Substring(6, p - 6);
                }
                else if (currentLine.StartsWith("<pdop>"))
                {
                    int p = currentLine.IndexOf("</pdop>");
                    pdo = currentLine.Substring(6, p - 6);
                }
                else if (currentLine.StartsWith("<MAC>"))
                {
                    int p = currentLine.IndexOf("</MAC>");
                    mac = currentLine.Substring(5, p - 5);
                }
                else if (currentLine.StartsWith("<SSID>"))
                {
                    int p = currentLine.IndexOf("</SSID>");
                    ssi = currentLine.Substring(6, p - 6);
                }
                else if (currentLine.StartsWith("<RSSI>"))
                {
                    int p = currentLine.IndexOf("</RSSI>");
                    rss = currentLine.Substring(6, p - 6);
                }
                else if (currentLine.StartsWith("<ChannelID>"))
                {
                    int p = currentLine.IndexOf("</ChannelID>");
                    cha = currentLine.Substring(11, p - 11);
                }
                else if (currentLine.StartsWith("<security>"))
                {
                    int p = currentLine.IndexOf("</security>");
                    sec = currentLine.Substring(10, p - 10);
                }
                else if (currentLine.StartsWith("<signalQuality>"))
                {
                    int p = currentLine.IndexOf("</signalQuality>");
                    sig = currentLine.Substring(15, p - 15);
                }
                else if (currentLine.StartsWith("<networkType>"))
                {
                    int p = currentLine.IndexOf("</networkType>");
                    net = currentLine.Substring(13, p - 13);
                }
                else if (currentLine.StartsWith("<rates>"))
                {
                    int p = currentLine.IndexOf("</rates>");
                    rat = currentLine.Substring(7, p - 7);
                }
                else if (currentLine.Equals("</wpt>"))
                {
                    //create hs object and add it to the brainz
                    HotSpot temp = new HotSpot(lat, lon, ele, tim, geo, nam, cmt, des, fix, sat, hdo, vdo, pdo, mac, ssi, rss, cha, sec, sig, net, rat);
                    data.Add(temp);
                    lat = ""; lon = ""; ele = ""; tim = ""; geo = ""; nam = "";
                    cmt = ""; des = ""; fix = ""; sat = ""; hdo = ""; vdo = "";
                    pdo = ""; mac = ""; ssi = ""; rss = ""; cha = ""; sec = "";
                    sig = ""; net = ""; rat = "";
                    //MessageBox.Show(hs.getCompiledHS());
                }
                currentLine = sr.ReadLine();
            }
            sr.Dispose();

            return data;
        }

        void writeNewXML(string fn)
        {
            FileStream stream = new FileStream(currFile, FileMode.Create);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            writer.WriteLine("<gpx>");
            for (int i = 0; i < log.getSize(); i++)
            {
                 string nextOutput = log.getHotSpot(i).getCompiledHS();
                 writer.WriteLine(nextOutput);
            }
            writer.WriteLine("</gpx>");
            writer.Close();
            stream.Close();
        }

        private void setA_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open File A...";
            ofd.Filter = "XML Files (*.XML)|*.xml";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileA = ofd.FileName;
                fileAdisplay.Text = fileA;
            }
        }

        private void setB_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open File B...";
            ofd.Filter = "XML Files (*.XML)|*.xml";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileB = ofd.FileName;
                fileBdisplay.Text = fileB;
            }
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open File for Processing...";
            ofd.Filter = "XML Files (*.XML)|*.xml";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fn = ofd.FileName;
                log = new GPXLog(readFile(fn,new List<HotSpot>()));
                log_active = new GPXLog(readFile(fn, new List<HotSpot>()));
                loadFile(fn);
            }
        }

        private void loadFile(string fn)
        {
            currFile = fn;
            currFileDisplay.Text = currFile;

            //enable navigation buttons now that a log of HotSpots exists
            nextRecord.Enabled = true;
            prevRecord.Enabled = true;
            jumpToRecord.Enabled = true;

            //set securoty statistics
            secTotalNum.Text = (log_active.getSize() + "");
            secWEPNum.Text = (log_active.getWEPNum() + "");
            secWPANum.Text = (log_active.getWPANum() + "");
            secWPA2Num.Text = (log_active.getWPA2Num() + "");
            secOpenNum.Text = (log_active.getOPENNum() + "");
            secOtherNum.Text = (log_active.getOtherSecNum() + "");

            //set security percentages
            double t = Math.Round((log_active.getWEPNum() / log_active.getSize()) * 100);
            secWEPPer.Text = (t + "%");
            t = Math.Round((log_active.getWPANum() / log_active.getSize()) * 100);
            secWPAPer.Text = (t + "%");
            t = Math.Round((log_active.getWPA2Num() / log_active.getSize()) * 100);
            secWPA2Per.Text = (t + "%");
            t = Math.Round((log_active.getOPENNum() / log_active.getSize()) * 100);
            secOpenPer.Text = (t + "%");
            t = Math.Round((log_active.getOtherSecNum() / log_active.getSize()) * 100);
            secOtherPer.Text = (t + "%");

            currIndex = 1;
            displayRecord();
        }

        private void nextRecord_Click(object sender, EventArgs e)
        {
            if (currIndex >= (log_active.getSize()))
            {
                currIndex = 1;
            }
            else
            {
                currIndex++;
            }

            displayRecord();
        }

        private void prevRecord_Click(object sender, EventArgs e)
        {
            if (currIndex <= 1)
            {
                currIndex = (log_active.getSize());
            }
            else
            {
                currIndex--;
            }

            displayRecord();
        }

        private void jumpToRecord_Click(object sender, EventArgs e)
        {
            int nr = (int)jumpToNum.Value;
            if (nr >= 1 && nr <= log_active.getSize())
            {
                currIndex = nr;
            }
            else
            {
                MessageBox.Show("Must enter a valid record number.");
            }

            displayRecord();
        }

        //displays the record of index 'r' on the form
        void displayRecord()
        {
            if (log_active.getSize() == 0)
            {
                ssid_info.Text = "";
                mac_info.Text = "";
                lat_info.Text = "";
                long_info.Text = "";
                security_info.Text = "";
                time_info.Text = "";
                currRecordPosition.Text = "(0 out of 0)";
            }
            else
            {
                currRecordPosition.Text = "(" + (currIndex) + " out of " + log_active.getSize() + ")";

                //This is where we will display the info of the individual record passed in
                ssid_info.Text = "SSID: " + log_active.getHotSpot(currIndex - 1).getSSID();
                mac_info.Text = "MAC: [" + log_active.getHotSpot(currIndex - 1).getMAC() + "]";
                lat_info.Text = "Latitude: " + log_active.getHotSpot(currIndex - 1).getLat();
                long_info.Text = "Longitude: " + log_active.getHotSpot(currIndex - 1).getLon();
                security_info.Text = "Security: " + log_active.getHotSpot(currIndex - 1).getSecurity();
                time_info.Text = "Time: " + log_active.getHotSpot(currIndex - 1).getTime();
            }
        } 

        private void apply_filter_Click(object sender, EventArgs e)
        {
            GPXLog filtered = new GPXLog();

            string ssid = ssid_filter.Text;
            string sec = security_filter.SelectedText;
            string channel = channel_filter.SelectedText;

            if (ssid == "")
            {
                log_active = log;
                currIndex = 1;
                displayRecord();
                return;
            }

            for (int i = 0; i < log_active.getSize(); i++)
            {
                HotSpot hs = log_active.getHotSpot(i);
                if (hs.getSSID().Contains(ssid))
                {
                    filtered.addHotSpot(hs);
                }
            }

            log_active = filtered;
            displayRecord();

            ssid_filter_changed = false;
            security_filter_changed = false;
            channel_filter_changed = false;
        }

        private void ssid_filter_TextChanged(object sender, EventArgs e)
        {
            ssid_filter_changed = true;
        }

        private void security_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            security_filter_changed = true;
        }

        private void channel_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            channel_filter_changed = true;
        }
    }
}
