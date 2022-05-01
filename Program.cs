using System;

namespace ConsoleApp8
{
    internal class Program
    {
        int[] a = new int[9];
        public static void Main(string[] args)
        {
            
            //Calc();
            Program sort = new Program();
            sort.generateArray();
            sort.OutputBubble();
            sort.BubbleSortSimple();
            Console.WriteLine("\n");
            sort.OutputBubble();
            Console.ReadLine();
        }


        #region Calc
        private static void Calc()
        {
            Console.WriteLine("Добро пожаловать в калькулятор!");
            bool useCalc = true;
            string leftOperand = "Введите левый операнд";
            string rightOperand = "Введите правый операнд";


            int GetNumber(string message = null)
            {
                // scope
                int i = int.MaxValue;
                bool noExit = true;

                Console.WriteLine(message ?? "Введите число");

                do
                {
                    string userInput = Console.ReadLine();
                    if (!int.TryParse(userInput, out i)) //
                    {
                        Console.WriteLine($"Неправильный формат, попробуйте ещё раз");
                    }
                    else
                    {
                        noExit = false;
                    }
                } while (noExit);

                return i;
            }

            do
            {
                Console.Write("Выберите операцию: '+','-','*','/','^','√(sqrt)','%(modulo)'\n");
                Console.Write("->");

                try
                {
                    switch (Console.ReadLine()?.ToLower())
                    {
                        case "+":
                        case "a":
                        case "addition":
                        case "add":
                            Console.WriteLine(GetNumber(leftOperand) + GetNumber(rightOperand));
                            break;
                        case "-":
                        case "s":
                        case "subtract":
                        case "sub":
                            Console.WriteLine(GetNumber(leftOperand) - GetNumber(rightOperand));
                            break;
                        case "*":
                        case "m":
                        case "multiply":
                        case "mul":
                            Console.WriteLine(GetNumber(leftOperand) * GetNumber(rightOperand));
                            break;
                        case "/":
                        case "d":
                        case "divide":
                        case "div":
                            Console.WriteLine(GetNumber() / GetNumber("Правый операнд может быть любым кроме 0!")); // No text passed
                            break;
                        case "√":
                        case "sq":
                        case "sqrt":
                            Console.WriteLine(Math.Sqrt(GetNumber(leftOperand)));
                            break;
                        case "^":
                        case "pow":
                            Console.WriteLine(Math.Pow(GetNumber(leftOperand), GetNumber(rightOperand)));
                            break;
                        case "%":
                        case "mod":
                        case "modulo":
                            Console.WriteLine((GetNumber(leftOperand) % GetNumber(rightOperand)));
                            break;
                        case "exit":
                            useCalc = false; // In case of exit - close the calc
                            break;
                        default:
                            Console.WriteLine("Неверный ввод операции, попробуйте ещё раз");
                            break;
                    }
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Вы не можете делить на ноль");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Что-то непредсказуемое произошло");
                    Console.WriteLine(ex.Message);
                }

                Console.ReadKey();
                Console.Clear();
            } while (useCalc);


            Console.ReadLine();
        }
        #endregion

        #region Bubble
        private void BubbleSortSimple()
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - 1; j++)
                {
                    int tmp = a[j];
                    if (a[j + 1] < tmp) continue;
                        a[j] = a[j + 1];
                        a[j + 1] = tmp;
                    
                }

                
            }
        }
        private  void generateArray()
        {
            Random r = new Random ();
            for (int d = 0; d < a.Length; d++)
            {
                a [d] = (int)(r.NextDouble () * 100);
            }
        }
        private  void OutputBubble()
        {
            for (int i = 0; i < a.Length; i++)
            {
               Console.Write( $"[{a[i]}]" + " ");
            }
        }

        #endregion





    }
}

