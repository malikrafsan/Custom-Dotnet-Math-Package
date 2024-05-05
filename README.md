# Custom Dotnet Math Package

> This is a custom math package for .NET, providing a wide range of mathematical functions and operations.

## Features
- Basic arithmetic operations: addition, subtraction, multiplication, division, modulus.
- Advanced mathematical functions: power, factorial, greatest common divisor (GCD), least common multiple (LCM), absolute value.
- Statistical operations: sum, product, average, median, mode, range, variance, standard deviation.
- Rounding functions: ceiling, floor, round.
- Exponential and logarithmic functions: exponent, logarithm with custom base, natural logarithm, base-10 logarithm.
- Trigonometric functions: sine, cosine, tangent, etc.

## Usage

### Installation
You can install this package via NuGet Package Manager or by adding the source code directly to your project.

### Example Usage
```csharp
using MathPackage;

class Program
{
    static void Main(string[] args)
    {
        int result = Math.Add(5, 3); // Output: 8
        Console.WriteLine("Addition: " + result);
        
        double value = Math.Sqrt(25); // Output: 5.0
        Console.WriteLine("Square Root: " + value);
        
        // Use other functions similarly...
    }
}
```

## License
This project is licensed under the MIT License.

## Author(s)
- Malik Akbar Hashemi Rafsanjani
