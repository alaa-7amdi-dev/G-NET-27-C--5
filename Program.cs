namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //A:
            //    Console.WriteLine("Enter Day Number from 0 to 6");
            //    bool isTrue = int.TryParse(Console.ReadLine(), out int day);
            //    do
            //    {

            //        if (isTrue)
            //        {

            //            break;

            //        }
            //        else
            //            Console.WriteLine("Invaild");
            //        goto A;

            //    }
            //    while (!isTrue);

            //    DayOfWeek dayOfWeek = (DayOfWeek)day;

            //    switch (dayOfWeek)
            //    {
            //        case DayOfWeek.Saturday:
            //        case DayOfWeek.Sunday:
            //        case DayOfWeek.Monday:
            //        case DayOfWeek.Tuesday:
            //        case DayOfWeek.Wednesday:
            //        case DayOfWeek.Thursday:
            //            Console.WriteLine($"Day:{Enum.GetName<DayOfWeek>(dayOfWeek)} \n It's the WorkDay");
            //            break;
            //        case DayOfWeek.Friday:
            //            Console.WriteLine($"Day:{Enum.GetName<DayOfWeek>(dayOfWeek)} \n It's the Weekend");
            //            break;
            //        default:
            //            Console.WriteLine("OutOfRange");
            //            break;


            //    }
            #endregion

            #region Q2
            //Console.WriteLine("Enter Size of Array : ");
            //int.TryParse(Console.ReadLine(), out int size);
            //int[] arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"\n Enter element[{i}]:");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int sum = 0, min=arr[0], max=arr[0];
            //double avg = 0;
            //foreach (int item in arr)
            //{
            //    if (item > max)
            //      max = item;
            //    if (item < min)
            //        min = item;
            //    sum+= item;
            //    avg =sum/size;
            //}

            //Console.WriteLine($"Sum =  {sum} \n Average ={avg} \n Max={max} \n Min=:{min}");
            //for (int j = 0; j < size; j--)
            //{
            //    Console.WriteLine(arr[j]);
            //}


            #endregion

            #region Student Grades Matrix
            //double[,]? studentGrades = new double[3, 4];
            //Console.WriteLine("Enter Grade of Each Student");
            //for (int i = 0; i < studentGrades.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Student{i+1}:");
            //    for (int j = 0; j< studentGrades.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Grade of Subject{j+1}:");

            //        studentGrades[i,j]=double.Parse(Console.ReadLine());
            //    }

            //}


            //double Sum = 0;

            //for (int i = 0; i < studentGrades.GetLength(0); i++)
            //{
            //    double studentSum = 0;
            //    for (int j = 0; j < studentGrades.GetLength(1); j++)
            //    {
            //        studentSum += studentGrades[i, j];
            //    }

            //    double studentAvg = studentSum / 4;
            //    Sum += studentSum;

            //    Console.WriteLine($"Student {i + 1} Average: {studentAvg}");
            //    Console.WriteLine($"Student {i + 1} sum: {Sum}");
            //}




            #endregion

            #region Functions Q1

            //Console.WriteLine("Enter Value Of first Num= ");
            // double.TryParse(Console.ReadLine(), out double a);
            //Console.WriteLine("Enter Value Of second Num= ");
            //double.TryParse(Console.ReadLine(), out double b);

            //Console.WriteLine("Enter operator : ");
            //bool isValid = char.TryParse(Console.ReadLine(), out char Oper);
            //double result=0;
            //do
            //{
            //    break;
            //} while (!isValid);

            //switch (Oper)
            //{
            //    case '+':
            //        result = Add(a, b);
            //        break;
            //    case '-':
            //        result = Subtract(a, b);
            //        break;
            //    case '*':
            //        result = Multiply(a, b);
            //        break;
            //    case '/':
            //        result = Divide(a, b);
            //        break;
            //    default:
            //        Console.WriteLine("Invaild Operatir");
            //        break;


            //}
            //Console.WriteLine(result);

            #endregion
        }

        static double Add(double x, double y)
            {
               double result=x + y;
               return result;
   
            }
        static double Subtract(double x, double y)
            {
               double result=x - y;
               return result;
   
            }
        static double Multiply(double x, double y)
            {
               double result=x * y;
               return result;
   
            }
        static double Divide(double x, double y)
            {
               double result=x / y;
               return result;
   
            }


    }
}
