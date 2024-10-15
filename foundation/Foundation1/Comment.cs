public class Comment
{
    private string commenterName;
    private string text;

    // Constructor
    public Comment(string commenterName, string text)
    {
        this.commenterName = commenterName;
        this.text = text;
    }

    // Method to get the name of the commenter
    public string GetCommenterName()
    {
        return commenterName;
    }

    // Method to get the comment text
    public string GetText()
    {
        return text;
    }
}
