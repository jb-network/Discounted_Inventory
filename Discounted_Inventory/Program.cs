// This is challenge work for the "C# Players Guide"
// Level 10 the Discounted Inventory Challenge
// Build a simple menu system to display prices of selected items
// The challenge requires the use of either switch statments or switch expressions
// Switch Expressions were used for this challenge
// This program is the same as the Level 10 Buying Inventory challenge, but with a 50% discount applied to a specific name (Swamp Fox). 


//Needed to use for Textinfo (titlecase)
using System.Globalization;

// Creates a TextInfo based on the "en-US" culture.
TextInfo tInfo = new CultureInfo("en-US", false).TextInfo;
Console.WriteLine("Enter your players name: ");
// Passes console to ToTitleCase to ensure name entered in normalized to have the first letter in uppercase and the rest in lower case
string playerName = tInfo.ToTitleCase(Console.ReadLine());
Console.Clear();


//Simple store menu system, user should select a number 1 - 7.  
Console.WriteLine($"Hello {playerName} Welcome to Tortuga Outfitters");
Console.WriteLine("________________________________________________");
Console.WriteLine("The following items are available for purchase: ");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.WriteLine("________________________________________________");
Console.WriteLine("What number do you want to see the price of? ");

//Grab the users input string and convert to an int
int userChoice = Convert.ToInt32(Console.ReadLine());

// the userchoice is mapped to item purchased
string itemPurchased = userChoice switch
{
    1 => "Rope",
    2 => "Tourches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies",
    _ => "Sorry, that is not an item from the list"    
};

//Now that itemPurchased is set with the item name, the next switch will map the item name to a price via itemPrice int.
float itemPrice = itemPurchased switch
{
    "Rope" => 10,
    "Tourches" => 15,
    "Climbing Equipment" => 25,
    "Clean Water" => 1,
    "Machete" => 20,
    "Canoe" => 200,
    "Food Supplies" => 1,
    _ => 0

};

//Discount for Swamp Fox and a bit of lore for fun
if (playerName == "Swamp Fox" && userChoice < 8)
{
    itemPrice /= 2;
    
    Console.WriteLine("\nTortuga does a double take and looks at you again. " +
        "\nWait I know you, he says " +
        "\nYou are the famous Swamp Fox, Francis Marion.  " +
        "\nYou are the father of modern guerrilla warfare. " +
        "\nYou get a 50% discount!");
}

if (itemPrice != 0)
{
    Console.WriteLine($"\n\n{itemPurchased} costs {itemPrice} gold");
}
else
{
    Console.WriteLine("The item you selected is not on the list. " +
        "\nPlease run the program again");
}
//Close out the program with a key press
Console.WriteLine("Press any key to end program");
Console.ReadKey();
