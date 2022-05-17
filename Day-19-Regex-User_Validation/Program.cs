// See https://aka.ms/new-console-template for more information
using Day_19_Regex_User_Validation;

Console.WriteLine("----- Regex User Validation -----\n");

RegexOps pattern = new RegexOps();

Console.Write("Enter Email_Id of the User :- ");
string User_MailID = Console.ReadLine();
if(pattern.ValidateUserName(User_MailID))
{
    Console.WriteLine("\n>> User Mail_ID format is Valid....");
}
else
{
    Console.WriteLine("\n>> User Mail_ID format is Invalid....");
}

