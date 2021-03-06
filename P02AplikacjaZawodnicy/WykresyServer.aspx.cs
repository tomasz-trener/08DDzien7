using P04AplikacjaZawodnicy.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaZawodnicy
{
    public partial class WykresyServer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IDostepDoDanych iDostepDoDanych = new ZawodnicyRepository();
            DaneWykresu daneWykresu= iDostepDoDanych.WygenerujWykres(RodzajDanych.Wzrost);

            JavaScriptSerializer jss = new JavaScriptSerializer();
            string napis = jss.Serialize(daneWykresu);
            Response.Write(napis);
        }
    }
}