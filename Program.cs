Console.WriteLine("How much do you weigh in kg?");

//Recieves input from user as a string
string? strWeight = Console.ReadLine();

double weight = 0;

//Converts string to a double value
if(strWeight != null){
    weight = double.Parse(strWeight);
} else {
    Console.WriteLine("Please enter a Value");
}

//Used the console here to test if the double value was correct
//Console.WriteLine($"{weight}");

//Instantiating Class as object to access methods
ProteinCalculator obj = new ProteinCalculator();

//Calculating the amount of protein needed 
double result = obj.CalculateDailyIntake(weight);

//Printing value to User
Console.WriteLine($"Your daily amount of protein is {result}.grams");

class ProteinCalculator{
    public double CalculateDailyIntake(double weight){
        double proteinPerKg = 2.2;
        return weight * proteinPerKg;
    }

}