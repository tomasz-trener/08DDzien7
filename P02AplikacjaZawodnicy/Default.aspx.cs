﻿using P04AplikacjaZawodnicy.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaZawodnicy
{
    public partial class Default : System.Web.UI.Page
    {
        IDostepDoDanych iDostepDoDanych = new ZawodnicyRepository();
        public Zawodnik[] Zawodnicy;
        protected void Page_Load(object sender, EventArgs e)
        {
            Zawodnicy = iDostepDoDanych.WygenerujZawodnikow();
        }
    }
}