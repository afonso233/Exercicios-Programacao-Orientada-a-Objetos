namespace Exercicios.Serivices {
    interface IOnlinePaymentService {
        double PaymentFee(double amonut);

        double Interest(double amonut, int months);

    }
}
