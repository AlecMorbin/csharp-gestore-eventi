using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class ProgrammaEventi 
    {
        //Attributi
        private string titolo;
        private List<Evento> eventi;

        //Costruttori
        public ProgrammaEventi(string titolo)
        {
            this.titolo = titolo;
            eventi = new List<Evento>();
        }

        //Metodi
        public void aggiungiEvento(Evento evento)
        {
            eventi.Add(evento);
        }

        public List<Evento> eventiInData(DateTime data)
        {
            List<Evento> eventiInData = new List<Evento>();
            foreach (Evento evento in eventi)
            {
                if (evento.getData() == data)
                    eventiInData.Add(evento);
            }
            return eventiInData;
        }

        public static void stampaLista(List<Object> lista)
        {
            foreach (Object item in lista)
                Console.WriteLine(item.ToString());
        }

        public int numeroEventi()
        {
            return eventi.Count;
        }

        public void svuotaListaEventi()
        {
            eventi.Clear();
        }


        public override string ToString()
        {
            string str = "\nTitolo: " + titolo + "\n";

            foreach (Evento evento in eventi)
                str += evento.stampaDataTitolo();

            return str;
        }
    }
}
