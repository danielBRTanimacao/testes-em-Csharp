Console.Write("Digite seu nome: ");
String yourName = Console.ReadLine();
Console.WriteLine($"Iae {yourName}!");
Console.Write("Digite o seu ano de nascimento: ");
int year = int.Parse(Console.ReadLine());
int age = 2022 - year;
Console.WriteLine($"Você tem {age} anos de idade!");

if(age >= 18)
{
    Console.WriteLine("Você e maior de idade!");
} 
else
{ 
    Console.WriteLine("Você e menor de idade seu corno");
}    
  
    