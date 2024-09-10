
//string name = "Alpha";


//bool isAlive = name == "Alpha";


//int hp = 100;

//hp += 10;

//hp++;



//Console.WriteLine($"Du har {hp} hp kvar");

//if (hp > 0)
//{
//Console.WriteLine("du är sigma!");

//}

//jag ville bara ha kvar min kod för jag tyckte om den :)


int rätt = 0;
Console.WriteLine("Välkommen till the Sigma Quiz. Den ända quizzen som visar ifall du är sigma eller inte :D!");
//jag tycker ordet sigma är väldigt roligt

Console.WriteLine("Fråga 1, Vad vill man vara i omegaverset?");
Console.WriteLine("a, Alpha b, Beta c, Omega");
string sigmasvaret = Console.ReadLine();
if (sigmasvaret == "a")
{
    rätt++;
    Console.WriteLine("DU hade RÄTT!! DU är verkerligen en potenciell sigma:3");
}
else
{
    Console.WriteLine("Attans, Du hade fel :( Verkar som att du inte är sigman som jag trodde du var.)");
}
Console.WriteLine("Fråga 2, ifall du möter en annan sigma på stan vad gör du?");
Console.WriteLine("a, du börjar ryta om grymta för att visa att du är alphan och tar kontroll över ditt revir! b, Du börjar looksmaxa och moggar den andra sigman för att visa att du är mer sigma än vad den andra är! c, Du gräpper tag i den andra sigmans underliv och känner ifall du kan vinna denna utmaning eller inte!");
string skibidisvaret = Console.ReadLine();
if (sigmasvaret == "c")
{
    rätt++;
    Console.WriteLine("Du är nu 50% mer sigma än vad den generalla populationen verkligen simga av dig");

}
else
{
    Console.WriteLine("cDet är dags för dig att lämna innan jag släpper ut min sigma på dig, Vänta du får ett försök till jag tror på dig sigma");
}

Console.WriteLine($"Du har {rätt} rätt");








Console.ReadLine();
