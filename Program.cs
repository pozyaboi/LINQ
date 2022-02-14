using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static IEnumerable<string> Suits()
        {
            yield return "Трефы";
            yield return "Ромб";
            yield return "Черви";
            yield return "Пики";
        }

        static IEnumerable<string> Ranks()
        {
            yield return "два";
            yield return "три";
            yield return "четыре";
            yield return "пять";
            yield return "шесть";
            yield return "семь";
            yield return "восемь";
            yield return "девять";
            yield return "десять";
            yield return "валет";
            yield return "дама";
            yield return "король";
            yield return "туз";
        }
        static void Main(string[] args)
        {
            var startingDeck = from s in Suits()
                               from r in Ranks()
                               select new { Suit = s, Rank = r };

            foreach (var card in startingDeck)
            {
                Console.WriteLine(card);
            }

        }
    }
}
