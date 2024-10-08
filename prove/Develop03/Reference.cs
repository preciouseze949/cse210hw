public class Reference
{
    public string Book { get; private set; }
    public int StartChapter { get; private set; }
    public int StartVerse { get; private set; }
    public int EndChapter { get; private set; }
    public int EndVerse { get; private set; }

    // Single verse constructor
    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        StartChapter = chapter;
        StartVerse = verse;
        EndChapter = chapter;
        EndVerse = verse;
    }

    // Verse range constructor
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        StartChapter = chapter;
        StartVerse = startVerse;
        EndChapter = chapter;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        if (StartVerse == EndVerse)
        {
            return $"{Book} {StartChapter}:{StartVerse}";
        }
        else
        {
            return $"{Book} {StartChapter}:{StartVerse}-{EndVerse}";
        }
    }
}
