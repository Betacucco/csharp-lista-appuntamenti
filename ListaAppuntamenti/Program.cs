using ListaAppuntamenti;

List<Appuntamenti> listaAppuntamenti = new List<Appuntamenti>();

Console.WriteLine("Quanti appuntamenti vuoi inserire in agenda? ");
int numeroAppuntamenti = int.Parse(Console.ReadLine());

for (int i = 0; i < numeroAppuntamenti; i++)
{
    Console.Write("Inserisci nome: ");
    string nomeAppuntamento = Console.ReadLine();

    Console.Write("Inserisci localita: ");
    string localita = Console.ReadLine();

    try
    {
        Console.Write("Inserisci data e ora appuntamento: ");
        DateTime dataOra = DateTime.Parse(Console.ReadLine());

        listaAppuntamenti.Add(new Appuntamenti(nomeAppuntamento, localita, dataOra));
        Console.WriteLine();
    }
    catch (InvalidDataException ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("Inserisci nuova data: ");

    }

}

    foreach (Appuntamenti appuntamento in listaAppuntamenti)
    {
        Console.WriteLine(appuntamento.ToString());
    }