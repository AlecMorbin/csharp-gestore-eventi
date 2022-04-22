using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
        private string titolo;
        private DateTime data;
        private int capienzaMassimaEvento;
        private int postiPrenotati;

        public Evento(string titolo, DateTime date, int postiDisponibili)
        {
            this.titolo = titolo;
            data = date;
            capienzaMassimaEvento = postiDisponibili;
            postiPrenotati = 0;
        }

        public void setTitolo(string titolo)
        {
            if (string.IsNullOrEmpty(titolo))
                this.titolo = titolo;
            else
                throw new ArgumentNullException("Il titolo inserito è vuoto");
        }
          
        public string getTitolo()
        {
            return this.titolo;
        }
        
        public void setData(DateTime date) 
        {
            if (date > DateTime.Now)
                this.data = date;
            else
                throw new Exception("La data inserita è nel passato");
        }

        public DateTime getData()
        {
            return data;
        }

        public int getCapienzaMassimaEvento()
        {
            return capienzaMassimaEvento;
        }

        public int getPostiPrenotati()
        {
            return postiPrenotati;
        }

        public void prenota()
        {
            if(capienzaMassimaEvento-postiPrenotati > 0)
            {
                postiPrenotati++;
            }
            else
            {
                throw new Exception("Non ci sono posti disponibili");
            }
        }

        public void disdici()
        {
            if (postiPrenotati > 0)
                postiPrenotati--;
            else
                throw new Exception("Non ci sono posti prenotati");
        }

        public int postiDisponibili()
        {
            return capienzaMassimaEvento - postiPrenotati;
        }

        public override string ToString()
        {
            return "Evento: "+"\nTitolo: "+titolo+
                    "\nData: "+data.ToString("dd/MM/yyyy")+
                    "\nCapeinza massima evento: "+capienzaMassimaEvento+
                    "\nPosti prenotati: "+postiPrenotati;
        }
    }
}
