using System;
using System.ComponentModel.Design;

namespace Aqui;

class Program
{
    //Tipo
    public static Tipo[] tp = new Tipo[9999999];
    public static int ondeparouTipo = 0;
    public static bool crioutipo = false;

    //Produto
    public static Produto[] pd = new Produto[9999999];
    public static int ondeparou = 0;
    public static bool criouproduto = false;

    //Palettis
    public static Palettis pl = new Palettis();

    //Operações do Sistema
    public static DateTime dateAtual = DateTime.Now;

    //Operações do Programa
    public static OperationsSystem os = new OperationsSystem();

    //Geral
    public static int opcao;
    public static string inputUser;
    public static int opcaoHelp;

    public static void Main(string[] args)
    {
        Menu();
    }

    public static void Menu()
    {
        Console.WriteLine("=====================================================");
        Console.WriteLine("                  BEM VINDO AO MENU                  ");
        Console.WriteLine("       [" + dateAtual.ToString("dddd, dd 'de' MMMM 'de' yyyy") + "]       ");
        Console.WriteLine("=====================================================");
        Console.WriteLine("");
        Console.WriteLine("=====================================================");
        Console.WriteLine("                    LISTA DE AÇÕES                   ");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("[1] Cadastrar novo Produto");
        Console.WriteLine("[2] Cadastrar novo Tipo");
        Console.WriteLine("[?] Caso Tenha Duvidas...");
        Console.WriteLine("[0] Fechar o Programa...");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("=====================================================");
        Console.WriteLine("");
        Console.WriteLine("=====================================================");
        Console.WriteLine(">> Digite a opção desejada: ");
        inputUser = Console.ReadLine();
        try
        {
            if (int.TryParse(inputUser, out opcao))
            {
                os.MenuCaseInt(opcao);
            }
            else
            {
                os.MenuCaseString(inputUser);
            }
        }
        catch(Exception e)
        {
            Console.WriteLine("Ocorreu um erro no Menu (" + e + ")");
            Thread.Sleep(5000);
            Console.Clear();
            Menu();
        }
        Console.WriteLine("=====================================================");
    }

    public static void criarTipo()
    {
        try
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("                   CRIAÇÃO DE TIPOS                  ");
            Console.WriteLine("=====================================================");
            Console.WriteLine("=====================================================");
            for (int i = ondeparouTipo; i < ondeparouTipo; i++)
            {
                tp[i] = new Tipo();
                do
                {
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("INDICE ATUAL [" + ondeparou + "]");
                    Console.WriteLine("Digite o nome do tipo: ");
                    tp[i].nome = Console.ReadLine();
                    Console.WriteLine("-----------------------------------------------------");
                } while (string.IsNullOrWhiteSpace(tp[i].nome));

                do
                {
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("INDICE ATUAL [" + ondeparou + "]");
                    Console.WriteLine("Digite o nome do tipo: ");
                    tp[i].descricao = Console.ReadLine();
                    Console.WriteLine("-----------------------------------------------------");
                } while (string.IsNullOrWhiteSpace(tp[i].descricao));

                try
                {
                    if (string.IsNullOrWhiteSpace(tp[i].descricao) && string.IsNullOrWhiteSpace(tp[i].nome))
                    {
                        Console.WriteLine("<< Por algum motivo desconhecido, todas as variaveis estão nulas! >>");
                        Thread.Sleep(5000);
                        Console.Clear();
                        Menu();
                    }
                    else
                    {
                        crioutipo = true;
                        ondeparouTipo = ondeparouTipo + 1;
                        Console.Clear();
                        Menu();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ocorreu um erro ao tentar registrar o indice 'ondeparou'[" + ondeparou + "]!");
                    Console.WriteLine("O Erro [" + e + "]");
                    Thread.Sleep(5000);
                    Console.Clear();
                    Menu();
                }
            }
            Console.WriteLine("");
            Console.WriteLine("=====================================================");
        }
        catch(Exception e)
        {
            Console.WriteLine("Ocorreu um erro ao criar um Tipo (" + e + ")");
            Thread.Sleep(5000);
            Console.Clear();
            Menu();
        }

        Console.Clear();
        Menu();
    }

