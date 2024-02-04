using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_MS
{
    internal class Book
    {
        public string title;
        public string author;
        public int publicationYear;
        public float price;
        public int quantityInStock;

        public Book(string title, string author, int publicationYear, float price, int quantityInStock)
        {
            this.title = title;
            this.author = author;
            this.publicationYear = publicationYear;
            this.price = price;
            this.quantityInStock = quantityInStock;
        }

        public string GetTitle()
        {
            return $"Title: {title}";
        }

        public string GetAuthor()
        {
            return $"Author: {author}";
        }

        public string GetPublicationYear()
        {
            return $"Publication Year: {publicationYear}";
        }

        public string GetPrice()
        {
            return $"Price: {price:C}";
        }

        public void SellCopies(int numberOfCopies)
        {
            if (quantityInStock >= numberOfCopies)
            {
                quantityInStock -= numberOfCopies;
                Console.WriteLine($"{numberOfCopies} copies bik(sold) ho chuki hain. Remaining stock yai hai==> {quantityInStock}");
            }
            else
            {
                Console.WriteLine($"Itna tou stock hi nhi hai. Available stock yai hai==> {quantityInStock}");
            }
        }

        public void Restock(int additionalCopies)
        {
            quantityInStock += additionalCopies;
            Console.WriteLine($"{additionalCopies} copies ko stock mai add kr dia hai. Naya stock yai hai==> {quantityInStock}");
        }

        public string BookDetails()
        {
            return $"{GetTitle()} | {GetAuthor()} | {GetPublicationYear()} | {GetPrice()} | Stock: {quantityInStock} copies";
        }
    }
}
