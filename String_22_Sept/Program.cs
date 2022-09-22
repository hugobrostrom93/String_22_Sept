using System.ComponentModel;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CommaSeparatedNumbers();
            //UsernameGenerator();
            //StarLine();
            //ConcatenateStrings();
            //ReplaceText();
            //CharPosition();
            //ReplaceChar();
            //Comparenames();
            ComparenamesFacit();
        }


        static void CommaSeparatedNumbers()
        {
            int sum = 0;
            Console.WriteLine("Ange flera siffror separerade med kommatecken:");
            var svar = Console.ReadLine();
            var splitSvar = svar.Split(',', StringSplitOptions.TrimEntries);

            foreach (var siffror in splitSvar)
            {
                sum += int.Parse(siffror);
            }
            Console.WriteLine($"Summan av talen är: {sum}");
            Console.WriteLine(svar);

        }


        static void UsernameGenerator()
        {
            Console.Write("Ange ditt namn: ");
            var namn = Console.ReadLine();

            Console.Write("Ange ditt fördelseår: ");
            var date = Console.ReadLine();

            var firstPart = namn.Substring(0, 3);
            var secondPart = namn.Split(' ')[^1].Substring(0, 3);
            var thirdPart = date.Substring(date.Length -2 , 2);

            Console.Write($"Ditt användarnamn är: {firstPart}{secondPart}{thirdPart}");
        }

        static void StarLine()
        {
            var stars = new string('+', 80);
            Console.WriteLine(stars);
        }

        static void ConcatenateStrings()
        {
            string[] names = {"Harry", "Ron", "Hermoine"};

            string namesWithPlus = names[0] + names[1] + names[2];
            string namesWithJoin = string.Join(" ", names);
            string namesWithContact = string.Concat(names);

            Console.WriteLine(namesWithPlus);
            Console.WriteLine(namesWithJoin);
            Console.WriteLine(namesWithContact);
        }

        static void ReplaceText()
        {
            Console.Write("Ange ett namn: ");
            string namn = Console.ReadLine();

            string replaceText = namn.Replace('a', 'o');
            Console.WriteLine(replaceText);
        }

        static void CharPosition()
        {
            Console.Write("Ange ditt namn: ");
            string namn = Console.ReadLine().ToLower();

            var firstE = namn.IndexOf('e');
            var lastE = namn.LastIndexOf('e');

            Console.WriteLine(firstE);
            Console.WriteLine(lastE);
        }

        static void ReplaceChar()
        {
            Console.WriteLine("Skriv ett ord: ");
            string word = Console.ReadLine();

            int firstA = word.IndexOf('a');

            string firstPart = word.Substring(0, firstA);

            string secondPart = word.Substring(firstA + 1);

            string newWord = $"{firstPart}i{secondPart}";

            Console.WriteLine(newWord);
        }

        static void Comparenames()
        {
            Console.WriteLine("Ange ett namn:");
            string nameOne = Console.ReadLine();
            Console.WriteLine("Ange ett annat namn:");
            string nameTwo = Console.ReadLine();

            var resultat = nameOne.CompareTo(nameTwo);
            var resultatTwo = nameTwo.CompareTo(nameOne);


            if (resultat > resultatTwo)
            {
                Console.WriteLine($"{nameTwo} är först i alfabetet");
            } else if (resultat == 0 && resultatTwo == 0)
            {
                Console.WriteLine($"{nameOne} och {nameTwo} är lika!");
            }
            else
            {
                Console.WriteLine($"{nameOne} är först i alfabetet");
            }
        }
        static void ComparenamesFacit()
        {
            Console.WriteLine("Ange ett namn");
            string name1 = Console.ReadLine();
            Console.WriteLine("Ange ett namn till");
            string name2 = Console.ReadLine();
            if (name1.CompareTo(name2) < 0) // Jämför om name1 är mindre än name2
            {
                Console.WriteLine($"{name1} är först i alfabetet");
            }
            else if (name1.CompareTo(name2) > 0) // annars jämför om name2 är mindre än name1
            {
                Console.WriteLine($"{name2} är först i alfabetet");
            }
            else // annars anta att namnen är lika
            {
                Console.WriteLine($"{name1} och {name2} är lika");
            }
        }
    }
}

