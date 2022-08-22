using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static int DemanderNombre(int min, int max)
        {
            int nombreUtilisateur = min -1;

            while ((nombreUtilisateur < min) || (nombreUtilisateur > max))
            {
                Console.Write("Rentrez un nombre entre " + min + " et " + max + " : " );
                string response = Console.ReadLine();

                try
                {
                    nombreUtilisateur = int.Parse(response);

                    if ((nombreUtilisateur < min) || (nombreUtilisateur > max))
                    {
                        Console.WriteLine("ERREUR : le nombre doit être entre " + min + " et " + max);
                    }


                }
                catch (Exception)
                {

                    Console.WriteLine("Erreur : vous devez rentrez un age valide.");
                }
            }
            return nombreUtilisateur;
        }


        static void Main(string[] args)
        {
            Random rand = new Random();
            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            int NOMBRE_MAGIQUE = rand.Next(NOMBRE_MIN, NOMBRE_MAX + 1);

            int nombre = NOMBRE_MAGIQUE+1;

            int nbVies = 4;

            while (nbVies > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Vies restantes : " + nbVies);
                nombre =  DemanderNombre(NOMBRE_MIN, NOMBRE_MAX);

                if (NOMBRE_MAGIQUE < nombre)
                {
                    Console.WriteLine("le nombre magique est plus petit");
                }
                else if (NOMBRE_MAGIQUE > nombre)
                {
                    Console.WriteLine("le nombre magique est plus grand");
                }
                else
                {
                    break;
                }
                nbVies--;


            }

            if (nombre == NOMBRE_MAGIQUE)
            {
                Console.WriteLine("Bravo , vous avez trouvé le nombre magique");

            }
            else
            {
                Console.WriteLine("Vous avez perdu, le nombre magique était : " + NOMBRE_MAGIQUE);
            }


        }
    }
}