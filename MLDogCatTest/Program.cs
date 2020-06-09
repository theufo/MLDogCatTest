using System;
using MLDogCatTestML.Model;

namespace MLDogCatTest
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter full path to image, or type \"exit\"");
                var path = Console.ReadLine();

                if (path == "exit")
                    break;

                try
                {
                    var input = new ModelInput();
                    input.ImageSource = path;

                    Console.WriteLine("Working on it");
                    var result = ConsumeModel.Predict(input);
                    Console.WriteLine($"Cat {result.Score[0]} \nDog {result.Score[1]}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}
