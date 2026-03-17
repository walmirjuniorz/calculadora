// v1
// Nossa calculadora deve ter a possibilidade de somar dois números [x]
// Nossa calculadora deve ter a possibilidade de subtrair dois números [x]
// Nossa calculadora deve ter a possibilidade de multiplicar dois números [x]
// Nossa calculadora deve ter a possibilidade de dividir dois números [x]
// Calculadora deve ter a possibilidade de executar operacoes em continuidade [x]

// v2
// Nossa calculadora deve produzir a tabuada de um numero informado
// Nossa calculadorada deve armazenar um historico de operacoes anteriores

//Arrays
string[] historicoOperacoes = new string[100]; // 0[] 1[] 2[] 
int totalOperacoes = 0;

// Estruturas de repeticao
// enquanto
while (true == true)
{
    Console.Clear();

    Console.WriteLine("--------------------------------");
    Console.WriteLine("Calculadora 2026");
    Console.WriteLine("--------------------------------");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Tabuada");
    Console.WriteLine("6 - Historico de operaçoes");
    Console.WriteLine("S - Sair");
    Console.WriteLine("-------------------------------");
    Console.Write("Escolha uma opcao válida: ");
    string opcao = Console.ReadLine();

    if (opcao == "S" || opcao == "s")
    {
        break;
    }

    if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "6")
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Escolha uma opcao válida!");
        Console.WriteLine("--------------------------------");

        Console.Write("Digite ENTER para sair...");
        Console.ReadLine();
        continue;
    }

    if (opcao == "5")
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Tabuada");
        Console.WriteLine("--------------------------------");
        Console.Write("Digite um numero inteiro: ");
        string strnumeroDigitado = Console.ReadLine();

        int numeroDigitado = Convert.ToInt32(strnumeroDigitado);

        Console.WriteLine(numeroDigitado);

        for (int iterador = 1; iterador <= 10; iterador = iterador + 1)
        {
            string linhaTabuada = $"{numeroDigitado} x {iterador} = {numeroDigitado * iterador}";
            Console.WriteLine(linhaTabuada);
        }

        Console.WriteLine("--------------------------------");
        Console.Write("Digite ENTER para continuar");
        Console.ReadLine();
        continue;

    }

    if (opcao == "6")
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Historico de Operacoes");
        Console.WriteLine("--------------------------------");

        if (totalOperacoes == 0)
        {
            Console.WriteLine("Nunhuma operacao registrada ainda.");
        }

        else
        {
            for (int i = 0; i < totalOperacoes; i++)
            {
                Console.WriteLine(historicoOperacoes[i]);
            }
        }

        Console.ReadLine();
        continue;
    }

    Console.Write("Digite o primeiro numero: ");
    string strprimeiroNumero = Console.ReadLine(); // texto - caracter string - cadeia de caracteres

    int primeiroNumero = Convert.ToInt32(strprimeiroNumero); // int é numero inteiro 1/5

    Console.Write("Digite o segundo numero: ");
    string strsegundoNumero = Console.ReadLine();

    int segundoNumero = Convert.ToInt32(strsegundoNumero);

    int resultado = 0;
    string operacaoTexto = "";

    if (opcao == "1")
    {
        resultado = primeiroNumero + segundoNumero;
        operacaoTexto = $"{primeiroNumero} + {segundoNumero} = {resultado}";
    }
    else if (opcao == "2")
    {
        resultado = primeiroNumero - segundoNumero;
        operacaoTexto = $"{primeiroNumero} + {segundoNumero} = {resultado}";
    }
    else if (opcao == "3")
    {
        resultado = primeiroNumero * segundoNumero;
        operacaoTexto = $"{primeiroNumero} + {segundoNumero} = {resultado}";
    }
    else if (opcao == "4")
    {
        if (segundoNumero == 0)
        {
            Console.WriteLine("Erro: Nao e possivel dividir por zero.");
            Console.ReadLine();
            continue;
        }

        resultado = primeiroNumero / segundoNumero;
        operacaoTexto = $"{primeiroNumero} + {segundoNumero} = {resultado}";
    }
    else
    {
        Console.WriteLine("Opçao inválida!");
        Console.ReadLine();
        continue;
    }
    // Salvar no histórico (se ainda houver espaço)
    if (totalOperacoes < historicoOperacoes.Length)
    {
        historicoOperacoes[totalOperacoes] = operacaoTexto;
        totalOperacoes++;
    }
    else
    {
        historicoOperacoes = new string[100];
        totalOperacoes = 0;

        historicoOperacoes[totalOperacoes] = operacaoTexto;
        totalOperacoes++;
    }

    Console.WriteLine("O resultado é: " + resultado);

    Console.ReadLine();

}

