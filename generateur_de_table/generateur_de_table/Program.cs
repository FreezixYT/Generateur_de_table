namespace generateur_de_table
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //fonction 
            int nombre = 0;



            Console.WriteLine("Combien de table voulez vous genere ?");
            int nbTable = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nbTable; i++)
            {
                //generateur
                Random rndm = new Random();
                nombre = rndm.Next(12);
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Voici une liste de " + nbTable + " Tables");
                Console.Write(nombre);
                Console.Write(" X ");
                Console.Write(nombre);
                Console.WriteLine();
            }

            Console.WriteLine("merci d'avoir utiliser Generateur de table !!!");


        }


    }
}