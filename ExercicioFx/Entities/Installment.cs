using System;

namespace ExercicioFx.Entities
{
    internal class Installment
    {
        /*Atributos*/
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        //Construtor padrao
        public Installment(DateTime dueDate, double amount) 
        {
            DueDate = dueDate;
            Amount = amount;
        }
    }
}
