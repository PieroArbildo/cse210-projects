using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1.Author = "Piero A.";
        video1.Title = "Conferencia Leer mas";
        video1.LengthSeconds   = 1200;
        video1.comments = new List<Comment>();

        Comment comment1 = new Comment();
        comment1.Name = "Junior";
        comment1.Text = "Este video me gusta mucho Gracias por publicarlo";
        Comment comment2 = new Comment();
        comment2.Name  = "Alan";
        comment2.Text   = "Ese dia la pase increible";
        
        Comment comment3 = new Comment();
        comment3.Name = "Desire";
        comment3.Text = "ese dia no pude asistir, me perdi la conferencia";

        Comment comment4 = new Comment();
        comment4.Name = "Lia";
        comment4.Text = "I would like it to have English subtitles";

        video1.comments.Add(comment1);
        video1.comments.Add(comment2);
        video1.comments.Add(comment3);
        video1.comments.Add(comment4);

        Console.WriteLine($"Autor:{video1.Author} Title: {video1.Title} Duration in Sencons: {video1.LengthSeconds}");
        Console.WriteLine($"Comments amount: {video1.GetnumberComments()}");

        foreach (Comment comment in video1.comments)
        {
            Console.WriteLine($"{comment.Name}: {comment.Text}");
        }
        Console.WriteLine("");

        Video video2 = new Video();
        video2.Author = "Garage band";
        video2.Title = "The best song";
        video2.LengthSeconds = 240;
        video2.comments = new List<Comment>();

        Comment commentMusic1 = new Comment();
        commentMusic1.Name = "user20";
        commentMusic1.Text = "This is the first time I've heard this song, it sounds really good.";

        Comment commentMusic2 = new Comment();
        commentMusic2.Name = "Gisela";
        commentMusic2.Text = "I remember when I heard this song live, good times";

        Comment commentMusic3 = new Comment();
        commentMusic3.Name = "Lily";
        commentMusic3.Text = "this is my dad's favorite song";

        video2.comments.Add(commentMusic1);
        video2.comments.Add(commentMusic2);
        video2.comments.Add(commentMusic3);

        Console.WriteLine($"Autor:{video2.Author} Title: {video2.Title} Duration in Sencons: {video2.LengthSeconds}");
        Console.WriteLine($"Comments amount: {video2.GetnumberComments()}");

        foreach (Comment comment in video2.comments)
        {
            Console.WriteLine($"{comment.Name}: {comment.Text}");
        }
        Console.WriteLine("");

        Video video3 = new Video();
        video3.Author = "Smith Green";
        video3.Title = "Ice Age";
        video3.LengthSeconds = 3600;
        video3.comments = new List<Comment>();

        Comment commentMovie1 = new Comment();
        commentMovie1.Name = "Thalia";
        commentMovie1.Text = "thanks for publishing this movie";

        Comment commentMovie2 = new Comment();
        commentMovie2.Name = "Gigi";
        commentMovie2.Text = "I didn't like this movie very much";

        Comment commentMovie3 = new Comment();
        commentMovie3.Name = "Lee";
        commentMovie3.Text = "It's my favorite movie";

        video3.comments.Add(commentMovie1);
        video3.comments.Add(commentMovie2);
        video3.comments.Add(commentMovie3);

        Console.WriteLine($"Autor:{video3.Author} Title: {video3.Title} Duration in Sencons: {video3.LengthSeconds}");
        Console.WriteLine($"Comments amount: {video3.GetnumberComments()}");

        foreach (Comment comment in video3.comments)
        {
            Console.WriteLine($"{comment.Name}: {comment.Text}");
        }
    }
}