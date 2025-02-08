// Implicit conversion. A long can hold any value an int can hold, and more!
using System.Runtime.CompilerServices;

int numero = 218756785;
long numeroLargo = numero;
System.Console.WriteLine(numeroLargo); // 218756785

// Implicit conversion. A long can hold any value an int can hold, and more!
double x = 1234.7;
int b;
// Cast double to int.
b = (int)x;
System.Console.WriteLine(b); // 1234


// Operador -- (incremento)

int i = 3;
Console.WriteLine(i);   // output: 3
Console.WriteLine(i++); // output: 3
Console.WriteLine(i);   // output: 4

double c = 1.5;
Console.WriteLine(c);    // output: 1.5
Console.WriteLine(++c);  // output: 2.5
Console.WriteLine(c);    // output: 2.5

// Operador -- (decremento)

int j = 3;
Console.WriteLine(j);   // output: 3
Console.WriteLine(j--); // output: 3
Console.WriteLine(j);   // output: 2

double d = 1.5;
Console.WriteLine(d);    // output: 1.5
Console.WriteLine(--d);  // output: 0.5
Console.WriteLine(d);    // output: 0.5

//El operador + unario

Console.WriteLine(+4); // output: 4
Console.WriteLine(-4); // output: -4
Console.WriteLine(-(-4)); // output: 4

uint e = 5;
var f = -e;
Console.WriteLine(f); // output: -5
Console.WriteLine(f.GetType()); // output: System.Int64

Console.WriteLine(-double.NaN); // output: NaN


// Operador * (multiplicación)


Console.WriteLine(5 * 2); // output: 10

Console.WriteLine(0.5 * 2.5); // output: 1.25

Console.WriteLine(0.1m * 23.4m); // output: 2.34


// Operador / (división)

Console.WriteLine(13 / 5.0); // output: 2.6

int g = 13;
int h = 5;

Console.WriteLine((double)g / h); // output: 2.6

// Operador % (módulo)

Console.WriteLine(5 % 4); // output: 1
Console.WriteLine(5 % -4); // output: 1
Console.WriteLine(-5 % 4); // output: -1
Console.WriteLine(-5 % -4); // output: -1

// Expresion Booleana 


DisplayMeasurement(45); // output: The measurement value is 45 
DisplayMeasurement(-3); // output: Warning: not acceptable value! The measurement value is -3

void DisplayMeasurement(double value) {

   if (value < 0 || value > 100)
    {
        Console.WriteLine("Warning: not acceptable value!");
    }

   Console.WriteLine($"The measurement value is {value}");
}


// Estructura compuesta

DisplayWheaterReport(15.0); // output: The weather is cold  
DisplayWheaterReport(25.0); // output: The weather is cool


    void DisplayWheaterReport(double tempInCelsius) { 

       if (tempInCelsius < 20.0)
    {
        Console.WriteLine("The weather is cold");
    }
    else
    {
        Console.WriteLine("The weather is cool");
    }

}

// Estructura multiple

DisplayCharacter('f');  // Output: A lowercase letter: f
DisplayCharacter('R');  // Output: An uppercase letter: R
DisplayCharacter('8');  // Output: A digit: 8
DisplayCharacter(',');  // Output: Not alphanumeric character: .

void DisplayCharacter(char ch)
{
    if (char.IsUpper(ch))
    {
        Console.WriteLine($"An uppercase letter: {ch}");
    }
    else if (char.IsLower(ch))
    {
        Console.WriteLine($"A lowercase letter: {ch}");
    }
    else if (char.IsDigit(ch))
    {
        Console.WriteLine($"A digit: {ch}");
    }
    else
    {
        Console.WriteLine($"Not alphanumeric character: {ch}");
    }
}


// Estructura switch

DisplayMeasurementt(-4); // Output: Measured value is -4; too low.
DisplayMeasurementt(5); // Output: Measured value is 5.
DisplayMeasurementt(30); // Output: Measured value is 30; too high.
DisplayMeasurementt(double.NaN); // Output: Failed measurement.

void DisplayMeasurementt(double measurement)
{
    switch (measurement)
    {
        case < 0.0:
            Console.WriteLine($"Measured value is {measurement}; too low.");
            break;

        case > 15.0:
            Console.WriteLine($"Measured value is {measurement}; too high.");
            break;

        case double.NaN:
            Console.WriteLine("Failed measurement.");
            break;

        default:
            Console.WriteLine($"Measured value is {measurement}.");
            break;
    }
}

//Instrucciones de iteración: for, foreach, do y while

for (int ii = 0; ii < 3; ii++)
{
    Console.WriteLine(ii);
}

// Output:
//012


List<int> fibNumbers = new() { 0, 1, 1, 2, 3, 5, 8, 13 };

foreach(int element in fibNumbers)
{
    Console.WriteLine($"{element} ");   
}

// output

// 0 1 1 2 3 5 8 13


// Intrucción Do

int jj = 0;

do { 
    
    
    Console.WriteLine(jj);
    jj++;


}while (jj < 3);

//Output:
//01234


// Instrucción While

int kk = 0;

while (kk < 5)
{
    Console.WriteLine(kk);
    kk++;
}

//Output:   
//01234


// Instrucción Metodos

string[] names = { "Spencer", "Sally", "Doug" };

string GetName(int ID)
{
    if (ID < names.Length)
        return names[ID];
    else
        return String.Empty;
}

