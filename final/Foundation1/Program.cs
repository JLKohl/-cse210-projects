using System;
using Foundation1;

class Program
{
    static void Main(string[] args)
    {
        
        // video A
        
        
        Comment one = new Comment("Tommy Jones", "This product is great!");
        
        Comment two = new Comment("Stacy Mann","I would love to try this new product in my house.");
        
        Comment three = new Comment("Rachel Lee", "Im not 100% sure I understood how to use this product.");
        
        Comment four = new Comment("Trixie Ponee", "Can you tell me where I can get this product?");
        
        List<Comment> vidOneComments = new List<Comment>();
        vidOneComments.Add(one);
        vidOneComments.Add(two);
        vidOneComments.Add(three);
        vidOneComments.Add(four);
        
        Video videoOne = new Video("Jessica Jimma",  "The Best NEW Cleaning Product!", 300, vidOneComments);
        
        videoOne.DisplayVideo();
        
        //Video B
        
        
        Comment five = new Comment("KK Marino", "This is really cool, can you make another video about this product?");
        
        Comment six = new Comment( "Travis Swift", "Is this something you use daily or on a weekly basis?");
        
        Comment seven = new Comment("Kyle Vaoyo", "This product looks like it is well made, love the design.");
        
        List<Comment> vidTwoComments = new List<Comment>();
        vidTwoComments.Add(five);
        vidTwoComments.Add(six);
        vidTwoComments.Add(seven);
        
        Video videoTwo = new Video("Shelly Oceaaaan","New self cleaning robot vacuum that also mops!",  651, vidTwoComments);
        
        videoTwo.DisplayVideo();
        
        // Video C
        
        
        Comment eight = new Comment("Karolina Kutters","Thanks for another great product review! This one was very informative" );
        
        Comment nine = new Comment("Lynn Manwell", "I think this product would be great to replace the one i used to use, but i can't find any more :(");
        
        Comment ten = new Comment( "Connie Way", "Could you give us an update video on how his product is continuing to work?");
        
        Comment eleven = new Comment( "Timetuu Flie",  "I bought this and didn't like it as much as you seemed to. I wonder if I did something wrong.");
        
        List<Comment> vidThreeComments = new List<Comment>();
        vidThreeComments.Add(eight);
        vidThreeComments.Add(nine);
        vidThreeComments.Add(ten);
        vidThreeComments.Add(eleven);
        
        Video videoThree = new Video("Jux theMAN","Great new self Cleaning litter box!", 453, vidThreeComments);
        
        videoThree.DisplayVideo();
    }
}