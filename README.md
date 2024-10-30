# Quadratic Equation Solver

This repository contains a simple C# application designed to solve quadratic equations. The application prompts the user to enter the coefficients of a quadratic equation, calculates the roots, and then displays the results.

## Overview

### Project Description

The Quadratic Equation Solver is a console-based application that solves quadratic equations of the form \( ax^2 + bx + c = 0 \). It uses the quadratic formula to determine the roots of the equation and handles cases where there are two real roots, one real root, or no real roots.

### Features

- Solves quadratic equations with real coefficients.
- Determines and displays the number of real roots.
- Outputs the roots if they exist.

### Project Structure

- **App.config**: Contains configuration settings for the .NET application.
- **Equation.cs**: Defines the `Equation` class with a method to solve quadratic equations.
- **Program.cs**: The main entry point of the application, which handles user input and displays the results.

## Getting Started

### Prerequisites

- .NET Framework 4.7.2 or higher

### Running the Application

1. Clone the repository:
    ```sh
    git clone https://github.com/your-username/QuadraticEquationSolver.git
    ```
2. Open the solution in Visual Studio or any other compatible IDE.
3. Build the solution to restore the necessary packages.
4. Run the application.

### Using the Application

1. When prompted, enter the coefficients `a`, `b`, and `c` of the quadratic equation \( ax^2 + bx + c = 0 \).
2. The application will calculate the roots and display the results.

## Example

```
Enter coefficients a, b and c:
1
-3
2
The equation has two real roots: 2 and 1
```

## Contributing

Contributions are welcome! Please fork this repository and submit pull requests with your changes.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Acknowledgments

- Inspired by basic quadratic equation solvers typically introduced in algebra courses.

