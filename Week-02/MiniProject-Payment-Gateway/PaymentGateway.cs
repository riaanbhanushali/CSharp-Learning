using System;

namespace PaymentGateway
{

    interface IPayment
    {
        void Pay(double amount);
    }

    class Razorpay : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Payment of ₹{amount} made successfully using Razorpay.");
        }
    }

    class PayPal : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Payment of ₹{amount} made successfully using PayPal.");
        }
    }

    class Stripe : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Payment of ₹{amount} made successfully using Stripe.");
        }
    }

    class Checkout
    {
        private IPayment paymentMethod;

        public Checkout(IPayment paymentMethod)
        {
            this.paymentMethod = paymentMethod;
        }

        public void CompleteOrder(double amount)
        {
            Console.WriteLine("\nProcessing Payment...");
            paymentMethod.Pay(amount);
            Console.WriteLine("Order Placed Successfully!");
        }
    }

    class MainP
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose Payment Method");
            Console.WriteLine("1.Razorpay\n2.PayPal\n3.Stripe");

            Console.Write("Enter Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            IPayment payment = null ;

            switch (choice)
            {
                case 1:
                    payment = new Razorpay();
                    break;

                case 2:
                    payment = new PayPal();
                    break;

                case 3:
                    payment = new Stripe();
                    break;

                default:
                    Console.WriteLine("Invalid Choice!");
                    return;
            }

            Checkout checkout = new Checkout(payment);

            checkout.CompleteOrder(amount);
        }
    }
}