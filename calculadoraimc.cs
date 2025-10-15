System.Console.WriteLine("Olá, seja bem vindo(a) a calculadora de IMC");

System.Console.WriteLine("Insira seu peso:");
var peso = System.Console.ReadLine();
var pesoconv = Convert.ToDouble(peso);
System.Console.WriteLine("Seu peso é: " + pesoconv);

System.Console.WriteLine("Insira sua altura:");
var altura = System.Console.ReadLine();
var alturaconv = Convert.ToDouble(altura);
System.Console.WriteLine($"sua altura é {alturaconv}");

var IMC = pesoconv / (alturaconv * alturaconv);
var IMCarred = Math.Round(IMC, 2);

System.Console.WriteLine($"Seu IMC é: {IMCarred}");

if (IMC < 18.5)
{
    System.Console.WriteLine("Você está com magreza.");
}
else if (IMC >= 18.5)
{
    System.Console.WriteLine("Você está no peso normal.");
}
else if (IMC >= 25)
{
    System.Console.WriteLine("Você está com sobrepeso.");
}
else if (IMC >= 30)
{
    System.Console.WriteLine("Você está com obesidade grau I.");
}
else if (IMC >= 35)
{
    System.Console.WriteLine("Você está com obesidade grau II");
}
else
    {
    System.Console.WriteLine("Você está com obesidade grau III");
    }