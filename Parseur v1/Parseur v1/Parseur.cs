using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Parseur_v1
{
    class Parseur
    {
        private string[] separators;
        private string patternFinal;

        public Parseur(string[] patternInitial, string patternFinal)
        {
            this.separators = patternInitial;
            this.patternFinal = patternFinal;
        }

        public static Parseur LoadParseur(string parseurName)
        {
            return null;
        }

        public static Parseur CreateNewParseur(string initial, Dictionary<Color, Tuple<int, string>> elementsInitial, string final, Dictionary<Color, Tuple<int, string>> elementsFinal)
        {
            string[] patternInit;
            string patternFinal = final;

            patternInit = initial.Split(elementsInitial.AsEnumerable().Select(x => x.Value.Item2).ToArray(), StringSplitOptions.RemoveEmptyEntries);//.Where(x => x.Length > 0).ToArray();
            
            //sous la forme index, length
            List<Tuple<int, int>> decalage = new List<Tuple<int, int>>();

            int i = 0;
            foreach (var elementInitial in elementsInitial)
            {
                string coloredString = elementInitial.Value.Item2;
                
                //replace the current word by {X} (where X is a number) in patternFinal

                if (elementsFinal.TryGetValue(elementInitial.Key, out Tuple<int, string> elementFinal))
                {
                    //int indexInit = elementInitial.Value.Item1;
                    int indexFinal = elementFinal.Item1 - (from decal in decalage
                                                          where decal.Item1 < elementFinal.Item1
                                                          select decal.Item2 - (2 + i.ToString().Length)).Sum();

                    patternFinal = new string(patternFinal.Take(indexFinal).ToArray()) + "{" + i + "}" + new string(patternFinal.Skip(indexFinal + coloredString.Length).ToArray());
                    decalage.Add(new Tuple<int, int>(elementFinal.Item1, coloredString.Length));
                    i++;
                }
            }
            //Console.WriteLine("initial : " + patternInit);
            //Console.WriteLine("final   : " + patternFinal);
            return new Parseur(patternInit, patternFinal); ;
        }

        public string DoParsing(string stringToParse)
        {
            //recupere tout les mots qui sont des variables
            List < string > variables = new List<string>();
            variables = stringToParse.Split(this.separators, StringSplitOptions.RemoveEmptyEntries).Where(x => x.Length > 0).ToList();

            return string.Format(patternFinal, variables.ToArray()); // Regex.Replace(result, "<var[0-9]*>", "");
        }

        public static void Test()
        {
            string initial= ",{0}mm;;soeur//toto";
            Dictionary<Color, Tuple<int, string>> elementsInitial = new Dictionary<Color, Tuple<int, string>>();
            elementsInitial.Add(Color.Black, new Tuple<int, string>(1, "{0}mm"));
            elementsInitial.Add(Color.AliceBlue, new Tuple<int, string>(8, "soeur"));
            elementsInitial.Add(Color.AntiqueWhite, new Tuple<int, string>(15, "toto"));

            string final = "soeur\n{0}mm\ntoto";
            Dictionary<Color, Tuple<int, string>> elementsFinal = new Dictionary<Color, Tuple<int, string>>();
            elementsFinal.Add(Color.Black, new Tuple<int, string>(6, "{0}mm"));
            elementsFinal.Add(Color.AliceBlue, new Tuple<int, string>(0, "soeur"));
            elementsFinal.Add(Color.AntiqueWhite, new Tuple<int, string>(12, "toto"));

            var a = CreateNewParseur(initial, elementsInitial, final, elementsFinal);
            //Parseur a = new Parseur(new string[]{ ",", ":", ";;", "ii" }, "{0}\n{1}\n{2}\n{3}");
            Console.WriteLine(a.DoParsing(",maman;;soeur//papa"));
        }
    }
}
