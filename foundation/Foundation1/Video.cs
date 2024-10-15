using System;
using System.Collections.Generic;

public class Video
{
    private string title;
    private string author;
    private int length;
    private List<Comment> comments;

    // Constructor
    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
        comments = new List<Comment>();
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    // Method to display video details and comments
    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Length: {length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");

        foreach (var comment in comments)
        {
            Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
        }
    }
}
