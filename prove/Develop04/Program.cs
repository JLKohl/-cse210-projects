
using System.IO.Compression;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
        {
             int activityChoice;
             Console.WriteLine("Welcome to your self-care app. Please pick a number from the menu:");
             
             
            while (true){ 
                 Console.WriteLine(
                       "1.Start Breathing activity \n"+
                       "2.Start Listing activity \n" +
                       "3.Start Reflection activity \n" +
                       "4.Quit");
                 Console.Write("Which activity would you like(1-3) or 4 to quit? ");
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
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "breathing");
                    breathingActivity.GetStartActivity();
                    breathingActivity.RunBreathingActivity();
                    breathingActivity.GetEndActivty();

                }
                else if (activityChoice == 2 )
                {
                    ListingActivity listingActivity = new ListingActivity("Listing Activity", "help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "listing");
                    listingActivity.GetStartActivity();
                    listingActivity.RunListingActivity();
                    listingActivity.GetEndActivty();
                }
                else if (activityChoice== 3 )
                {
                    ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", "help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "reflection");
                    reflectionActivity.GetStartActivity();
                    reflectionActivity.RunReflectionActivity();
                    reflectionActivity.GetEndActivty();
                }
                else if (activityChoice == 4){
                    break;
                }
                else{
                    Console.WriteLine("invalid input, please try again.");
                }
            }
    
                    Console.WriteLine("now exiting program...");
    

             
        }
    
}          
