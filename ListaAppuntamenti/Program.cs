using ListaAppuntamenti;

List<Appuntamenti> listaAppuntamenti = new List<Appuntamenti>();

//Numero di appuntamenti da inserire
Console.WriteLine("Quanti appuntamenti vuoi inserire in agenda? ");
int numeroAppuntamenti = int.Parse(Console.ReadLine());

    for (int i = 0; i < numeroAppuntamenti; i++)
    {
        Console.Write("Inserisci nome: ");
        string nomeAppuntamento = Console.ReadLine();

        Console.Write("Inserisci localita: ");
        string localita = Console.ReadLine();

        bool dataOraNonCorretta = false;   
        //Finche' la data non e' corretta continuaiamo ad inserirla catturando l'eccezione
        while (!dataOraNonCorretta) 
            try
            {
                Console.Write("Inserisci data e ora appuntamento: ");
                DateTime dataOra = DateTime.Parse(Console.ReadLine());

                listaAppuntamenti.Add(new Appuntamenti(nomeAppuntamento, localita, dataOra));
                Console.WriteLine();
                dataOraNonCorretta = true;   
            }
            catch (InvalidDataException ex)
            {
                Console.WriteLine(ex.Message);

            }
    }

    //Stampo la lista con il foreach
    foreach (Appuntamenti appuntamento in listaAppuntamenti)
    {
        Console.WriteLine(appuntamento.ToString());
    }

    /*
    string scelta1 = "si";
    string scelta2 = "no";
    Console.WriteLine("Vuoi modificare un elemento nelle lista[si/no]?");
    string sceltaModifica = Console.ReadLine();

    if (sceltaModifica.Equals(scelta1))
    {
        
    }*/
 