using static System.Console;

string password = "ninja";
if (password.Length < 8)
{
    WriteLine("Tour password is to short at least 8 characters.");
} else
{
    WriteLine("Your password is strong");
}

object o = "3";
int j = 4;

if (o is int i)
{
    WriteLine($" {i} * {j} {i * j}");

}else
{
    WriteLine("o is not int so o it cannot multiply.");

}
