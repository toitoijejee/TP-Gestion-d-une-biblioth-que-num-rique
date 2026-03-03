using System;
using System.Collections.Generic;

namespace BibliothequeNumerique
{
    struct Livre
    {
        public string Titre;
        public string Auteur;
        public int Annee;
        public int Pages;
        public bool EstDisponible;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Livre livre1;
            livre1.Titre = "Le Petit Prince";
            livre1.Auteur = "Antoine de Saint-Exupéry";
            livre1.Annee = 1943;
            livre1.Pages = 96;
            livre1.EstDisponible = true;

            Livre livre2;
            livre2.Titre = "Harry Potter à l'école des sorciers";
            livre2.Auteur = "J.K. Rowling";
            livre2.Annee = 1997;
            livre2.Pages = 309;
            livre2.EstDisponible = true;

            Livre livre3;
            livre3.Titre = "L'Étranger";
            livre3.Auteur = "Albert Camus";
            livre3.Annee = 1942;
            livre3.Pages = 123;
            livre3.EstDisponible = false;

            Console.WriteLine(livre1.Titre + " - " + livre1.Auteur + " - " + livre1.Annee);
            Console.WriteLine(livre2.Titre + " - " + livre2.Auteur + " - " + livre2.Annee);
            Console.WriteLine(livre3.Titre + " - " + livre3.Auteur + " - " + livre3.Annee);

            List<Livre> bibliotheque = new List<Livre>();
            bibliotheque.Add(livre1);
            bibliotheque.Add(livre2);
            bibliotheque.Add(livre3);

            Console.WriteLine("\nTous les livres de la bibliothèque :");
            foreach (var livre in bibliotheque)
            {
                Console.WriteLine(livre.Titre + " - " + livre.Auteur + " - " + livre.Annee + " - " + livre.Pages + " pages - " + (livre.EstDisponible ? "Disponible" : "Indisponible"));
            }

            Console.WriteLine("\nLivres disponibles :");
            foreach (var livre in bibliotheque)
            {
                if (livre.EstDisponible)
                    Console.WriteLine(livre.Titre + " - " + livre.Auteur);
            }

            Console.WriteLine("\nLivres avec plus de 300 pages :");
            foreach (var livre in bibliotheque)
            {
                if (livre.Pages > 300)
                    Console.WriteLine(livre.Titre + " - " + livre.Pages + " pages");
            }

            Console.WriteLine("\nLivres publiés après 2000 :");
            foreach (var livre in bibliotheque)
            {
                if (livre.Annee > 2000)
                    Console.WriteLine(livre.Titre + " - " + livre.Annee);
            }

            int totalPages = 0;
            int nbDisponibles = 0;
            foreach (var livre in bibliotheque)
            {
                totalPages += livre.Pages;
                if (livre.EstDisponible) nbDisponibles++;
            }
            Console.WriteLine("\nNombre total de pages : " + totalPages);
            Console.WriteLine("Nombre de livres disponibles : " + nbDisponibles);

            Console.WriteLine("\nEntrez le titre du livre à rechercher :");
            string titreRecherche = Console.ReadLine();
            bool trouve = false;
            foreach (var livre in bibliotheque)
            {
                if (livre.Titre.Equals(titreRecherche, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Trouvé : " + livre.Titre + " - " + livre.Auteur + " - " + (livre.EstDisponible ? "Disponible" : "Indisponible"));
                    trouve = true;
                    break;
                }
            }
            if (!trouve)
                Console.WriteLine("Livre introuvable");

            Console.WriteLine("\nEntrez le titre du livre à emprunter :");
            string titreEmprunt = Console.ReadLine();
            bool empruntValide = false;
            for (int i = 0; i < bibliotheque.Count; i++)
            {
                if (bibliotheque[i].Titre.Equals(titreEmprunt, StringComparison.OrdinalIgnoreCase))
                {
                    if (bibliotheque[i].EstDisponible)
                    {
                        Livre l = bibliotheque[i];
                        l.EstDisponible = false;
                        bibliotheque[i] = l;
                        Console.WriteLine("Emprunt validé");
                        empruntValide = true;
                    }
                    else
                    {
                        Console.WriteLine("Emprunt impossible : livre indisponible");
                        empruntValide = true;
                    }
                    break;
                }
            }
            if (!empruntValide)
                Console.WriteLine("Emprunt impossible : livre introuvable");
        }
    }
}
