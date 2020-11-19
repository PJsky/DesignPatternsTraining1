using System;

namespace strategyPatternTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Character Bob = new Character("Bob");
            Bob.Shield = new Buckler();
            Bob.Armor = new LeatherArmor();
            Bob.Weapon = new Mace();
            Character Mark = new Character("Mark");
            Mark.Weapon = new Axe();
            Mark.Shield = new TowerShield();
            Mark.Armor = new PlateArmor();
            int playerTurn = 1;
            while(Mark.Hp>0 && Bob.Hp>0){
                if(playerTurn == 1)
                    Mark.ExecuteAttack(Bob);
                else
                    Bob.ExecuteAttack(Mark);
                playerTurn = playerTurn == 1 ? 2 : 1; 
            }
            if(Mark.Hp > 0) System.Console.WriteLine("Mark won");
            else System.Console.WriteLine("Bob won");
        }
    }
}
