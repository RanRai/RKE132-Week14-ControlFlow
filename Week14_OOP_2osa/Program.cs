Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Good Girl");


Console.WriteLine($"My dogs name is {myDog.Name}."); //getter kuvab Name väärtuse
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}.");

myDog.Rename("Bad Boy"); //Rename meetod kirjeldatakse all pool.


class Dog //class käsu saab paigutada teise faili.
{
    private string _name = "Koer";//public jätab ümbernimetusvõimaluse, private mitte. Väljaspool classi ei ole _name enam kätte saadav.
    private int _level0fHappiness = 0;

    //cunstructor
    public Dog(string name)//name - lets the user name the dog
    {
        _name = name;
        _level0fHappiness = 0;
    }
    //getter, et classi omadust kuvada
    public string Name
    {
        get { return _name; } //tagastan vahemälusse _name nimetuse, aga sellega ei saa peale vaatamise enam midagi teha
    }
    public void Rename(string newName) //annan võimaluse koera nime muutmiseks
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }
    
}
