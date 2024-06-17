public class ListingActivity : Activity
{
    private List<string> _userList = new List<string>();
    private string _entry;

    public void GetList()
    {
        
    }

    public void GetNumberFromList()
    {
        
    }
    
    public ListingActivity(string activityName, string activityStartMessage, string activityEndMessage) : base(activityName, activityStartMessage, activityEndMessage)
    {
        
    }

    public void RunListingActivity()
    {
        Console.WriteLine(' ');
        Console.WriteLine(' ');
        
        
        ListingPrompts prompter = new ListingPrompts();
        Console.WriteLine(prompter.DisplayListingQuestions());
        
        while (DateTime.Now < _endTime)
        {
            Console.Write("> ");
            _entry = Console.ReadLine(); //write as many times as you want
            _userList.Add(_entry);
        }
        
        Console.WriteLine($"You listed { _userList.Count()} items.");
        
        Console.WriteLine(' ');
        Console.WriteLine(' ');
        
    }
}