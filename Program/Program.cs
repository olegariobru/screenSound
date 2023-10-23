//ScreenSound

string mensagemDeBoasVindas = "Bem vindo ao Screen Sound!";
//List<string>listasDasBandas = new List<string>(); //variavel que cria uma lista em c#
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

void ExibirLogo(){
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu() {
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas cadastradas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a opção desejada: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica) 
    {
        case 1: RegistrarBanda();
            break;

        case 2: MostrarBandasRegistradas();
            break;

        case 3: AvalieUmaBanda();
            break;

        case 4: ExibirMedia();
            break;

        case 0: Console.WriteLine("\nAté a próxima :)");
            break;

        default: Console.WriteLine("\nOpção invalida!");
            break;
    }

    void RegistrarBanda(){
        Console.Clear();
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja cadastrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        bandasRegistradas.Add(nomeDaBanda, new List<int>());
        //listasDasBandas.Add(nomeDaBanda); //função para adicionar uma opção a uma lista
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    void MostrarBandasRegistradas()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

        foreach (string banda in bandasRegistradas.Keys)// um laço de repetição melhor que o for tradicional 
        {
            Console.WriteLine($"Banda: {banda}");
        }

            Console.WriteLine("\nGostaria de adicionar uma nova banda? (Sim/Não)");
            string rspUser = Console.ReadLine()!;
            if(rspUser == "Sim")
            {
            Console.Write("\nDigite o nome da banda que deseja cadastrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            bandasRegistradas.Add(nomeDaBanda, new List<int>());
            //listasDasBandas.Add(nomeDaBanda); //função para adicionar uma opção a uma lista
            Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
            Thread.Sleep(2000);
            MostrarBandasRegistradas();

        }
        else{
            Console.WriteLine("\nAperte qualquer tecla para voltar ao menu inicial");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
            }

        
    }

}
    void ExibirTituloDaOpcao(string titulo) //função que o titulo irá ajustar os asteriscos
    {
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*' );
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    void AvalieUmaBanda()
    {
    //digitar qual banda deseja avaliar
    // se a banda existir no dicionario >> atribuir uma nota
    // senão, volta ao menu principal

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Bandas");
    Console.Write("Digite o nome da banda que deseja avaliar:");
    string nomeDaBanda = Console.ReadLine()!;
    if(bandasRegistradas.ContainsKey(nomeDaBanda)){

        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece:");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else{
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }

    }

void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média da banda");
    Console.Write("Digite o nome da banda que voce deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if(bandasRegistradas.ContainsKey (nomeDaBanda)){
        List<int> notasDasbandas = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"A média da banda {nomeDaBanda} é {notasDasbandas.Average()}.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal!");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }else{
        Console.WriteLine("A Banda não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}
    
ExibirOpcoesDoMenu();