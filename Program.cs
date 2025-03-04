//declare multTwo and multiplies 5 by 7
int multTwo = 5 * 7;
//declare addTwo and adds 6 and 12
int addTwo = 6 + 12;
//declare min and determine the lower value of multTwo and addTwo
int min = Math.Min(multTwo, addTwo);
//declare max and determine the higher value of multTwo and addTwo
int max = Math.Max(multTwo, addTwo);
// write a truthful statement of which of the two values are greater or lesser
Console.WriteLine($"The greater value of {multTwo} and {addTwo} is {max} while the lesser value is {min}");
//declare isIntGreater and determines max is greater
bool isIntGreater = max > min; 
//writes question of weither if multTwo is greater or addTwo
Console.WriteLine($"So is {multTwo} greater than {addTwo}?");
//writes that the question is true
Console.WriteLine(isIntGreater);