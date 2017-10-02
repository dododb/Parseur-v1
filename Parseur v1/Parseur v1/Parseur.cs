using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace Parseur_v1
{
    class Parseur
    {
        private string[] separators;
        private string patternFinal;
        private int nombreVar;
        string filePath = @"C:\Users\dorba\Desktop\ParseurFile";

        public Parseur(string[] patternInitial, string patternFinal)
        {
            this.separators = patternInitial;
            this.patternFinal = patternFinal;
            nombreVar = Regex.Matches(patternFinal, "{[0-9]+}").Count;
        }

        /// <summary>
        /// permet de load un parseur a l'aide du fichier contenant tout les parseurs sauvegardé
        /// </summary>
        /// <param name="parseurName"></param>
        /// <returns></returns>
        public static Parseur LoadParseur(string parseurName)
        {
            return null;
        }

        /// <summary>
        /// permet de sauvegarder le parseur dans le fichier qui contient tout les parseur
        /// </summary>
        /// <remarks>
        /// fichier sous la forme
        /// <name>name</name>
        /// <stringInitial>stringInitial</stringInitial>
        /// <stringFinal>stringFinal</stringFinal>
        /// </remarks>
        public void SaveParseur()
        {
            StreamWriter sw = new StreamWriter(this.filePath);
            sw.WriteLine("coucou");
            sw.Close();
        }

        /// <summary>
        /// créer un nouveau Parseur au donnée envoyé par la parti graphique
        /// </summary>
        /// <param name="initial"></param>
        /// <param name="elementsInitial"></param>
        /// <param name="final"></param>
        /// <param name="elementsFinal"></param>
        /// <returns></returns>
        public static Parseur CreateNewParseur(string initial, Dictionary<Color, Tuple<int, string>> elementsInitial, string final, Dictionary<Color, Tuple<int, string>> elementsFinal)
        {
            string[] patternInit;
            string patternFinal = final;

            patternInit = initial.Split(elementsInitial.AsEnumerable().Select(x => x.Value.Item2).ToArray(), StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();//.Where(x => x.Length > 0).ToArray();
            
            //sous la forme <index, length>
            //permet de connaitre le decalage provoqué par le remplacement des mots pas {X} dans patternFinal
            List<Tuple<int, int>> decalage = new List<Tuple<int, int>>();

            int i = 0;
            foreach (var elementInitial in elementsInitial)
            {
                string coloredString = elementInitial.Value.Item2;
                
                //replace the current word by {X} (where X is a number) in patternFinal
                if (elementsFinal.TryGetValue(elementInitial.Key, out Tuple<int, string> elementFinal))
                {
                    //int indexInit = elementInitial.Value.Item1;
                    int a = i.ToString().Length;
                    int indexFinal = elementFinal.Item1 - (from decal in decalage
                                                          where decal.Item1 < elementFinal.Item1
                                                          select decal.Item2).Sum();

                    patternFinal = new string(patternFinal.Take(indexFinal).ToArray()) + "{" + i + "}"
                        + new string(patternFinal.Skip(indexFinal + coloredString.Length).ToArray());
                    decalage.Add(new Tuple<int, int>(elementFinal.Item1, coloredString.Length -(2 + i.ToString().Length)));
                    i++;
                }
            }
            return new Parseur(patternInit, patternFinal);
        }

        /// <summary>
        /// parse une string a l'aide de ce parseur
        /// </summary>
        /// <param name="stringToParse"></param>
        /// <returns></returns>
        /// <error>quand il manque une information dans la chaine a parser, le programme plante (a cause du string.Format)</error>
        public string DoParsing(string stringToParse)
        {
            string basePattern = patternFinal;
            //recupere tout les mots qui sont des variables
            List <string> variables = new List<string>();
            variables = stringToParse.Split(this.separators, StringSplitOptions.None).ToList();

            //enleve les vide en debut et en fin si il y a trop de variables (se sont alors des vides rajouté par erreur)
            int count = variables.Count();
            while (count % this.nombreVar > 0 && count > this.nombreVar)
            {
                variables.RemoveAt(variables.First() == "" ? 0 : count - 1);
                count--;
            }

            //permet de gérer les cycles
            for(int i = 1; i < Math.Ceiling((double)variables.Count / this.nombreVar); i++)
            {
                string[] newVarName = new string[nombreVar];
                for (int j = 0; j < nombreVar; j++)
                {
                    newVarName[j] = "{" + (i * nombreVar + j) + "}";
                }
                patternFinal += "\n" + string.Format(basePattern, newVarName);
            }

            return string.Format(patternFinal, variables.ToArray()); // Regex.Replace(result, "{[0-9]*}", "");
        }

        /// <summary>
        /// permet de testé rapidement les fonctionCreateNewParseur et DoParsing
        /// </summary>
        public static void Test()
        {
            int length = 10000;
            var parseur = TestCreatePasseur(length);
            parseur.TestParseur(length);
            //parseur.TestSave();
        }

        private static Parseur TestCreatePasseur(int length = 2)
        {
            Stopwatch t = new Stopwatch();
            t.Start();
            string smallInit = "{0}mm;;soeur//toto,";
            string smallFinal = "soeur\n{0}mm\ntoto\n";
            string initial = string.Join(smallInit, new string[length]);
            string final = string.Join(smallFinal, new string[length]);

            //StreamWriter sw = new StreamWriter(@"C:\Users\dorba\Desktop\blop.txt");
            //sw.WriteLine(initial);
            //sw.Close();
            //Console.WriteLine("toto");

            //string initial = "{0}mm;;soeur//toto,";
            //string final = "soeur\n{0}mm\ntoto\n";

            Dictionary<Color, Tuple<int, string>> elementsInitial = new Dictionary<Color, Tuple<int, string>>();
            Dictionary<Color, Tuple<int, string>> elementsFinal = new Dictionary<Color, Tuple<int, string>>();

            Tuple<int, int, int> col = new Tuple<int, int, int>(0, 0, 0);
            for (int i = 0; i < length-1; i++)
            {
                elementsInitial.Add(Color.FromArgb(col.Item1, col.Item2, col.Item3), new Tuple<int, string>(1 + i * smallInit.Length, "{0}mm"));
                elementsFinal.Add(Color.FromArgb(col.Item1, col.Item2, col.Item3), new Tuple<int, string>(6 + i * smallFinal.Length, "{0}mm"));
                col = addForColor(col);

                elementsInitial.Add(Color.FromArgb(col.Item1, col.Item2, col.Item3), new Tuple<int, string>(8 + i * smallInit.Length, "soeur"));
                elementsFinal.Add(Color.FromArgb(col.Item1, col.Item2, col.Item3), new Tuple<int, string>(0 + i * smallFinal.Length, "soeur"));
                col = addForColor(col);

                elementsInitial.Add(Color.FromArgb(col.Item1, col.Item2, col.Item3), new Tuple<int, string>(15 + i * smallInit.Length, "toto"));
                elementsFinal.Add(Color.FromArgb(col.Item1, col.Item2, col.Item3), new Tuple<int, string>(12 + i * smallFinal.Length, "toto"));
                col = addForColor(col);
            }
            t.Stop();
            Console.WriteLine("creation time : " + t.Elapsed);

            Stopwatch timerCreateParseur = new Stopwatch();
            timerCreateParseur.Start();
            Parseur parseur = CreateNewParseur(initial, elementsInitial, final, elementsFinal);
            timerCreateParseur.Stop();
            Console.WriteLine("time to create the parsor : " + timerCreateParseur.Elapsed);
            return parseur;
        }

        private static Tuple<int,int,int> addForColor(Tuple<int,int,int> col)
        {
            int a = col.Item1;
            int b = col.Item2;
            int c = col.Item3;

            a++;
            b += a / 256;
            c += b / 256;

            
            return new Tuple<int, int, int>(a%256, b%256, c%256);
        }

        private void TestParseur(int length = 2)
        {
            Stopwatch timerParsing = new Stopwatch();
            timerParsing.Start();
            var result = this.DoParsing(string.Join("maman;;soeur//papa,", new string[length]));
            timerParsing.Stop();
            //Console.WriteLine(result);
            Console.WriteLine("timer to parse : " + timerParsing.Elapsed);
        }

        private void TestSave()
        {
            this.SaveParseur();
        }
    }
}
