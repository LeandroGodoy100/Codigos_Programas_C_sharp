using System;
using System.Globalization;

namespace Leandro
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Pode Começar :");
            Console.WriteLine();   /*
                
                      
             /*                  
            Exercicio 2 Classes  #######################################################################################
            //inicio
            */

            Funcionario nome1, salario1, nome2, salario2;
            nome1 = new Funcionario();
            salario1 = new Funcionario();
            nome2 = new Funcionario();
            salario2 = new Funcionario();

            double media;

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.Write("Nome: ");
            nome1.nome = Console.ReadLine();
            Console.Write("Salario: ");
            salario1.salariao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); 
            Console.WriteLine();

            Console.WriteLine("Dados do segundo Funcionário: ");
            Console.Write("Nome: ");
            nome2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            salario2.salariao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);           
            Console.WriteLine();

            media = (salario1.salariao + salario2.salariao) / 2;
            Console.WriteLine("A media salário: "+media.ToString("F2",CultureInfo.InvariantCulture));


            /*
           Classes / Cadastro de Cliente #######################################################################################

         //Inicio
         *

            Dados_Pessoas dados_pessoais;
            dados_pessoais = new Dados_Pessoas();


            Console.Write("Gostaria de se cadastrar? digite 's' para sim ou 'n' para não - ");
            string opcao = Console.ReadLine();
            Console.WriteLine();
            int i = 0;

            while (opcao != "s" & opcao != "n")
            {
                Console.Write("Digite 's' para sim ou 'n' para não - ");
                opcao = Console.ReadLine();
            }
            Console.WriteLine();

            if (opcao == "n")
            {
                Console.WriteLine("Obrigado pela visita!!! ");
            }
            else
            {
                while (opcao == "s")
                {

                    while (opcao == "s")
                    {
                        Console.WriteLine();
                        Console.Write("Digite o nome: ");
                        dados_pessoais.Nome[i] = Console.ReadLine();

                        Console.Write("Digite a idade: ");
                        dados_pessoais.Idade[i] = int.Parse(Console.ReadLine());

                        Console.Write("Digite o CPF: ");
                        dados_pessoais.Cpf[i] = Console.ReadLine();
                        Console.WriteLine();

                        i++;

                        Console.Write("Gostaria de cadastrar outra Pessoa? digite 's' para sim ou 'n' para não - ");
                        opcao = Console.ReadLine();
                        Console.WriteLine();
                    }

                    Console.WriteLine("Confira seus dados: ");

                    int j = 0;
                    for (j = 0; j < i; j++)
                    {
                        Console.WriteLine(dados_pessoais.Nome[j]);
                        Console.WriteLine(dados_pessoais.Idade[j]);
                        Console.WriteLine(dados_pessoais.Cpf[j]);
                        Console.WriteLine();
                    }

                    Console.Write("Estão corretos? digite: 1 para sim ou 2 para não? - ");

                    int escolha = int.Parse(Console.ReadLine());

                    if (escolha == 1)
                    {
                        Console.WriteLine("Cadastro efetuado com sucesso!!!");
                    }
                    else
                    {
                        Console.Write("Corrigir os erros - digite 's' para sim ou 'n' para não - ");
                        opcao = Console.ReadLine();
                        Console.WriteLine();
                        i = 0;
                    }
                }

            }
            /*
           Solução com Classes ###########################################################################################
            //Inicio
            *
               Triangulo x, y, h;
               x = new Triangulo();
               y = new Triangulo();
               h = new Triangulo();

               Console.WriteLine("Entre com as medidas do triângulo X ");

               x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

               Console.WriteLine("Entre com as medidas do triângulo y ");

               y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

               Console.WriteLine("Entre com as medidas do triângulo h ");

               h.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               h.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               h.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

               double areax, areay, areah;

               areax = x.Area();

               Console.WriteLine("A area de x = " + areax.ToString("f4", CultureInfo.InvariantCulture));

               areay = x.Area();

               Console.WriteLine("A area de y = " + areay.ToString("f4", CultureInfo.InvariantCulture));

               areah = x.Area();

               Console.WriteLine("A area de h = " + areah.ToString("f4", CultureInfo.InvariantCulture));

               if (areax > areay & areax > areah)
               {
                   Console.WriteLine("A Maior area é = X");
               }
               else if (areay > areax & areay > areah)
               {
                   Console.WriteLine("A Maior area é = Y");
               }
               else
                   Console.WriteLine("A Maior area é = H");




               /*
               Solução Sem Classe ########################################################################################################
               // Inicio
               *
               double xa, xb, xc, ya, yb, yc, areax, areay, p;

               Console.WriteLine("Entre com as medidas do triângulo X ");

               xa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               xb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               xc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

               Console.WriteLine("Entre com as medidas do triângulo y ");

               ya = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               yb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               yc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

               p = (xa + xb + xc) / 2;

               areax = Math.Sqrt(p * (p - xa) * (p - xb) * (p - xc));

               Console.WriteLine("A area de x = " + areax.ToString("f4", CultureInfo.InvariantCulture));

               p = (ya + yb + yc) / 2;

               areay = Math.Sqrt(p * (p - ya) * (p - yb) * (p - yc));

               Console.WriteLine("A area de y = " + areay.ToString("f4", CultureInfo.InvariantCulture));

               if (areax > areay)
               {
                   Console.WriteLine("A Maior area é = X");
               }
               else
               {
                   Console.WriteLine("A Maior area é = Y");
               }
               /*
                    Teste again#########################################################################################
               // inicio
               *
               Console.WriteLine('bobo');
               Error Too many charecters...

                 /*                      
               DIO Pratica C# ######################################################################################################
                *
               // inicio da solução:

               Aluno[] alunos = new Aluno[5];

               int indiceAluno = 0;

               string opcaoUsuario = obterOpcaoUsuario();

               while (opcaoUsuario.ToUpper() != "X")

               {
                   switch (opcaoUsuario)
                   {
                       case "1":
                           // TODO: adicionar aluno
                           Console.Write("Informe o nome do aluno: ");
                           Aluno aluno = new Aluno();
                           aluno.Nome = Console.ReadLine();

                           Console.Write("Informe a nota do aluno: ");

                           if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                           {
                               aluno.Nota = nota;
                           }
                           else
                           {
                               throw new ArgumentException("Valor da nota deve ser decimal");
                           }

                           alunos[indiceAluno] = aluno;
                           indiceAluno++;

                           break;

                       case "2":
                           // TODO: listar alunos
                           foreach(var a in alunos)
                           {
                               if (!string.IsNullOrEmpty(a.Nome))
                               {
                                   Console.WriteLine($"Aluno {a.Nome} - Nota: {a.Nota}");
                               }
                           }

                           break;

                       case "3":
                           // TODO: calcular media geral
                           decimal notaTotal = 0;
                           var nrAlunos = 0;

                           for(int i = 0;i < alunos.Length; i++)
                           {
                               if (!string.IsNullOrEmpty(alunos[i].Nome))
                               {
                                   notaTotal = notaTotal + alunos[i].Nota;
                                   nrAlunos++;
                               }
                           }

                           var mediaGeral = notaTotal / nrAlunos;
                           Conceito conceitoGeral;

                           if (mediaGeral < 2)
                           {
                               conceitoGeral = Conceito.E;
                           }
                           else if(mediaGeral < 4)
                           {
                               conceitoGeral = Conceito.D;
                           }
                           else if (mediaGeral < 6)
                           {
                               conceitoGeral = Conceito.C;
                           }
                           else if (mediaGeral < 8)
                           {
                               conceitoGeral = Conceito.B;
                           }
                           else
                           {
                               conceitoGeral = Conceito.A;
                           }

                           Console.WriteLine($"Media Geral: {mediaGeral} Conceito {conceitoGeral}");

                           break;

                       default:
                           throw new ArgumentOutOfRangeException();
                   }

                   opcaoUsuario = obterOpcaoUsuario();

               }

           }
           private static string obterOpcaoUsuario()
           {
               Console.WriteLine();
               Console.WriteLine(" Informe a Posição desejada: ");
               Console.WriteLine(" 1 - Inserir novo Aluno: ");
               Console.WriteLine(" 2 - Listar aluno: ");
               Console.WriteLine(" 3 - Calcular média geral: ");
               Console.WriteLine(" X - Sair ");
               Console.WriteLine();

               string opcaoUsuario = Console.ReadLine();
               Console.WriteLine();

               return opcaoUsuario;
           }

           /*
           URI_1050 ###############################################################################################################

           Leia um número inteiro que representa um código de DDD para discagem interurbana. 
               Em seguida, informe à qual cidade o DDD pertence, considerando a tabela abaixo:

           61   -  Brasilia
           71   -  Salvador
           11   -  São Paulo
           21   -  Rio de Janeiro
           32   -  Juiz de Fora
           19   -  Campinas
           27   -  Vitoria
           31   -  Belo Horizonte


      Se a entrada for qualquer outro DDD que não esteja presente na tabela acima, o programa deverá informar:
      DDD nao cadastrado

      Entrada
      A entrada consiste de um único valor inteiro.

      Saída
      Imprima o nome da cidade correspondente ao DDD existente na entrada. Imprima DDD nao cadastrado
           caso não existir DDD correspondente ao número digitado.

      Exemplo de Entrada	 Exemplo de Saída

      11

                      Sao Paulo

           *
           //inicio da solução:

           int n = int.Parse(Console.ReadLine());

           switch (n)
           {

               case 61:
                   Console.WriteLine("Brasilia");
                   break;

               case 71:
                   Console.WriteLine("Salvador");
                   break;

               case 11:
                   Console.WriteLine("Sao Paulo");
                   break;

               case 21:
                   Console.WriteLine("Rio de Janeiro");
                   break;

               case 32:
                   Console.WriteLine("Juiz de Fora");
                   break;

               case 19:
                   Console.WriteLine("Campinas");
                   break;

               case 27:
                   Console.WriteLine("Vitória");
                   break;

               case 31:
                   Console.WriteLine("Belo Horizonte");
                   break;

               default:
                   Console.WriteLine("DDD não cadastrado");
                   break;
           }



           /*

           //Matrizes #############################################################################

            teste de mesa

           *
           // inicio da solução:

           int x = 0, m = 2, n = 3;

           int[] v;
           v = new int[5];

           int[,] mat;
           mat = new int[m, n];

           for (int i = 0; i < m; i++)
           {
               for (int j = 0; j < n; j++)
               {
                   x = x + 2;
                   mat[i, j] = x;

                   Console.WriteLine("Matriz na linha "+i+" coluna "+j+" = " + mat[i, j]);
               }

               v[i] = x; 
           }

           Console.WriteLine();

           for (int i = 0; i < m; i++)
           {

               Console.WriteLine("Vetor na linha = "+i+" = " + v[i]);
           }


           /*
            Vetores #####################################################################################################################

           /* n
           // n_idade
           // n_altura
           // altura_media

           porcentagem_de_pessoas_menor_16
           Fazer um programa  para lwer um numero n, depois  nome ( apenas uma palavra), idade e altura de n pessoas, conforme exemplo:
           Depois mostrar na tela a altura media das pessoas, e mostrar também a porcentagem de pessoas com menos de 16 anos.

           valores de entrada:                    saída

           5                                   altura media: 1.69
           Joao  15 1.82                       Pessoas com menos de 16 anos : 40.0%
           maria 16 1.60
           Teresa  14  1.58
           Carlos 21 1.65
           Paulo 17 1.78

            *
           // inicio da solução:

           int n = int.Parse(Console.ReadLine());

           string[] nomes  = new string[n];
              int[] idade  = new    int[n];
           double[] altura = new double[n];



           for (int i = 0; i < n; i++)
           {
               string[] vet = Console.ReadLine().Split(' ');
               nomes[i] = vet[0];
               idade[i] = int.Parse(vet[1]);
               altura[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
           }
           Console.WriteLine();

           double soma = 0;

           for(int i = 0; i < n; i++)
           {
               soma = soma + altura[i];
           }
           double media = soma / n;

           Console.WriteLine("Media de altura = "+ media.ToString("F2",CultureInfo.InvariantCulture));
           Console.WriteLine();

           int cont = 0;
           for (int i = 0; i < n; i++) 
           {
               if(idade[i] < 16)
               {
                   cont++;
               }
           }
           double porcentagem =(double) cont / n * 100.0;

           Console.WriteLine("Porcentagem de idade = "+ porcentagem.ToString("F1", CultureInfo.InvariantCulture)+" %");

           /*
           teste ###################################################################################################################

           *
           // inicio da solução:

           int a = 0;

           int[] v;
           v = new int[5];

           int cont = 0;

           while (a < 6)
           {
               v[a] = 10 + a;
               cont++;

               Console.WriteLine("Vetor["+cont+"] = " + v[a]);

               a++;

           }


           /*
           teste #####################################################################################################

           *
           // inicio da solução:

           int a = 10;
           int b = 20;
           int c = (a + b) / 2;
           c = c - 40;

           int[] vetor; // declaração da variável.
           vetor = new int[5]; // instanciação do vetor.

           for (int i = 0; i < 4; i++)
           {

               int linha = vetor[i];

               Console.WriteLine("Vetor["+i+"] = " + vetor[i]);


           }
           vetor[4] = a + b + c; // alocação dos valores

           Console.WriteLine("Vetor[4] = " + vetor[4]);



           /*
           Uri_1049 ##############################################################################################

            Animal

            Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível
             segundo o esquema abaixo, da esquerda para a direita.  Em seguida conclua
              qual dos animais seguintes foi escolhido, através das três palavras fornecidas.

                                      carnivoro =>  águia
                          ave     <
                                      onivero   =>  pomba
       vertebrado <   

                                      onivero   =>  homem    
                         mamifero <
                                      herbívoro =>  vaca




                                      hematofago => pulga
                         inseto  <
                                      herbivoro  => lagarta
       invertebrado <

                                      hematofago => sanguesuga
                        anelídeo <
                                      onivoro    => minhoca



           Entrada
          A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o animal segundo a figura acima,
           com todas as letras minúsculas.

          Saída
          Imprima o nome do animal correspondente à entrada fornecida.

      Exemplos de Entrada	     Exemplos de Saída

      vertebrado
      mamifero
      onivoro

                           homem

      vertebrado
      ave
      carnivoro

                          águia

      invertebrado
      anelideo
      onivoro

                         minhoca

           *
           // inicio da solução:

           string a = Console.ReadLine();
           string b = Console.ReadLine();
           string c = Console.ReadLine();


           if ( a == "vertebrado" && b == "ave" && c == "carnivoro")
           {
               Console.WriteLine();
               Console.WriteLine("águia");
           }


           else if (a == "vertebrado" && b == "ave" && c == "onivero")
           {
               Console.WriteLine();
               Console.WriteLine("pomba");
           }

           else if (a == "vertebrado" && b == "mamifero" && c == "onivoro")
           {
               Console.WriteLine();
               Console.WriteLine("homem");

           }
           else if (a == "vertebrado" && b == "mamifero" && c == "herbivoro")
           {
               Console.WriteLine();
               Console.WriteLine("vaca");

           }


           else if (a == "invertebrado" && b == "inseto" && c == "hematofago")
           {
               Console.WriteLine();
               Console.WriteLine("pulga");
           }

           else if (a == "invertebrado" && b == "inceto" && c == "herbivoro")
           {
               Console.WriteLine();
               Console.WriteLine("lagarta");
           }

           else if (a == "invertebrado" && b == "anelidio" && c == "hematofago")
           {
               Console.WriteLine();
               Console.WriteLine("sanguesuga");
           }

           else 

           {
               Console.WriteLine();
               Console.WriteLine("minhoca");
           }






           /*
            * URI_1048 ##############################################################################################
            * A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo
            * com a tabela abaixo:


      Salário	             Percentual de Reajuste
      0 - 400.00                   15%
      400.01 - 800.00              12%
      800.01 - 1200.00             10%
      1200.01 - 2000.00            7%
      Acima de 2000.00             4%

      Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste
           ganho e o índice reajustado, em percentual.

      Entrada
      A entrada contém apenas um valor de ponto flutuante, com duas casas decimais.

      Saída
      Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste e o percentual de reajuste ganho,
           conforme exemplo abaixo.

      Exemplo de Entrada	Exemplo de Saída
      400.00

      Novo salario: 460.00
      Reajuste ganho: 60.00
      Em percentual: 15 %

      800.01

      Novo salario: 880.01
      Reajuste ganho: 80.00
      Em percentual: 10 %

      2000.00

      Novo salario: 2140.00
      Reajuste ganho: 140.00
      Em percentual: 7 %

           *
           // inicio da solução:


           double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
           double reajuste;
           double porcentagem;
           double total;

           if (salario <= 400.00)
           {
               porcentagem = 15;
               reajuste = salario * porcentagem / 100;
               total = salario + reajuste;

               Console.WriteLine("Novo salario: "+ total.ToString("F2",CultureInfo.InvariantCulture));
               Console.WriteLine("Reajuste ganho: "+ reajuste.ToString("F2",CultureInfo.InvariantCulture));
               Console.WriteLine("Em percentual: "+porcentagem+ "%");
           }
           else if (salario <= 800.00)
           {
               porcentagem = 12;
               reajuste = salario * porcentagem / 100;
               total = salario + reajuste;

               Console.WriteLine("Novo salario: " + total.ToString("F2", CultureInfo.InvariantCulture));
               Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
               Console.WriteLine("Em percentual: " + porcentagem + "%");
           }
           else if (salario <= 1200.00)
           {
               porcentagem = 10;
               reajuste = salario * porcentagem / 100;
               total = salario + reajuste;

               Console.WriteLine("Novo salario: " + total.ToString("F2", CultureInfo.InvariantCulture));
               Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
               Console.WriteLine("Em percentual: " + porcentagem + "%");
           }
           else if (salario <= 2000.00)
           {
               porcentagem = 7;
               reajuste = salario * porcentagem / 100;
               total = salario + reajuste;

               Console.WriteLine("Novo salario: " + total.ToString("F2", CultureInfo.InvariantCulture));
               Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
               Console.WriteLine("Em percentual: " + porcentagem + "%");
           }
           else
           {
               porcentagem = 4;
               reajuste = salario * porcentagem / 100;
               total = salario + reajuste;

               Console.WriteLine("Novo salario: " + total.ToString("F2", CultureInfo.InvariantCulture));
               Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
               Console.WriteLine("Em percentual: " + porcentagem + "%");
           }

           /* 
           treinando For(para): ######################################################################################

           *
           // inicio da solução:

           int n, soma;

           n = int.Parse(Console.ReadLine());
           soma = 0;

           for (int i = 0; i < n; i++)
           {
               soma = soma + 2;
               Console.WriteLine("Valor de i = "+ i);
               Console.WriteLine("Resultado da Multiplicação = "+ soma);
           }

           /*
           Tabuada do 9 ###########################################################################################

           *
           // inicio da solução:

           int n, mult;

           n = int.Parse(Console.ReadLine());

           while (n != 0)
           {
               mult = n * 9;
               Console.WriteLine("Resultado 9 * n = "+mult+ "");
               Console.WriteLine();
               n = int.Parse(Console.ReadLine());
           }

           /*
           URI_1047 ##################################################################################################
            * Leia a hora inicial, minuto inicial, hora final e minuto final de um jogo.
            * A seguir calcule a duração do jogo.

      Obs: O jogo tem duração mínima de um (1) minuto e duração máxima de 24 horas.

      Entrada
      Quatro números inteiros representando a hora de início e fim do jogo.

      Saída
      Mostre a seguinte mensagem: “O JOGO DUROU XXX HORA(S) E YYY MINUTO(S)” .

      Exemplo de Entrada	Exemplo de Saída
      7 8 9 10

      O JOGO DUROU 2 HORA(S) E 2 MINUTO(S)

      7 7 7 7

      O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)

      7 10 8 9

      O JOGO DUROU 0 HORA(S) E 59 MINUTO(S)

           *
           // inicio da solução:

           string[] vet = Console.ReadLine().Split(' ');
           int hora_inicio = int.Parse(vet[0]);
           int minut_inicio = int.Parse(vet[1]);
           int hora_final = int.Parse(vet[2]);
           int minut_final = int.Parse(vet[3]);
           int total_horas, total_minut;

           if (hora_inicio == hora_final && minut_inicio == minut_final)
           {
               Console.WriteLine("O jogo durou 24 horas e 0 minutos");
           }
           else
           {
               if (hora_inicio < hora_final)
               {
                   total_horas = ((hora_final * 60) + minut_final - ((hora_inicio * 60) + minut_inicio)) / 60;
                   total_minut = ((hora_final * 60) + minut_final - ((hora_inicio * 60) + minut_inicio)) % 60;

                   Console.WriteLine("O jogo durou " + total_horas + " horas e " + total_minut);
               }
               else
               {
                   total_horas = ((hora_inicio * 60) + minut_inicio - ((hora_final * 60) + minut_final)) / 60;
                   total_minut = ((hora_inicio * 60) + minut_inicio - ((hora_final * 60) + minut_final)) % 60;

                   Console.WriteLine("O jogo durou " + total_horas + " horas e " + total_minut);
               }
           }

           /*
           URI_1046  ##########################################################################################################
            * Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo,  1.440
            * sabendo que o mesmo pode começar em um dia e terminar em outro, 
            * tendo uma duração mínima de 1 hora e máxima de 24 horas.

      Entrada
      A entrada contém dois valores inteiros representando a hora de início e a hora de fim do jogo.

      Saída
      Apresente a duração do jogo conforme exemplo abaixo.

      Exemplo de Entrada	Exemplo de Saída
      16 2

      O JOGO DUROU 10 HORA(S)

      0 0

      O JOGO DUROU 24 HORA(S)

      2 16

      O JOGO DUROU 14 HORA(S)

            *
           // inicio da solução:

           string[] vet = Console.ReadLine().Split(' ');
           int inicio = int.Parse(vet[0]);
           int final = int.Parse(vet[1]);
           int total;

           if (inicio < final)
           {
               total = final - inicio;
               Console.WriteLine("O jogo durou "+total+" hora(s)");
           }
           else if (inicio > final)
           {
               total = (24 - inicio) + final;
               Console.WriteLine("O jogo durou " + total + " hora(s)");
           }
           else if (inicio == final)
           {
               Console.WriteLine("O jogo durou 24 hora(s)");
           }
           else
           {
               Console.WriteLine("Fora da hora especifica");
           }

           /*
           URI_1045 ###########################################################################################################
            * Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, 
            * de modo que o lado A representa o maior dos 3 lados. A seguir, determine o tipo de triângulo que estes três lados formam, 
            * com base nos seguintes casos, sempre escrevendo uma mensagem adequada:
      se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
      se A2² = B2² + C2², apresente a mensagem: TRIANGULO RETANGULO
      se A2² > B2² + C2², apresente a mensagem: TRIANGULO OBTUSANGULO
      se A2² < B2² + C2², apresente a mensagem: TRIANGULO ACUTANGULO
      se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
      se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES
      Entrada
      A entrada contem três valores de ponto flutuante de dupla precisão A (0 < A) , B (0 < B) e C (0 < C).

      Saída
      Imprima todas as classificações do triângulo especificado na entrada.

      Exemplos de Entrada	Exemplos de Saída
      7.0 5.0 7.0

      TRIANGULO ACUTANGULO
      TRIANGULO ISOSCELES

      6.0 6.0 10.0

      TRIANGULO OBTUSANGULO
      TRIANGULO ISOSCELES

      6.0 6.0 6.0

      TRIANGULO ACUTANGULO
      TRIANGULO EQUILATERO

      5.0 7.0 2.0

      NAO FORMA TRIANGULO

      6.0 8.0 10.0

      TRIANGULO RETANGULO

            *
           // inicio da solução:

           double A, B, C, A2, B2, C2;

           string[] vet = Console.ReadLine().Split(' ');
           A = double.Parse(vet[0], CultureInfo.InvariantCulture);
           B = double.Parse(vet[1], CultureInfo.InvariantCulture);
           C = double.Parse(vet[2], CultureInfo.InvariantCulture);



           if (A > B && B > C)
           {
               A2 = A;
               B2 = B;
               C2 = C;
           }
           else if (A > B && C > B)
           {
               A2 = A;
               B2 = C;
               C2 = B;
           }
           else if (B > A && A > C)
           {
               A2 = B;
               B2 = A;
               C2 = C;
           }
           else if (B > A && C > A)
           {
               A2 = B;
               B2 = C;
               C2 = A;
           }
           else if (C > A && B > A)
           {
               A2 = C;
               B2 = B;
               C2 = A;
           }
           else
           {
               A2 = C;
               B2 = A;
               C2 = B;

           }

           if (A2 >= B2 + C2)
           {
               Console.WriteLine("NAO FORMA TRIANGULO");
           }

           else
           {


               if (A2 * A2 == (B2 * B2 + C2 * C2))
               {
                   Console.WriteLine("TRIANGULO RETANGULO");
               }
               if (A2 * A2 == (B2 * B2 + C2 * C2))
               {
                   Console.WriteLine("TRIANGULO OBTUSANGULO");
               }
               if (A2 * A2 < (B2 * B2 + C2 * C2))
               {
                   Console.WriteLine("TRIANGULO ACUTANGULO");
               }
               if (A2 == B2 && A2 == C2)
               {
                   Console.WriteLine("TRIANGULO EQUILATERO");
               }
               if (A2 == B2 && A2 != C2 || B2 == C2 && B2 != A2 || A2 == C2 && A2 != B2)
               {
                   Console.WriteLine("TRIANGULO ISOSCELES");
               }

           }

           /*
           URI_1044  #########################################################################################################
            * Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem 
            * "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si.

      Entrada
      A entrada contém valores inteiros.

      Saída
      A saída deve conter uma das mensagens conforme descrito acima.

      Exemplo de Entrada	Exemplo de Saída
      6 24

      Sao Multiplos

      6 25

      Nao sao Multiplos

            *
           // inicio da solução:

           int A, B, resto;

           string[] vet = Console.ReadLine().Split(' ');
           A = int.Parse(vet[0]);
           B = int.Parse(vet[1]);



           if (A > B)
           {
               resto = A % B;

               if (resto == 0)
               {
                   Console.WriteLine("Sao Multipos");
               }
               else
               {
                   Console.WriteLine("Nao sao Multiplos");
               }

           }

           if (A < B)
           {
               resto = B % A;

               if (resto == 0)
               {
                   Console.WriteLine("Sao Multiplos");
               }
               else
               {
                   Console.WriteLine("Nao sao Multiplos");
               }

           }


           /*
           URI_1043 #########################################################################################################

            * Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo 
            * (Condição de existência de um triângulo).
            * | b - c | < a < b + c
              | a - c | < b < a + c
              | a - b | < c < a + b

            * Em caso positivo,
            * calcule o perímetro do triângulo e apresente a mensagem:


      Perimetro = XX.X


      Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem
           A = (B + b) * h / 2


      Area = XX.X

      Entrada
      A entrada contém três valores reais.

      Saída
      O resultado deve ser apresentado com uma casa decimal.

      Exemplo de Entrada	Exemplo de Saída
      6.0 4.0 2.0

      Area = 10.0

      6.0 4.0 2.1

      Perimetro = 12.1

            *
           // inicio da soluçaõ:

           double A, B, C;

           string[] vet = Console.ReadLine().Split(' ');
           A = double.Parse(vet[0],CultureInfo.InvariantCulture);
           B = double.Parse(vet[1],CultureInfo.InvariantCulture);
           C = double.Parse(vet[2],CultureInfo.InvariantCulture);

           if ((B-C)< A & A < (B+C) & (A-C) < B & B <(A+C) & (A-B) < C & C < (A + B))
           {
               double P = A + B + C;
               Console.WriteLine("Perimetro = "+ P.ToString("F1",CultureInfo.InvariantCulture));
           }
           else
           {
               double Area = (A + B) * C / 2;
               Console.WriteLine("Area = "+Area.ToString("F1",CultureInfo.InvariantCulture));
           }


           /*
           URI_1042 #########################################################################################################
            * 
            * Leia 3 valores inteiros e ordene-os em ordem crescente. No final, mostre os valores em ordem crescente, 
            * uma linha em branco e em seguida, os valores na sequência como foram lidos.

      Entrada
      A entrada contem três números inteiros.

      Saída
      Imprima a saída conforme foi especificado.

      Exemplo de Entrada	Exemplo de Saída
      7 21 -14

      -14
      7
      21

      7
      21
      -14

      -14 21 7

      -14
      7
      21

      -14
      21
      7

           *
           // inicio da solução:

           int a, b, c;

           string[] vet = Console.ReadLine().Split(" ");
           a = int.Parse(vet[0]);
           b = int.Parse(vet[1]);
           c = int.Parse(vet[2]);




           if (a > b & b > c)
           {
               Console.WriteLine(c);
               Console.WriteLine(b);
               Console.WriteLine(a);
           }
           else if (a > c & c > b)
           {
               Console.WriteLine(b);
               Console.WriteLine(c);
               Console.WriteLine(a);
           }
           else if (b > a & a > c)
           {
               Console.WriteLine(c);
               Console.WriteLine(a);
               Console.WriteLine(b);
           }
           else if (b > c & c > a)
           {
               Console.WriteLine(a);
               Console.WriteLine(c);
               Console.WriteLine(b);
           }
           else if (c > a & a > b)
           {
               Console.WriteLine(b);
               Console.WriteLine(a);
               Console.WriteLine(c);

           }
           else
           {
               Console.WriteLine(a);
               Console.WriteLine(b);
               Console.WriteLine(c);
           }

           Console.WriteLine();

           Console.WriteLine(a);
           Console.WriteLine(b);
           Console.WriteLine(c);


           /*
           URI_1041 ##########################################################################################################

            * Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano.
            * A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos 
            * ou na origem (x = y = 0).
            * 
                                       Y 
                                   Q2  |  Q1
                                 ______|______X
                                       |
                                   Q3  |  Q4

      Se o ponto estiver na origem, escreva a mensagem “Origem”.

      Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.

      Entrada
      A entrada contem as coordenadas de um ponto.

      Saída
      A saída deve apresentar o quadrante em que o ponto se encontra.

      Exemplo de Entrada	Exemplo de Saída
      4.5 -2.2

      Q4

      0.1 0.1

      Q1

      0.0 0.0

      Origem
           *
           // inicio da solução:

           double x, y;

           string[] vet = Console.ReadLine().Split(" ");

            x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y = double.Parse(vet[1],CultureInfo.InvariantCulture);


           if (x > 0 & y > 0)
           {
               Console.WriteLine("Q1");
           }
           else if (x < 0 & y < 0)
           {
               Console.WriteLine("Q3");
           }
           else if (x > 0 & y < 0)
           {
               Console.WriteLine("Q4");
           }
           else if (x < 0 & y > 0) 
           {
               Console.WriteLine("Q2");
           }
           else
           {
               Console.WriteLine("Origem");
           }


           /*
           URI_1040 #######################################################################################################

            * Leia quatro números (N1, N2, N3, N4), cada um deles com uma casa decimal, correspondente 
            * às quatro notas de um aluno. Calcule a média com pesos 2, 3, 4 e 1, respectivamente,
            * para cada uma destas notas e mostre esta média acompanhada pela
            * mensagem "Media: ". Se esta média for maior ou igual a 7.0, imprima a mensagem "Aluno aprovado.".
            * Se a média calculada for inferior a 5.0, imprima a mensagem "Aluno reprovado.".
            * Se a média calculada for um valor entre 5.0 e 6.9, inclusive estas, 
            * o programa deve imprimir a mensagem "Aluno em exame.".

      No caso do aluno estar em exame, leia um valor correspondente à nota do exame obtida pelo aluno.
           Imprima então a mensagem "Nota do exame: " acompanhada pela nota digitada.
           Recalcule a média (some a pontuação do exame com a média anteriormente calculada e divida por 2). 
           e imprima a mensagem "Aluno aprovado." (caso a média final seja 5.0 ou mais )
           ou "Aluno reprovado.", (caso a média tenha ficado 4.9 ou menos). 
           Para estes dois casos (aprovado ou reprovado após ter pego exame) 
           apresente na última linha uma mensagem "Media final: " seguido da média final para esse aluno.

      Entrada
      A entrada contém quatro números de ponto flutuante correspendentes as notas dos alunos.

      Saída
      Todas as respostas devem ser apresentadas com uma casa decimal. 
           As mensagens devem ser impressas conforme a descrição do problema.
           Não esqueça de imprimir o enter após o final de cada linha, caso contrário obterá "Presentation Error".

      Exemplo de Entrada	Exemplo de Saída
      2.0 4.0 7.5 8.0
      6.4

      Media: 5.4
      Aluno em exame.
      Nota do exame: 6.4
      Aluno aprovado.
      Media final: 5.9

      2.0 6.5 4.0 9.0

      Media: 4.8
      Aluno reprovado.

      9.0 4.0 8.5 9.0

      Media: 7.3
      Aluno aprovado.

           *
           // inicio da solução:

           string[] vet = Console.ReadLine().Split(" ");
           double N1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
           double N2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
           double N3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
           double N4 = double.Parse(vet[3], CultureInfo.InvariantCulture);

           double media = (double)((N1 * 2.0) + (N2 * 3.0) + (N3 * 4.0) + (N4 * 1.0)) / 10.0;

           Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

           if (media >= 7.0)
           {
               Console.WriteLine("Aluno Aprovado");
           }

           else if (media >= 5.0 & media <= 6.9)
           {
               Console.WriteLine("Aluno em exame");
               double N5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               Console.WriteLine("Nota do exame: " + N5.ToString("F1", CultureInfo.InvariantCulture));
               double exame = (double)(N5 + media) / 2.0;

               if (exame >= 5.0)
               {
                   Console.WriteLine("Aluno aprovado");
                   Console.WriteLine("Media final: " + exame.ToString("F1", CultureInfo.InvariantCulture));

               }
               else
               {
                   Console.WriteLine("Aluno reprovado");
                   Console.WriteLine("Media final: " + exame.ToString("F1", CultureInfo.InvariantCulture));
               }


           }

           else
           {
               Console.WriteLine("Aluno reprovado");
           }


           /*
           URI_1038 ##############################################################################################################

            * Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item.
            * A seguir, calcule e mostre o valor da conta a pagar.

      Código     Especificações      Preço
      1        Cachorro Quente     R$ 4.00 
      2        X-Salada            R$ 4.50     
      3        X-Bacon             R$ 5.00
      4        Torrada Simples     R$ 2.00 
      5        Refrigerante        R$ 1.50

           Entrada
      O arquivo de entrada contém dois valores inteiros correspondentes ao código e à quantidade de um item conforme tabela acima.

      Saída
      O arquivo de saída deve conter a mensagem "Total: R$ " seguido pelo valor a ser pago, com 2 casas após o ponto decimal.

      Exemplo de Entrada	Exemplo de Saída
      3 2

      Total: R$ 10.00

      4 3

      Total: R$ 6.00

      2 3

      Total: R$ 13.50

            *
           // inicio da solução:

           string[] vet = Console.ReadLine().Split(" ");
           double cod = double.Parse(vet[0]);
           double quant = double.Parse(vet[1]);
           double res ;

           if (cod == 1)
           {

               res = quant * 4.00;
               Console.WriteLine("Total: R$ "+res.ToString("F2",CultureInfo.InvariantCulture));
           }
           else if(cod == 2)
           {
               res = quant * 4.50;
               Console.WriteLine("Total: R$ "+res.ToString("F2",CultureInfo.InvariantCulture));
           }
           else if (cod == 3)
           {
               res = quant * 5.00;
               Console.WriteLine("Total: R$ " + res.ToString("F2", CultureInfo.InvariantCulture));

           }
           else if (cod == 4)
           {
               res = quant* 2.00;
               Console.WriteLine("Total: R$ " + res.ToString("F2", CultureInfo.InvariantCulture));
           }
           else if (cod == 5)
           {
               res = 1.50 * quant;
               Console.WriteLine("Total: R$ " + res.ToString("F2", CultureInfo.InvariantCulture));
           }
           else
           {
               Console.WriteLine("Código Invalido");
           }

           /*
           URI_1037 #######################################################################################################
            * Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual
            * dos seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. 
            * Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser 
            * impressa a mensagem “Fora de intervalo”.

      O símbolo ( representa "maior que". Por exemplo:
      [0,25]  indica valores entre 0 e 25.0000, inclusive eles.
      (25,50] indica valores maiores que 25 Ex: 25.00001 até o valor 50.0000000

      Entrada
      O arquivo de entrada contém um número com ponto flutuante qualquer.

      Saída
      A saída deve ser uma mensagem conforme exemplo abaixo.

      Exemplo de Entrada	Exemplo de Saída
      25.01

      Intervalo (25,50]

      25.00

      Intervalo [0,25]

      100.00

      Intervalo (75,100]

      -25.02

      Fora de intervalo

            *
           // inicio da solução:

           double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           if (N >= 0 & N <= 25)
           {
               Console.WriteLine("Intervalo [0 , 25]");

           }
           else if (N > 25 & N <= 50)
           {
               Console.WriteLine("Intervalo (25 , 50 ]");

           }
           else if (N > 50 & N <= 75)
           {
               Console.WriteLine("Intervalo (50, 75]");
           }
           else if (N> 75 & N <= 100)
           {
               Console.WriteLine("Intervalo (75, 100]");
           }
           else
           {
               Console.WriteLine("Fora de Intervalo");
           }

           /*
           URI_1036 ###############################################################################################################

            * Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. 
            * Se não for possível calcular as raízes, mostre a mensagem correspondente “Impossivel calcular”, 
            * caso haja uma divisão por 0 ou raiz de numero negativo.

      Entrada
      Leia três valores de ponto flutuante (double) A, B e C.

      Saída
      Se não houver possibilidade de calcular as raízes, apresente a mensagem "Impossivel calcular". 
           Caso contrário, imprima o resultado das raízes com 5 dígitos após o ponto,
           com uma mensagem correspondente conforme exemplo abaixo. Imprima sempre o final de linha após cada mensagem.

      Exemplos de Entrada	Exemplos de Saída
      10.0 20.1 5.1

      R1 = -0.29788
      R2 = -1.71212

      0.0 20.0 5.0

      Impossivel calcular

      10.3 203.0 5.0

      R1 = -0.02466
      R2 = -19.68408

      10.0 3.0 5.0

      Impossivel calcular

            *
           // inicio da solução:

           string[] vet = Console.ReadLine().Split(" ");
           double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
           double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
           double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

           if (A == 0 || A + C > B)
           {
               Console.WriteLine("Impossível calcular");
           }


           if (-B + Math.Sqrt(B * B - 4.0 * A * C) == 0 || -B - Math.Sqrt(B * B - 4.0 * A * C) == 0
           || (B * B) - (4.0 * A * C) < 0)
           {
               Console.WriteLine("Impossível calcular");
           }
           else
           {
               double R1 = (-B + Math.Sqrt(B * B - 4.0 * A * C)) / (2.0 * A);
               double R2 = (-B - Math.Sqrt(B * B - 4.0 * A * C)) / (2.0 * A);

               Console.WriteLine(R1.ToString("F5", CultureInfo.InvariantCulture));
               Console.WriteLine(R2.ToString("F5", CultureInfo.InvariantCulture));
           }


           /*
           URI_1035 ########################################################################################################

            * Leia 4 valores inteiros A, B, C e D. A seguir, se B for maior do que C e se D for maior do que A,
            * e a soma de C com D for maior que a soma de A e B e se C e D, ambos, forem positivos e se a variável A
            * for par escrever a mensagem "Valores aceitos", senão escrever "Valores nao aceitos".

      Entrada
      Quatro números inteiros A, B, C e D.

      Saída
      Mostre a respectiva mensagem após a validação dos valores.

      Exemplo de Entrada	Exemplo de Saída
      5 6 7 8

      Valores nao aceitos

      2 3 2 6

      Valores aceitos

           *
           // inicio da solução:

           string[] vet = Console.ReadLine().Split(" ");
           int A = int.Parse(vet[0]);
           int B = int.Parse(vet[1]);
           int C = int.Parse(vet[2]);
           int D = int.Parse(vet[3]);

           if (B > C &  D > A & (C + D) > (A + B) & C >= 0 & D >= 0 & A % 2 == 0) 
           { 
               Console.WriteLine("Valores aceitos"); 
           }
           else 
           { 
               Console.WriteLine("Valores não aceitos"); 
           }

           /*
           URI_1021 #######################################################################################################

            * Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário.
            * A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto.
            * As notas consideradas são de 100, 50, 20, 10, 5, 2. 
            * As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01. A seguir mostre a relação de notas necessárias.
            * 

      Entrada
      O arquivo de entrada contém um valor de ponto flutuante N (0 ≤ N ≤ 1000000.00).

      Saída
      Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial, conforme exemplo fornecido.

      Obs: Utilize ponto (.) para separar a parte decimal.

      Exemplo de Entrada	Exemplo de Saída
      576.73

      NOTAS:
      5 nota(s) de R$ 100.00
      1 nota(s) de R$ 50.00
      1 nota(s) de R$ 20.00
      0 nota(s) de R$ 10.00
      1 nota(s) de R$ 5.00
      0 nota(s) de R$ 2.00
      MOEDAS:
      1 moeda(s) de R$ 1.00
      1 moeda(s) de R$ 0.50
      0 moeda(s) de R$ 0.25
      2 moeda(s) de R$ 0.10
      0 moeda(s) de R$ 0.05
      3 moeda(s) de R$ 0.01

      4.00

      NOTAS:
      0 nota(s) de R$ 100.00
      0 nota(s) de R$ 50.00
      0 nota(s) de R$ 20.00
      0 nota(s) de R$ 10.00
      0 nota(s) de R$ 5.00
      2 nota(s) de R$ 2.00
      MOEDAS:
      0 moeda(s) de R$ 1.00
      0 moeda(s) de R$ 0.50
      0 moeda(s) de R$ 0.25
      0 moeda(s) de R$ 0.10
      0 moeda(s) de R$ 0.05
      0 moeda(s) de R$ 0.01

      91.01

      NOTAS:
      0 nota(s) de R$ 100.00
      1 nota(s) de R$ 50.00
      2 nota(s) de R$ 20.00
      0 nota(s) de R$ 10.00
      0 nota(s) de R$ 5.00
      0 nota(s) de R$ 2.00
      MOEDAS:
      1 moeda(s) de R$ 1.00
      0 moeda(s) de R$ 0.50
      0 moeda(s) de R$ 0.25
      0 moeda(s) de R$ 0.10
      0 moeda(s) de R$ 0.05
      1 moeda(s) de R$ 0.01

           *
           // inicio da solução:

           double N = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

           int cem = (int) N / 100;
           int cinquenta = (int) N % 100 / 50;
           int vinte = (int) N % 100 % 50 / 20; 
           int des = (int) N % 100 % 50 % 20 / 10;
           int cinco = (int)N % 100 % 50 % 20 % 10 / 5;
           int dois = (int)N % 100 % 50 % 20 % 10 % 5 / 2;

           int hum = (int)(N % 100 % 50 % 20 % 10 % 5 % 2 / 1);
           int cinquentacent = (int)(N % 100 % 50 % 20 % 10 % 5 % 2 % 1 / 0.50);
           int vintcincocent = (int)(N % 100 % 50 % 20 % 10 % 5 % 2 % 1 % 0.50 / 0.25);
           int descent = (int)(N % 100 % 50 % 20 % 10 % 5 % 2 % 1 % 0.50 % 0.25 / 0.10);
           int cincocent = (int)(N % 100 % 50 % 20 % 10 % 5 % 2 % 1 % 0.50 % 0.25 % 0.10 / 0.05);
           int humcent = (int)(N % 100 % 50 % 20 % 10 % 5 % 2 % 1 % 0.50 % 0.25 % 0.10 % 0.05/ 0.01);
           Console.WriteLine("Notas:");

           Console.WriteLine(cem + " nota(s) de R$ 100.00");
           Console.WriteLine(cinquenta + " nota(s) de R$ 50.00");
           Console.WriteLine(vinte+ " nota(s) de R$ 20.00");
           Console.WriteLine(des + " nota(s) de R$ 10.00");
           Console.WriteLine(cinco + " nota(s) de R$ 5.00");
           Console.WriteLine(dois + " nota(s) de R$ 2.00");
           Console.WriteLine();

           Console.WriteLine("Moedas:");

           Console.WriteLine(hum +" moeda(s) de R$ 1.00");
           Console.WriteLine(cinquentacent+" moeda(s) de R$ 0.50");
           Console.WriteLine(vintcincocent + " moeda(s) de R$ 0.25");
           Console.WriteLine(descent + " moeda(s) de R$ 0.10");
           Console.WriteLine(cincocent + " moeda(s) de R$ 0.05");
           Console.WriteLine(humcent + " moeda(s) de R$ 0.01");


           /*
           URI_1020 ###########################################################################################################

            * Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias

      Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. Nos casos de teste nunca
           haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364. 
           Este é apenas um exercício com objetivo de testar raciocínio matemático simples.

      Entrada
      O arquivo de entrada contém um valor inteiro.

      Saída
      Imprima a saída conforme exemplo fornecido.

      Exemplo de Entrada	Exemplo de Saída
      400

      1 ano(s)
      1 mes(es)
      5 dia(s)

      800

      2 ano(s)
      2 mes(es)
      10 dia(s)

      30

      0 ano(s)
      1 mes(es)
      0 dia(s)
           *
           // inicio da solução:

           int idade = int.Parse(Console.ReadLine());

           int ano = idade / 365;
           int mes = idade % 365 / 30;
           int dia = idade % 365 % 30;

           Console.WriteLine(ano + " ano(s)");
           Console.WriteLine(mes + " mes(es)");
           Console.WriteLine(dia + " dia(s)");


           /*
           URI_1019 ###################################################################################################

            * Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica,
            * e informe-o expresso no formato horas:minutos:segundos.

      Entrada
      O arquivo de entrada contém um valor inteiro N.

      Saída
      Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.

      Exemplo de Entrada	Exemplo de Saída
      556

      0:9:16

      1

      0:0:1

      140153

      38:55:53
           *
           // inicio da solução:

           int tempo = int.Parse(Console.ReadLine());

           int hora = tempo / 3600;
           int min = tempo % 3600 / 60;
           int sec = tempo % 60;

           Console.WriteLine(hora + ":" + min + ":" + sec);

           /*
           URI_1018 #######################################################################################################

            Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas)
           no qual o valor pode ser decomposto.
           As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas
           necessárias.

      Entrada
      O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).

      Saída
      Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, conforme o exemplo fornecido.
           Não esqueça de imprimir o fim de linha após cada linha, caso contrário seu programa apresentará a mensagem:
           “Presentation Error”.

      Exemplo de Entrada	Exemplo de Saída
      576

      576
      5 nota(s) de R$ 100,00
      1 nota(s) de R$ 50,00
      1 nota(s) de R$ 20,00
      0 nota(s) de R$ 10,00
      1 nota(s) de R$ 5,00
      0 nota(s) de R$ 2,00
      1 nota(s) de R$ 1,00

      11257

      11257
      112 nota(s) de R$ 100,00
      1 nota(s) de R$ 50,00
      0 nota(s) de R$ 20,00
      0 nota(s) de R$ 10,00
      1 nota(s) de R$ 5,00
      1 nota(s) de R$ 2,00
      0 nota(s) de R$ 1,00

      503

      503
      5 nota(s) de R$ 100,00
      0 nota(s) de R$ 50,00
      0 nota(s) de R$ 20,00
      0 nota(s) de R$ 10,00
      0 nota(s) de R$ 5,00
      1 nota(s) de R$ 2,00
      1 nota(s) de R$ 1,00

           *
           // inicio da solução:

           int valor = int.Parse(Console.ReadLine());


           int cem = Math.Abs(valor / 100);


           int cinquenta = Math.Abs(valor % 100 / 50);


           int vinte = Math.Abs(valor % 100 % 50 / 20);


           int dez = Math.Abs(valor % 100 % 50 % 20 / 10);


           int cinco = Math.Abs(valor % 100 % 50 % 20 / 5);


           int dois = Math.Abs(valor % 100 % 50 % 20 % 5 / 2);


           int hum = Math.Abs(valor % 100 % 50 % 20 % 5 % 2 / 1);

           Console.WriteLine(cem+" nota(s) de R$ 100,00");
           Console.WriteLine(cinquenta + " nota(s) de R$ 50,00");
           Console.WriteLine(vinte + " nota(s) de R$ 20,00");
           Console.WriteLine(dez + " nota(s) de R$ 10,00");
           Console.WriteLine(cinco + " nota(s) de R$ 5,00");
           Console.WriteLine(dois + " nota(s) de R$ 2,00");
           Console.WriteLine(hum + " nota(s) de R$ 1,00");

           /*
           URI_1017 ##########################################################################################################

            * Joaozinho quer calcular e mostrar a quantidade de litros de combustível gastos em uma viagem, 
            * ao utilizar um automóvel 
            * que faz 12 KM/L.
            * Para isso, ele gostaria que você o auxiliasse através de um simples programa. Para efetuar o cálculo, 
            * deve-se fornecer o tempo gasto na viagem (em horas) e a velocidade média durante a mesma (em km/h). 
            * Assim, pode-se obter distância percorrida e, em seguida, calcular quantos litros seriam necessários.
            * Mostre o valor com 3 casas decimais após o ponto.

      Entrada
      O arquivo de entrada contém dois inteiros. O primeiro é o tempo gasto na viagem (em horas) e o segundo é a
           velocidade média durante a mesma (em km/h).

      Saída
      Imprima a quantidade de litros necessária para realizar a viagem, com três dígitos após o ponto decimal

      Exemplo de Entrada	Exemplo de Saída
      10
      85

      70.833

      2
      92

      15.333

      22
      67

      122.833

           *
           // inicio da soluçao:


           int A = int.Parse(Console.ReadLine());
           int B = int.Parse(Console.ReadLine());

           double KM =(double) A * B / 12;

           Console.WriteLine(KM.ToString("F3",CultureInfo.InvariantCulture));



           /*
           URI_1016 ###############################################################################################################

            * Dois carros (X e Y) partem em uma mesma direção. O carro X sai com velocidade constante de 60 Km/h 
            * e o carro Y sai com velocidade constante de 90 Km/h.

      Em uma hora (60 minutos) o carro Y consegue se distanciar 30 quilômetros do carro X, ou seja, consegue se afastar
           um quilômetro a cada 2 minutos.

      Leia a distância (em Km) e calcule quanto tempo leva (em minutos) para o carro Y tomar essa distância do outro carro.

      Entrada
      O arquivo de entrada contém um número inteiro.

      Saída
      Imprima o tempo necessário seguido da mensagem "minutos".

      Exemplo de Entrada	Exemplo de Saída
      30

      60 minutos

      110

      220 minutos

      7

      14 minutos
           *
           // inicio da solução:

           int carro = int.Parse(Console.ReadLine());

           int distancia = carro * 2;

           Console.WriteLine(distancia+" minutos");


           /*
           URI_1015 ###############################################################################################################

           Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2)
           e calcule a distância entre eles, mostrando 4 casas decimais após a vírgula, segundo a fórmula:

      Distancia =√(x2-x1)²+(y2-y1)²

      Entrada
      O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1 e a 
           segunda linha contém dois valores de ponto flutuante x2 y2.

      Saída
      Calcule e imprima o valor da distância segundo a fórmula fornecida, com 4 casas após o ponto decimal.

      Exemplo de Entrada	Exemplo de Saída
      1.0 7.0
      5.0 9.0

      4.4721

      -2.5 0.4
      12.1 7.3

      16.1484

      2.5 -0.4
      -12.2 7.0

      16.4575
           *
           // Inicio da solução:

           string[] vet1 = Console.ReadLine().Split(" ");
           double x1 = double.Parse(vet1[0],CultureInfo.InvariantCulture);
           double y1 = double.Parse(vet1[1],CultureInfo.InvariantCulture);

           string[] vet2 = Console.ReadLine().Split(" ");
           double x2 = double.Parse(vet2[0],CultureInfo.InvariantCulture);
           double y2 = double.Parse(vet2[1],CultureInfo.InvariantCulture);

           double x3 = x2 - x1;
           double y3 = y2 - y1;

           double distancia = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2));

           Console.WriteLine(distancia.ToString("F4",CultureInfo.InvariantCulture));



           /*
           URI_101 #########################################################################################################
           4 - Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km) 
            * e o total de combustível gasto (em litros).

      Entrada
      O arquivo de entrada contém dois valores: um valor inteiro X representando a distância total percorrida (em Km), 
           e um valor real Y representando o total de combustível gasto, com um dígito após o ponto decimal.

      Saída
      Apresente o valor que representa o consumo médio do automóvel com 3 casas após a vírgula, seguido da mensagem "km/l".

      Exemplo de Entrada	Exemplo de Saída
      500
      35.0

      14.286 km/l

      2254
      124.4

      18.119 km/l

      4554
      464.6

      9.802 km/l
           * 
           // Inicio da solução:

           int X;
           double Y;

           X = int.Parse(Console.ReadLine());
           Y = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

           double Media = (double)X / Y;

           Console.WriteLine(Media.ToString("F3",CultureInfo.InvariantCulture)+" Km/l");


                 /*
           URI_1013 ####################################################################################################

           - Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido
           da mensagem
        * “eh o maior”. 
        * Utilize a fórmula:



      Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, 
       portanto é necessário para chegar no resultado esperado.

      Entrada
      O arquivo de entrada contém três valores inteiros.

      Saída
      Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".

      Exemplos de Entrada	Exemplos de Saída
      7 14 106

      106 eh o maior

      217 14 6

      217 eh o maior

           *
           // Inicio da solução:

       string[] vet = Console.ReadLine().Split(" ");
       int A = int.Parse(vet[0]);
       int B = int.Parse(vet[1]);
       int C = int.Parse(vet[2]);

       int MaiorAB = (A + B + Math.Abs(A - B)) / 2;
       int Maior = (MaiorAB + C + Math.Abs(MaiorAB - C)) / 2;

       Console.WriteLine(Maior+" he o maior");

       /*

        * URI 1012 ##########################################################################################################
        * 
        * Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. 
        * Em seguida,
        * calcule e mostre:
      a) a área do triângulo retângulo que tem A por base e C por altura.
      b) a área do círculo de raio C. (pi = 3.14159)
      c) a área do trapézio que tem A e B por bases e C por altura.
      d) a área do quadrado que tem lado B.
      e) a área do retângulo que tem lados A e B.
      Entrada
      O arquivo de entrada contém três valores com um dígito após o ponto decimal.

      Saída
      O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas acima, 
       sempre com mensagem correspondente e um espaço entre os dois pontos e o valor. 
           O valor calculado deve ser apresentado
       com 3 dígitos após o ponto decimal.

      Exemplos de Entrada	Exemplos de Saída
      3.0 4.0 5.2

      TRIANGULO: 7.800
      CIRCULO: 84.949
      TRAPEZIO: 18.200
      QUADRADO: 16.000
      RETANGULO: 12.000

      12.7 10.4 15.2

      TRIANGULO: 96.520
      CIRCULO: 725.833
      TRAPEZIO: 175.560
      QUADRADO: 108.160
      RETANGULO: 132.080

           *
           // Inicio da soluçao:

       string[] Vet = Console.ReadLine().Split(" ");
       double A = double.Parse(Vet[0],CultureInfo.InvariantCulture);
       double B = double.Parse(Vet[1],CultureInfo.InvariantCulture);
       double C = double.Parse(Vet[2],CultureInfo.InvariantCulture);

       double Atriangulo = A * C / 2;
       double Acirculo = 3.14159 * Math.Pow(C, 2);
       double Atrapezio = ((A + B )/ 2 )* C;
       double Aquadrado = Math.Pow(B, 2);
       double Aretangulo = A * B;

       Console.WriteLine("TRIANGULO: "+Atriangulo.ToString("F3",CultureInfo.InvariantCulture));
       Console.WriteLine("CIRCULO: "+Acirculo.ToString("F3",CultureInfo.InvariantCulture));
       Console.WriteLine("TRAPEZIO: "+Atrapezio.ToString("F3",CultureInfo.InvariantCulture));
       Console.WriteLine("QUADRADO: "+Aquadrado.ToString("F3", CultureInfo.InvariantCulture));
       Console.WriteLine("RETANGULO: "+Aretangulo.ToString("F3",CultureInfo.InvariantCulture));

             /*
           URI 1011 #################################################################################################################

           - Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R).
        * A fórmula para calcular o volume é: (4/3) * pi * R3. Considere (atribua) para pi o valor 3.14159.

      Dica: Ao utilizar a fórmula, procure usar (4/3.0) ou (4.0/3), pois algumas linguagens (dentre elas o C++),
       assumem que o resultado da divisão entre dois inteiros é outro inteiro.

      Entrada
      O arquivo de entrada contém um valor de ponto flutuante (dupla precisão), correspondente ao raio da esfera.

      Saída
      A saída deverá ser uma mensagem "VOLUME" conforme o exemplo fornecido abaixo, com um espaço antes e um espaço depois
           da igualdade.
       O valor deverá ser apresentado com 3 casas após o ponto.

      Exemplos de Entrada	Exemplos de Saída
      3

      VOLUME = 113.097

      15

      VOLUME = 14137.155

      1523

      VOLUME = 14797486501.627

           *
           // Inicio da Solução:

       double Raio = double.Parse(Console.ReadLine());

       double Pi = 3.14159;

       double Volume = (4.0 / 3.0 )* Pi * Math.Pow(Raio, 3);

       Console.WriteLine("VOLUME = "+Volume.ToString("F3",CultureInfo.InvariantCulture));


           /*
           URI 1010 ##########################################################################################################

           - Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, 
           o valor unitário de cada peça 1,
        * o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.
        * Após, calcule e mostre o valor a ser pago.

      Entrada
      O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores,
           respectivamente dois inteiros e um valor com 2 casas decimais.

      Saída
      A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, 
           lembrando de deixar um espaço após os dois pontos e um
       espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.

      Exemplos de Entrada	Exemplos de Saída
      12 1 5.30
      16 2 5.10

      VALOR A PAGAR: R$ 15.50

      13 2 15.30
      161 4 5.20

      VALOR A PAGAR: R$ 51.40

      1 1 15.10
      2 1 15.10

      VALOR A PAGAR: R$ 30.20

           *
           // Inicio da Solução:

       String[] Vet = Console.ReadLine().Split(" ");
       int Peca1 = int.Parse(Vet[0]);
       int Quant1 = int.Parse(Vet[1]);
       double ValUni1 = double.Parse(Vet[2],CultureInfo.InvariantCulture);

       string[] Vet2 = Console.ReadLine().Split(" ");
       int Peca2 = int.Parse(Vet2[0]);
       int Quant2 = int.Parse(Vet2[1]);
       double ValUni2 = double.Parse(Vet2[2],CultureInfo.InvariantCulture);


       double Total = (double)Quant1 * ValUni1 + Quant2 * ValUni2;

       Console.WriteLine("VALOR A PAGAR: R$ "+Total.ToString("F2",CultureInfo.InvariantCulture));

            /*
           URI 1009 ##########################################################################################################

           -bFaça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas
           efetuadas por ele no mês (em dinheiro). 
        * Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar o total a receber
        * no final do mês,
        * com duas casas decimais.

      Entrada
      O arquivo de entrada contém um texto (primeiro nome do vendedor) e 2 valores de dupla precisão (double)
           com duas casas decimais,
       representando o salário fixo do vendedor e montante total das vendas efetuadas por este vendedor, respectivamente.

      Saída
      Imprima o total que o funcionário deverá receber, conforme exemplo fornecido.

      Exemplos de Entrada	Exemplos de Saída
      JOAO
      500.00
      1230.30

      TOTAL = R$ 684.54

      PEDRO
      700.00
      0.00

      TOTAL = R$ 700.00

      MANGOJATA
      1700.00
      1230.50

      TOTAL = R$ 1884.58

           *
           // Inicio da Solução

       string Nome = Console.ReadLine();
       double Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
       double Vendas = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

       double Total = (Vendas * 15.0) / 100.0 + Salario;

       Console.WriteLine("TOTAL = R$ "+Total.ToString("F2",CultureInfo.InvariantCulture));




       /*
       URI 1008 #############################################################################################################

           - Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas,
       o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário 
           do funcionário, 
       com duas casas decimais.

      Entrada
      O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais, representando o número,
           quantidade de horas trabalhadas e 
       o valor que o funcionário recebe por hora trabalhada, respectivamente.

      Saída
      Imprima o número e o salário do funcionário, conforme exemplo fornecido, com um espaço em branco antes e depois da igualdade.

       No caso do salário, também deve haver um espaço em branco após o $.

      Exemplos de Entrada	Exemplos de Saída
      25
      100
      5.50

      NUMBER = 25
      SALARY = U$ 550.00

      1
      200
      20.50

      NUMBER = 1
      SALARY = U$ 4100.00

      6
      145
      15.55

      NUMBER = 6
      SALARY = U$ 2254.75

           *
           //Inicio da Solução:

       int Numero, HorasTrab;
       double PorHora, Salario;

       Numero = int.Parse(Console.ReadLine());
       HorasTrab = int.Parse(Console.ReadLine());
       PorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

       Salario =(double) HorasTrab * PorHora;


       Console.WriteLine("NUMBER = "+Numero);
       Console.WriteLine("SALARY = U$ "+Salario.ToString("F2",CultureInfo.InvariantCulture));




       /*
      URI 1007 ##########################################################################################################################

           -   Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
           de A e B pelo produto de C e D 
       segundo a fórmula: DIFERENCA = (A * B - C * D).

      Entrada
      O arquivo de entrada contém 4 valores inteiros.

      Saída
      Imprima a mensagem DIFERENCA com todas as letras maiúsculas, conforme exemplo abaixo, com um espaço em branco antes e depois
           da igualdade.

      Exemplos de Entrada	Exemplos de Saída
      5
      6
      7
      8

      DIFERENCA = -26

      0
      0
      7
      8

      DIFERENCA = -56

      5
      6
      -7
      8

      DIFERENCA = 86

            *
           // Inicio da Solução

       int A, B, C, D, Diferenca;

       A = int.Parse(Console.ReadLine());
       B = int.Parse(Console.ReadLine());
       C = int.Parse(Console.ReadLine());
       D = int.Parse(Console.ReadLine());

       Diferenca = (A * B - C * D);

       Console.WriteLine("DIFERENCA = "+Diferenca);

       /*
      ##############################################################################################################################################

        *Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. A seguir,
        *calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5.
        *Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

      Entrada
      O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão (double).

      Saída
      Imprima a mensagem "MEDIA" e a média do aluno conforme exemplo abaixo,
       com 1 dígito após o ponto decimal e com um espaço em branco antes e depois da igualdade. 
       Assim como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, 
       você receberá "Presentation Error".

      Exemplos de Entrada	Exemplos de Saída
      5.0
      6.0
      7.0

      MEDIA = 6.3

      5.0
      10.0
      10.0

      MEDIA = 9.0

      10.0
      10.0
      5.0

      MEDIA = 7.5
           *
       // Inicio da solução:

       double A, B, C, P1, P2, P3, Media;

       A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
       B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
       C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

       P1 = 2;
       P2 = 3;
       P3 = 5;

       Media = ((A * P1) + (B * P2) + (C * P3)) / (P1 + P2 + P3);
       Console.WriteLine("MEDIA = " + Media.ToString("F1", CultureInfo.InvariantCulture));
       /*
      ####################################################################################################################################
       *
       //Media Ponderada M = P1*N1 + P2*N2... / P1 + P2...

       double A, B, Media, P1, P2;

       A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
       B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
       P1 = 3.5;
       P2 = 7.5;

       Media = ((A * P1) + (B * P2)) / (P1 + P2);

       Console.WriteLine("MEDIA Ponderada = " + Media.ToString("F2", CultureInfo.InvariantCulture));
       /*
      ######################################################################################################################################
       *
       int A = int.Parse(Console.ReadLine());
       int B = int.Parse(Console.ReadLine());

       int PROD = A * B;

       Console.WriteLine("PROD = "+PROD);


       /*
      ######################################################################################################################################
        *

       int A = int.Parse(Console.ReadLine());
       int B = int.Parse(Console.ReadLine());

       int Soma = A + B;

       Console.WriteLine("Soma = "+Soma);


       /*
      #######################################################################################################################################

       *
       // Area do circulo

       double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

       double n = 3.14159;

       double area = n * Math.Pow(raio, 2);

       Console.WriteLine("A= "+area.ToString("F4",CultureInfo.InvariantCulture));
        /*
      ############################################################################################################################################
       *
       int A = int.Parse(Console.ReadLine());
       int B = int.Parse(Console.ReadLine());

       int x = A + B;

       Console.WriteLine("x = "+x);

           /*
      #############################################################################################################################################

         *

       string[] x = Console.ReadLine().Split(' ');
       int peca1 = int.Parse(x[0]);
       int quant1 = int.Parse(x[1]);
       double val1 = double.Parse(x[2],CultureInfo.InvariantCulture);

       double valor1 = quant1 * val1;

       string[] y = Console.ReadLine().Split(' ');
       int peca2 = int.Parse(y[0]);
       int quant2 = int.Parse(y[1]);
       double val2 = double.Parse(y[2], CultureInfo.InvariantCulture);

       double valor2 = quant2 * val2;

       double ValTotal = valor1 + valor2;

       Console.WriteLine("Valor a Pagar R$ "+ValTotal.ToString("F2", CultureInfo.InvariantCulture));

        /*   

      #####################################################################################################################################
       *

       int x = int.Parse(Console.ReadLine());

       if (x == 2)
       {
           Console.WriteLine("Hello World!");

       }
       else
       {
           Console.WriteLine("Você errou");
       }

       /*

       */



        }
    }
}
