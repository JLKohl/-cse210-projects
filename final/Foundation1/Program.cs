using System;
using Foundation1;

class Program
{
    static void Main(string[] args)
    {
        // video A
        
        Comment oneA = new Comment();
        oneA._name = "Tommy Jones";
        oneA._comment = "This product is great!";
        
        Comment twoA = new Comment();
        twoA._name = "Stacy Mann";
        twoA._comment = "I would love to try this new product in my house.";
        
        Comment threeA = new Comment();
        threeA._name = "Rachel Lee";
        threeA._comment = "Im not 100% sure I understood how to use this product.";
        
        Comment fourA = new Comment();
        fourA._name = "Trixie Ponee";
        fourA._comment = "Can you tell me where I can get this product?";
        
        //Video B
        Comment oneB = new Comment();
        oneB._name = "KK Marino";
        oneB._comment = "This is really cool, can you make another video about this product?";
        
        Comment twoB = new Comment();
        twoB._name = "Travis Swift";
        twoB._comment = "Is this something you use daily or on a weekly basis?";
        
        Comment threeB = new Comment();
        threeB._name = "Kyle Vaoyo";
        threeB._comment = "This product looks like it is well made, love the design.";
        
        // Video C
        Comment oneC = new Comment();
        oneC._name = "Karolina Kutters";
        oneC._comment = "Thanks for another great product review! This one was very informative";
        
        Comment twoC = new Comment();
        twoC._name = "Lynn Manwell";
        twoC._comment = "I think this product would be great to replace the one i used to use, but i can't find any more :(";
        
        Comment threeC = new Comment();
        threeC._name = "Connie Way";
        threeC._comment = "Could you give us an update video on how his product is continuing to work?";
        
        Comment fourC = new Comment();
        fourC._name = "Timetuu Flie";
        fourC._comment = "I bought this and didn't like it as much as you seemed to. I wonder if I did something wrong.";


        Video videoOne = new Video();

        videoOne._author = "Jessica Jimma";
        videoOne._title = "The Best NEW Cleaning Product!";
        videoOne._length = 300;
        videoOne._comments.Add(oneA);
        videoOne._comments.Add(twoA);
        videoOne._comments.Add(threeA);
        videoOne._comments.Add(fourA);
        
        videoOne.Display();
        
        Video videoTwo = new Video();

        videoTwo._author = "Shelly Oceaaaan";
        videoTwo._title = "New cleaning Vaccume that also mops!";
        videoTwo._length = 651;
        videoTwo._comments.Add(oneB);
        videoTwo._comments.Add(twoB);
        videoTwo._comments.Add(threeB);
        
        videoTwo.Display();
        
        Video videoThree = new Video();

        videoThree._author = "Jux theMAN";
        videoThree._title = "Great new self Cleaning litter box!";
        videoThree._length = 453;
        videoThree._comments.Add(oneC);
        videoThree._comments.Add(twoC);
        videoThree._comments.Add(threeC);
        videoThree._comments.Add(fourC);
        
        videoThree.Display();
    }
}