using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart.Tests
{
    public class HarryPotterCart
    {
        private const string _serial = "HarryPotter";
        public double CountPrice(List<Book> books)
        {
            double result = 0;
            List<double> discounts = new List<double> { 1, 1, 0.95, 0.9, 0.8, 0.75 };

            var source = books.Where(book => book.Serial == _serial).GroupBy(book => book.Episode).ToList();
            var counts = source.Select(item => item.Count()).OrderBy(item => item).ToList();

            var prevCount = 0;
            counts.ForEach(c => {
                var discount = discounts[source.Count(b => b.Count() >= c)];
                result += source.Where(bs => bs.Count() >= c).Sum(bs => bs.Sum(b => b.price * discount * (c - prevCount)));
                prevCount = c;
            });

            return result;
        }
    }
}