    public static void criarProduto()
    {
        

        if (crioutipo == true)
        {
            try
            {
                for (int i = ondeparou; i < ondeparou + 1; i++)
                {
                    Console.Clear();

                    pd[i] = new Produto();
                    tp[i] = new Tipo();

                    Console.WriteLine("=====================================================");
                    Console.WriteLine("                 CRIAÇÃO DE PRODUTOS                 ");
                    do
                    {
                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine("INDICE ATUAL [" + ondeparou + "]");
                        Console.WriteLine("Digite o nome do produto: ");
                        pd[i].nome = Console.ReadLine();
                        Console.WriteLine("-----------------------------------------------------");
                    } while (string.IsNullOrWhiteSpace(pd[i].nome));

                    do
                    {
                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine("INDICE ATUAL [" + ondeparou + "]");
                        Console.WriteLine("Digite a descrição do produto: ");
                        pd[i].descricao = Console.ReadLine();
                        Console.WriteLine("-----------------------------------------------------");
                    } while (string.IsNullOrWhiteSpace(pd[i].descricao));
                    Console.WriteLine("=====================================================");

                    try
                    {
                        if (string.IsNullOrWhiteSpace(pd[i].descricao) && string.IsNullOrWhiteSpace(pd[i].nome))
                        {
                            Console.WriteLine("<< Por algum motivo desconhecido, todas as variaveis estão nulas! >>");
                            Thread.Sleep(5000);
                            Console.Clear();
                            Menu();
                        }
                        else
                        {
                            criouproduto = true;
                            ondeparou = ondeparou + 1;
                            Console.Clear();
                            Menu();
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Ocorreu um erro ao tentar registrar o indice 'ondeparou'[" + ondeparou + "]!");
                        Console.WriteLine("O Erro [" + e + "]");
                        Thread.Sleep(5000);
                        Console.Clear();
                        Menu();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Não foi possivel criar um novo produto: Erro:(" + e + ")");
                Thread.Sleep(5000);
                Console.Clear();
                Menu();
            }

            Console.Clear();
            Menu();
        }
        else
        {
            Console.WriteLine("Você precisa criar um tipo antes de criar produtos!");
            Thread.Sleep(5000);
            Console.Clear();
            Menu();
        }
    }

    public static void Help()
    {
        Console.WriteLine("=====================================================");
        Console.WriteLine("                 CRIAÇÃO DE PRODUTOS                 ");
        Console.WriteLine("=====================================================");
        Console.WriteLine("=====================================================");
        Console.WriteLine("           BEM VINDO(A) AO CENTRO DE AJUDA           ");
        Console.WriteLine("             SOBRE QUAL TEMA DESEJA FALAR            ");
        Console.WriteLine("=====================================================");
        Console.WriteLine("[1] Cadastrar novo Produto");
        Console.WriteLine("[2] Cadastrar novo Tipo");
        Console.WriteLine("[0] Voltar para o Menu...");
        Console.WriteLine("=====================================================");
        opcaoHelp = int.Parse(Console.ReadLine());
        os.HelpCase(opcaoHelp);
    }
}
class HelpQuerys
{
    public void CadastroDeProdutos()
    {
        Console.WriteLine("=====================================================");
        Console.WriteLine("'Para criar produtos você antes precisa de criar um tipo!' = Você precisa em menu antes de criar o produto, ir em criar um tipo, que é sobre falar para o sistema, qual é o tipo do produto!");
        Console.WriteLine("=====================================================");
        Console.WriteLine("Digite qualquer tecla para continuar...");
        Console.ReadLine();
        Console.Clear();
        Program.Help();
    }

    public void CadastroDeTipo()
    {
        Console.WriteLine("=====================================================");
        Console.WriteLine("'Para criar tipos para criar produtos!' = tipos são a definição do que é e do que se refere o produto o qual você o irá atribuir!");
        Console.WriteLine("=====================================================");
        Console.WriteLine("Digite qualquer tecla para continuar...");
        Console.ReadLine();
        Console.Clear();
        Program.Help();
    }
}

class OperationsSystem
{
    public static HelpQuerys hq = new HelpQuerys();
    public void HelpCase(int opcaoo)
    {
        switch (opcaoo)
        {
            case 0:
                Console.Clear();
                Program.Menu();
                break;
            case 1:
                Console.Clear();
                hq.CadastroDeProdutos();
                break;
            case 2:
                Console.Clear();
                hq.CadastroDeTipo();
                break;
            default:
                Console.WriteLine("<< Opção digitada não é aceita ["+ opcaoo + "] >>");
                break;
        }
    }
    public void MenuCaseInt(int opcaoo)
    {
        switch (opcaoo)
        {
            case 0:
                return;
            case 1:
                Console.Clear();
                Program.criarProduto();
                break;
            case 2:
                Console.Clear();
                Program.criarTipo();
                break;
            default:
                Console.WriteLine("<< VOCÊ NÃO PODE USAR ESSA OPÇÃO [" + opcaoo + "] >>");
                Thread.Sleep(5000);
                Console.Clear();
                Program.Menu();
                break;
        }
    }

    public void MenuCaseString(string opcaoo)
    {
        switch (opcaoo)
        {
            case "?":
                Console.Clear();
                Program.Help();
                break;
            default:
                Console.WriteLine("<< VOCÊ NÃO PODE USAR ESSA OPÇÃO [" + opcaoo + "] >>");
                Thread.Sleep(5000);
                Console.Clear();
                Program.Menu();
                break;
        }
    }
}

class Palettis
{
    int coluna;
    int linha;
    int altura;
}

class Tipo
{
    public int id;
    public string nome;
    public string descricao;
}

class Produto
{
    public int id = 0;
    public string descricao = "";
    public string nome = "";
    public int tipo = 0;
}
