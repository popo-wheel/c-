Console.Write("Add your name: ");
string username = Console.ReadLine();

if(username.ToLower() == "timur")
{
    Console.WriteLine("Wow, its Timur!");
}
else{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}