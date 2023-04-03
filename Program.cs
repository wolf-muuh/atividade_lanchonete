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

string nomeBebida = ".........."; 

switch (nomeBebida)
{
    case 1:
        Console.WriteLine($"Suco de laranja");
        
        break;
    default:
        break;
}





