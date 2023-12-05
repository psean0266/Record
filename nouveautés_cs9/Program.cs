using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace nouveautés_cs9
{

    struct PersonneStruct
    {
        public string nom { get; set; }
        public int age { get; set; }

        public void Afficher()
        {
            Console.WriteLine("Nom: " + nom + " - Age: " + age + "ans");
        }
    }

    record PersonneRecord
    {
        public string nom { get; set; }
        public int age { get; set; }

        public void Afficher()
        {
            Console.WriteLine("Nom: " + nom + " - Age: " + age + "ans");
        }
    }

    class PersonneClass
    {
        public string nom { get; set ; }
        public int age { get; set; }

        public void Afficher()
        {
            Console.WriteLine("Nom: "+nom+ " - Age: "+ age + "ans");
        }

        //public override bool Equals(object obj)
        //{
        //    PersonneClass ObjetAcomparer  =(PersonneClass)obj;
        //    if((nom == ObjetAcomparer.nom)&&(age == ObjetAcomparer.age )) return true;

        //    return false;
        //    //return base.Equals(obj);
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            b = a;
            a = 6;

            Console.WriteLine("a = "+ a);
            Console.WriteLine("b = "+b);

            Console.WriteLine("<-----------------------------------------------------AVEC Class---------------------------------------------------->");

            var personne1 = new PersonneClass() { nom = "toto",  age = 20 };
            var personne2 = new PersonneClass() { nom = "toto", age = 20 };

            //    var personne2= personne1;

        //    personne1.nom = "tata";

            personne1.Afficher();
            personne2.Afficher();

            Console.WriteLine(" Class : " + personne1.Equals(personne2));

            Console.WriteLine();

            Console.WriteLine("<-----------------------------------------------------AVEC STRUCT---------------------------------------------------->");

            var personne3 = new PersonneStruct() { nom = "toto", age = 20 };

            var personne4 = personne3;

            personne3.nom = "tata";

            personne3.Afficher();
            personne4.Afficher();

            Console.WriteLine(" Struct : " + personne3.Equals(personne4));

            Console.WriteLine("<-----------------------------------------------------AVEC Record---------------------------------------------------->");

            var personne5 = new PersonneRecord() { nom = "toto", age = 20 };
            var personne6 = new PersonneRecord() { nom = "toto", age = 20 };

            personne6 = personne5 with { };

            personne6 = personne5;

           // personne6 = personne5 with {  }; // Cloner sans référence
      //      personne6 = personne5 with { nom = "Tata" }; // cloner et ajouter une valeur

        //    personne5.nom = "Tata";

            personne5.Afficher();
            personne6.Afficher();

            Console.WriteLine(" Record : " + personne5.Equals(personne6));

            Console.WriteLine( personne5 == personne6);  // ça test le contenu d'objet


            /* Types simples (int , float, char...) -> Value Type (valeur)
             * structures -> Value Type ( valeur = les valeurs des champs)
             * class -> Reference Type ( valeur = adresse de l'objet)
             * List<string> Reference Type(valeur = adresse de l'objet)
             * 
             * avec Struct on peut comparer avec les valeurs mais avec la class c'est impossible car la class marche par référence
             * Class: Quand on Override la fonction Equal intégré on peut modiffier pour ne plus utiliser la comparaison par référence
             * La class n'est pas fait pour tester l'égalité des champs
             */

            //Console.WriteLine("Hello World!");

            //foreach(var arg in args)
            //{
            //    Console.WriteLine(arg);
            //}


        }
    }
}
