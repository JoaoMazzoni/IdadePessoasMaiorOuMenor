int idade;
int maior = 0;
int menor = 0;

for(int i = 1; i <= 10; i++)
{
    do
    {
        Console.Write("\nDigite a idade da Pessoa {0}: ", i);
        idade = int.Parse(Console.ReadLine());
        if (idade < 0)
        {
            Console.WriteLine("\n|A idade não pode ser menor que zero!\n");
            Console.WriteLine("------------------------------------------------------");
        }

    } while (idade < 0);
   
    if(idade >= 18)
    {
        maior++;
    }

    else
    {
        menor++;
    }

}
 
Console.WriteLine("\n|Pessoas maiores de idade: {0}", maior);
Console.WriteLine("|Pessoas menores de idade: {0}", menor);


