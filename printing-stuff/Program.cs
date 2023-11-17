// C# recognizes `string` as a native type.
string firstMessage = "Hello, World!";

// WriteLine adds a new line (also known as: Line Feed, LF, \n, 0x0A, %0A...) at the end
Console.WriteLine("First Example:");
Console.WriteLine(firstMessage);

Console.WriteLine("== End Of Example ==");

string secondMessage = "Marco";
string secondMessageWord = "Polo";
// Mind you: C# (just like C/C++) treats ' differently than ".
char dot = '.';
char space = ' ';

Console.WriteLine("Second Example:");
// this looks like it'd say: Marco... Polo...
// But you'd be surprised with the output...
Console.Write(secondMessage, dot, dot, dot, space, secondMessageWord, dot, dot, dot);
// A single line
Console.Write("\n");
// This works as expected
Console.WriteLine("Second Example (again): {0}... {1}...", secondMessage, secondMessageWord);
// And we can go to ridiculous extents...
Console.WriteLine("Second Example (again): {0}{1}{1}{1}{2}{3}{1}{1}{1}", secondMessage, dot, space, secondMessageWord);

Console.WriteLine("== End Of Example ==");

// Numbers are just like in C/C++...
int number = 628;
double double_with_decimals = 355.0/113.0; // half-assed Pi
// Downgrading types must be explicit... This will make sense later.
float number_with_decimals = (float)(355.0/113.0); // half-assed Pi x2

Console.WriteLine("Third Example:");

Console.WriteLine("int: {0}", number);
Console.WriteLine("float: {0}", number_with_decimals);
Console.WriteLine("double: {0}", double_with_decimals); // notice the decimals

Console.WriteLine("---");
Console.WriteLine("Hex: {0:X}", number);
Console.WriteLine("Percent: {0:P}", number_with_decimals/5);
Console.WriteLine("Scientific Notation: {0:E}", number_with_decimals);
Console.WriteLine("Currency: {0:C}", double_with_decimals); // good luck changing locale...

Console.WriteLine("== End Of Example ==");