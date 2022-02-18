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
    public partial class DefaultServer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filtr = Request["filtr"];

            IDostepDoDanych iDostepDoDanych = new ZawodnicyRepository();
            Zawodnik[] zawodnicy= iDostepDoDanych.Filtruj(filtr);

            JavaScriptSerializer jss = new JavaScriptSerializer();
            string naps= jss.Serialize(zawodnicy);
            Response.Write(naps);
        }
    }
}