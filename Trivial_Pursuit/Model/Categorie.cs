using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trivial_Pursuit.Model;

namespace Trivial_Pursuit.Model
{
    public class Categorie
    {
        private string Titre;
        private Color Couleur;
        private List<Questions> Questions = new List<Questions>();

        private static Categorie CatGeographie = new Model.Categorie("Géographie", Color.Blue);
        private static Categorie CatHistoire = new Model.Categorie("Histoire", Color.Yellow);
        private static Categorie CatDivertissement = new Model.Categorie("Divertissemeent", Color.Pink);
        private static Categorie CatSport = new Model.Categorie("Sport", Color.Orange);
        private static Categorie CatArtLitterature = new Model.Categorie("Art et Litterature", Color.Maroon);
        private static Categorie CatScienceNature = new Model.Categorie("Science et Nature", Color.Green);

        public void GenerateQuestions()
        {

            CatGeographie.AjouterQuestion(new Model.QO("Quelle est la capitale de la France?", "Paris"));
            CatGeographie.AjouterQuestion(new Model.QCM("Quel est le plus gran desert au monde ?", "Sahara", "Sahara", "Gobie", "Artique"));
            CatGeographie.AjouterQuestion(new Model.QO("Quel pays a la plus grande superficie ?", "Russie"));
            CatGeographie.AjouterQuestion(new Model.QCM("Quelle riviere traverse Londres ?", "La Tamise", "La Seine", "La Tamise", "La Liane"));

            CatHistoire.AjouterQuestion(new Model.QO("Quel est le nom du roi de France qui a régné pendant la Révolution française ?", "Louis XVI"));
            CatHistoire.AjouterQuestion(new Model.QO("En quelle année a eu lieu la chute du mur de Berlin ?", "1989"));
            CatHistoire.AjouterQuestion(new Model.QO("Quel empire a été dirigé par Jules César ?", "Romain"));
            CatHistoire.AjouterQuestion(new Model.QO("Qui était le général célèbre pendant la guerre de Cent Ans ?", "Jeanne d'Arc"));
            CatHistoire.AjouterQuestion(new Model.QO("Qui a découvert l'Amérique en 1492 ?", "Colomb"));
            CatHistoire.AjouterQuestion(new Model.QO("Quel est le nom du célèbre dictateur italien pendant la Seconde Guerre mondiale ?", "Mussolini"));
            CatHistoire.AjouterQuestion(new Model.QO("Quel était le nom du premier président des États-Unis ?", "Washington"));
            CatHistoire.AjouterQuestion(new Model.QO("Dans quel pays s'est déroulée la bataille de Waterloo en 1815 ?", "Belgique"));
            CatHistoire.AjouterQuestion(new Model.QO("Quel était le nom de la déesse grecque de la sagesse ?", "Athéna"));
            CatHistoire.AjouterQuestion(new Model.QO("Quel pharaon égyptien est célèbre pour sa tombe intacte découverte en 1922 ?", "Toutankhamon"));
            CatHistoire.AjouterQuestion(new Model.QO("Quel est le nom du traité signé en 1919 mettant fin à la Première Guerre mondiale ?", "Versailles"));
            CatHistoire.AjouterQuestion(new Model.QO("En quelle année a eu lieu la Révolution française ?", "1789"));
            CatHistoire.AjouterQuestion(new Model.QO("Quel général français a conduit les armées de la France pendant la Première Guerre mondiale ?", "Pétain"));
            CatHistoire.AjouterQuestion(new Model.QO("Dans quelle ville a eu lieu le procès de Nuremberg après la Seconde Guerre mondiale ?", "Nuremberg"));
            CatHistoire.AjouterQuestion(new Model.QO("Qui a été le leader du mouvement des droits civiques aux États-Unis dans les années 1960 ?", "King"));
            CatHistoire.AjouterQuestion(new Model.QO("Quel était le nom du dernier tsar de Russie ?", "Nicolas II"));
            CatHistoire.AjouterQuestion(new Model.QO("Quel est le nom du dirigeant chinois qui a fondé la République populaire de Chine ?", "Mao"));
            CatHistoire.AjouterQuestion(new Model.QO("Quel est le nom du plus grand empire de l'histoire en termes de superficie ?", "Empire britannique"));
            CatHistoire.AjouterQuestion(new Model.QO("Quel roi d'Angleterre est célèbre pour avoir six épouses ?", "Henri VIII"));
            CatHistoire.AjouterQuestion(new Model.QO("Quel événement historique a eu lieu le 6 juin 1944 ?", "Débarquement"));

            CatHistoire.AjouterQuestion(new Model.QCM("Qui a écrit Les Misérables ?", "Hugo", "Balzac", "Zola", "Hugo"));
            CatHistoire.AjouterQuestion(new Model.QCM("Quel pays a été le principal acteur de la guerre de Sécession ?", "États-Unis", "France", "Allemagne", "États-Unis"));
            CatHistoire.AjouterQuestion(new Model.QCM("Qui était le principal adversaire de Napoléon Bonaparte lors de la bataille de Waterloo ?", "Wellington", "Nelson", "Joffre", "Wellington"));
            CatHistoire.AjouterQuestion(new Model.QCM("Quel événement a marqué la fin de la Seconde Guerre mondiale en Europe ?", "Capitulation de l'Allemagne", "Bataille de Stalingrad", "Bombardement de Hiroshima", "Capitulation de l'Allemagne"));
            CatHistoire.AjouterQuestion(new Model.QCM("Quel empereur romain a adopté le christianisme ?", "Constantin", "Néron", "Augustus", "Constantin"));
            CatHistoire.AjouterQuestion(new Model.QCM("Qui a fondé la dynastie des Mérovingiens en France ?", "Clovis", "Charlemagne", "Hugues Capet", "Clovis"));
            CatHistoire.AjouterQuestion(new Model.QCM("Quel grand philosophe grec est l'auteur de La République ?", "Platon", "Aristote", "Socrate", "Platon"));
            CatHistoire.AjouterQuestion(new Model.QCM("En quelle année a eu lieu l'assassinat de l'archiduc François-Ferdinand ?", "1914", "1912", "1916", "1914"));
            CatHistoire.AjouterQuestion(new Model.QCM("Quel était le nom de l'armée allemande pendant la Seconde Guerre mondiale ?", "Wehrmacht", "Luftwaffe", "SS", "Wehrmacht"));
            CatHistoire.AjouterQuestion(new Model.QCM("Quel roi de France a été surnommé le Roi Soleil ?", "Louis XIV", "Louis XIII", "Louis XVI", "Louis XIV"));
            CatHistoire.AjouterQuestion(new Model.QCM("Quel événement a provoqué la Première Guerre mondiale ?", "L'assassinat de François-Ferdinand", "La révolution russe", "Le traité de Versailles", "L'assassinat de François-Ferdinand"));
            CatHistoire.AjouterQuestion(new Model.QCM("Quel est le nom du bateau qui a coulé lors de son voyage inaugural en 1912 ?", "Titanic", "Lusitania", "Mayflower", "Titanic"));
            CatHistoire.AjouterQuestion(new Model.QCM("Qui était le leader soviétique pendant la guerre froide ?", "Staline", "Trotsky", "Khrushchev", "Staline"));
            CatHistoire.AjouterQuestion(new Model.QCM("Quel empire a dirigé la Chine avant la fondation de la République populaire de Chine ?", "Empire Qing", "Empire Ming", "Empire Han", "Empire Qing"));
            CatHistoire.AjouterQuestion(new Model.QCM("Qui était le dernier président de la République de Weimar ?", "Hindenburg", "Ludendorff", "Hitler", "Hindenburg"));
            CatHistoire.AjouterQuestion(new Model.QCM("Quel général est célèbre pour avoir traversé les Alpes pendant la Seconde Guerre punique ?", "Hannibal", "Jules César", "Scipion l'Africain", "Hannibal"));
            CatHistoire.AjouterQuestion(new Model.QCM("Quel était le nom du premier satellite lancé par l'URSS en 1957 ?", "Sputnik", "Apollo", "Vostok", "Sputnik"));
            CatHistoire.AjouterQuestion(new Model.QCM("Quel roi d'Angleterre est célèbre pour avoir fondé l'Église anglicane ?", "Henri VIII", "Édouard VI", "Charles Ier", "Henri VIII"));
            CatHistoire.AjouterQuestion(new Model.QCM("Quel événement historique a eu lieu le 11 septembre 2001 ?", "Les attentats à New York", "La guerre du Vietnam", "Le traité de paix de Paris", "Les attentats à New York"));
            CatHistoire.AjouterQuestion(new Model.QCM("Qui était le dernier pharaon de l'Égypte ancienne ?", "Cléopâtre", "Nefertiti", "Ramsès II", "Cléopâtre"));

            CatGeographie.AjouterQuestion(new Model.QO("Quelle est la capitale du Japon ?", "Tokyo"));
            CatGeographie.AjouterQuestion(new Model.QO("Quel est le plus grand océan du monde ?", "Pacifique"));
            CatGeographie.AjouterQuestion(new Model.QO("Quel est le plus grand désert du monde ?", "Sahara"));
            CatGeographie.AjouterQuestion(new Model.QO("Quel est le plus long fleuve du monde ?", "Nil"));
            CatGeographie.AjouterQuestion(new Model.QO("Dans quel pays se trouve la montagne Everest ?", "Népal"));
            CatGeographie.AjouterQuestion(new Model.QO("Quel est le pays le plus vaste du monde ?", "Russie"));
            CatGeographie.AjouterQuestion(new Model.QO("Quel est le plus grand lac d'eau douce du monde ?", "Lac Baïkal"));
            CatGeographie.AjouterQuestion(new Model.QO("Quelle mer sépare l'Italie de la Grèce ?", "Mer Ionienne"));
            CatGeographie.AjouterQuestion(new Model.QO("Quelle est la capitale de l’Australie ?", "Canberra"));
            CatGeographie.AjouterQuestion(new Model.QO("Dans quel océan se trouve l’île de Madagascar ?", "Océan Indien"));
            CatGeographie.AjouterQuestion(new Model.QO("Quel est le plus grand pays d'Afrique ?", "Algérie"));
            CatGeographie.AjouterQuestion(new Model.QO("Quel est le nom de la capitale de la France ?", "Paris"));
            CatGeographie.AjouterQuestion(new Model.QO("Quel pays est traversé par le fleuve Amazone ?", "Brésil"));
            CatGeographie.AjouterQuestion(new Model.QO("Quelle est la plus grande ville des États-Unis ?", "New York"));
            CatGeographie.AjouterQuestion(new Model.QO("Quel pays est le plus peuplé au monde ?", "Chine"));
            CatGeographie.AjouterQuestion(new Model.QO("Quel est le plus petit pays du monde ?", "Vatican"));
            CatGeographie.AjouterQuestion(new Model.QO("Quel océan borde la côte ouest des États-Unis ?", "Pacifique"));
            CatGeographie.AjouterQuestion(new Model.QO("Quel est le pays d'origine de la ville de Marrakech ?", "Maroc"));
            CatGeographie.AjouterQuestion(new Model.QO("Dans quel continent se trouve le pays du Chili ?", "Amérique du Sud"));
            CatGeographie.AjouterQuestion(new Model.QO("Quel est le pays situé à l’est de la Chine ?", "Japon"));
            CatGeographie.AjouterQuestion(new Model.QCM("Quelle est la capitale de l'Italie ?", "Rome", "Florence", "Milan", "Rome"));
            CatGeographie.AjouterQuestion(new Model.QCM("Quel pays est bordé par la mer Méditerranée à l’ouest et la mer Noire au nord ?", "Turquie", "Grèce", "Égypte", "Turquie"));
            CatGeographie.AjouterQuestion(new Model.QCM("Quel est le plus grand désert du monde après le Sahara ?", "Désert de Gobi", "Désert d'Atacama", "Désert de Kalahari", "Désert de Gobi"));
            CatGeographie.AjouterQuestion(new Model.QCM("Quel pays a une frontière terrestre avec la Chine et l’Inde ?", "Pakistan", "Vietnam", "Bangladesh", "Pakistan"));
            CatGeographie.AjouterQuestion(new Model.QCM("Quel est le plus grand pays d’Amérique du Sud ?", "Brésil", "Argentine", "Colombie", "Brésil"));
            CatGeographie.AjouterQuestion(new Model.QCM("Quel océan borde la côte est des États-Unis ?", "Océan Atlantique", "Océan Pacifique", "Océan Indien", "Océan Atlantique"));
            CatGeographie.AjouterQuestion(new Model.QCM("Quel est le plus grand archipel du monde ?", "Indonésie", "Philippines", "Maldives", "Indonésie"));
            CatGeographie.AjouterQuestion(new Model.QCM("Quel pays possède le plus grand nombre d’îles au monde ?", "Suède", "Grèce", "Canada", "Suède"));
            CatGeographie.AjouterQuestion(new Model.QCM("Dans quel pays se trouve la ville de Rio de Janeiro ?", "Brésil", "Argentine", "Chili", "Brésil"));
            CatGeographie.AjouterQuestion(new Model.QCM("Quel est le plus petit continent en termes de superficie ?", "Océanie", "Europe", "Afrique", "Océanie"));
            CatGeographie.AjouterQuestion(new Model.QCM("Quel est le plus grand pays d’Afrique de l’Est ?", "Éthiopie", "Kenya", "Tanzanie", "Éthiopie"));
            CatGeographie.AjouterQuestion(new Model.QCM("Quel est le pays le plus élevé en moyenne par rapport au niveau de la mer ?", "Bolivie", "Nepal", "Bhoutan", "Bolivie"));
            CatGeographie.AjouterQuestion(new Model.QCM("Quel est le plus long fleuve d'Amérique du Sud ?", "Amazonie", "Paraguay", "Orénoque", "Amazonie"));
            CatGeographie.AjouterQuestion(new Model.QCM("Quelle île est la plus grande en Méditerranée ?", "Sicile", "Crète", "Chypre", "Sicile"));
            CatGeographie.AjouterQuestion(new Model.QCM("Quel est le pays qui contient le plus de volcans actifs ?", "Indonésie", "Japon", "Italie", "Indonésie"));
            CatGeographie.AjouterQuestion(new Model.QCM("Quel est le plus grand pays d’Asie de l’Ouest ?", "Arabie Saoudite", "Iran", "Irak", "Iran"));
            CatGeographie.AjouterQuestion(new Model.QCM("Quel pays est traversé par le méridien de Greenwich ?", "Royaume-Uni", "France", "Espagne", "Royaume-Uni"));
            CatGeographie.AjouterQuestion(new Model.QCM("Dans quel océan se trouve l'île de Cuba ?", "Océan Atlantique", "Océan Indien", "Océan Pacifique", "Océan Atlantique"));
            CatGeographie.AjouterQuestion(new Model.QCM("Quel pays possède l'archipel des Maldives ?", "Maldives", "Seychelles", "Maurice", "Maldives"));
            CatGeographie.AjouterQuestion(new Model.QCM("Quel est le plus grand pays en Europe ?", "Russie", "Ukraine", "France", "Russie"));

            CatDivertissement.AjouterQuestion(new Model.QO("Quel est le nom du célèbre détective créé par Arthur Conan Doyle ?", "Sherlock"));
            CatDivertissement.AjouterQuestion(new Model.QO("Quel acteur incarne Jack Dawson dans le film Titanic ?", "DiCaprio"));
            CatDivertissement.AjouterQuestion(new Model.QO("Dans quel jeu vidéo Mario apparaît-il pour la première fois ?", "Donkey Kong"));
            CatDivertissement.AjouterQuestion(new Model.QO("Quel est le nom du navire dans Pirates des Caraïbes ?", "Black Pearl"));
            CatDivertissement.AjouterQuestion(new Model.QO("Qui est le super-héros surnommé l'Homme-Araignée ?", "Spider-Man"));
            CatDivertissement.AjouterQuestion(new Model.QO("Dans quelle série télévisée peut-on retrouver un personnage nommé Eleven ?", "Stranger Things"));
            CatDivertissement.AjouterQuestion(new Model.QO("Quel est le nom du chien dans Les Simpson ?", "Petit Aider"));
            CatDivertissement.AjouterQuestion(new Model.QO("Quel groupe musical a chanté Bohemian Rhapsody ?", "Queen"));
            CatDivertissement.AjouterQuestion(new Model.QO("Qui a écrit Le Seigneur des Anneaux ?", "Tolkien"));
            CatDivertissement.AjouterQuestion(new Model.QO("Quel est le nom du robot dans Star Wars qui dit 'R2-D2' ?", "R2-D2"));
            CatDivertissement.AjouterQuestion(new Model.QO("Quel personnage principal de Batman est un milliardaire de Gotham City ?", "Bruce Wayne"));
            CatDivertissement.AjouterQuestion(new Model.QO("Quel est le prénom de l’agent secret dans la saga James Bond ?", "James"));
            CatDivertissement.AjouterQuestion(new Model.QO("Quel film a remporté l'Oscar du meilleur film en 1994 ?", "Forrest Gump"));
            CatDivertissement.AjouterQuestion(new Model.QO("Dans quel pays a été créé le jeu de société Monopoly ?", "États-Unis"));
            CatDivertissement.AjouterQuestion(new Model.QO("Dans quel film d'animation trouve-t-on un personnage nommé Elsa ?", "Frozen"));
            CatDivertissement.AjouterQuestion(new Model.QO("Qui a réalisé le film Inception ?", "Nolan"));
            CatDivertissement.AjouterQuestion(new Model.QO("Quel est le nom de l’univers fictif dans Harry Potter ?", "Poudlard"));
            CatDivertissement.AjouterQuestion(new Model.QO("Dans quelle série télévisée peut-on entendre la phrase 'Winter is coming' ?", "Game of Thrones"));

            CatDivertissement.AjouterQuestion(new Model.QCM("Quel est le nom du célèbre personnage de dessin animé qui porte des oreilles de souris ?", "Mickey Mouse", "Donald Duck", "Goofy", "Mickey Mouse"));
            CatDivertissement.AjouterQuestion(new Model.QCM("Quel est le prénom de l'acteur qui joue Iron Man dans l'univers Marvel ?", "Robert", "Chris", "Mark", "Robert"));
            CatDivertissement.AjouterQuestion(new Model.QCM("Dans quel film l’acteur Tom Hanks dit-il 'La vie, c’est comme une boîte de chocolats' ?", "Forrest Gump", "Cast Away", "Apollo 13", "Forrest Gump"));
            CatDivertissement.AjouterQuestion(new Model.QCM("Qui a joué le rôle de Hermione Granger dans Harry Potter ?", "Emma Watson", "Rupert Grint", "Daniel Radcliffe", "Emma Watson"));
            CatDivertissement.AjouterQuestion(new Model.QCM("Quel est le titre de la chanson interprétée par Whitney Houston pour le film The Bodyguard ?", "I Will Always Love You", "Greatest Love of All", "I Have Nothing", "I Will Always Love You"));
            CatDivertissement.AjouterQuestion(new Model.QCM("Quel est le nom de l'acteur qui interprète Thor dans les films Marvel ?", "Chris Hemsworth", "Chris Pratt", "Mark Ruffalo", "Chris Hemsworth"));
            CatDivertissement.AjouterQuestion(new Model.QCM("Dans quelle série peut-on entendre la phrase 'How you doin' ?'", "Friends", "The Office", "Parks and Recreation", "Friends"));
            CatDivertissement.AjouterQuestion(new Model.QCM("Dans quel film peut-on trouver les personnages de Woody et Buzz L’Éclair ?", "Toy Story", "Monsters, Inc.", "Cars", "Toy Story"));
            CatDivertissement.AjouterQuestion(new Model.QCM("Quel est le nom de la planète d'origine de Superman ?", "Kryptonite", "Vênus", "Krypton", "Krypton"));
            CatDivertissement.AjouterQuestion(new Model.QCM("Qui est le créateur de la série télévisée The Simpsons ?", "Matt Groening", "Seth MacFarlane", "Trey Parker", "Matt Groening"));
            CatDivertissement.AjouterQuestion(new Model.QCM("Quel est le nom de la ville où se déroule Breaking Bad ?", "Albuquerque", "Phoenix", "Los Angeles", "Albuquerque"));
            CatDivertissement.AjouterQuestion(new Model.QCM("Quel est le prénom de l'héroïne dans La Reine des Neiges ?", "Elsa", "Anna", "Ariel", "Elsa"));
            CatDivertissement.AjouterQuestion(new Model.QCM("Quel acteur joue le rôle de Jack dans Titanic ?", "Leonardo DiCaprio", "Johnny Depp", "Brad Pitt", "Leonardo DiCaprio"));
            CatDivertissement.AjouterQuestion(new Model.QCM("Dans quelle saga retrouve-t-on un personnage nommé Yoda ?", "Star Wars", "Star Trek", "The Matrix", "Star Wars"));
            CatDivertissement.AjouterQuestion(new Model.QCM("Quel film a pour personnage principal un ogre vert nommé Shrek ?", "Shrek", "Monstres et Cie", "Madagascar", "Shrek"));
            CatDivertissement.AjouterQuestion(new Model.QCM("Quel est le nom de la ville fictive dans Les Simpsons ?", "Springfield", "Sunnydale", "Mayberry", "Springfield"));
            CatDivertissement.AjouterQuestion(new Model.QCM("Quel groupe a chanté Yesterday ?", "The Beatles", "The Rolling Stones", "The Doors", "The Beatles"));
            CatDivertissement.AjouterQuestion(new Model.QCM("Quel film raconte l’histoire d’un homme qui se réveille tous les jours à une date différente ?", "Un jour sans fin", "50 First Dates", "Time Traveler's Wife", "Un jour sans fin"));
            CatDivertissement.AjouterQuestion(new Model.QCM("Dans quelle série télévisée peut-on voir un personnage nommé Dexter Morgan ?", "Dexter", "Breaking Bad", "True Detective", "Dexter"));
            CatDivertissement.AjouterQuestion(new Model.QCM("Dans quel film se trouve le personnage de 'Dory' ?", "Le Monde de Nemo", "Le Voyage de Chihiro", "Zootopia", "Le Monde de Nemo"));

            CatSport.AjouterQuestion(new Model.QO("Quel pays a remporté la Coupe du Monde de football 2018 ?", "France"));
            CatSport.AjouterQuestion(new Model.QO("Qui détient le record du monde du 100 mètres chez les hommes ?", "Bolt"));
            CatSport.AjouterQuestion(new Model.QO("Dans quel sport joue-t-on avec un ballon ovale ?", "Rugby"));
            CatSport.AjouterQuestion(new Model.QO("Quel joueur de tennis a remporté le plus de titres du Grand Chelem ?", "Federer"));
            CatSport.AjouterQuestion(new Model.QO("Quel est le sport national du Japon ?", "Sumo"));
            CatSport.AjouterQuestion(new Model.QO("Quel pays a remporté le plus de titres olympiques en gymnastique ?", "États-Unis"));
            CatSport.AjouterQuestion(new Model.QO("Quel club de football a remporté le plus de Ligue des champions ?", "Real Madrid"));
            CatSport.AjouterQuestion(new Model.QO("Quel est le prénom du célèbre boxeur surnommé 'The Greatest' ?", "Ali"));
            CatSport.AjouterQuestion(new Model.QO("Quel sport se pratique avec une raquette et une balle jaune ?", "Tennis"));
            CatSport.AjouterQuestion(new Model.QO("Quel joueur de basketball est surnommé 'King James' ?", "LeBron"));
            CatSport.AjouterQuestion(new Model.QO("Quel pays a remporté la Coupe du Monde de rugby 2019 ?", "Afrique du Sud"));
            CatSport.AjouterQuestion(new Model.QO("Quel est le nom de la compétition de football interclubs la plus prestigieuse en Europe ?", "Ligue des champions"));
            CatSport.AjouterQuestion(new Model.QO("Qui est considéré comme le meilleur joueur de football de tous les temps ?", "Pelé"));
            CatSport.AjouterQuestion(new Model.QO("Quel pays a remporté la Coupe du Monde féminine de football 2019 ?", "États-Unis"));
            CatSport.AjouterQuestion(new Model.QO("Quel est le sport qui se joue sur un terrain de sable avec des filets ?", "Volley-ball"));
            CatSport.AjouterQuestion(new Model.QO("Quel joueur de football a marqué le plus de buts en Coupe du Monde ?", "Müller"));
            CatSport.AjouterQuestion(new Model.QO("Dans quel sport court-on sur des anneaux de métal ?", "Gymnastique"));
            CatSport.AjouterQuestion(new Model.QO("Quel pays a organisé les Jeux Olympiques d'hiver en 2018 ?", "Corée du Sud"));
            CatSport.AjouterQuestion(new Model.QO("Quel joueur est surnommé 'La Machine' en football ?", "Lewandowski"));
            CatSport.AjouterQuestion(new Model.QO("Quel sport est pratiqué dans le cadre de la formule 1 ?", "Course automobile"));

            CatSport.AjouterQuestion(new Model.QCM("Qui est le meilleur buteur de l’histoire de la Ligue des champions ?", "Cristiano Ronaldo", "Lionel Messi", "Raúl", "Cristiano Ronaldo"));
            CatSport.AjouterQuestion(new Model.QCM("Dans quel sport Lionel Messi excelle-t-il ?", "Football", "Tennis", "Basketball", "Football"));
            CatSport.AjouterQuestion(new Model.QCM("Quel pays a remporté les derniers Jeux Olympiques d'été ?", "Japon", "Brésil", "États-Unis", "Japon"));
            CatSport.AjouterQuestion(new Model.QCM("Qui est l’entraîneur actuel du PSG  CatSport.AjouterQuestion(new Model.QCM(Paris Saint-Germain)); ?", "Mauricio Pochettino", "Thomas Tuchel", "Unai Emery", "Mauricio Pochettino"));
            CatSport.AjouterQuestion(new Model.QCM("Quelle équipe a remporté la Ligue des champions en 2020 ?", "Bayern Munich", "Liverpool", "Real Madrid", "Bayern Munich"));
            CatSport.AjouterQuestion(new Model.QCM("Quel athlète a remporté 8 médailles d'or aux JO de Pékin en 2008 ?", "Michael Phelps", "Usain Bolt", "Carl Lewis", "Michael Phelps"));
            CatSport.AjouterQuestion(new Model.QCM("Quel est le sport le plus pratiqué au monde ?", "Football", "Basketball", "Tennis", "Football"));
            CatSport.AjouterQuestion(new Model.QCM("Quel joueur de football a remporté le plus de Ballon d'Or ?", "Lionel Messi", "Cristiano Ronaldo", "Michel Platini", "Lionel Messi"));
            CatSport.AjouterQuestion(new Model.QCM("Qui a remporté la Coupe du Monde de football 2014 ?", "Allemagne", "Brésil", "Argentine", "Allemagne"));
            CatSport.AjouterQuestion(new Model.QCM("Dans quel sport le célèbre joueur Rafael Nadal excelle-t-il ?", "Tennis", "Football", "Basketball", "Tennis"));
            CatSport.AjouterQuestion(new Model.QCM("Quel pays a remporté la Coupe du Monde de football 1998 ?", "France", "Brésil", "Argentine", "France"));
            CatSport.AjouterQuestion(new Model.QCM("Quel sport est pratiqué sur un terrain de 100m de long et 50m de large ?", "Football", "Basketball", "Rugby", "Football"));
            CatSport.AjouterQuestion(new Model.QCM("Dans quelle compétition de football joue-t-on le Super Bowl ?", "NFL", "CFL", "AFL", "NFL"));
            CatSport.AjouterQuestion(new Model.QCM("Quel est le pays d'origine du hockey sur glace ?", "Canada", "Suède", "Finlande", "Canada"));
            CatSport.AjouterQuestion(new Model.QCM("Qui a remporté le Tour de France en 2019 ?", "Egan Bernal", "Chris Froome", "Bernard Hinault", "Egan Bernal"));
            CatSport.AjouterQuestion(new Model.QCM("Quel est le nombre de joueurs dans une équipe de rugby à XV ?", "15", "12", "10", "15"));
            CatSport.AjouterQuestion(new Model.QCM("Dans quel sport la compétition principale est appelée Wimbledon ?", "Tennis", "Football", "Cyclisme", "Tennis"));
            CatSport.AjouterQuestion(new Model.QCM("Quel est le plus grand tournoi de tennis sur terre battue ?", "Roland Garros", "Wimbledon", "US Open", "Roland Garros"));
            CatSport.AjouterQuestion(new Model.QCM("Quel est le nom de l'attaquant brésilien qui a joué au PSG et au FC Barcelone ?", "Neymar", "Kaká", "Ronaldo", "Neymar"));
            CatSport.AjouterQuestion(new Model.QCM("Quel pays a remporté le plus de Coupes du Monde de football ?", "Brésil", "Allemagne", "Argentine", "Brésil"));

            CatArtLitterature.AjouterQuestion(new Model.QO("Qui a écrit Les Misérables ?", "Hugo"));
            CatArtLitterature.AjouterQuestion(new Model.QO("Quel peintre est célèbre pour ses tableaux représentant des tournesols ?", "Van Gogh"));
            CatArtLitterature.AjouterQuestion(new Model.QO("Quel écrivain a créé le personnage de Sherlock Holmes ?", "Conan Doyle"));
            CatArtLitterature.AjouterQuestion(new Model.QO("Qui a écrit Le Petit Prince ?", "Saint-Exupéry"));
            CatArtLitterature.AjouterQuestion(new Model.QO("Quel est le prénom de l’auteure de Harry Potter ?", "J.K. Rowling"));
            CatArtLitterature.AjouterQuestion(new Model.QO("Quel peintre a réalisé la célèbre œuvre La Joconde ?", "Léonard de Vinci"));
            CatArtLitterature.AjouterQuestion(new Model.QO("Quel est le titre de l’œuvre la plus célèbre de F. Scott Fitzgerald ?", "Gatsby"));
            CatArtLitterature.AjouterQuestion(new Model.QO("Quel auteur est l’inventeur du genre littéraire de la science-fiction ?", "Verne"));
            CatArtLitterature.AjouterQuestion(new Model.QO("Quel peintre a peint La Nuit étoilée ?", "Van Gogh"));
            CatArtLitterature.AjouterQuestion(new Model.QO("Qui a écrit 1984 ?", "Orwell"));
            CatArtLitterature.AjouterQuestion(new Model.QO("Quel roman de George Orwell décrit une société totalitaire et une surveillance omniprésente ?", "1984"));
            CatArtLitterature.AjouterQuestion(new Model.QO("Qui a écrit Le Rouge et le Noir ?", "Stendhal"));
            CatArtLitterature.AjouterQuestion(new Model.QO("Quel poète français est l’auteur des Fleurs du mal ?", "Baudelaire"));
            CatArtLitterature.AjouterQuestion(new Model.QO("Quel écrivain britannique a écrit L'Appel de la forêt ?", "London"));
            CatArtLitterature.AjouterQuestion(new Model.QO("Quel artiste a réalisé la sculpture Le Penseur ?", "Rodin"));
            CatArtLitterature.AjouterQuestion(new Model.QO("Quel roman est attribué à Albert Camus et traite de l'absurdité de la condition humaine ?", "L'Étranger"));
            CatArtLitterature.AjouterQuestion(new Model.QO("Quel écrivain est l'auteur de Les Fables ?", "La Fontaine"));
            CatArtLitterature.AjouterQuestion(new Model.QO("Quel peintre espagnol a créé Guernica ?", "Picasso"));
            CatArtLitterature.AjouterQuestion(new Model.QO("Quel poète français a écrit Le Bateau Ivre ?", "Rimbaud"));
            CatArtLitterature.AjouterQuestion(new Model.QO("Quel peintre est connu pour ses œuvres de l'art abstrait et ses Compositions ?", "Mondrian"));

            CatArtLitterature.AjouterQuestion(new Model.QCM("Qui a écrit Les Liaisons Dangereuses ?", "Pierre Choderlos de Laclos", "Voltaire", "Racine", "Pierre Choderlos de Laclos"));
            CatArtLitterature.AjouterQuestion(new Model.QCM("Quel peintre est associé au mouvement cubiste ?", "Pablo Picasso", "Claude Monet", "Henri Matisse", "Pablo Picasso"));
            CatArtLitterature.AjouterQuestion(new Model.QCM("Quel roman a été écrit par Emile Zola ?", "Germinal", "Les Misérables", "Le Rouge et le Noir", "Germinal"));
            CatArtLitterature.AjouterQuestion(new Model.QCM("Quel est le titre du roman de Victor Hugo qui se déroule à Paris et où l’on retrouve le personnage de Quasimodo ?", "Notre-Dame de Paris", "Les Misérables", "Le Dernier Jour d'un Condamné", "Notre-Dame de Paris"));
            CatArtLitterature.AjouterQuestion(new Model.QCM("Qui a écrit Don Quichotte ?", "Miguel de Cervantes", "Flaubert", "Dumas", "Miguel de Cervantes"));
            CatArtLitterature.AjouterQuestion(new Model.QCM("Quel écrivain est l’auteur de Les Fleurs du mal ?", "Baudelaire", "Verlaine", "Rimbaud", "Baudelaire"));
            CatArtLitterature.AjouterQuestion(new Model.QCM("Dans quel roman de Dumas trouve-t-on le personnage d’Edmond Dantès ?", "Le Comte de Monte-Cristo", "Les Trois Mousquetaires", "La Reine Margot", "Le Comte de Monte-Cristo"));
            CatArtLitterature.AjouterQuestion(new Model.QCM("Qui a peint Les Nympheas ?", "Claude Monet", "Pierre-Auguste Renoir", "Édouard Manet", "Claude Monet"));
            CatArtLitterature.AjouterQuestion(new Model.QCM("Quel écrivain a créé le personnage de Dr Jekyll et Mr Hyde ?", "Robert Louis Stevenson", "Oscar Wilde", "H.G. Wells", "Robert Louis Stevenson"));
            CatArtLitterature.AjouterQuestion(new Model.QCM("Quel poète américain est l’auteur de Leaves of Grass ?", "Walt Whitman", "Emily Dickinson", "Sylvia Plath", "Walt Whitman"));
            CatArtLitterature.AjouterQuestion(new Model.QCM("Qui a écrit Frankenstein ?", "Mary Shelley", "Bram Stoker", "Edgar Allan Poe", "Mary Shelley"));
            CatArtLitterature.AjouterQuestion(new Model.QCM("Quel artiste est l’auteur de La Naissance de Vénus ?", "Sandro Botticelli", "Michel-Ange", "Raphaël", "Sandro Botticelli"));
            CatArtLitterature.AjouterQuestion(new Model.QCM("Quel écrivain a créé les personnages de Tom Sawyer et Huckleberry Finn ?", "Mark Twain", "Ernest Hemingway", "Jack London", "Mark Twain"));
            CatArtLitterature.AjouterQuestion(new Model.QCM("Quel est le nom de la première œuvre littéraire de Marcel Proust ?", "Du côté de chez Swann", "À la recherche du temps perdu", "Le Temps retrouvé", "Du côté de chez Swann"));
            CatArtLitterature.AjouterQuestion(new Model.QCM("Qui a écrit Le Portrait de Dorian Gray ?", "Oscar Wilde", "Bram Stoker", "H.G. Wells", "Oscar Wilde"));
            CatArtLitterature.AjouterQuestion(new Model.QCM("Quel peintre est célèbre pour ses Campbell's Soup Cans ?", "Andy Warhol", "Roy Lichtenstein", "Jackson Pollock", "Andy Warhol"));
            CatArtLitterature.AjouterQuestion(new Model.QCM("Dans quel livre de science-fiction H.G. Wells raconte-t-il l’histoire d’un voyage dans le temps ?", "La Machine à explorer le temps", "Le Premier Homme dans la Lune", "La Guerre des mondes", "La Machine à explorer le temps"));
            CatArtLitterature.AjouterQuestion(new Model.QCM("Quel peintre français est célèbre pour ses œuvres impressionnistes, notamment Impression, Soleil Levant ?", "Claude Monet", "Pierre-Auguste Renoir", "Édouard Manet", "Claude Monet"));
            CatArtLitterature.AjouterQuestion(new Model.QCM("Quel écrivain a créé les personnages de Sherlock Holmes et Dr Watson ?", "Arthur Conan Doyle", "Agatha Christie", "G.K. Chesterton", "Arthur Conan Doyle"));
            CatArtLitterature.AjouterQuestion(new Model.QCM("Quel poète est l’auteur de Les Chansons de Bilitis ?", "Pierre Louÿs", "Paul Verlaine", "Arthur Rimbaud", "Pierre Louÿs"));

            CatScienceNature.AjouterQuestion(new Model.QO("Quel est le gaz le plus abondant dans l’atmosphère terrestre ?", "Azote"));
            CatScienceNature.AjouterQuestion(new Model.QO("Quel est l'organe principal de la respiration chez l'homme ?", "Poumons"));
            CatScienceNature.AjouterQuestion(new Model.QO("Quel est l'élément chimique dont le symbole est O ?", "Oxygène"));
            CatScienceNature.AjouterQuestion(new Model.QO("Quel est le plus grand océan de la Terre ?", "Pacifique"));
            CatScienceNature.AjouterQuestion(new Model.QO("Qui est le père de la théorie de l'évolution ?", "Darwin"));
            CatScienceNature.AjouterQuestion(new Model.QO("Quel est le plus grand animal vivant sur Terre ?", "Baleine"));
            CatScienceNature.AjouterQuestion(new Model.QO("Quel est l’organe qui produit l’insuline dans le corps humain ?", "Pancréas"));
            CatScienceNature.AjouterQuestion(new Model.QO("Quel est le nom du processus par lequel les plantes fabriquent leur nourriture ?", "Photosynthèse"));
            CatScienceNature.AjouterQuestion(new Model.QO("Quel est le métal dont le symbole chimique est Fe ?", "Fer"));
            CatScienceNature.AjouterQuestion(new Model.QO("Quel est le plus grand continent du monde ?", "Asie"));
            CatScienceNature.AjouterQuestion(new Model.QO("Quel est l'organe de l'audition chez l'homme ?", "Oreille"));
            CatScienceNature.AjouterQuestion(new Model.QO("Quelle est la planète la plus proche du Soleil ?", "Mercure"));
            CatScienceNature.AjouterQuestion(new Model.QO("Quel est le nom de l'élément chimique de numéro atomique 1 ?", "Hydrogène"));
            CatScienceNature.AjouterQuestion(new Model.QO("Quel est le nom du plus grand désert chaud du monde ?", "Sahara"));
            CatScienceNature.AjouterQuestion(new Model.QO("Quel est l’instrument utilisé pour mesurer la température ?", "Thermomètre"));
            CatScienceNature.AjouterQuestion(new Model.QO("Quelle est la couleur du sang des vers de terre ?", "Vert"));
            CatScienceNature.AjouterQuestion(new Model.QO("Quel est le gaz principal responsable du réchauffement climatique ?", "Dioxyde de carbone"));
            CatScienceNature.AjouterQuestion(new Model.QO("Quel est le plus grand fleuve du monde ?", "Amazone"));
            CatScienceNature.AjouterQuestion(new Model.QO("Quel est le nom du processus où une larve se transforme en un insecte adulte ?", "Métamorphose"));
            CatScienceNature.AjouterQuestion(new Model.QO("Quel est le plus grand volcan sur Terre ?", "Mauna Loa"));

            CatScienceNature.AjouterQuestion(new Model.QCM("Quelle est la formule chimique de l'eau ?", "H2O", "O2", "CO2", "H2O"));
            CatScienceNature.AjouterQuestion(new Model.QCM("Quel est le gaz principal dans l'atmosphère terrestre ?", "Azote", "Oxygène", "Dioxyde de carbone", "Azote"));
            CatScienceNature.AjouterQuestion(new Model.QCM("Quel est l’organe qui filtre le sang dans le corps humain ?", "Reins", "Foie", "Cœur", "Reins"));
            CatScienceNature.AjouterQuestion(new Model.QCM("Quelle est la planète connue pour ses anneaux ?", "Saturne", "Jupiter", "Mars", "Saturne"));
            CatScienceNature.AjouterQuestion(new Model.QCM("Quel est l’élément chimique dont le symbole est Na ?", "Sodium", "Néon", "Azote", "Sodium"));
            CatScienceNature.AjouterQuestion(new Model.QCM("Quelle est la vitesse de la lumière dans le vide ?", "300 000 km/s", "150 000 km/s", "1 000 km/s", "300 000 km/s"));
            CatScienceNature.AjouterQuestion(new Model.QCM("Quel est le nom de la plus grande forêt tropicale ?", "Amazonie", "Forêt de Taïga", "Forêt de Congo", "Amazonie"));
            CatScienceNature.AjouterQuestion(new Model.QCM("Quel est le principal gaz responsable de l'effet de serre ?", "Dioxyde de carbone", "Méthane", "Azote", "Dioxyde de carbone"));
            CatScienceNature.AjouterQuestion(new Model.QCM("Quel est l'organe qui produit des globules rouges ?", "Moelle osseuse", "Cerveau", "Foie", "Moelle osseuse"));
            CatScienceNature.AjouterQuestion(new Model.QCM("Quel est le plus petit os du corps humain ?", "L’étrier", "Le fémur", "Le tibia", "L’étrier"));
            CatScienceNature.AjouterQuestion(new Model.QCM("Quel est le plus grand animal terrestre ?", "Éléphant", "Girafe", "Baleine", "Éléphant"));
            CatScienceNature.AjouterQuestion(new Model.QCM("Quel est le nom de la période géologique pendant laquelle les dinosaures ont vécu ?", "Mésozoïque", "Paléozoïque", "Quaternaire", "Mésozoïque"));
            CatScienceNature.AjouterQuestion(new Model.QCM("Quel est l'organe qui permet la digestion des aliments ?", "Estomac", "Cœur", "Reins", "Estomac"));
            CatScienceNature.AjouterQuestion(new Model.QCM("Dans quelle couche de l’atmosphère se trouve la couche d’ozone ?", "Stratosphère", "Troposphère", "Mésosphère", "Stratosphère"));
            CatScienceNature.AjouterQuestion(new Model.QCM("Quel est l’élément chimique dont le symbole est Au ?", "Or", "Argent", "Platine", "Or"));
            CatScienceNature.AjouterQuestion(new Model.QCM("Quel est le nom de la principale source d'énergie pour les plantes ?", "Soleil", "Vent", "Pluie", "Soleil"));
            CatScienceNature.AjouterQuestion(new Model.QCM("Quel est l'organe responsable de la production de bile ?", "Foie", "Reins", "Pancréas", "Foie"));
            CatScienceNature.AjouterQuestion(new Model.QCM("Quel est le nom du processus où les plantes libèrent de l’eau ?", "Transpiration", "Respiration", "Evaporation", "Transpiration"));
            CatScienceNature.AjouterQuestion(new Model.QCM("Quel est le nom du processus par lequel les cellules humaines se divisent ?", "Mitose", "Méiose", "Fission", "Mitose"));
            CatScienceNature.AjouterQuestion(new Model.QCM("Quel est le nom du phénomène par lequel les oiseaux migrent ?", "Migration", "Hibernation", "Photosynthèse", "Migration"));
        }

