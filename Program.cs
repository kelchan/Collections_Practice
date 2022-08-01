// ---------- Three Basic Arrays ----------

// Create an array to hold integer values 0 through 9
int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// Create an array of the names "Tim", "Martin", "Nikki", and "Sara"
string[] names = { "Tim", "Martin", "Nikki", "Sara" };

// Create an array of length 10 that alternates between true and false values, starting with true
bool[] bools = { true, false, true, false, true, false, true, false, true, false };



// ---------- List of Flavors ----------

// Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
List<string> flavors = new List<string>()
{
    "vanilla",
    "chocolate",
    "cookies and creme",
    "cookie dough",
    "mint chocolate chip"
};

// Output the length of this list after building it
int numberOfFlavors = flavors.Count;
Console.WriteLine( $"Number of ice cream flavors: {numberOfFlavors}" );

// Output the third flavor in the list, then remove this value
string thirdFlavor = flavors[2];
Console.WriteLine( $"Removing third ice cream flavor: {thirdFlavor}" );
flavors.RemoveAt( 2 );

// Output the new length of the list (It should just be one fewer!)
Console.WriteLine( $"New number of flavors: {flavors.Count}" );



// ---------- User Info Dictionary ----------

// Create a dictionary that will store both string keys as well as string values
Dictionary<string, string> userInfo = new Dictionary<string, string>();

// Add key/value pairs to this dictionary where:
//      each key is a name from your names array
//      each value is a randomly elected flavor from your flavors list.
Random rand = new Random();
foreach( string name in names )
{
    int randNum = rand.Next( 0, flavors.Count );
    userInfo.Add( name, flavors[ randNum ] );
};


// Loop through the dictionary and print out each user's name and their associated ice cream flavor
foreach( KeyValuePair<string,string> user in userInfo )
{
    Console.WriteLine( user );
};

