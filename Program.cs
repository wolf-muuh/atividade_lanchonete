//crie um menu de opções e peça para o usuário escolher uma das opções
//a depender da opção, exiba uma mensagem se gostaria de acrescentar gelo
//se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo
//caso contrário, a bebida é sem gelo adicional


Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(@$"
-------------------------------------
|      ~~Cardápio de bebidas~~      | 
|                                   |
|    sucos: 1)laranja               |
|           2)uva                   |
|           3)manga                 |
|           4)caja                  |
|           5)caju                  |
|                                   |
|  Refrigerantes: 6) coca-cola      |
|                 7) Pepsi          |
|                 8) Guarana        |
|                 9) Fanta uva      |
|                 10) Fanta laranja |
-------------------------------------    
");
Console.ResetColor();

Console.WriteLine($"Digite o número da bebida desejada: ");
int numBebida = int.Parse(Console.ReadLine());

int nomeBebida = 0;

switch (numBebida)
{
    case 1:
        Console.WriteLine($"Suco de laranja");

        break;

    case 2:
        Console.WriteLine($"Suco de uva");

        break;

    case 3:
        Console.WriteLine($"Suco de manga");

        break;


    case 4:
        Console.WriteLine($"Suco de caja");

        break;

    case 5:
        Console.WriteLine($"Suco de caju");

        break;
    case 6:
        Console.WriteLine($"coca-cola");

        break;
    case 7:
        Console.WriteLine($"pepsi");

        break;
    case 8:
        Console.WriteLine($"guaraná");

        break;
    case 9:
        Console.WriteLine($"fanta uva");

        break;
    case 10:
        Console.WriteLine($"fanta laranja");

        break;

    default:
        Console.WriteLine($"O número digitado não corresponde a nenhuma opção de bebida.");

        break;
}

Console.WriteLine($"Deseja por gelo por mais 50 centavos? digite ~~s~~ para sim e ~~n~~ para não");
string simounao = Console.ReadLine();

switch (simounao)
{
    case "s":
        Console.WriteLine($"Ok será R$2,50 tenha um bom dia");

        break;

    case "n":
        Console.WriteLine($"Ok R$2 será tenha um bom dia");

        break;
    default:
        Console.WriteLine($"Eu fui bem claro utilize ~~s~~ para sim e ~~n~~ para não... repita o processo!");
        
        break;
}







