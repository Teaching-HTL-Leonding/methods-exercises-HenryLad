int min = 0;
int max = 0;
int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int enternumber = 0;
bool fortnite = false;
string selection;

do
{
   Console.Clear();
   Console.WriteLine("What do you want to execute?");
   Console.WriteLine("============================");
   Console.WriteLine();
   Console.WriteLine("0. Calculate Circle Area");
   Console.WriteLine("1. Random in Range");
   Console.WriteLine("2. To FizzBuzz");
   Console.WriteLine("3. Fibonacci by Index");
   Console.WriteLine("4. Ask for Number in Range");
   Console.WriteLine("5. Is palindrome?");
   Console.WriteLine("6. Is palindrome? (advanced)");
   Console.WriteLine("7. Chart Bar");
   Console.WriteLine("8. Count Smiling Faces");
   Console.WriteLine("q to Quit");
   selection = Console.ReadLine()!;

   if (selection != "q")
   {
      Console.Clear();
      switch (selection)
      {
         case "0": RunCalculateCircleArea(); break;
         // TODO: Add additional cases for other methods here

         case "1": MaxMin(); Gibaus(); break;
         case "2": ToFizzBuzz(); break;
         case "3": Fibonacci(); break;
         case "4": NumberRange(); CheckIfValid(min, max); break;
         case "5": Chuxel(); break;
         case "6 ": TrippleChuxel(); break;
         default: break;
      }

      Console.WriteLine("Press any key to continue...");
      Console.ReadKey();
   }
}
while (selection != "q");

// TODO: Create one code region for each level
#region Calculate Circle Area
void RunCalculateCircleArea()
{
   Console.Write("Enter radius:");
   var radius = double.Parse(Console.ReadLine()!);
   var area = CalculateCircleArea(radius);
   Console.WriteLine($"Area of circle with radius {radius} is {area}");
}

double CalculateCircleArea(double radius)
{
   return radius * radius * Math.PI;
}
#endregion

#region Level1



void MaxMin()
{
   Console.Write("Enter your min Value : ");
   min = int.Parse(Console.ReadLine()!);
   Console.Write("Enter you max Value : ");
   max = int.Parse(Console.ReadLine()!);
}

int RandomInRange(int max, int min)
{
   return Random.Shared.Next(min, max + 1);
}


void Gibaus()
{
   for (int i = 0; i < 1000000; i++)
   {
      int RandomNUmber = RandomInRange(max, min);


      if (RandomNUmber == 0) { counter0++; }
      if (RandomNUmber == 1) { counter1++; }
      if (RandomNUmber == 2) { counter2++; }
   }
   System.Console.WriteLine($"You have {counter0} 0; you have {counter1} 1; you have {counter2} 2 ");
}
#endregion

#region Level2
int Value = 0;
void ToFizzBuzz()
{
   Console.WriteLine("Enter a Value: ");
   Value = int.Parse(Console.ReadLine()!);
   string result = CheckTOFizzBuzz(Value);
   System.Console.WriteLine($"You have a {result}");

}

string CheckTOFizzBuzz(int Value)
{
   if (Value % 3 == 0 && Value % 5 == 0)
   {
      return "FizzBuzz";
   }
   else if (Value % 3 == 0)
   {
      return "Fizz";
   }
   else if (Value % 5 == 0)
   {
      return "Buzz";
   }
   else
      return Value.ToString();
}
#endregion

#region Level 3

int index = 0;
void Fibonacci()
{
   System.Console.Write("Enter the number");
   index = int.Parse(Console.ReadLine()!);
   int result = FibonacciByIndex(index);
   System.Console.WriteLine($"Your index is {result}");



}
int FibonacciByIndex(int index)
{
   if (index == 0)
      return 0;
   else if (index == 1)
      return 1;
   else
      return FibonacciByIndex(index - 1) + FibonacciByIndex(index - 2);

}
Fibonacci();

#endregion
#region  Level 4

void NumberRange()
{
   min = 0;
   max = 0;
   Console.Write("Enter your min Value : ");
   min = int.Parse(Console.ReadLine()!);
   Console.Write("Enter you max Value : ");
   max = int.Parse(Console.ReadLine()!);
}
void CheckIfValid(int min, int max)
{
    fortnite = false;
   do
   {
      System.Console.WriteLine($"PLease enter a number between {min} and {max}");
      enternumber = int.Parse(Console.ReadLine()!);
      if (enternumber > max) { System.Console.WriteLine("Your number is to big"); }
      else if (enternumber < min) { System.Console.WriteLine("Your number is to little"); }
      if (enternumber > min && enternumber < max) { System.Console.WriteLine("Vaild input. Thank you for your time."); fortnite = true; }
   } while (fortnite == false);
}



#endregion
#region  Level 5
void Chuxel(){
System.Console.Write("Enter a text input: ");
string input = System.Console.ReadLine()!;
if(!isPladirome(input))
{
   System.Console.WriteLine("The input is not a Palindrome");
}
if(isPladirome(input))
{
   System.Console.WriteLine("The input is  a Palindrome");
}
bool isPladirome(string text)
{
   for (int i = 0; i < text.Length / 2; i++)
   {
      if (text[i] != text[text.Length - i - 1])
      {
         return false;
      }
      
   }
   return true;
}}

#endregion
#region Level 6

void TrippleChuxel()
{
   System.Console.Write("Enter a text input: ");
string input = System.Console.ReadLine()!.ToLower();
if(!isPalindrome(input))
{
   System.Console.WriteLine("The input is not a Palindrome");
}
if(isPalindrome(input))
{
   System.Console.WriteLine("The input is a Palindrome");
}



bool isPalindrome(string text)
{
    if(text.Length == 0){return false;}
     text = text 
      .Replace("", "")
      .Replace(",", "")
      .Replace(".", "")
      .ToLower();
      


    for (int i = 0; i < text.Length / 2; i++)
    {
        if (text[i] != text[text.Length - i - 1])
        {
            return false;
        }
    }
    return true;
}}


#endregion