using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Josh_Slaunwhite_Structs
{
    internal class Program
    {
        // PROGRAMMING
        // 1) Data -- Stores things
        // 2) Code -- Does things (to/with data)

        // Encapsulation
        // 1) Data -- Structs, Classes, ...
        // 2) Code -- Methods!

        //structs
        struct Vector2
        {
            public int x;
            public int y;
        }

        //Weapon Struct
        
        struct Weapon
        {
            public int strength;
            public int speed;
            public int durability;
            public string name;
        }

        //Weapons
        static Weapon sword;
        static Weapon bat;
        static Weapon gun;
        static Weapon knife;

        // Player info
        //static int x = 10; // Position
        //static int y = 10; // Position
        static Vector2 Playerposition;
        static int Health = 100; // Health
        static int Shield = 100; // Shield
        static int Lives = 3; // Lives
        static string name; // Name

        //Enemy #1
        static Vector2 Enemy1position;
        // Or with arrays

        //Enemy #2
        static Vector2 Enemy2position;
        // Or with arrays

        //Enemy #3
        static Vector2 Enemy3position;
        // Or with arrays

        // OR enemies with arrays
        static int[] enemyX = new int[100];
        static int[] enemyY = new int[100];

        static void Main(string[] args)
        {
            sword.strength = 100;
            sword.name = "John";
            bat.durability = 100;

            Console.WriteLine("Structs");
            Console.WriteLine("- - - - - - -");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit . . .");
            Console.ReadKey(true);
        }
    }
}
