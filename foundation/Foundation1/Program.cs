using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating video objects
        Video video1 = new Video("C# Tutorial", "John Doe", 300);
        Video video2 = new Video("Encapsulation Explained", "Jane Smith", 420);
        Video video3 = new Video("Understanding Abstraction", "Mike Johnson", 360);

        // Adding comments to video1
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot!"));

        // Adding comments to video2
        video2.AddComment(new Comment("Dave", "Awesome explanation!"));
        video2.AddComment(new Comment("Eve", "Encapsulation is cool!"));
        video2.AddComment(new Comment("Frank", "I finally understand it!"));

        // Adding comments to video3
        video3.AddComment(new Comment("Grace", "Very clear!"));
        video3.AddComment(new Comment("Hank", "Thanks for the examples!"));
        video3.AddComment(new Comment("Ivy", "I needed this!"));

        // Storing the videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Displaying the details of each video
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }
    }
}
