using P04AplikacjaZawodnicy.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P01AplikacjaWebowa
{
    public partial class ZawodnicyView : System.Web.UI.Page
    {
        IDostepDoDanych iDostepDoDanych;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnWczytaj_Click(object sender, EventArgs e)
        {
            iDostepDoDanych = new ZawodnicyRepository();
            Odswiez();
        }

        private void Odswiez()
        {
            Zawodnik.KolumnyZWidoku = new string[]{ "Imie","Nazwisko" };
            Zawodnik[] zawodnicy = iDostepDoDanych.WygenerujZawodnikow();
            lbDane.DataSource = zawodnicy;
            lbDane.DataTextField = "WidoczneKolumny";
         //   lbDane.DataValueField = "Id_zawodnika";
            lbDane.DataBind();

        }
    }
}