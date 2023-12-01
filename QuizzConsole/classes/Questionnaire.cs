using System;
using System.Collections.Generic;

namespace QuizzConsole.classes
{
    public class Questionnaire
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="question"></param>
        /// <param name="trueAnswer"></param>
        /// <param name="options"></param>
        public void AskQuestion(
            List<string> question,
            List<string> trueAnswer,
            List<string> options
        )
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(question[i]);
                Console.WriteLine(
                    "\t\n 1 - " + options[0] + 
                    "\t\n 2 - " + options[1] + 
                    "\t\n 3 - " + options[0] + 
                    "\t\n 4 - " + options[1]   
                );

                string reponse = Console.ReadLine();

                if (reponse == trueAnswer[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nBravo, c'est la bonne réponse");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nMauvaise réponse !!! La bonne réponse était : {trueAnswer[i]}");
                }

                // Rétablir la couleur par défaut après l'affichage du message
                Console.ResetColor();
            }
        }
    }
}
