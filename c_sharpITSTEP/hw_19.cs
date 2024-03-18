//using System;

//public class SendMessage
//{
//    public delegate void MessageSender(string title, string message);

//    public MessageSender Sender { get; set; }

//    public void Send(string title, string message)
//    {
//        if (Sender != null)
//        {
//            Sender(title, message);
//        }
//        else
//        {
//            Console.WriteLine("No sender logic defined.");
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        SendMessage messageSender = new SendMessage();

//        messageSender.Sender = (title, message) =>
//        {
//            Console.WriteLine($"Sending message with title: {title}");
//            Console.WriteLine($"Message content: {message}");
//        };

//        messageSender.Send("Oleh Volostnykh", "My name is Oleh Volostnykh.");
//        Console.ReadLine();
//    }
//}





