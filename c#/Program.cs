Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"Olá, {nome}");
Console.Write("Digite sua idade: ");
int num1 =  int.Parse(Console.ReadLine());
if(num1 < 18)
{
    Console.WriteLine("Você e menor de idade");
}
if(num1 >= 18)
{
    Console.WriteLine("Você e maior de idade!");
}