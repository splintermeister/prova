//AUTORES: VITOR PINHEIRO E JOSÉ VITOR IZAC

int recomeço = 0;
while (recomeço == 0)
{
    Console.WriteLine();
    Console.WriteLine("TURBO QUIZ - Tema: Better Call Saul");
    Console.WriteLine("Pressione <enter> para começar");
    Console.WriteLine();

    while (Console.ReadKey().Key != ConsoleKey.Enter)
    {
        Console.WriteLine();
        Console.WriteLine("Comando errado. Pressione <Enter> para iniciar o quiz...");
        Console.WriteLine();
    }

    Console.WriteLine("Pergunta #1");
    Console.WriteLine("Quando a série começou?");
    Console.WriteLine();
    Console.WriteLine("<1> 2009");
    Console.WriteLine("<2> 2014");
    Console.WriteLine("<3> 2015");
    Console.WriteLine("<4> 2022");

    int resposta = Convert.ToInt32(Console.ReadLine());

    int correto = 0;
    int incorreto = 0;

    if (resposta == 3)
    {
        Console.WriteLine();
        Console.WriteLine("Acertou, tu é foda!");
        Console.WriteLine();
        correto++;
    }
    else
    {
        incorreto++;
        Console.WriteLine();
        Console.WriteLine("Errou, vai ter que assistir tudo denovo.");
        Console.WriteLine();

    }
    Console.WriteLine("Pergunta #2");
    Console.WriteLine("Quantas temporadas a série tem?");
    Console.WriteLine();
    Console.WriteLine("<1> 3");
    Console.WriteLine("<2> 7");
    Console.WriteLine("<3> 6");
    resposta = Convert.ToInt32(Console.ReadLine());

    if (resposta == 3)
    {
        Console.WriteLine();
        Console.WriteLine("Acertou, tu é foda!");
        Console.WriteLine();
        correto++;
    }
    else
    {
        incorreto++;
        Console.WriteLine();
        Console.WriteLine("Errou, vai ter que assistir tudo denovo.");
        Console.WriteLine();

    }
    Console.WriteLine("Pergunta #3");
    Console.WriteLine("Better Call Saul é uma sequência ou prequência de Breaking Bad?");
    Console.WriteLine();
    Console.WriteLine("<1> Sequência");
    Console.WriteLine("<2> Prequência");
    Console.WriteLine("<3> Nenhuma. Ambas acontecem simultâneamente.");
    resposta = Convert.ToInt32(Console.ReadLine());

    if (resposta == 2)
    {
        Console.WriteLine();
        Console.WriteLine("Acertou, tu é foda!");
        Console.WriteLine();
        correto++;
    }
    else
    {
        incorreto++;
        Console.WriteLine();
        Console.WriteLine("Errou, vai ter que assistir tudo denovo.");
        Console.WriteLine();

    }
    Console.WriteLine("Pergunta #4");
    Console.WriteLine("Qual é o nome verdadeiro de Saul Goodman?");
    Console.WriteLine();
    Console.WriteLine("<1> James Morgan McGill");
    Console.WriteLine("<2> Walter Hartwell White");
    Console.WriteLine("<3> Aaron Paul");
    Console.WriteLine("<4> Jesse Pinkman");
    resposta = Convert.ToInt32(Console.ReadLine());

    if (resposta == 1)
    {
        Console.WriteLine();
        Console.WriteLine("Acertou, tu é foda!");
        Console.WriteLine();
        correto++;
    }
    else
    {
        incorreto++;
        Console.WriteLine();
        Console.WriteLine("Errou, vai ter que assistir tudo denovo.");
        Console.WriteLine();

    }
    Console.WriteLine("Pergunta #5");
    Console.WriteLine("Onde ficava o primeiro escritório de Jimmy?");
    Console.WriteLine();
    Console.WriteLine("<1> Uma padaria");
    Console.WriteLine("<2> Um salão de beleza");
    Console.WriteLine("<3> Uma farmácia");
    Console.WriteLine("<4> Uma universidade");
    resposta = Convert.ToInt32(Console.ReadLine());

    if (resposta == 2)
    {
        Console.WriteLine();
        Console.WriteLine("Acertou, tu é foda!");
        Console.WriteLine();
        correto++;
    }
    else
    {
        incorreto++;
        Console.WriteLine();
        Console.WriteLine("Errou, vai ter que assistir tudo denovo.");
        Console.WriteLine();

    }
    Console.WriteLine("Pergunta #6");
    Console.WriteLine("Better Call Saul possui um Spin-Off animado, como se chama?");
    Console.WriteLine();
    Console.WriteLine("<1> Slippin' Jimmy");
    Console.WriteLine("<2> El Camino");
    Console.WriteLine("<3> Breaking Bad");
    resposta = Convert.ToInt32(Console.ReadLine());

    if (resposta == 1)
    {
        Console.WriteLine();
        Console.WriteLine("Acertou, tu é foda!");
        Console.WriteLine();
        correto++;
    }
    else
    {
        incorreto++;
        Console.WriteLine();
        Console.WriteLine("Errou, vai ter que assistir tudo denovo.");
        Console.WriteLine();

    }

    Console.WriteLine("Fim do quiz, resultados:");
    Console.WriteLine();
    Console.WriteLine("Acertos: " + correto);
    Console.WriteLine("Erros: " + incorreto);
    Console.WriteLine();
    Console.WriteLine("Pressione <1> para reiniciar ou qualquer outra tecla para encerrar o quiz.");
    {
        if (Console.ReadKey().Key != ConsoleKey.D1)
        {
            recomeço++;
            Console.Clear();
            Console.WriteLine("Obrigado por jogar!");
        }
        else {
            Console.Clear();
        }
    }
}
