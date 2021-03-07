using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int shot, shot_num = 0;
            Console.WriteLine("Choose your tank");
            Console.WriteLine("1)Obj.907");
            Console.WriteLine("2)Chieftain  FV4201");
            int user_tank_num = int.Parse(Console.ReadLine());
            Tank1 Tank_Fi, Tank_Sec;
            if (user_tank_num == 1)
            {
                Tank_Fi = new Tank1("Obj.907", 325, 410, 2500);
                Tank_Sec = new Tank1("Chieftain  FV4201 ", 331, 315, 2800);
            }
            else
            {
                Tank_Fi = new Tank1("Chieftain  FV4201 ", 331, 315, 2800);
                Tank_Sec = new Tank1("Obj.907", 325, 410, 2500);
            }
            Console.WriteLine(Tank_Fi.Health);
            Console.WriteLine("Your tank properties: " + Tank_Fi.GetInfo());
            Console.WriteLine("Enemy tank properties: " + Tank_Sec.GetInfo());
            Console.WriteLine("Enter 1 if you want to start BATTLE!!!!!");
            shot = int.Parse(Console.ReadLine());
            if (shot == 1)
            {
                while (Tank_Sec.Health > 0 && Tank_Fi.Health > 0)
                {
                    Console.WriteLine("Enter armor's matrix number:");
                    int a_arr_index = int.Parse(Console.ReadLine());
                    int b_arr_index = int.Parse(Console.ReadLine());
                    Console.WriteLine(Tank_Fi.MakeShot(Tank_Sec, a_arr_index, b_arr_index));
                    Console.WriteLine(Tank_Fi.TakeShot(Tank_Sec));
                    Console.WriteLine("Your tank Health: " + Tank_Fi.Health);
                    Console.WriteLine("Enemy tank Health: " + Tank_Sec.Health);
                    shot_num++;
                    
                }
                if (Tank_Fi.Health > 0) Console.WriteLine($"VICTORY, You won this game, you did {shot_num}  shot!!!! ");
                else Console.WriteLine($"LOSERRRR!!!! Your opponent won this battle, you did {shot_num}  shot!!!! ");
            }
        }
    }
}
