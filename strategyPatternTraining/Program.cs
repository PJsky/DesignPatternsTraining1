using System;

namespace strategyPatternTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            ICharacter Bob = new Character("Bob");
            Bob.Shield = new Buckler();
            Bob.Armor = new LeatherArmor();
            Bob.Weapon = new Mace();
            ICharacter Mark = new Character("Mark");
            Mark.Weapon = new Axe();
            Mark.Shield = new TowerShield();
            Mark.Armor = new PlateArmor();
            int playerTurn = 1;
            while(Mark.IsAlive() && Bob.IsAlive()){
                if(playerTurn == 1)
                    Mark.ExecuteAttack(Bob);
                else
                    Bob.ExecuteAttack(Mark);
                playerTurn = playerTurn == 1 ? 2 : 1; 
            }
            if(Mark.IsAlive()) System.Console.WriteLine("Mark won");
            else System.Console.WriteLine("Bob won");
        }
    }
}
