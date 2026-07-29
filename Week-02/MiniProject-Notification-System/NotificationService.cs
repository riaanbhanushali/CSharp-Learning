using System;

namespace NotificationSystem
{
    interface INotification
    {
        void Send(string message);
    }

    class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Email Recieved : " + message);
        }
    }
    class Whatsapp : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Whatsapp message Recieved : " + message);
        }
    }

    class Teams : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Teams Message Recieved :" + message);
        }
    }

    class NotificationService
    {
        private INotification notification;
        public NotificationService(INotification notification)
        {
            this.notification = notification;
        }

        public void Notify(string message)
        {
            notification.Send(message);
        }
    }

    class MainP
    {
        public static void Main()
        {
            NotificationService service = new NotificationService(new EmailNotification());

            service.Notify("Salary Credited :) ");
        }
    }
}