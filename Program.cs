using System;
using System.IO;
using System.Text;

namespace AdventOfCode_2021_Day3
{
    public static class Program
    {
        public static void Main()
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string file = Path.Combine(currentDirectory, @"..\..\..\test.txt");
            string path = Path.GetFullPath(file);
            string[] text = File.ReadAllText(path).Split("\n");

            var result = CalculateGammaEpsilon(text);
            int gamma = Convert.ToInt32(result[0],2);
            int epsilon = Convert.ToInt32(result[1],2);

            Console.WriteLine("Gamma is " + gamma);
            Console.WriteLine("Epsilon is " + epsilon);
            Console.WriteLine("Total power is " + (epsilon*gamma));

            // Part 2
            var result2 = CalculateOxygenCarbon(text);
            int oxygen = Convert.ToInt32(result2[0],2);
            int co2 = Convert.ToInt32(result2[1],2);

            Console.WriteLine("Oxygen is " + oxygen);
            Console.WriteLine("C02 Scrubber rating is " + co2);
            Console.WriteLine("Total life support rating is " + (oxygen*co2));
        }

        public static string[] CalculateGammaEpsilon(string[] input)
        {
            string[] result = new string[2];
            int[] count = new int[input[0].Length];

            for (int i = 0; i < input.Length; i++ ){
                string str = input[i];
                for(int j = 0; j < str.Length; j++){
                    if(str[j].Equals('1')){
                        count[j]++;
                    }
                }
            }

            for(int i = 0; i < count.Length-1; i++){
                if(count[i] > input.Length/2){
                    result[0]+= "1";
                    result[1]+= "0";
                }
                else{
                    result[1]+= "1";
                    result[0]+= "0";
                }
            }
            return result;
        }

        public static string[] CalculateOxygenCarbon(string[] input){
            string[] result = new string[2];
            return result;
        }

    }
}
