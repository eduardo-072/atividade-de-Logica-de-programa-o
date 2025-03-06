// 1- 
String nome;

Console.WriteLine("Digite seu nome");
nome = Console.ReadLine();
Console.WriteLine("Seu nome é: " + nome);

// 2-
Console.Write("Digite um número: ");
Double n1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo numero: ");
Double n2 = Convert.ToDouble(Console.ReadLine());

Double Soma, Mult, Div, Sub;

Soma = n1 + n2;
Sub = n2 - n1;
Mult = n1 * n2;
Div = n1 / n2;

Console.WriteLine("\n Soma: " + Soma);
Console.WriteLine("\n Subtração: " + Sub);
Console.WriteLine("\n Multiplicação: " + Mult);
Console.WriteLine("\n Divisão: " + Div);
Console.ReadKey();

// 3-
int idade_Nasc, idade_atual;
Console.WriteLine("Digite o ano de seu nascimento");
idade_Nasc = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o ano em que estamos");
idade_atual = Convert.ToInt32(Console.ReadLine());

int result = idade_atual - idade_Nasc;
Console.WriteLine("Sua idade é: " + result);

//4- 
Console.WriteLine("Vamos fazer uma média aritimética");
Console.Write("Digite o primeiro número: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o primeiro número: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o primeiro número: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int result = (n1 + n2 + n3) / 3;

Console.Write("Seu resultado foi: " + result);


// 5-
Console.Write("Digite um número: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int result = n1 -1;

Console.WriteLine("Olhe a mágica acontecer: " + result);
Console.ReadKey();

//agora com letras//
Console.Write("Digite uma letra: ");
double L = Convert.ToDouble(Console.Read());

double antecessor_L = L - 1;
Console.Write($"\nSeu antecessor é {(char)antecessor_L}");

Console.ReadKey();

// 6-
Console.WriteLine("Cálculo a área de um retângulo ");

Console.Write("Digite o primeiro ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número ");
int h = Convert.ToInt32(Console.ReadLine());

int result = b * h;
Console.Write("A área do retângulo é de: " + result);

Console.ReadKey();

// 7-
Console.Write("Digite sua idade: ");
int AA = Convert.ToInt32(Console.ReadLine());
int MM = 0;

int result = (AA * 365) + (MM * 30);
Console.WriteLine("Sua idade em dias é de: " + result + "dias");
    
// 8-
Console.Write("Vamos calcular a formula de bharkara:");

Console.Write("Digite o primeiro número: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o terceiro número: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int result = num1 * num1;
int result1 = 4 * num2 * num3;
int result2 = result1 - result;

Console.WriteLine("O resultado de Δ é de: " + result2);

// 9-
Console.WriteLine("Cálcule a sua média poderada");
Console.Write("Digite sua primeira nota: ");
int nota1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite sua segunda nota: ");
int nota2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite sua terceira nota: ");
int nota3 = Convert.ToInt32(Console.ReadLine());

int peso1 = 2;
int peso2 = 3;
int peso3 = 5;

int soma = (nota1 * peso1) + (nota1 * peso1) + (nota1 * peso1);
int result = soma / peso1 + peso2 + peso3;

Console.Write("Sua média ponderada final foi de " + result);
