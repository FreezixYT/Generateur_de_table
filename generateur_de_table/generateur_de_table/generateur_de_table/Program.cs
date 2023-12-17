namespace generateur_de_table
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //fonction 
            int nombre1 = 0;
            int nombre2 = 0;



            Console.WriteLine("Combien de table voulez vous genere ?");
            int nbTable = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Voici une liste de " + nbTable + " Tables");

            for (int i = 0; i < nbTable; i++)
            {
                //generateur
                Random rndm = new Random();
                nombre1 = rndm.Next(12);

                Random rndm2 = new Random();
                nombre2 = rndm.Next(12);

               
                Console.Write(nombre1);
                Console.Write(" X ");
                Console.Write(nombre2);
                Console.WriteLine();
            }

            Console.WriteLine("Merci d'avoir utiliser Generateur de table !!!");


        }


    }
}