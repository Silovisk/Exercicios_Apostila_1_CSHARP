using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace ExAp1
{
    internal class Program
    {
        public class ResultadoIMC
        {
            public double IMC
            {
                get;
                set;
            }
            public string Situacao
            {
                get;
                set;
            }
        }

        public static ResultadoIMC Calc_imc(double PESO, double ALTURA)
        {

            double IMC = PESO / Math.Pow(ALTURA, 2);
            string situacao;

            if (IMC < 17)
            {
                situacao = "Muito abaixo do peso";
            }
            else if (IMC >= 17 && IMC <= 18.49)
            {
                situacao = "Abaixo do peso";
            }
            else if (IMC >= 18.5 && IMC <= 24.99)
            {
                situacao = "Peso normal";
            }
            else if (IMC >= 25 && IMC <= 29.99)
            {
                situacao = "Acima do peso";
            }
            else if (IMC >= 30 && IMC <= 34.99)
            {
                situacao = "Obesidade I";
            }
            else if (IMC >= 35 && IMC <= 39.99)
            {
                situacao = "Obesidade II (severa)";
            }
            else if (IMC > 40)
            {
                situacao = "Obesidade III (mórbida)";
            }
            else
            {
                situacao = "Invalido";
            }

            return new ResultadoIMC
            {
                IMC = IMC,
                Situacao = situacao
            };
        }

        static void Main(string[] args)
        {
            int escolha_exercicio = -1;

            while (escolha_exercicio != 0)
            {
                Console.WriteLine("Escolha um Exercicio: \n[1] - Exercício 1 \n[2] - Exercício 2 \n[3] - Exercício 3");
                Console.WriteLine("[0] - Finaliza");
                if (int.TryParse(Console.ReadLine(), out escolha_exercicio)) // Try Parse serve para receber um input do usuário e tentar converter o valor inserido em um int
                {

                    switch (escolha_exercicio)
                    {
                        case 1:
                            Console.WriteLine("Elabore um programa em console, C#, para calcular a resistência equivalente entre dois registros R1 e R2 em paralelo. Lembre-se que a resistência equivalente entre dois registros em paralelo é dada por: ");
                            double resistencia(double R1, double R2)
                            {
                                double result = R1 * R2 / (R1 + R2);
                                return result;
                            }

                            double r1, r2;
                            Console.Write("Informe o valor de r1: ");
                            r1 = double.Parse(Console.ReadLine());

                            Console.Write("Informe o valor de r2: ");
                            r2 = double.Parse(Console.ReadLine());

                            Console.WriteLine("R1: " + r1);
                            Console.WriteLine("R2: " + r2);
                            Console.WriteLine("Resultado: " + resistencia(r1, r2).ToString("F2"));

                            break;
                        case 2:
                            Console.WriteLine("Escreva um programa em console, c#, para calcular a distância entre dois pontos (x1, y1) e (x2, y2) no plano cartesiano. Os pontos são digitados pelo usuário. A distância entre dois pontos é dada por:");

                            double distancia_entre_dois_pontos(double X1, double X2, double Y1, double Y2)
                            {
                                double result = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
                                return result;
                            }

                            double x1, x2, y1, y2;
                            Console.WriteLine("Digite o valorr de X1: ");
                            x1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o valorr de X2: ");
                            x2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o valorr de Y1: ");
                            y1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o valorr de Y2: ");
                            y2 = double.Parse(Console.ReadLine());

                            Console.WriteLine("X1: " + x1);
                            Console.WriteLine("X2: " + x2);
                            Console.WriteLine("Y1: " + y1);
                            Console.WriteLine("Y2: " + y2);
                            Console.WriteLine("Resultado: " + distancia_entre_dois_pontos(x1, x2, y1, y2).ToString("F2"));
                            break;
                        case 3:

                            Console.WriteLine("Escreva um programa em console, c#, e requisite ao operador o nome, o sexo, o peso, a altura e data de nascimento. Como resultado imprima no console os seguintes resultados:");

                            string nome, sexo;
                            double peso, altura;
                            int idade, ano_nascimento;

                            Console.WriteLine("Infome seu Nome: ");
                            nome = Console.ReadLine();

                            Console.WriteLine("Escolha seu Sexo: \n[M] - Masculino \n[F] - Feminino");
                            sexo = Console.ReadLine();

                            Console.WriteLine("Informe seu peso: ");
                            peso = double.Parse(Console.ReadLine());

                            Console.WriteLine("Informe sua altura: ");
                            altura = double.Parse(Console.ReadLine());

                            Console.WriteLine("Informe seu ano de nascimento: ");
                            ano_nascimento = int.Parse(Console.ReadLine());

                            idade = 2023 - ano_nascimento;

                            ResultadoIMC resultado = Calc_imc(peso, altura);

                            Console.WriteLine("++++++++++++ Tabela ++++++++++++ \nNome: " + nome + "\nSexo: " + sexo + "\nAltura: " + altura + "\nAno Nascimento: " + ano_nascimento + "\nIdade: " + idade + "\nIMC: " + resultado.IMC.ToString("F2") + "\nSituacao: " + resultado.Situacao);
                            break;
                        default:
                            Console.WriteLine("Op invalida");
                            break;

                    }
                }
            }
        }
    }
}
