public class Word
{
    private string content;
    private bool isHidden;

    public Word(string word)
    {
        content = word;
        isHidden = false;
    }

    public void Hide()
    {
        isHidden = true;
    }

    public bool IsHidden()
    {
        return isHidden;
    }

    public string Display()
    {
        return isHidden ? "_____" : content;
    }
}
