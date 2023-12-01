using System;
using System.Collections.Generic;

namespace QuizzConsole.classes
{
    public class Ihm
    {
        private List<string> _question;
        private List<string> _options;
        private List<string> _trueAnswers;

        public void Start()
        {
            Console.WriteLine("\t\tQuizzConsole: Le meilleur Quiz de France !");
            AskName();
            AskTheme();
        }

        private void AskName()
        {
            Console.WriteLine("Quel est votre nom ?");
            string nom = Console.ReadLine();
            Console.WriteLine("\t\t\tBienvenue " + nom);
        }

        private void AskTheme()
        {
            Console.WriteLine("Quel thème choisissez-vous ?");
            Console.WriteLine("\n\t1 - Géographie \n\t2 - Cinéma \n\t3 - Informatique \n\t4 - Aléatoire");
            string theme = Console.ReadLine();

            switch (theme)
            {
                case "1":
                    Console.WriteLine("Vous avez choisi le thème Géographie. Appuyez sur entrer pour continuer!");
                    Console.ReadLine();
                    Console.Clear();
                    GeographyQuestions();
                    break;
                case "2":
                    Console.WriteLine("Vous avez choisi le thème Cinéma. Appuyez sur entrer pour continuer!");
                    Console.ReadLine();
                    CinemaQuestions();
                    break;
                case "3":
                    Console.WriteLine("Vous avez choisi le thème Informatique. Appuyez sur entrer pour continuer!");
                    Console.ReadLine();
                    ComputerQuestions();
                    break;
                case "4":
                    Console.WriteLine("Vous avez choisi le thème Aléatoire. Appuyez sur entrer pour continuer!");
                    Console.ReadLine();
                    Console.Clear();
                    RandomTheme();
                    break;
            }
            Console.Clear();
        }

        private void CinemaQuestions()
        {
            _question = new List<string>
            {
                "Quel réalisateur a dirigé 'Inception' et 'Interstellar' ?",
                "Quel film a remporté l'Oscar du meilleur film en 2020 ?",
            };

            _options = new List<string>
            {
                "Christopher Nolan",
                "Steven Spielberg",
                "Quentin Tarantino",
                "James Cameron",
                "1917",
                "Joker",
                "Parasite",
                "Once Upon a Time in Hollywood"
            };

            _trueAnswers = new List<string>
            {
                "Christopher Nolan",
                "Parasite"
            };

            Questionnaire cinemaQuestionnary = new Questionnaire();
            cinemaQuestionnary.AskQuestion(_question, _options, _trueAnswers);
        }

        private void GeographyQuestions()
        {
            Console.WriteLine("Quelle est la capitale de la France ? ");
            Questionnaire geographyQuestionnary = new Questionnaire();
            geographyQuestionnary.AskQuestion(null, null, null);
        }

        private void ComputerQuestions()
        {
            Questionnaire computerQuestionnary = new Questionnaire();
            computerQuestionnary.AskQuestion(null, null, null);
        }

        private void RandomTheme()
        {
            Random random = new();
            int randomIndex = random.Next(1, 4);

            switch (randomIndex)
            {
                case 1:
                    Console.WriteLine("Le thème aléatoire est Géographie!");
                    GeographyQuestions();
                    break;
                case 2:
                    Console.WriteLine("Le thème aléatoire est Cinéma!");
                    CinemaQuestions();
                    break;
                case 3:
                    Console.WriteLine("Le thème aléatoire est Informatique!");
                    ComputerQuestions();
                    break;
            }
        }
    }
}
