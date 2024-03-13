using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public enum Role {Customer, Seller, Administrator}
    public class User
    {
        private string userName;
        private string password;
        private string name;
        private string lastName;
        private string gender;
        private string email;
        private DateTime birthDate;
        private Role role;
        private List<Order> orderList;
        private List<Product> favoriteProductsList;
        private List<Product> publishedProductsList;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public Role Role { get => role; set => role = value; }
        public List<Order> OrderList { get => orderList; set => orderList = value; }
        public List<Product> FavoriteProductsList { get => favoriteProductsList; set => favoriteProductsList = value; }
        public List<Product> PublishedProductsList { get => publishedProductsList; set => publishedProductsList = value; }

        public User()
        {
            orderList = new List<Order>();
            FavoriteProductsList = new List<Product>();
            PublishedProductsList = new List<Product>();
        }

        public User(string userName, string password, string name, string lastName, string gender, string email, DateTime birthDate, Role role)
        {
            UserName = userName;
            Password = password;
            Name = name;
            LastName = lastName;
            Gender = gender;
            Email = email;
            BirthDate = birthDate;
            Role = role;
            orderList = new List<Order>();
            FavoriteProductsList = new List<Product>();
            PublishedProductsList = new List<Product>();
        }
    }
}



