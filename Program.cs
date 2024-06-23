
using Exercicio_Robson1;

Basico _bas = new Basico();
Console.WriteLine("valor x");
_bas.X = double.Parse(Console.ReadLine());
Console.WriteLine("valor y");
_bas.Y = double.Parse(Console.ReadLine());
Console.WriteLine();
_bas.Multiplicar();
Console.WriteLine();
_bas.Dividir();
Console.WriteLine();
_bas.Somar();
Console.WriteLine();
_bas.Subtrair();

Estatico _estatico;
Console.WriteLine("Digite a quantidade de notas");
int valor = int.Parse(Console.ReadLine());
Estatico[] vect = new Estatico[valor];
for (int i = 0; i < valor; i++)
{
    double d = double.Parse(Console.ReadLine());
    vect[i] = new Estatico { A = d };
    
}
double media = 0.0;
for (int i = 0;i < valor; i++)
{
    media += vect[i].A;
}
double media2 = media / valor;
Console.WriteLine("Media " + media2);
