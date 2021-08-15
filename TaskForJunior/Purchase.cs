using System;
using System.Collections.Generic;
using System.Text;

namespace TaskForJunior
{
    public class Purchase
    {
        public int Id  { get; set; }
        public string Product { get; set; }
        public double PurchasePrice { get; set; }

        public void PurchaseInfo()
        {
             Console.WriteLine($"Id = {Id}, Product = {Product}, PurchasePrice = {PurchasePrice}");
        }
    }
}
