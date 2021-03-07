using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Tank1
    {
        //properties
        public string TankName { get; private set; }
        public int[,] TankArm { get; private set; } = new int[8, 8];
        public int Penetr { get; private set; }
        public int Dmg { get; private set; }
        public int Health { get; private set; }
        //constructor
        public Tank1(string name, int penetr, int dmg, int Hp)
        {
            this.TankName = name;
            this.Penetr = penetr;
            this.Dmg = dmg;
            this.Health = Hp;
        }
        //methods
        public string GetInfo()
        {
            Random rnd = new Random();
            string arm = "";
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    TankArm[i, j] = rnd.Next(290, 350);
                    arm += TankArm[i, j].ToString() + " ";
                }
                arm += Environment.NewLine;
            }
            return TankName + "\n" + arm + "Avg Penetration:" + Penetr + "\n" + "Avg dmg:" + Dmg + "\n" + "Hp:" + Health;
            // (de)serialization, JSON, XML, Upcast down cast,
        }
        public string MakeShot(Tank1 enemytank, int i, int j)
        {

            if (Penetr > enemytank.TankArm[i, j])
            {
                enemytank.Health -= Dmg;
                return "you penetrated their armor!!";
            }
            else
            {
                return "We didn't penetrate their armor!! :( :( ";
            }
        }
        public string TakeShot(Tank1 enemytank)
        {
            Random rnd = new Random();
            int comp_i = rnd.Next(1, 5), comp_j = rnd.Next(1, 5);
            if (enemytank.Penetr > TankArm[comp_i, comp_j])
            {
                Health -= enemytank.Dmg;
                return $"Oponent penetrated you at index [{comp_i} , {comp_j}], where your armor was: {TankArm[comp_i, comp_j]}, and Op's penetration was {enemytank.Penetr} ";
            }
            else
            {
                return $"Oponent DIDN'T penetrated you at index [{comp_i} , {comp_j}], where your armor was: {TankArm[comp_i, comp_j]} , and Op's penetration was {enemytank.Penetr} ";
            }


        }
    }
}
