
namespace ExercicioFx.Services
{
    /**
     * 
     * Toda interface começa com I maiusculo
     * para indicar que é uma interface
     * 
     **/
    interface IOnlinePaymentService
    {
        //A interface só serve para fazer o contrato do "negocio"
        double paymentFree(double amount);  /*Taxa de pagamento do paypal*/
    }
}
