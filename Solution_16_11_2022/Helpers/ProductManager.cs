using Solution_16_11_2022.Models;
using System;

namespace Solution_16_11_2022.Helpers
{
    internal class ProductManager
    {

        public static Product[] CreateProducts(int noProducts)
        {
            int noOfProducts = noProducts;
            Product[] products = new Product[noOfProducts];
            for (int i = 0; i < noOfProducts; i++)
            {
                products[i] = new Product(ConsolePrompt.GetPropertyAsInt("Id"),
                ConsolePrompt.GetPropertyAsString("Title"), ConsolePrompt.GetPropertyAsString("Description"),
                ConsolePrompt.GetPropertyAsDouble("Price"), ConsolePrompt.GetPropertyAsString("Serial Number"));
            }

            return products;
        }
    }
}