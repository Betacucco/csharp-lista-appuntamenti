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

    //Chiediamo all'utente se vuole cambiare data
    Console.WriteLine("Vuoi cambiare data?");
    string risposta = Console.ReadLine();

    if (risposta == "si")
    {
        Console.WriteLine("Inserisci nome appuntamento a cui vuoi cambiare l'orario");
        string nomeAppuntamentoDaCambiare = Console.ReadLine();
        //Prendiamo l'indice in base al nome dell'appuntamento presente in lista
        int index = listaAppuntamenti.FindIndex(a => a.nome == nomeAppuntamentoDaCambiare);
        //Cambiamo l'ora con il metodo creato nella classe
        listaAppuntamenti[index].NuovoAppuntamento();
    }
    else if (risposta == "no")
    {
        Console.WriteLine("Nessun cambiamento!");
    }

     //Stampo la lista con il foreach
    foreach (Appuntamenti appuntamento in listaAppuntamenti)
    {
    Console.WriteLine(appuntamento.ToString());
    }

