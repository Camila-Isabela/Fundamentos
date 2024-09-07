namespace Praticando;

class DesafioPratico
{
    /*
    1.Crie um programa em que o usuário precisa digitar um nome
      e uma mensagem de boas vindas personalizada com o nome dele
      é exibida:  Olá, Welisson! Seja muito bem-vindo! 
    */
    public static string Exercicio1()
    {
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();
        return $"Olá, {nome}! Seja muito bem-vindo, ou muito bem vinda!";
    }

    /*
    2.Crie um programa que concatene um nome e um sobrenome inseridos 
      pelo usuário e ao final exiba o nome completo.
    */

    public static string Exercicio2()
    {
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();

        return $"{nome} {sobrenome}";
    }

    /*
    3.Crie um programa com 2 valores do tipo double já declarados que retorne:
        - A soma entre esses dois números;
        - A subtração entre os dois números;
        - A multiplicação entre os dois números;
        - A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
        - A média entre os dois números.

    Obs.: Você pode ir além e permitir que o usuário insira dois números aleatórios! 
    */

    public static string Exercicio3()
    {
        //Declarando valores
        double num1 = 10;
        double num2 = 5;

        //Indo além...
        Console.WriteLine("Digite o primeiro número: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        return $"Soma: {num1 + num2}\n" +
            $"Subtração: {num1 - num2}\n" +
            $"Multiplicação: {num1 * num2}\n" +
            $"Divisão: {(num2 == 0 ? "Divisão por zero!" : $"{num1 / num2}")}\n" +
            $"Média: {(num1 + num2) / 2}";
    }

    /*
    4.Crie um programa em que o usuário digita uma ou mais palavras e é 
    exibido a quantidade de caracteres que a palavra inserida tem.
    */

    public static string Exercicio4()
    {
        Console.WriteLine("Digite uma palavra: ");
        string palavra = Console.ReadLine();
        return $"A palavra {palavra} tem {palavra.Length} caracteres.";
    }

    /*
    5.Crie um programa em que o usuário precisa digitar a placa de um veículo 
    e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
        - A placa deve ter 7 caracteres alfanuméricos;
        - Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
        - Os quatro últimos caracteres são números;

    Ao final, o programa deve exibir Verdadeiro se a placa for válida e Falso caso contrário.
    */

    public static string Exercicio5()
    {
        Console.WriteLine("Digite a placa do veículo: ");
        string placa = Console.ReadLine();

        if(placa.Length != 7)
        {
            return "Falso";
        }
        else
        {
            for(int i = 0; i < 3; i++)
            {
                if(!char.IsLetter(placa[i]))
                {
                    return "Falso";
                }
            }

            for(int i = 3; i < 7; i++)
            {
                if(!char.IsDigit(placa[i]))
                {
                    return "Falso";
                }
            }
        }

        return "Verdadeiro";
    }

    /*
    6.Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
        - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
        - Apenas a data no formato "01/03/2024".
        - Apenas a hora no formato de 24 horas.
        - A data com o mês por extenso.
    */

    public static string Exercicio6()
    {
        return $"Data completa: {DateTime.Now}\n" +
               $"Data no formato 01/03/2024: {DateTime.Now:dd/MM/yyyy}\n" +
               $"Hora no formato 24 horas: {DateTime.Now:HH:mm:ss}\n" +
               $"Data com o mês por extenso: {DateTime.Now:dd/MMMM/yyyy}";
    }
}
