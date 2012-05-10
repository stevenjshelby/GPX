using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GPXLogInterface
{
    class GPXLog
    {
        //holds all of the HotSpots found
        List<HotSpot> theData = new List<HotSpot>();

        int WEPnum, WPAnum, WPA2num, OPENnum, OTHERsecNum;

        //Constructor for creating empty logs
        public GPXLog()
        {
            theData = new List<HotSpot>();
        }

        //Contructor takes in a List of HotSpots
        public GPXLog(List<HotSpot> hs)
        {
            theData = hs;

            setSecurityStats();
        }

        //loop through entire list and count the different security setting
        void setSecurityStats()
        {
            WEPnum = 0; WPAnum = 0; WPA2num = 0; OPENnum = 0; OTHERsecNum = 0;
            for (int i = 0; i < theData.Count(); i++)
            {
                if (theData[i].getSecurity().Contains("WEP"))
                    WEPnum += 1;
                else if (theData[i].getSecurity().Contains("WPA2"))
                    WPA2num += 1;
                else if (theData[i].getSecurity().Contains("WPA"))
                    WPAnum += 1;
                else if (theData[i].getSecurity().Contains("Open"))
                    OPENnum += 1;
                else
                    OTHERsecNum += 1;
            }
        }

        //returns the size of the HotSpot list
        public int getSize()
        {
            return theData.Count();
        }

        //adds a HotSpot object to the data
        public void addHotSpot(HotSpot hs)
        {
            theData.Add(hs);
        }

        //returns the string output of a specific HotSpot record
        public HotSpot getHotSpot(int index)
        {
            return theData[index];
        }

        //sorts HotSpot list by MAC addresses
        //used to make filterData() easier
        public void sortData()
        {
            List<string> MAClist = new List<string>();
            List<HotSpot> newData = new List<HotSpot>();
            
            int i = 0;
            while (i < theData.Count())
            {
                string currMAC = theData[i].getMAC();
                if (!MAClist.Contains(currMAC))
                {
                    MAClist.Add(currMAC);
                    for (int j = 0; j < theData.Count(); j++)
                    {
                        HotSpot HS = theData[j];

                        if (HS.getMAC() == currMAC)
                        {
                            newData.Add(HS);
                        }
                    }
                }
                i++;
            }
            theData = newData;

            setSecurityStats();
        }

        //filters out duplicate MAC addresses and saves the HotSpot with highest signal quality
        public void filterData()
        {
            sortData();

            List<HotSpot> newData = new List<HotSpot>();

            HotSpot hs = theData[0];
            string currMAC = hs.getMAC();
            int currHigh = hs.getSigNumeric();

            for (int i = 0; i < theData.Count(); i++)
            {
                if (theData[i].getMAC() == currMAC)
                {
                    if (theData[i].getSigNumeric() > currHigh)
                    {
                        hs = theData[i];
                    }
                }
                else
                {
                    newData.Add(hs);
                    hs = theData[i];
                    currMAC = hs.getMAC();
                    currHigh = hs.getSigNumeric();
                }
            }
            theData = newData;

            setSecurityStats();
        }

        //returns the number of WEP encrypted networks in the list
        public double getWEPNum()
        {
            return WEPnum;
        }

        //returns the number of WPA encrypted networks in the list
        public double getWPANum()
        {
            return WPAnum;
        }

        //returns the number of WPA2 encrypted networks in the list
        public double getWPA2Num()
        {
            return WPA2num;
        }

        //returns the number of open networks in the list
        public double getOPENNum()
        {
            return OPENnum;
        }

        //returns the number of networks with other securoty settings in the list
        public double getOtherSecNum()
        {
            return OTHERsecNum;
        }

    }
}
