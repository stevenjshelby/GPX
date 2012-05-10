using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GPXLogInterface
{
    class HotSpot
    {
        //initialize variables for the HotSpot object
        string latitude, longitude, ele, time, geoidheight, name, cmt, desc,
               fix, sat, hdop, vdop, pdop, MAC, SSID, RSSI, ChannelID, security,
               signalQuality, networkType, rates;

        //constructor that takes in every variable as a string
        public HotSpot(string lat, string lon, string e, string t,
                       string geoid, string na, string c, string de,
                       string f, string s, string hd, string vd, string pd,
                       string M, string SS, string RS, string Chan,
                       string sec, string sig, string net, string r)
        {
            latitude = lat;
            longitude = lon;
            ele = e;
            time = t;
            geoidheight = geoid;
            name = na;
            cmt = c;
            desc = de;
            fix = f;
            sat = s;
            hdop = hd;
            vdop = vd;
            pdop = pd;
            MAC = M;
            SSID = SS;
            RSSI = RS;
            ChannelID = Chan;
            security = sec;
            signalQuality = sig;
            networkType = net;
            rates = r;
        }

        //GET(string) methods for all variables. Although most are uneeded.
        public string getLat()
        {
            return latitude;
        }

        public string getLon()
        {
            return longitude;
        }

        public string getEle()
        {
            return ele;
        }

        public string getTime()
        {
            return time;
        }

        public string getGeoidheight()
        {
            return geoidheight;
        }

        public string getName()
        {
            return name;
        }

        public string getCmt()
        {
            return cmt;
        }

        public string getDesc()
        {
            return desc;
        }

        public string getFix()
        {
            return fix;
        }

        public string getSat()
        {
            return sat;
        }

        public string getHdop()
        {
            return hdop;
        }

        public string getVdop()
        {
            return vdop;
        }

        public string getPdop()
        {
            return pdop;
        }

        public string getMAC()
        {
            return MAC;
        }

        public string getSSID()
        {
            return SSID;
        }

        public string getRSSI()
        {
            return RSSI;
        }

        public string getChannelID()
        {
            return ChannelID;
        }

        public string getSecurity()
        {
            return security;
        }

        public string getSignalStrength()
        {
            return signalQuality;
        }

        public string getNetworkType()
        {
            return networkType;
        }

        public string getRates()
        {
            return rates;
        }

        //return compiled HotSpot in string format to be written to a GPX/xml file
        //hopefully this actually works......
        public string getCompiledHS()
        {
            string output;

            output = "   <wpt lat=\"" + latitude + "\" lon=\"" + longitude + "\">\n";
            output += "      <ele>" + ele + "</ele>\n";
            output += "      <time>" + time + "</time>\n";
            output += "      <geoidheight>" + geoidheight + "</geoidheight>\n";
            output += "      <name>" + name + "</name>\n";
            output += "      <cmt>" + cmt + "</cmt>\n";
            output += "      <desc>" + desc;
            output += "      <fix>" + fix + "</fix>\n";
            output += "      <sat>" + sat + "</sat>\n";
            output += "      <hdop>" + hdop + "</hdop>\n";
            output += "      <vdop>" + vdop + "</vdop>\n";
            output += "      <pdop>" + pdop + "</pdop>\n";
            output += "      <extensions>\n";
            output += "         <MAC>" + MAC + "</MAC>\n";
            output += "         <SSID>" + SSID + "</SSID>\n";
            output += "         <RSSI>" + RSSI + "</RSSI>\n";
            output += "         <ChannelID>" + ChannelID + "</ChannelID>\n";
            output += "         <security>" + security + "</security>\n";
            output += "         <signalQuality>" + signalQuality + "</signalQuality>\n";
            output += "         <networkType>" + networkType + "</networkType>\n";
            output += "         <rates>" + rates + "</rates>\n";
            output += "      </extensions>\n";
            output += "   </wpt>";

            return output;
        }

        //SET(string) methods for all variables. These aren't really needed.
        public void setLat(string s)
        {
            latitude = s;
        }

        public void setLon(string s)
        {
            longitude = s;
        }

        public void setEle(string s)
        {
            ele = s;
        }

        public void setTime(string s)
        {
            time = s;
        }

        public void setGeoidheight(string s)
        {
            geoidheight = s;
        }

        public void setName(string s)
        {
            name = s;
        }

        public void setCmt(string s)
        {
            cmt = s;
        }

        public void setDesc(string s)
        {
            desc = s;
        }

        public void setFix(string s)
        {
            fix = s;
        }

        public void setSat(string s)
        {
            sat = s;
        }

        public void setHdop(string s)
        {
            hdop = s;
        }

        public void setVdop(string s)
        {
            vdop = s;
        }

        public void setPdop(string s)
        {
            pdop = s;
        }

        public void setMAC(string s)
        {
            MAC = s;
        }

        public void setSSID(string s)
        {
            SSID = s;
        }

        public void setRSSI(string s)
        {
            RSSI = s;
        }
        
        public void setChannelID(string s)
        {
            ChannelID = s;
        }

        public void setSecurity(string s)
        {
            security = s;
        }

        public void setSignalStrength(string s)
        {
            signalQuality = s;
        }

        public void setNetworkType(string s)
        {
            networkType = s;
        }

        public void setRates(string s)
        {
            rates = s;
        }

        //get signalQuality in numeric form
        public int getSigNumeric()
        {
            int s = Convert.ToInt32(signalQuality);
            return s;
        }

        //get date in usable DateTime form
        //right now, only return day, month, and year
        public DateTime getDate()
        {
            int y = Convert.ToInt32(time.Substring(0, 4));
            int mo = Convert.ToInt32(time.Substring(5, 2));
            int d = Convert.ToInt32(time.Substring(8, 2));
            //int h = 0;
            //int mi = 0;
            //int s = 0;

            DateTime date = new DateTime(y, mo, d);
            //DateTime date = new DateTime(y, mo, d, h, mi, s);
            return date;
        }
    }
}
