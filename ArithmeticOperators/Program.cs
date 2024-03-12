namespace ArithmeticOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* Hello Viewer!                                                                          *");
            Console.WriteLine("*            Exercises for understanding how to handling operators in C# .NET            *");
            Console.WriteLine("*                                                                            version 1.3 *");
            Console.WriteLine("******************************************************************************************");

            Console.WriteLine("\n1. Arithmetic Calculations\n==========================\n");
            decimal a = 10M;
            decimal b = 3M;
            decimal c = a + b;
            decimal d = a - b;
            decimal e = a * b;
            decimal f = a / b;
            decimal g = a % b;
            
            Console.WriteLine("The initial values for\na is " + a + " & for b is " + b + " \n--------------------");
            Console.Write("c = a + b <=> c = ");
            Console.WriteLine(c);
            Console.Write("d = a - b <=> d = ");
            Console.WriteLine(d);
            Console.Write("e = a * b <=> e = ");
            Console.WriteLine(e);
            Console.Write("f = a / b <=> f = ");
            Console.WriteLine(f);
            Console.Write("g = a % b <=> g = ");
            Console.WriteLine(g);
            
            
            Console.WriteLine("\n\nPress any key to continue to the other part of programm... ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* Hello Viewer!                                                                          *");
            Console.WriteLine("*            Exercises for understanding how to handling operators in C# .NET            *");
            Console.WriteLine("*                                                                            version 1.3 *");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("\n\n2. Assigment Operators\n========================\n");
            decimal k = 10M;
            Console.Write("Initial k: ");
            Console.WriteLine(k + "\n-------------");

            k += 20M;
            Console.Write("\nk+=20M: ");
            Console.WriteLine(k);

            k -= 20M;
            Console.Write("k-=20M: ");
            Console.WriteLine(k);

            k *= 3M;
            Console.Write("k *= 3M: ");
            Console.WriteLine(k);

            k /= 3M;
            Console.Write("k /= 3M: ");
            Console.WriteLine(k);

            k %= 3M;
            Console.Write("k %= 3M: ");
            Console.WriteLine(k);

            Console.WriteLine("\n\nPress any key to continue to the other part of programm... ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* Hello Viewer!                                                                          *");
            Console.WriteLine("*            Exercises for understanding how to handling operators in C# .NET            *");
            Console.WriteLine("*                                                                            version 1.3 *");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("\n\n3. Increment / Decrement Operators\n===========================================");
            decimal m = 10M;
            Console.Write("Initial m: ");
            Console.WriteLine(m + "\n------------------");
            Console.Write("\n++m: ");
            Console.WriteLine(++m);
            Console.Write("m++: ");
            Console.WriteLine(m++);
            Console.Write("Now the m is: ");
            Console.WriteLine(m);
            Console.Write("--m: ");
            Console.WriteLine(--m);
            Console.Write("m--: ");
            Console.WriteLine(m--);
            Console.Write("Final m: ");
            Console.WriteLine(m);

            Console.Write("\n\nPress a key to continue to the other part of programm... ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* Hello Viewer!                                                                          *");
            Console.WriteLine("*            Exercises for understanding how to handling operators in C# .NET            *");
            Console.WriteLine("*                                                                            version 1.3 *");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("\n\n4. Comparison Operators\n============================");
            decimal o = 10M;
            Console.Write("comparison variable o: ");
            Console.WriteLine(o + "\n-----------------------");
            bool p1 = o == 10;
            Console.Write("\np1 = o == 10 --> p1: ");
            Console.WriteLine(p1);

            bool p2 = o != 10;
            Console.Write("p2 = o != 10 --> p2: ");
            Console.WriteLine(p2);

            bool p3 = o < 10;
            Console.Write("p3 = o < 10 --> p3: ");
            Console.WriteLine(p3);

            bool p4 = o > 10;
            Console.Write("p4 = o > 10 --> p4: ");
            Console.WriteLine(p4);

            bool p5 = o <= 10;
            Console.Write("p5 = o <= 10 --> p5: ");
            Console.WriteLine(p5);

            bool p6 = o >= 10;
            Console.Write("p6 = o >= 10 --> p6: ");
            Console.WriteLine(p6);

            Console.Write("\n\nPress a key to continue to other part of programm... ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* Hello Viewer!                                                                          *");
            Console.WriteLine("*            Exercises for understanding how to handling operators in C# .NET            *");
            Console.WriteLine("*                                                                            version 1.3 *");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("\n\n5. Logical Operators\n============================");

            int hourOfTheDay_OR = 10;
            Console.WriteLine("time: " + hourOfTheDay_OR);
            bool answerOR = hourOfTheDay_OR > 8 || hourOfTheDay_OR < 11;
            Console.WriteLine("hourOfTheDay_OR > 8 || hourOfTheDay_OR < 11");
            Console.WriteLine("Your time is higher than 8 and lower than  11! It is: " + answerOR + "\n--------\n");

            int hourOfTheDay_OR2 = 15;
            Console.WriteLine("time: " + hourOfTheDay_OR2);
            bool answerOR2 = hourOfTheDay_OR2 > 8 || hourOfTheDay_OR2 < 11;
            Console.WriteLine("hourOfTheDay_OR2 > 8 || hourOfTheDay_OR2 < 11");
            Console.WriteLine("Your time is higher than 8 and lower than 11! It is: " + answerOR2 + "\n----------\n");


            int hourOfTheDay_AND = 10;
            Console.WriteLine("time: " + hourOfTheDay_AND);
            bool answerAND = hourOfTheDay_AND > 8 && hourOfTheDay_AND < 24;
            Console.WriteLine("hourOfTheDay_AND > 8 && hourOfTheDay_AND < 24");
            Console.WriteLine("Is the hour between 8 and 24? It is: " + answerAND + "\n----------------\n");

            int hourOfTheDay_AND2 = 35;
            Console.WriteLine("time: " + hourOfTheDay_AND2);
            bool answerAND2 = hourOfTheDay_AND2 > 8 && hourOfTheDay_AND2 < 24;
            Console.WriteLine("hourOfTheDay_AND2 > 8 && hourOfTheDay_AND2 < 24");
            Console.WriteLine("Is the hour between 8 and 24? It is: " + answerAND2 + "\n---------------\n");

            
            bool valid = false;
            bool result = !valid;  //LOGICAL NEGATION OPERATOR ( ! )
            Console.WriteLine("bool valid = false;\nbool result = !valid;");
            Console.WriteLine("What is the value of result? It is: " + result + "\n---------------------\n");

            string name = "Dimitris"; int age = 24;
            Console.WriteLine("string name = Dimitris; int age = 24;");
            string message = "Hey " + name + ", your age is " + age + "!";
            Console.WriteLine(message);

            Console.Write("\n\nPress a key to continue to the other part of programm... ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* Hello Viewer!                                                                          *");
            Console.WriteLine("*            Exercises for understanding how to handling operators in C# .NET            *");
            Console.WriteLine("*                                                                            version 1.3 *");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("\n\n6. TERNARY OPERATOR - ΤΡΙΑΔΙΚΟΣ ΤΕΛΕΣΤΗΣ\n========================================");
            int ageOfPeople = 20;
            string title = (ageOfPeople < 13) ? "Child" : (ageOfPeople >= 13 && ageOfPeople <= 19) ? "Teenager" : "Adult";
            Console.WriteLine("ageOfPeople < 13) ? 'Child' : (ageOfPeople >= 13 && ageOfPeople <= 19) ? 'Teenager' : 'Adult'");
            Console.WriteLine(" =>   Child < 13  --  >= 13 Teenager <= 19  -- Adult > 19)");
            Console.WriteLine($"Your age is " + age + ", so you are a/an: " + title);

            Console.Write("\n\nPress a key to continue to other part of programm... ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* Hello Viewer!                                                                          *");
            Console.WriteLine("*            Exercises for understanding how to handling operators in C# .NET            *");
            Console.WriteLine("*                                                                            version 1.3 *");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("\n\n7. Operators Presedence  [ (), *, /, +, -, ^ ]\n===============================================");

            double z = 10 + 4 * 30 / 10;
            Console.Write("z = 10 + 4 * 30 / 10 <=> z = ");
            Console.WriteLine(z);
            Console.WriteLine("a)*, b)/, c)+ \n-----------\n\n");

            double y = 10 * 4 + 30 / 10;
            Console.Write("y = 10 * 4 + 30 / 10 <=> y = ");
            Console.WriteLine(y);
            Console.WriteLine("a)*, b)/, c)+ \n-----------\n\n");

            double w = 10 + 4 / 30 * 10;
            Console.Write("w = 10 + 4 / 30 * 10 <=> w = ");
            Console.WriteLine(w);
            Console.WriteLine("a)/, b)*, c)+ \n-----------\n\n");

            double v = (10 + 4) / 30 * 10;
            Console.Write("v = (10 + 4) / 30 * 10 <=> v = ");
            Console.WriteLine(v);
            Console.WriteLine(" a)(), b)/, c)* \n-----------\n\n");

            double t = (10 + 4) / 30 * 10 ^ 2;
            Console.Write("t = (10 + 4) / 30 * 10 ^ 2 <=> t = ");
            Console.WriteLine(t);
            Console.WriteLine("a)(), b)/, c)^\n-----------\n\n");

            Console.WriteLine("End of programm of OPERATORS EXAMPLES!");
            Console.Write("\n\nPress a key to continue to see the Author and his source... ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* Hello Viewer!                                                                          *");
            Console.WriteLine("*            Exercises for understanding how to handling operators in C# .NET            *");
            Console.WriteLine("*                                                                            version 1.3 *");
            Console.WriteLine("******************************************************************************************");

            Console.WriteLine("\n\n\n");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* Created by Antoniou Ioannis                                                            *");
            Console.WriteLine("*                                                                    Powered by C# .NET8 *");
            Console.WriteLine("*                                                          written in Visual Studio 2022 *");
            Console.WriteLine("*----------------------------------------------------------------------------------------*");
            Console.WriteLine("* Source from mr Kassapogloy Michael's free courses                                      *");
            Console.WriteLine("* https://kassapoglou.github.io/csharp/csharp.html                                       *");
            Console.WriteLine("* specific source: https://kassapoglou.github.io/csharp/lesson5_operators_part1.html     *");
            Console.WriteLine("* specific source: https://kassapoglou.github.io/csharp/lesson6_operators_part2.html     *");
            Console.WriteLine("*----------------------------------------------------------------------------------------*");
            Console.WriteLine(" I would like to express my thanks, and my gratitude to mr KASSAPOGLOY M.\nfor the very meaningful, understandable and contagious training program\nfor learning programming language C# in .NET8!");
            Console.WriteLine("******************************************************************************************\n\n");

            Console.WriteLine("\nThanks for your visited my project!\nHAVE A NICE DAY.");
            Console.WriteLine("\nCOMING SOON with a new version with menu selector.\nANTONIOU IOANNIS");

            Console.ReadKey();

        }
    }
}
