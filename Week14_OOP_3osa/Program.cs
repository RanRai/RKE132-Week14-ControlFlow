Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Good Girl");


Console.WriteLine($"My dogs name is {myDog.Name}."); //getter kuvab Name väärtuse
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}.");

myDog.Rename("Bad Boy"); //all meetod ümbernimetamiseks

while (myDog.Level0fHappiness != 5) //lasen haukuda kuni 5 korda while tsükliga
{
    myDog.Bark(); //panen koera haukuma
}

myDog.WagTail(); //koer hakkab saba liputama peale 5 korda haukumist

class Dog //kirjeldab nii meie kui naabri koera (class), "koeri" saab juurde luua
{
    private string _name = "Koer";//privat kaitseb koera nime. Väljaspool classi ei ole _name enam kätte saadav.
    private int _level0fHappiness = 0;

    //cunstructor
    public Dog(string name)//name - lets the user name the dog
    {
        _name = name;
        _level0fHappiness = 0;
    }
    //getter, et classi omadust kuvada
    public string Name //et kuvada koera nime
    {
        get { return _name; }
    }

    public int Level0fHappiness //et kuvada koera õnnelikkust
    {
        get { return _level0fHappiness; } //et saaksin heaolutaset hiljem näha.
    }
 

    public void Rename(string newName) //lase nime muuta
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }

    public void Bark() //iga kord kui koer haugub, suureneb heaolutase koeral
    {
        Console.WriteLine("Woof-woof!");
        _level0fHappiness++; //iga haukumisega suureneb õnnelikkuse tase +1
    }

    public void WagTail()//meetod mida oskab class kasutada. panime koera saba liputama
    {
        Console.WriteLine("Wiggle-wiggle!"); //koer liputab saba.
    }
}
