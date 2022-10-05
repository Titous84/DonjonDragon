namespace DonjonDragon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            statsPersonnages();
        }

        static void statsPersonnages()
        {
            Random rng = new Random();

            int guerrierAtt = rng.Next(14, 19);
            int guerrierHP = 30;
            int guerrierDef = 18;
            int guerrierDeDmg = 8;
            int guerrierBonusDmg = 2;
            int guerrierInitiative = 0;
            int guerrierDmg = 0;

            int orcAtt = rng.Next(10, 19);
            int orcHP = 30;
            int orcDef = 14;
            int orcDeDmg = 10;
            int orcBonusDmg = 2;
            int orcInitiative = 0;
            int orcDmg = 0;

            guerrierBonusDmg = guerrierBonusDmg + (guerrierAtt - 9) / 2;
            orcBonusDmg = orcBonusDmg + (orcAtt - 9) / 2;

            Console.WriteLine("Stats pour guerrier : ");
            Console.WriteLine("Hp : " + guerrierHP);
            Console.WriteLine("Att : " + guerrierAtt);
            Console.WriteLine("Def : " + guerrierDef);
            Console.WriteLine("Dé de dommage : " + guerrierDeDmg);
            Console.WriteLine("Bonus dommage : " + guerrierBonusDmg);

            Console.WriteLine("Stats pour l'orc : ");
            Console.WriteLine("Hp : " + orcHP);
            Console.WriteLine("Att : " + orcAtt);
            Console.WriteLine("Def : " + orcDef);
            Console.WriteLine("Dé de dommage : " + orcDeDmg);
            Console.WriteLine("Bonus dommage : " + orcBonusDmg);

            guerrierInitiative = rng.Next(1, 21);
            orcInitiative = rng.Next(1, 21);
            bool mort = false;

            while (guerrierHP >= 0 && orcHP >= 0)
            {

                // Humain premier
                if (guerrierInitiative >= orcInitiative)
                {
                    Console.WriteLine("Le guerrier attaque");

                    if (rng.Next(1, 21) >= orcDef)
                    {
                        guerrierDmg = rng.Next(1, guerrierDeDmg + 1) + guerrierBonusDmg;
                        Console.WriteLine("Le guerrier fait " + guerrierDmg + "de dégâts à l'orc.");
                        orcHP = orcHP - guerrierDmg;
                        Console.WriteLine("Il reste " + orcHP + "points de vie à l'orc");
                    }
                    else
                    {
                        Console.WriteLine("Le guerrier ne fait pas assez de dégâts pour blesser l'orc");
                    }

                    // L'orc attaque

                    if ((rng.Next(1, 21) + 2) >= guerrierDef)
                    {
                        orcBonusDmg = rng.Next(1, orcDeDmg + 1) + orcBonusDmg;
                        Console.WriteLine("L'orc touche pour " + orcBonusDmg + "pts de dommages");
                        guerrierHP = guerrierHP - orcBonusDmg;
                        Console.WriteLine("Il reste " + guerrierHP + "points de vie à l'humain");
                    }
                    else
                    {
                        Console.WriteLine("L'orc rate !");
                    }
                }

                else
                {
                    Console.WriteLine("L'Orc attaque en Premier !");
                    // ici toucher et dmg en premier
                    if ((rng.Next(1, 21) + 2) >= guerrierDef)
                    {
                        orcBonusDmg = rng.Next(1, orcDeDmg + 1) + orcBonusDmg;
                        Console.WriteLine("L'orc touche pour " + orcBonusDmg + "pts de dommages");
                        guerrierHP = guerrierHP - orcBonusDmg;
                        Console.WriteLine("Il reste " + guerrierHP + "points de vie à l'humain");
                    }
                    else
                    {
                        Console.WriteLine("L'orc rate !");
                    }
                    // attaque du guerrier
                    if (rng.Next(1, 21) >= orcDef)
                    {
                        guerrierDmg = rng.Next(1, guerrierDeDmg + 1) + guerrierBonusDmg;
                        Console.WriteLine("Guerrier touche pour " + guerrierDmg + "pts de dommages.");
                        orcHP = orcHP - guerrierDmg;
                        Console.WriteLine("Il reste " + orcHP + "points de vie à l'orc");
                    }
                    else
                    {
                        Console.WriteLine("Le guerrier rate !");
                    }
                }
                mort = true;
            }
        }
        
    }
}