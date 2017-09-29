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
        private string patternInitial;
        private string patternFinal;

        public Parseur(string patternInitial, string patternFinal)
        {
            this.patternInitial = patternInitial;
            this.patternFinal = patternFinal;
        }

        public static Parseur LoadParseur(string parseurName)
        {
            return null;
        }

        public static Parseur CreateNewParseur(string initial, Dictionary<Color, Tuple<int, string>> elementsInitial, string final, Dictionary<Color, Tuple<int, string>> elementsFinal)
        {
            string patternInit = initial;
            string patternFinal = final;

            int i = 0;
            foreach(var elementInitial in elementsInitial)
            {
                string coloredString = elementInitial.Value.Item2;

                //replace the current word by <varX> (where X is a number) in both patternInitial and patternFinal
                if (elementsFinal.TryGetValue(elementInitial.Key, out Tuple<int, string> elementFinal))
                {
                    int indexInit = elementInitial.Value.Item1;
                    int indexFinal = elementFinal.Item1;

                    patternInit = patternInit.Take(indexInit - 1) + "<var" + i + ">" + new string(patternInit.Skip(indexInit + coloredString.Length).ToArray());
                    patternInit = patternInit.Take(indexInit - 1) + "<var" + i + ">" + new string(patternInit.Skip(indexInit + coloredString.Length).ToArray());

                    patternFinal = patternFinal.Take(indexFinal - 1) + "<var" + i + ">" + new string(patternFinal.Skip(indexFinal + coloredString.Length).ToArray());
                    patternFinal = patternFinal.Take(indexFinal - 1) + "<var" + i + ">" + new string(patternFinal.Skip(indexFinal + coloredString.Length).ToArray());

                    i++;
                }
            }
            Console.WriteLine("initial : " + patternInit);
            Console.WriteLine("final   : " + patternFinal);
            return new Parseur(patternInit, patternFinal); ;
        }

        public string DoParsing(string stringToParse)
        {
            //get all separator in the string order
            var separators = from separator in Regex.Split(this.patternInitial, "<var[0-9]+>")
                                  where separator.Length > 0
                                  select separator;

            //recupere tout les mots qui sont des variables
            List < string > variables = new List<string>();
            foreach(string separator in separators)
            {
                var splited = Regex.Split(stringToParse, separator);

                //if the split suceede
                if (splited.Length > 1)
                {
                    if (splited[0].Length > 0)
                    {
                        variables.Add(splited[0]);
                        stringToParse = splited[1];
                    }
                    else
                    {
                        stringToParse = splited[1];
                    }
                }
            }
            //when string to parse is not empty, the staying is the last variable
            variables.Add(stringToParse);

            //replace variable with patternFinal
            string result = patternFinal;
            int i = 0;
            foreach(string variable in variables)
            {
                string toReplace = "<var" + i + ">";
                result = result.Replace(toReplace, variable);
                i++;
            }
            return result;
        }

        public static void Test()
        {
            Parseur a = new Parseur(",<var0>:<var1>;;<var2>", "<var1>\n<var0>\n<var2>");
            Console.WriteLine(a.DoParsing(",papa:maman;;soeur"));
        }
    }
}
