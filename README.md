# Household Census Program

This is a simple console application written in C# that allows users to input information about multiple households, such as the name of the household, annual income, and number of members. The program then determines whether each household is eligible for assistance based on specific income thresholds. Finally, it displays the household information, including the assistance status, and calculates the average income of all households.

## Usage

To use this program, follow these steps:

1. Compile the source code files (`class1.cs` and `Program.cs`) using a C# compiler.
2. Run the compiled executable to start the program.
3. Enter the requested information for each household, including the household name, annual income, and number of members.
4. After entering the details for each household, the program will determine the assistance eligibility and display the household information, including the assistance status.
5. The program will also calculate and display the average income of all households.

## Files

This project contains the following files:

- `class1.cs`: This file contains the `Main` method, which is the entry point of the program. It creates an instance of the `HouseholdCensus` class and calls its methods to input household information and determine assistance.
- `Program.cs`: This file contains the `HouseholdCensus` class, which encapsulates the functionality of the household census program. It includes methods to input household information, determine assistance eligibility, and display household information.

## Functionality

### `HouseholdCensus` Class

#### Constructor

- `HouseholdCensus()`: Initializes a new instance of the `HouseholdCensus` class.

#### Public Methods

- `void inputHouseholdInfo()`: Prompts the user to input information for multiple households, including the name of the household, annual income, and number of members. The information is stored in private arrays.
- `void determineAssistance()`: Determines the assistance eligibility for each household based on the number of members and annual income. The results are stored in a private array.
- `void displayHouseholdInfo(string[] namesOfHeads, double[] annualIncome, int[] numberOfMembers, char[] assistanceCode, int counter)`: Displays the household information, including the household name, annual income, number of members, and assistance status. It also calculates and displays the average income of all households.

### `Program` Class

#### `Main` Method

- `static void Main(string[] args)`: The entry point of the program. It creates an instance of the `HouseholdCensus` class and calls its methods to perform the household census.

## Contributing

If you would like to contribute to this project, feel free to fork the repository and submit a pull request. Your contributions are greatly appreciated!
