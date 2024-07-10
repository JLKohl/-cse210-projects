namespace Foundation1;

public class Video
{
    public string _author;
    public string _title;
    public int _length;
    public List<Comment> _comments = new List<Comment>();


    public int countComments()
    {
        int numOfVids = 0;
        
        for (; numOfVids < _comments.Count(); numOfVids++ )
        {
            
        }
        
        return numOfVids;
    }
    public void Display()
    {
        Console.WriteLine(" ");
        Console.WriteLine("_______________New Video_________________");
        Console.WriteLine($" Video title: {_title}");
        Console.WriteLine($" Author: {_author}");
        Console.WriteLine($" Length: {_length} sec");
        Console.WriteLine($" Number of Product Comments: {countComments()}");
        //call method to print number of comments
        
        Console.WriteLine(" ");
        Console.WriteLine($"Comments:");
        foreach (Comment comment in _comments )
        {
            comment.GetComment();
        }
        
    }

}