using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public class Review
    {
        private Product product;
        private User kupac;
        private string naslov;
        private string reviewContent;
        private string imagePath;


        public Product Product { get => product; set => product = value; }
        public User Kupac { get => kupac; set => kupac = value; }
        public string Naslov { get => naslov; set => naslov = value; }
        public string ReviewContent { get => reviewContent; set => reviewContent = value; }
        public string ImagePath { get => imagePath; set => imagePath = value; }

        public Review()
        {

        }

        public Review(Product product, User kupac, string naslov, string reviewContent, string imagePath)
        {
            Product = product;
            Kupac = kupac;
            Naslov = naslov;
            ReviewContent = reviewContent;
            ImagePath = imagePath;
        }
    }
}