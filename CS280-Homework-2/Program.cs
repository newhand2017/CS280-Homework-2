using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//---------------------------------------------------------
// User defined .dll
//---------------------------------------------------------
using CS280_Homework_1._2;

//---------------------------------------------------------

namespace CS280_Homework_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //---------------------------------------------
            // Claim
            //---------------------------------------------
            //Pokemon pokemon = new Pokemon();

            //Array type
            Pokemon[] pokemon = new Pokemon[1];
            pokemon[0] = new Pokemon();

            //---------------------------------------------
            // Function
            //---------------------------------------------
            Console.WriteLine("請輸入一隻Pokemon : ");

            Console.Write("請輸入名稱(Name) : ");
            pokemon[0].Name = Console.ReadLine();

            Console.Write("請輸入編號(Number) : ");
            try
            {
                pokemon[0].Number = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入格式錯誤，請輸入Int 格式。");
                Console.WriteLine("錯誤訊息 : \n" + e.ToString());

                return;
            }

            Console.Write("請輸入高度(Height) : ");
            try
            {
                pokemon[0].Height = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入格式錯誤，請輸入Float 格式。");
                Console.WriteLine("錯誤訊息 : \n" + e.ToString());

                return;
            }

            Console.Write("請輸入重量(Weight) : ");
            try
            {
                pokemon[0].Weight = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入格式錯誤，請輸入Float 格式。");
                Console.WriteLine("錯誤訊息 : \n" + e.ToString());

                return;
            }

            Console.Write("請輸入種類(Category) : ");
            pokemon[0].Category = Console.ReadLine();

            Console.Write("請輸入能力(Abilities) : ");
            pokemon[0].Abilities = Console.ReadLine();

            Console.Write("請輸入性別(Gender) : ");
            pokemon[0].Gender = Console.ReadLine();

            //---------------------------------------------
            // Output result
            Console.WriteLine("\n怪獸資料 : ");

            Console.WriteLine("Name: {0} \tNumber: #{1,3:d3}",
                pokemon[0].Name, pokemon[0].Number);
            Console.WriteLine("Height: {0,4:f} ft \tCategory: {1}",
                pokemon[0].Height, pokemon[0].Category);
            Console.WriteLine("Weight: {0,4:f} lbs \tAbilities: {1}",
                pokemon[0].Weight, pokemon[0].Abilities);
            Console.WriteLine("Gender: {0} \t",
                pokemon[0].Gender);

            //---------------------------------------------
        }
    }
}