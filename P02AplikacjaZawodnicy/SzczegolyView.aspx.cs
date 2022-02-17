using P04AplikacjaZawodnicy.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaZawodnicy
{
    public partial class SzczegolyView : System.Web.UI.Page
    {
        IDostepDoDanych iDostepDoDanych = new ZawodnicyRepository();
        public Zawodnik Zawodnik;
        protected void Page_Load(object sender, EventArgs e)
        {
            string ids = Request["id"];
            if (ids == null)
                Response.Redirect("Default.aspx");

            int id = Convert.ToInt32(ids);
            Zawodnik= iDostepDoDanych.PodajZawodnika(id);

            if (!Page.IsPostBack)
            {
                txtImie.Text = Zawodnik.Imie;
                txtNazwisko.Text = Zawodnik.Nazwisko;
                txtKraj.Text = Zawodnik.Kraj;
                txtDataUr.Text = Zawodnik.DataUrodzenia.ToString("yyyy-MM-dd");
                txtWaga.Text = Convert.ToString(Zawodnik.Waga);
                txtWzrost.Text = Convert.ToString(Zawodnik.Wzrost);
            }
           
        }

        protected void btnZapisz_Click(object sender, EventArgs e)
        {
            Zawodnik.Imie = txtImie.Text;
            Zawodnik.Nazwisko = txtNazwisko.Text;
            Zawodnik.Kraj = txtKraj.Text;
            Zawodnik.DataUrodzenia = Convert.ToDateTime(txtDataUr.Text);
            Zawodnik.Waga = Convert.ToInt32(txtWaga.Text);
            Zawodnik.Wzrost = Convert.ToInt32(txtWzrost.Text);

            iDostepDoDanych.Edytuj(Zawodnik);
            Response.Redirect("Default.aspx");

        }
    }
}