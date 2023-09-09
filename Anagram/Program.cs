using System;

namespace Anagram
{
    internal class Program {

        public bool Anagram(string? val1, string? val2) {
            if(val1.Length != val2.Length) {
                return false;
            }
            else {
                val1.ToLower();
                val2.ToLower();

                int[] counts = new int[26];
                
                for(int i = 0; i < val1.Length; i++) {
                    counts[val1[i] - 'a']++;
                    counts[val2[i] - 'a']--;
                }

                for (int i = 0; i < 26; i++) {
                    if (counts[i] != 0) {
                        return false;
                    }
                }
                return true;

            }

            
        }
        static void Main(string[] args) {
            Program program = new Program();
            Console.WriteLine("Enter the first string...");
            string? string1 = Console.ReadLine();
            Console.WriteLine("Enter the second string...");
            string? string2 = Console.ReadLine();
            bool result = program.Anagram(string1, string2);
            if (result) {
                Console.WriteLine("Is Anagram");
            }
            else {
                Console.WriteLine("Not Anagram");
            }
        }
    }
}