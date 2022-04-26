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
        private string nome;
        private string localitaAppuntamento;

        private DateTime dataAppuntamento;

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

        //------------GET-------------
        public string GetNome()
        {
            return nome;
        }

        public string GetLocalitaAppuntamento()
        {
            return localitaAppuntamento;
        }
        //------------------------------

        //------------SET------------------
        public void SetNome(string newName)
        {
            nome = newName;
        }

        public void SetLocalitaAppuntamento(string nuovaLocalita)
        {
            localitaAppuntamento = nuovaLocalita;
        }
        //--------------------------------------

        //Metodo per inserire una nuova data
        public DateTime NuovoAppuntamento(DateTime nuovaData)
        {
            this.dataAppuntamento = nuovaData;

            if (this.dataAppuntamento <= DateTime.Now)
            {
                throw new InvalidDataException("La data inserita e' nel passato o oggi.");
            }

            return this.dataAppuntamento;
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
