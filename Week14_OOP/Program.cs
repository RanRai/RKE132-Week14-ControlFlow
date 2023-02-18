Console.WriteLine("Name your dog:");//meetod WC oskab kuvada tagasisidet console aknast
string myDogName = Console.ReadLine();//myDogName antakse läbi Console.ReadLine
Dog myDog = new Dog(myDogName);//kutsun välja classi (string ja int omadused), peale classi loomist.

Dog neighboursDog= new Dog("Good Girl");//loon veel ühe koera(sellele on eraldi andmete kastike, samasugune nagu myDog.), mõlemad on objektid. 
//neighboursDogile on vaikimisi nimi antud

Console.WriteLine($"My dogs name is {myDog._name}.");
Console.WriteLine($"My neighbours dogs name is {neighboursDog._name}.");



class Dog //"koera" kirjelduse loomine. enne loomist tuleb objekti kirjeldada
{
    public string _name = "Koer";//annan "koerale" nime. (public jätab ümbernimetusvõimaluse, private mitte)
    public int _level0fHappiness = 0;//anna Koerale rõõmu mõõtme. vaikimisi ei ole Koer õnnelik. String & int jagavad ühte kasti myDog

    //cunstructor - laseb kasutajal koera nime anda. saame lahti väärtustest, mis me oleme andnud vaikimisi
    public Dog(string name)//name - lets the user name the dog. ei pane _name. 
    {
        _name= name; //name tuleb kasutaja käest.
        _level0fHappiness = 0;
    }
}
