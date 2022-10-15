using System;

namespace ExercicioFx.Entities
{
    internal class Contract
    {
        /*Atributos da Classe*/
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        //Construtor padrao
        public Contract(int number, DateTime date, double totalValue) {

            Number = number;
            Date = date;
            TotalValue = totalValue;

        }
    }
}
