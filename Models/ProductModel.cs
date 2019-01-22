using System;
using System.Collections.Generic;
using System.Linq;

namespace PhotoScape.Models
{
    public class ProductModel
    {
        public readonly List<Product> products;

        public ProductModel()
        {
            products = new List<Product>() {
                new Product {
                    Id = "1",
                    Author = "John Smith",
                    Price = 5.99,
                    Photo = "1.jpg"
                },
                new Product {
                    Id = "2",
                    Author = "Jonathan Baker",
                    Price = 8.59,
                    Photo = "2.gif"
                },
                new Product {
                    Id = "3",
                    Author = "Jennifer Casper",
                    Price = 2.89,
                    Photo = "3.jpg"
                },
                new Product {
                    Id = "4",
                    Author = "Adam Meyer",
                    Price = 6.39,
                    Photo = "4.jpg"
                },
                new Product {
                    Id = "5",
                    Author = "Lawrence Daniels",
                    Price = 7.09,
                    Photo = "5.jpg"
                },
                new Product {
                    Id = "6",
                    Author = "Alfredo LaPaya",
                    Price = 8.14,
                    Photo = "6.jpg"
                },
                new Product {
                    Id = "7",
                    Author = "Kendrid Murray",
                    Price = 10.80,
                    Photo = "7.jpg"
                },
                new Product {
                    Id = "8",
                    Author = "Chelsie Valero",
                    Price = 5.75,
                    Photo = "8.jpg"
                },
                new Product {
                    Id = "9",
                    Author = "Marcus Capello",
                    Price = 14.48,
                    Photo = "9.jpg"
                },                
                new Product {
                    Id = "10",
                    Author = "Gerald Montenero",
                    Price = 6.77,
                    Photo = "10.jpg"
                },
                new Product {
                    Id = "11",
                    Author = "Pam Hutchingson",
                    Price = 12.19,
                    Photo = "11.jpg"
                },
                new Product {
                    Id = "12",
                    Author = "Michael Taylor",
                    Price = 7.59,
                    Photo = "12.jpg"
                },
                new Product {
                    Id = "13",
                    Author = "Amanda Pierr",
                    Price = 5.89,
                    Photo = "13.jpg"
                },
                new Product {
                    Id = "14",
                    Author = "Nathan Syfer",
                    Price = 11.05,
                    Photo = "14.jpg"
                },
                new Product {
                    Id = "15",
                    Author = "Chad Callings",
                    Price = 9.39,
                    Photo = "15.jpg"
                }
            };
        }

        public List<Product> FindAll()
        {
            return products;
        }

        public Product Find(string id)
        {
            return products.SingleOrDefault(p => p.Id.Equals(id));
        }
    }
}