using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAppuntamenti
{
    internal class Appuntamenti 
    {
        public string nome { get; }
        public string localitaAppuntamento { get; set; }

        public DateTime dataAppuntamento { get; }

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
