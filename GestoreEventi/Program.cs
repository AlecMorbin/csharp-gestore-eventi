using GestoreEventi;

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
