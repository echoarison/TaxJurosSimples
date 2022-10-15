using System;

namespace ExercicioFx.Entities
{
    internal class Contract
    {
        /*Atributos da Classe*/
        public int Number { get; set; }
        public DateTime Date { get; set; }
        //public double TotalValue { get; set; }

        //Construtor padrao
        public Contract(int number, DateTime date) {

            Number = number;
            Date = date;

        }

        //Get do totalValue
        public double TotalValue 
        {
            get { return TotalValue; }
        }
    }
}
