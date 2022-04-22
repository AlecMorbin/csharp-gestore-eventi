using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
        //Attributi
        private string titolo;
        private DateTime data;
        private int capienzaMassimaEvento;
        private int postiPrenotati;
        
        //Costruttore
        public Evento(string titolo, DateTime date, int postiDisponibili)
        {
            setTitolo(titolo);
            setData(date);
            capienzaMassimaEvento = postiDisponibili;
            postiPrenotati = 0;
        }

        //Metodi
        public void setTitolo(string titolo)
        {
            if (string.IsNullOrEmpty(titolo))
                this.titolo = titolo;
            else
                throw new ArgumentNullException(titolo,"Il titolo inserito è vuoto");
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

        public void prenota(int postiRichiesti)
        {
            if (data > DateTime.Now)
            {
                if (postiDisponibili() > 0)
                {
                    if(postiRichiesti < capienzaMassimaEvento)
                    {
                        if (postiRichiesti < postiDisponibili())
                            postiPrenotati += postiRichiesti;
                        else
                            throw new Exception("Hai chiesto più posti di quelli disponibili");
                    }
                    else 
                        throw new Exception("Hai chiesto più posti di quanto possibile per l'evento");
                }
                else
                {
                    throw new Exception("Non ci sono posti disponibili");
                }
            }
            else
                throw new Exception("L'evento è già passato");
        }

        public void disdici(int PostiRichiesti)
        {
            if (data > DateTime.Now)
            {
                if (PostiRichiesti < capienzaMassimaEvento) 
                {
                    if (PostiRichiesti < postiPrenotati)
                        postiPrenotati -= PostiRichiesti;
                    else
                        throw new Exception("Posti da disdire richiesti sono più di quelli prenotati");
                }
                else
                    throw new Exception("Hai chiesto più posti di quanto possibile per l'evento");
            }
            else
                throw new Exception("L'evento è già passato");
        }

        public int postiDisponibili()
        {
            return capienzaMassimaEvento - postiPrenotati;
        }

        public string stampaDataTitolo()
        {
            return this.getData().ToString("dd/MM/yyyy") + "  -  " + this.getTitolo() + "\n";
        }

        public override string ToString()
        {
            return "\nEvento: "+"\nTitolo: "+titolo+
                    "\nData: "+data.ToString("dd/MM/yyyy")+
                    "\nCapeinza massima evento: "+capienzaMassimaEvento+
                    "\nPosti prenotati: "+postiPrenotati;
        }
    }
}
