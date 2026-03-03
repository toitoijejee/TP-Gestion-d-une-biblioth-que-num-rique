using System;
using System.Collections.Generic;

// Partie 1 – Créer la structure Livre
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
    static void Main()
    {
        Livre livre1 = new Livre
        {
            Titre = "Le Petit Prince",
            Auteur = "Antoine de Saint-Exupéry",
            Annee = 1943,
            Pages = 96,
            EstDisponible = true
        };

        Livre livre2 = new Livre
        {
            Titre = "1984",
            Auteur = "George Orwell",
            Annee = 1949,
            Pages = 328,
            EstDisponible = false
        };

        Livre livre3 = new Livre
        {
            Titre = "Le Seigneur des Anneaux",
            Auteur = "J.R.R. Tolkien",
            Annee = 1954,
            Pages = 1178,
            EstDisponible = true
        };

        Console.WriteLine("--- Partie 1 : Affichage des 3 livres ---");
        AfficherLivre(livre1);
        AfficherLivre(livre2);
        AfficherLivre(livre3);

        List<Livre> bibliotheque = new List<Livre>();
        bibliotheque.Add(livre1);
        bibliotheque.Add(livre2);
        bibliotheque.Add(livre3);

        Console.WriteLine("\n--- Partie 2 : Parcours de la bibliothèque ---");
        foreach (var livre in bibliotheque)
        {
            AfficherLivre(livre);
        }

        Console.WriteLine("-- Partie 3 : Livres disponibles ---");
        foreach (var livre in bibliotheque)
        {
            if (livre.EstDisponible)
                AfficherLivre(livre);
        }

        Console.WriteLine("- Partie 3 : Livres de plus de 300 pages ---");
        foreach (var livre in bibliotheque)
        {
            if (livre.Pages > 300)
                AfficherLivre(livre);
        }

        Console.WriteLine("-- Partie 3 : Livres publiés après 2000 ---");
        foreach (var livre in bibliotheque)
        {
            if (livre.Annee > 2000)
                AfficherLivre(livre);
        }
    }

    static void AfficherLivre(Livre livre)
    {
        Console.WriteLine($"Titre: {livre.Titre}, Auteur: {livre.Auteur}, Année: {livre.Annee}, Pages: {livre.Pages}, Disponible: {livre.EstDisponible}");
    }
}


