using System;
using System.Collections.Generic;
using System.Text;

namespace TaskForJunior
{
    public class Client
    {
        public int  Id { get; set; }
        public  int PhoneNumber { get; set; }
        public string Email { get; set; }

        public void ClientInfo()
        {
            Console.WriteLine($"Id = {Id}, PhoneNumber = {PhoneNumber}, Email = {Email}");
        }
    }
}
