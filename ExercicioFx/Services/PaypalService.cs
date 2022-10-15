using System;


namespace ExercicioFx.Services
{
    /**
     * 
     * Aqui estou fazendo uma realização de interface
     * é da mesma maneira que uma herança, mas nesse
     * contexto não é.
     * Que seria """A interface que ele pertence"""
     * 
     **/
    internal class PaypalService : IOnlinePaymentService
    {
        //methos da class PaypalService
        public double paymentFree(double amount)
        {

            /**
             * 
             * estou somando o valor com a taxa de 2%
             * 
             **/
            return amount + 0.2;

        }

        public double interest(int months, double amount)
        {
            /**
             * 
             * estou retornando o valor somado com 1% vezes o mes em questão
             * 
             **/
            return (amount + 0.1) * months;
        }

    }
}
