using System.Text;

decimal saldo = 1000.0m;

Console.WriteLine("Bem-vindo ao caixa eletronico da ADS");
int opcao = 0;

do
{
    Console.WriteLine("1-Ver Saldo\n2-Depositar\n3-sacar\n4-Sair");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Saldo: atual: R${saldo:F2}");
            break;

        case 2:
            Console.WriteLine("Valor do deposito: ");
            Decimal deposito = Convert.ToDecimal(Console.ReadLine());
            saldo += deposito;
            Console.WriteLine($"Deposito de: R${deposito} efetuado com Sucesso.");
            break;

        case 3:
            Console.Write("Valor para saque: R$");
            decimal valor = Convert.ToDecimal(Console.ReadLine());
            while (saldo - valor < 0)
            {
                Console.WriteLine($"O saque de {valor} não concluido, saldo insuficiente, você tem {saldo}");
                valor = Convert.ToDecimal(Console.ReadLine());
                
            }
        saldo -= valor;
        Console.WriteLine($"Você sacou {valor} e o saldo atual é: {saldo}");
     
        break;
    default:
    Console.WriteLine("Você escolheu uma opção invalida, tente novamente!");
    break; 
    }
    
} while (opcao != 4);