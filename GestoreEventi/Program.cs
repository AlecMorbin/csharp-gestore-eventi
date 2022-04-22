﻿using GestoreEventi;
/*
Console.WriteLine("Inserisci i dettaggli su nuovo evento:");


Console.Write("\nInserisci il nome dell'evento: ");
string nome = Console.ReadLine();
Console.Write("\nInserisci la data dell'evento: ");
DateTime data = DateTime.Parse(Console.ReadLine());
Console.Write("\nInserisci il numero di posti totale :");
int posti = int.Parse(Console.ReadLine());

Evento evento = new Evento(nome, data, posti);

Console.Write("\nQuanti posti vuoi prenotare: ");

evento.prenota(int.Parse(Console.ReadLine()));

Console.WriteLine("Posti prenotati: " + evento.getPostiPrenotati());
Console.WriteLine("Posti Disponibili : " + evento.postiDisponibili());

Console.Write("\nVuoi disdire dei posti?");

string rischiesta = Console.ReadLine();

if (rischiesta.ToLower() == "si")
{
    Console.Write("\nQuanti posti vuoi disdire: ");
    evento.disdici(int.Parse(Console.ReadLine()));
    Console.WriteLine("Posti prenotati: " + evento.getPostiPrenotati());
    Console.WriteLine("Posti Disponibili : " + evento.postiDisponibili());
}
else
{
    Console.WriteLine("Ok va bene!");
}

*/
//Commentato per escluderlo dall'esecuzione

Console.Write("Inserisci il nome del tuo programma Eventi: ");
ProgrammaEventi programma = new ProgrammaEventi(Console.ReadLine());
Console.Write("Indica il numero di eventi da insere: ");
int iterazioniUtente = int.Parse(Console.ReadLine());


for (int i = 0; i < iterazioniUtente; i++)
{
    bool flag=true;
    do { 
        try
        {
            Console.Write("Inserisci il titolo dell'evento numero " + (i + 1) + " :\t");
            string titolo = Console.ReadLine();
            Console.Write("Inserisci la data dell'evento numero: " + (i + 1) + " :\t");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write("Inserisci il numero di posti dell'evento numero: " + (i + 1) + " :\t");
            int posti = int.Parse(Console.ReadLine());
            Evento evento = new Evento(titolo, data, posti);
            programma.aggiungiEvento(evento);
            flag = true;
        }
        catch (Exception e)
        { 
            Console.WriteLine("Hai inserito in modo non corretto la data o la quantità di posti, per favore reinserisci i dati dell'evento");
            flag = false;
        }
    } while (flag==false);
}

Console.WriteLine(programma.ToString());

