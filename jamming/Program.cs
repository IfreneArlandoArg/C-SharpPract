
// See https://aka.ms/new-console-template for more information
using jamming;
using System.Text.RegularExpressions;

try
{
    Dictionary<int, Person> myDict = new Dictionary<int, Person>();

    string[] MonthYear = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

    myDict.Add(1, new Person("Ifrene", "Arlando A.", 96153411, DateTime.Parse("06/09/1998")));
    myDict.Add(2, new Person("Desiderio", "Mariana M.", 90000000, DateTime.Parse("06/12/1988")));
    myDict.Add(3, new Person("Desiderio", "Wes", 86153411, DateTime.Parse("12/21/2018")));


    foreach (KeyValuePair<int, Person> element in myDict)
    {

        Console.WriteLine($"Hello, {element.Value.FirstName} {element.Value.LastName} {element.Value.Birthday.Day} of {MonthYear[element.Value.Birthday.Month - 1]}, {element.Value.Birthday.Year}!\n");
    }

    Regex rgx = new Regex(@"^[0-9]{2}-[0-9]{3}-[0-9]{3}-[A-Z]{3}$");

    Console.WriteLine("Enter your ID :\nFormat : NN-NNN-NNN-LLL");
    string UserInput = Console.ReadLine();

    if (!rgx.IsMatch(UserInput))
        throw new Exception("Incorrect Input format...\nFormat : NN-NNN-NNN-LLL\nN being being integers from 0 to 9... and L being uppercase letters From A to Z");

    Console.WriteLine($"Success!!!\n{UserInput} is in the right format...");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
	
}

