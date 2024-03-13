using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public enum Status { Active, Carried, Cancelled}
    public class Order
    {
        private Product product;
        private int quantity;
        private User kupac;
        private DateTime orderDate;
        private Status status;

        
        public Product Product { get => product; set => product = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public User Kupac { get => kupac; set => kupac = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public Status Status { get => status; set => status = value; }


        public Order(Product product, int quantity, User kupac, DateTime orderDate, Status status)
        {
            Product = product;
            Quantity = quantity;
            Kupac = kupac;
            OrderDate = orderDate;
            Status = status;
        }
    }
}