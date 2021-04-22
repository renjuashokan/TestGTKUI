using System;
using System.Collections.Generic;
using System.Text;

namespace TestGTKUI
{
    public class CSSData
    {
        public string cssdata = @"
        GtkButton,
        .button_style {
            color: black;
            font-weight: bold;
        }

        GtkLabel,
        .labelStyle {
            color: forestgreen;
            font-weight: bold;
            font-size: 15px;
        }
        ";

        public CSSData()
        {
            Console.WriteLine("ctr");
        }

        public string CSSString
        {
            get => cssdata;
        }
    }
    
}
