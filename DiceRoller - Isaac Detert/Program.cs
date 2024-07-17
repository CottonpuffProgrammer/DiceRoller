using DiceRoller___Isaac_Detert;

Die myDie = new Die(); // Get a random number when die is created
// Setting face value should not be allowed outside of class
byte currentValue = myDie.FaceValue;
myDie.Roll();

Console.ReadKey();