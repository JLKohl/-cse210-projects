public class ReflectionPrompts
{
    private List<string> _reflectionPrompts = new List<string>()
    {
        "Think of a time when you stood up for someone else",
        "Think of yourself achieving your biggest goal",
        "Think of  each part of your body and how it feels from head to toe",
        "Think of a time when you did something really difficult",
        "Think of someone that you love and what they mean to you."
    };
    private List<string> _reflectionQuestions = new List<string>()
    {
        "Why is this experience meaningful to you?",
        "What did you notice about your feelings during this practice?",
        "Did any particular insights arise during your practice?",
        "Did your breathing change at all through out the practice? How?",
        "What distractions did you encounter during your meditation?",
        "How do you feel now?",
        "What can you learn about yourself from thinking of these things?",
        "How can you keep these things in mind for the future?"
    };
    
    public string DisplayReflectionPrompt()
    {
        
        Random randomPrompts = new Random();
        int index = randomPrompts.Next(_reflectionPrompts.Count);
        string newPromt = _reflectionPrompts[ index ];

        return newPromt;
    }

    public string DisplayReflectionQuestions()
    {
        
        Random randomQuestion = new Random();
        int index = randomQuestion.Next(_reflectionQuestions.Count);
        string newQuestion = _reflectionQuestions[ index ];

        return newQuestion;
    }
}