string mes =  "";
int dias = 0;

Console.WriteLine("------------");
Console.WriteLine("Dias de um mês");
Console.WriteLine("-------------\n");

Console.WriteLine("Informe o mês por extenso: ");
mes = Console.ReadLine()!.ToUpper();

switch(mes)
{
    case "JANEIRO":
    case "MARÇO":
    case "MAIO":
    case "JULHO":
    case "AGOSTO":
    case "OUTUBRO":
    case "DEZEMBRO":
        dias = 31;
        break;
    case "ABRIL":
        dias = 30;
        break;
    case "SETEMBRO":
    case "NOVEMBRO":
        dias = 30;
        break;
    case "JUNHO":
        dias = 29;
        break;
    case "FEVEREIRO":
        dias = 28;
        break;
            default:
                Console.WriteLine("Mês inválido");
                break;
        }
if (dias > 0)

{
    Console.WriteLine($"O mês de {mes} possui {dias} dias");
}