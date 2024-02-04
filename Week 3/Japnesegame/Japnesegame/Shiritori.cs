using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Japnesegame
{
     public class Shiritori
    {
        public List<string> words;
        public bool game_over;

        public Shiritori()
        {
            words = new List<string>();
            game_over = false;
        }

        public List<string> Play(string word)
        {
            if (game_over)
            {
                Console.WriteLine("Word matched with previous one...Haar gaye app!");
                return words;
            }

            if (IsValidWord(word))
            {
                words.Add(word.ToLower());
                Console.WriteLine("Shi jaa rhy ho! Previous Words ==> " + string.Join(", ", words));
            }
            else
            {
                game_over = true;
                Console.WriteLine("Ghlt Lfz....Game Khtm!");
            }

            return words;
        }
        public string Restart()
        {
            words.Clear();
            game_over = false;
            Console.WriteLine("Game restarted.....");
            return "game restarted";
        }

        public bool IsValidWord(string word)
        {
            if (words.Count > 0 && char.ToLower(words[words.Count - 1][words[words.Count - 1].Length - 1]) != char.ToLower(word[0]))
            {
                return false; 
            }

            if (words.Contains(word.ToLower()))
            {
                return false; 
            }

            return true;
        }
        public bool IsGameOver()
        {
            return game_over;
        }
    }
}
