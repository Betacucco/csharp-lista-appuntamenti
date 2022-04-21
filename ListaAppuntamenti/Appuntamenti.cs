using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAppuntamenti
{
    internal class Appuntamenti 
    {
        //ATTRIBUTI
        public string nome { get; }
        public string localitaAppuntamento { get; }

        public DateTime dataAppuntamento { get; set; }

        //COSTRUTTORE
        public Appuntamenti(string nome, string localitaAppuntamento, DateTime dataAppuntamento)
        {
            this.nome = nome;
            this.localitaAppuntamento = localitaAppuntamento;
            this.dataAppuntamento = dataAppuntamento;

            if (this.dataAppuntamento <= DateTime.Now)
            {
                throw new InvalidDataException("La data inserita e' nel passato o oggi.");
            }   
        }

        public void NuovaData()
        {
            DateTime newDate = DateTime.Parse(Console.ReadLine());
            this.dataAppuntamento = newDate;
        }

        //Override del metodo toString per stampare ogni appuntamento in lista
        public override string ToString()
        {
            string rappresentazioneInStringa = "";

            rappresentazioneInStringa += "---- Appuntamento ---- \n";
            rappresentazioneInStringa += "Nome appuntamento: " + this.nome + "\n";
            rappresentazioneInStringa += "Localita Appuntamento: " + this.localitaAppuntamento + "\n";
            rappresentazioneInStringa += "Data e ora: " + this.dataAppuntamento + "\n";

            return rappresentazioneInStringa;
        }
    }
}
