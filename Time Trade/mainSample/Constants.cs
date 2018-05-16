﻿using System;
using System.Collections.Generic;

namespace mainSample
{
    public static class Constants
    {
        public static readonly int displayedDays = 60; //Days to be displayed
        public static readonly List<string> companies = new List<string>() //All companies
        { "AAPL","AMZN","BA","BBI","BBY","BP","C","CAT","DDAIF","F","INTC","JPM","KO","LEHMQ","MOT","MTLQQ.PK","S","SBUX",
          "T","TRMP"
        }; //Company SYMBOLS
        public static readonly double[,,] values = new double[20, 1096, 5];      //Values obtained from database
        public static readonly string[,] stockInfo = new string[20, 2]; //Information of the companies
        public static readonly bool stableBuild = true;
        public static readonly string newPlay = "AAPL:10000:1:6:2007#Empty:Empty:Empty:Empty:Empty:Empty:Empty:Empty:Empty:Empty:AAPL:AMZN:BA#AAPL:AMZN:BA:BBI:BBY:BP:C:CAT:DDAIF:F:INTC:JPM:KO:LEHMQ:MOT:MTLQQ.PK:S:SBUX:T:TRMP#############";

        //BEGIN HOOKS CODE
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //END HOOKS CODE
    }
}
