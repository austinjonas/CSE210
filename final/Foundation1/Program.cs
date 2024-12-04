using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Video testVideo = new Video();
        testVideo.AddVideo("bfg", "mr austin", 400);
        testVideo.AddComments("Bo", " This is great video");
        testVideo.AddComments("steven", " This is the really good guy.");
        testVideo.AddComments("James", " This is the really good guy.");

        Video video1 = new Video();
        video1.AddVideo("wow clickbait video", "mr beast", 10000);
        video1.AddComments("Bo", " 1This is great video");
        video1.AddComments("steven", " 1This is the really good guy.");
        video1.AddComments("James", " 1This is the really good guy.");

        Video video2 = new Video();
        video2.AddVideo("lame guy video", "mr. bob", 500);
        video2.AddComments("Bo", " 2This is great video");
        video2.AddComments("steven", " 2This is the really good guy.");
        video2.AddComments("James", " 2This is the really good guy.");


        Console.WriteLine();
        Console.WriteLine("->->->->");
        foreach (string video in testVideo.GetVideo())
        {
            Console.WriteLine(video);
            foreach (string comment in testVideo.GetComment())
            {
                Console.WriteLine(comment);
            }
        }
        Console.WriteLine("->->->->");
        foreach (string video in video1.GetVideo())
        {
            Console.WriteLine(video1);
            foreach (string comment in video1.GetComment())
            {
                Console.WriteLine(comment);
            }
        }
        Console.WriteLine("->->->->");
        foreach (string video in video2.GetVideo())
        {
            Console.WriteLine(video2);
            foreach (string comment in video2.GetComment())
            {
                Console.WriteLine(comment);
            }
        }
    }
}