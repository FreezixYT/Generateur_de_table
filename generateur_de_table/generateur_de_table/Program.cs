namespace generateur_de_table
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //fonction 
            int nombre1 = 0;
            int nombre2 = 0;
            int multipleMin = 0;
            int multipleMax = 0;


            Console.WriteLine("Combien de table voulez vous genere ?");
            int nbTable = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrer la table minimum");
            multipleMin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrer la table maximum");
            multipleMax = Convert.ToInt32(Console.ReadLine());

            Separation();
            Console.WriteLine("Voici une liste de " + nbTable + " Tables");
            Separation();

            for (int i = 0; i < nbTable; i++)
            {
                //generateur
                Random rndm = new Random();
                nombre1 = rndm.Next(multipleMin , multipleMax + 1);

                Random rndm2 = new Random();
                nombre2 = rndm.Next(multipleMin, multipleMax + 1);


                Console.Write(nombre1);
                Console.Write(" X ");
                Console.Write(nombre2);
                
                Console.Write(" = ");
                Console.WriteLine(Calcule(nombre1, nombre2));
            }
            Separation();
            Console.WriteLine("Merci d'avoir utiliser Generateur de table !!!");


        }

        static void Separation()
        {
            Console.WriteLine("----------------------");
        }

        static int Calcule(int nombre1 , int nombre2)
        {
            return nombre1 * nombre2;
        }


}
}
