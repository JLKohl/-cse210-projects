using System.Reflection;

namespace Foundation1;

public class Comment
{
    public string _name;
    public string _comment;

   public void GetComment()
   {
       Console.WriteLine($"{_name}: {_comment}");
   }
}