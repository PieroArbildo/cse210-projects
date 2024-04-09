public class Video
{
    public string Title;
    public string Author;
    public int LengthSeconds;
    public List<Comment> comments;

    public int GetnumberComments()
    {
        return comments.Count;
    }
}
