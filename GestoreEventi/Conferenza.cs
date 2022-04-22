using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Conferenza : Evento
    {
        //Attributi
        private string relatore;
        private double prezzo;

        //Costruttore
        public Conferenza(string relatore, double prezzo ,string titolo,DateTime date,int postiDisponibili) : base(titolo,date,postiDisponibili)
        {
            this.relatore = relatore;
            this.prezzo = prezzo;
        }

        //Metodi

        public string getRelatore()
        {
            return relatore;
        }
        public double getPrezzo()
        {
            return prezzo;
        }
        public void setRelatore(string relatore)
        {
            if (string.IsNullOrEmpty(relatore))
                this.relatore=relatore;
            else
                throw new ArgumentNullException(relatore,"Il nome inserito è vuoto");
        }
        public void setPrezzo(double prezzo) 
        { 
            this.prezzo = prezzo; 
        }

        public string dataPrezzoFormattato()
        {
            string ris = "";
            ris += getData().ToString("dd/MM/yyyy")+" - "+getPrezzo().ToString("0.00")+" Euro";
            return ris;
        }

        public override string ToString()
        {
            return "Conferenza:\n"+
                    "Data: " + getData().ToString("dd/MM/yyyy") + "\n"+
                    "Titolo: " + getTitolo() + "\n"+
                    "Realtore: " + getRelatore() + "\n"+
                    "Prezzo: " + getPrezzo().ToString("0.00") + "\n";
        }
    }
}
