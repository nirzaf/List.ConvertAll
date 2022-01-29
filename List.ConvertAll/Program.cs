
using static System.Console;

List<int> intCollection = new() {1,2,3,4,5,6,7,8,9};

List<string> convertAll = intCollection.ConvertAll(c => c.ToString());

foreach (var sVal in convertAll)
{
    WriteLine(sVal);
}