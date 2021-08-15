using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace TaskForJunior
{
    class Program
    {
      public static  MailAddress fromUser, SendClient;

      public static  MailMessage Massage;

      public static SmtpClient smtpClient;

      public static Client client;

      public static Purchase purchase;

        static void Main(string[] args)
        {
           
            client = new Client() { Id = 1, PhoneNumber = 927758499, Email = "shahzodjonjonizoqov@gmail.com" };

            client.ClientInfo();

            purchase = new Purchase() { Id = 1, Product = "Drink", PurchasePrice = 9 };

            purchase.PurchaseInfo();

            Console.WriteLine("Choose sending message to Client:\nEmail: 1\nSMS: 2");
            try
            {
                int number = int.Parse(Console.ReadLine());

                if (number == 1)
                {
                    SendingEmail();
                }
                else
                {

                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
       
            Console.Read();
        }

        static void SendingEmail()
        {
            try
            {
                fromUser = new MailAddress("Muhammadumirzoqov12@gmail.com", "Muhammad");

                SendClient = new MailAddress(client.Email);

                Massage = new MailMessage(fromUser, SendClient);

                Massage.Subject = "Write message";

                Massage.Body = "<h1>Номи тавар  " + purchase.Product + "</h1></br><p>Нархи тавар" + purchase.PurchasePrice + "</p>";

                Massage.IsBodyHtml = true;

                smtpClient = new SmtpClient("smtp.gmail.com", 587);

                smtpClient.Credentials = new NetworkCredential("Muhammadumirzoqov12@gmail.com", "ff123456&&");

                smtpClient.EnableSsl = true;

                smtpClient.Send(Massage);

                Console.WriteLine("Youre message sended to Client");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error:{ex.Message}");
            }
        }
    }
}