        // constructeur paramétré
        public Categorie(string titre, Color couleur)
        {
            this.Titre = titre;
            this.Couleur = couleur;
            GenerateQuestions();
        }
        public List<Questions> GetQuestions()
        {
            return this.Questions;
        }

        public void AjouterQuestion(Questions question)
        {
            this.Questions.Add(question);
        }
        
        public static Categorie GetCategorie(Color uneCouleur)
        {
            if (uneCouleur == Color.Blue)
            {
                return CatGeographie;
            }
            else if (uneCouleur == Color.Red)
            {
                return CatDivertissement;
            }
            else if (uneCouleur == Color.Green)
            {
                return CatSport;
            }
            else if (uneCouleur == Color.Yellow)
            {
                return CatArtLitterature;
            }
            else if (uneCouleur == Color.Purple)
            {
                return CatScienceNature;
            }
            else
            {
                return CatGeographie;
            }
        }

        public static Categorie GetQuestionsFromCategory(string uneCategorie)
        {
            switch (uneCategorie.ToLower()) // Convertit en minuscule pour éviter les erreurs de casse
            {
                case "géographie":
                    return CatGeographie;
                case "histoire":
                    return CatHistoire;
                case "divertissement":
                    return CatDivertissement;
                case "sport":
                    return CatSport;
                case "art et litterature":
                    return CatArtLitterature;
                case "science et nature":
                    return CatScienceNature;
                default:
                    throw new ArgumentException("Catégorie inconnue : " + uneCategorie);
            }
        }

        public string GetTitre()
        {
            return this.Titre;
        }
    }
}