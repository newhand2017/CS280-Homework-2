using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS280_Homework_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //---------------------------------------------
            // Claim
            //---------------------------------------------
            Pokemon pokemon = new Pokemon();

            //---------------------------------------------
            // Function
            //---------------------------------------------
            Console.Write("請輸入名稱(Name) : ");
            pokemon.Name = Console.ReadLine();

            Console.Write("請輸入編號(Number) : ");
            pokemon.Number = int.Parse(Console.ReadLine());

            Console.Write("請輸入高度(Height) : ");
            pokemon.Height = float.Parse(Console.ReadLine());

            Console.Write("請輸入重量(Weight) : ");
            pokemon.Weight = float.Parse(Console.ReadLine());

            Console.Write("請輸入種類(Category) : ");
            pokemon.Category = Console.ReadLine();

            Console.Write("請輸入能力(Abilities) : ");
            pokemon.Abilities = Console.ReadLine();

            Console.Write("請輸入性別(Gender) : ");
            pokemon.Gender = Console.ReadLine();

            //---------------------------------------------
            // Output result
            Console.WriteLine("\n怪獸資料 : ");

            Console.WriteLine("Name: {0} \tNumber: #{1,3:d3}",
                pokemon.Name, pokemon.Number);
            Console.WriteLine("Height: {0,4:f} ft \tCategory: {1}",
                pokemon.Height, pokemon.Category);
            Console.WriteLine("Weight: {0,4:f} lbs \tAbilities: {1}",
                pokemon.Weight, pokemon.Abilities);
            Console.WriteLine("Gender: {0} \t",
                pokemon.Gender);

            //---------------------------------------------
        }
    }
}