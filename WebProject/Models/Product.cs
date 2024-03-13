using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public class Product
    {
        private string name;
        private double price;
        private int quantity;
        private string description;
        private string imagePath;
        DateTime productDate;
        private string city;
        private bool available;
        private List<Review> reviewsList;


        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Description { get => description; set => description = value; }
        public string ImagePath { get => imagePath; set => imagePath = value; }
        public DateTime ProductDate { get => productDate; set => productDate = value; }
        public string City { get => city; set => city = value; }
        public bool Available { get => available; set => available = value; }
        public List<Review> ReviewsList { get => reviewsList; set => reviewsList = value; }

        public Product()
        {
            ReviewsList = new List<Review>();
        }

        public Product(string name, double price, int quantity, string description, string imagePath, DateTime productDate, string city, bool available)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Description = description;
            ImagePath = imagePath;
            ProductDate = productDate;
            City = city;
            Available = available;
            ReviewsList = new List<Review>();
        }
    }
}