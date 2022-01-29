using static System.Console;

List<int> intCollection = new() {1,2,3,4,5,6,7,8,9};

List<string> convertAll = intCollection.ConvertAll(c => c.ToString());

//Shortest way to iterate through List and Write into console
convertAll.ForEach(WriteLine);
