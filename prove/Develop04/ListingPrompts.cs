public class ListingPrompts
{
    private List<string> _listingQuestions = new List<string>()
    {
        "What is something that made you smile today?",
        "Who did you help today?",
        "What is something new you learned today?",
        "How did you see Gods hand in your life today?",
        "What was the best thing you ate today?",
        "How were you most blessed today?"
    };

    public string DisplayListingQuestions()
    {
        Random randomQuestion = new Random();
        int index = randomQuestion.Next(_listingQuestions.Count);
        string newQuestion = _listingQuestions[index];

        return newQuestion;
    }
} 