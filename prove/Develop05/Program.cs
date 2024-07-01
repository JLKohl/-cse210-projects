
using Develop05;

class Program
{
    static void Main(string[] args)
    {
        string userGoalName;
        int userGoalPoints;
        string userGoalDescription;
        List <Goal> userGoalList = new List<Goal>();
        Animation animation = new Animation();
        
        
        
        int activityChoice;
        Console.WriteLine("Welcome to your Eternal Quest. Please pick a number from the menu to start you adventure!");
        Console.WriteLine(" ");
   
            while (true){ 
                int totalPoints = 0; 
                
            Console.WriteLine(" ");
            for (int i = 0; i < userGoalList.Count; i++)
            {
                totalPoints += userGoalList[i].ReturnTotal();
            }
            Console.WriteLine($" Your total points are: {totalPoints}");
            
             Console.WriteLine(
                   "1.Create New Goal \n"+
                   "2.List Goals \n" +
                   "3.Save Goals \n" +
                   "4.Load Goals \n" +
                   "5.Record Event\n" +
                   "6.Quit");
             Console.Write("Which activity would you like(1-5) or 6 to quit? ");
             String userInput = Console.ReadLine();
             Console.WriteLine(" ");
             
             try
             {
                 activityChoice = int.Parse(userInput); 
             }
             catch (System.Exception)
             {
                Console.WriteLine("invalid input, please try again.");
                continue;
            }
        
            if (activityChoice == 1)
            {
                Console.WriteLine("The Types of Goals are: ");
                Console.WriteLine(
                    "1.Simple Goal \n" +
                    "2.Eternal Goal \n" +
                    "3.Checklist Goal \n" 
                    );
                Console.Write("What type of goal would you like to create? ");
                String userGoalInput = Console.ReadLine();
                
                int userGoalChoice;
                try
                {
                    userGoalChoice = int.Parse(userGoalInput);
                }
                catch (System.Exception)
                {
                    Console.WriteLine("invalid input, please try again.");
                    continue;
                }
        
                if (userGoalChoice == 1)
                {
                    Console.WriteLine("What is the name of your goal? ");
                    userGoalName = Console.ReadLine();
                    
                    Console.WriteLine("Write a short description of your Goal");
                    userGoalDescription = Console.ReadLine();
                    
                    Console.WriteLine("What is the point value of your goal? ");
                    userGoalPoints = int.Parse(Console.ReadLine());
                    
                    SimpleGoal simpleGoal = new SimpleGoal(userGoalPoints, userGoalName, userGoalDescription);
                    userGoalList.Add(simpleGoal);
                    //serialize simple goal so that it can be saved to a file 
                }
                else if (userGoalChoice == 2)
                {
                    Console.WriteLine("What is the name of your goal? ");
                    userGoalName = Console.ReadLine();
                    
                    Console.WriteLine("Write a short description of your Goal");
                    userGoalDescription = Console.ReadLine();
                    
                    Console.WriteLine("What is the point value of your goal? ");
                    userGoalPoints = int.Parse(Console.ReadLine());
                    
                    EternalGoal eternalGoal = new EternalGoal(userGoalPoints, userGoalName, userGoalDescription);
                    userGoalList.Add(eternalGoal);

                }
                else if (userGoalChoice == 3)
                {
                    Console.WriteLine("What is the name of your goal? ");
                    userGoalName = Console.ReadLine();
                    
                    Console.WriteLine("Write a short description of your Goal");
                    userGoalDescription = Console.ReadLine();
                    
                    Console.WriteLine("What is the point value of your goal? ");
                    userGoalPoints = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("How many times will you complete this goal to receive bonus point?");
                    int userHowManyTimesToComplete = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("How many bonus points will you receive? ");
                    int userBonusPoints = int.Parse(Console.ReadLine());
                    
                    CheckListGoal checkListGoal = new CheckListGoal(userGoalPoints, userGoalName, userGoalDescription, userBonusPoints, userHowManyTimesToComplete, 0);
                    userGoalList.Add(checkListGoal);
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
            }
            else if (activityChoice == 2 )
            {
                foreach (Goal goal in userGoalList)
                {
                    Console.WriteLine(goal.DisplayGoals());
                }
            }
            else if (activityChoice== 3 )
            {
                Console.WriteLine("Enter filename: ");
                string fileName = Console.ReadLine();

                string currentDirectory = System.IO.Directory.GetCurrentDirectory();
                Console.WriteLine($"Current Directory: {currentDirectory}");
                try
                {
                    using (StreamWriter sw = new StreamWriter(fileName))
                    {
                        
                        sw.WriteLine(totalPoints);
                      
                        foreach (Goal goal in userGoalList)
                        {
                            sw.WriteLine(goal.SerializeGoals());
                        }
                    }
                    Console.WriteLine($"Goals saved to {fileName}");

                }
                catch (Exception ex)
                
                {
                    Console.WriteLine($"An error occured while trying to write to the file: {ex.Message}");
                }
        
            }
            else if (activityChoice == 4)
            {
                Console.WriteLine("Enter the name of the file you want to load from: ");
                string filename = Console.ReadLine();
                
                var lines = File.ReadAllLines(filename);
                
                userGoalList.Clear();

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains("Simple Goal"))
                    {
                        Goal simpleGoal = new SimpleGoal(0, "", "").DeserializeGoals(lines[i]) as SimpleGoal;
                        userGoalList.Add(simpleGoal);
                    }
                    else if (lines[i].Contains("Eternal Goal"))
                    {
                        Goal eternalGoal = new EternalGoal(0, "", "").DeserializeGoals(lines[i]) as EternalGoal;
                        userGoalList.Add(eternalGoal);
                    }
                    else if (lines[i].Contains("Check List Goal"))
                    {
                        Goal checkListGoal = new CheckListGoal(0, "", "", 0, 0, howManyCompleted: 0).DeserializeGoals(lines[i]) as CheckListGoal;
                        userGoalList.Add(checkListGoal);
                    }
                    else
                    {
                        totalPoints = int.Parse(lines[i]);
                        
                    }
                }

                if (userGoalList.Count > 0)
                {
                    foreach (Goal goal in userGoalList)
                    {
                        Console.WriteLine(goal.DisplayGoals());
                    }
                }
                else
                {
                    Console.WriteLine("No goals have been added yet.");
                }
               
            }
            else if (activityChoice == 5)
            {

                for (int i = 0; i < userGoalList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {userGoalList[i].DisplayName()}");

                }

                Console.WriteLine("Which Goal Would you like to record: ");
                String userGoalChoice = Console.ReadLine();
                int userGoalRecord = int.Parse(userGoalChoice)-1;

                userGoalList[userGoalRecord].RecordEvent();
                
            }
            else if (activityChoice == 6){
                break;
            }
            else{
                Console.WriteLine("invalid input, please try again.");
            }
        }
                Console.Write($"now exiting program");
                animation.DisplayAnimation();
                
    }
}