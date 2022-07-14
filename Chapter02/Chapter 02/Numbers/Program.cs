// unsigned integer means positive whole number or 0
uint naturalNumber = 23;

// integer means negative or positive whole number or 0
int integerNumber = -23;

// float means single-precision floating point

// F suffix makes it a float literal
float realNumber = 2.3F;
// double means double-precision floating point
double anotherRealNumber = 2,3;
// double literal

Console.WriteLine(naturalNumber);
Console.WriteLine(integerNumber);
Console.WriteLine(anotherRealNumber);
Console.WriteLine(realNumber);

int decimalNation = 2_000_000;
int binaryNotation = 0b_001_1110_1000_000_100_000;
int hexadecimalNotation = 0x_001E_8480;


Console.WriteLine($"{decimalNotation == binaryNotation}");



Console.WriteLine("Using doubles:");
double a = 0.1;
double b = 0.2;

if (a + b == 0.3)
{ Console.WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    Console.Writeline($"")
}



Console.WriteLine($"{decimalNotation == hexadecimalNotation}");
Console.WriteLine(decimalNotation);
Console.WriteLine(binaryNotation);
Console.WriteLine(hexadecimalNotation);


Console.WriteLine($"int uses{sizeof(int)} bytes " +
    $" and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}");













