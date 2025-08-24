using System.Collections;
using static LINQSessions1_2.ListGenerator;
namespace LINQSessions1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Implicitly-Type Local Variable [Var- Dynamic ]

            #region Var
            // Var 

            // var Dat01 = "Ahmed";

            //Compiler Can Detect The DataType Of The Local Variable Based On Initial Value ,At Compination Time 
            //Must BE Initialized
            //Can't Initialized The Local Variable With Null
            //Can't Change DataType Of The Local After Initialization
            //Can;t Use Var as Parameter Or Return Type
            //Data01 = 12;//InValid 
            #endregion

            #region Dynamic
            //Dynamic: Like Var in JS

            // dynamic Data02 = null;
            // Console.WriteLine(Data02.GetType().Name);//Exception [Runtime Binder  Exception ]

            //CLR Detect The DataType Of The Local Variable Based On Last Value, At Runtime
            //Don'tNeed To Be Initialized
            //Can Initialize The Local Variable With Null
            //Can Change DataType Of The Local Variable After Initialization
            //Can Use The Dynamic KeyWord AS Parameter OR Return Type
            //Be carefull When Use Dynamic 
            //Like var in JS Or Objecet in C#


            //Data02 = 12;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 1.4;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 1.4f;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 1.4m;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = true;
            //Console.WriteLine(Data02.GetType().Name);

            #endregion

            #endregion

            #region Anonymous Type

            //Employee E01= new Employee() {Id=1,Name="Ahmed",Salary=12000 } ;
            // var E01 = new { Id = 1, Name = "Ahmed", Salary = 12000.0m };
            // var E02 = new { Id = 2, Name = "Ahmed", Salary = 12000.0m };
            //var E02 = E01 with { Id = 2 }; //New Feature C# 10.0

            //E01.Id=12;//Invalid:Immutable Can't Change Its Value After Creation

            //Console.WriteLine(E01.Name.GetHashCode()); // -1394292997
            //Console.WriteLine(E02.Name.GetHashCode()); //-1394292997     
            //The Same Anonymouse Type As Long As: 1.The Same Property Name [Case Sensitive] 
            //                                     2.The Same Property Order
            //                                     


            //Console.WriteLine(E01);//{ Id = 1, Name = Ahmed, Salary = 12000.0 }
            //Compiler Will Override On ToString
            //Console.WriteLine(E01.GetHashCode);
            //Console.WriteLine(E02.GetHashCode);

            // if(E01.Equals(E02)) //Compiler Will Override on Equales(), GetHashCode()
            //     Console.WriteLine("E01 == E02");
            // else
            //     Console.WriteLine("E01 !=E02");


            #endregion

            #region Extention Method

            // int Number = 12345;

            //var result = IntExtention.Reverse(Number);//Class Method

            // var result= Number.Reverse();//Extension Method

            // Console.WriteLine(result);//54321



            #endregion

            #region What Is LinQ

            // LinQ1 : Language Integrate Query 
            //       : 40+ Extension Method (LinQ Operator ) Against Any Data [Data in Sequence]
            //       : Regardless Data Store
            //       : 13 category
            //       : LinQ Operator Exists in Built-in Class "Enumrable"


            // Sequence : Object from Class Implement Interface "IEnumrable"

            // Local Sequence : L2O , L2XML
            // Remote Sequence: L2EF

            // Input Sequence -> LinQ Operator -> Output Sequence
            // Input Sequence -> LinQ Operator -> Output Sequence
            //                -> LinQ Operator -> Output Sequence


            // List<int> Number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // //var result = Enumerable.Where(Number, N => N % 2 == 0);
            // //var result = Enumerable.Any(Number, N => N % 2 == 0);
            // var result = Enumerable.Range(1,100);
            //// Console.WriteLine(result);
            // foreach (var item in result)
            // {
            //     Console.Write($"{item} ");
            // }


            #endregion

            #region LinQ Syntax
            // 1.Fluent Syntax 
            // Use LinQ Method 
            // 1.1 LinQ Operator as => Class Member Method Through Class "Enumerable" 

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var result = Enumerable.Where(Numbers, X => X % 2 == 0);
            //foreach (var item in result)
            //{
            //    Console.Write($"{item} ");
            //}

            // 1.2 LinQ Operator as => Extension Method Through Sequence [Recommended]


            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var result = Numbers.Where( X => X % 2 == 0);
            //foreach (var item in result)
            //{
            //    Console.Write($"{item} ");
            //}


            // 2.Query Syntax Like SQL Style
            //Start -> From
            //End   -> Select , Group By


            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var result = from N in Numbers
            //             where N % 2 == 0
            //             select N;

            //foreach (var item in result)
            //{
            //    Console.Write($"{item} ");
            //}

            #endregion

            #region LinQ Excution Ways

            //1.Differed Excution Way  : 10 Category
            //2.Immediate Excution Way : 3 Category   [Elements Operator , Casting Operator , Aggregate Operator ]


            //List<int> Number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result =Number.Where( N => N % 2 == 0); // Differed

            //Number.AddRange(new int[] { 11, 12, 13, 14, 15 });

            //foreach (var item in result) //Here
            //{
            //    Console.Write($"{item} ");
            //}

            //List<int> Number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = Number.Where(N => N % 2 == 0).ToList(); // Immediate

            //Number.AddRange(new int[] { 11, 12, 13, 14, 15 });

            //foreach (var item in result) 
            //{
            //    Console.Write($"{item} ");
            //}


            #endregion

            #region Setup Data
            // Console.WriteLine(ProductsList[0]);
            // Console.WriteLine(CustomersList[0]);

            // var result = ProductsList.Where(P => P.UnitsInStock == 0);
            //// var result = CustomersList.Where(C=>C.City=="Berlin");

            // foreach (var item in result)
            // {
            //     Console.WriteLine(item);
            // }

            #endregion

            #region Filteration Operation 

            // 1.Filteration Operation - Where/ OfType

            // All Product Out Stouck 

            //Fluent Syntax
            //var result = ProductList.Where(P => P.UnitsInStock == 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Query Syntax
            //var result = from P in ProductList
            //             where P.UnitsInStock == 0
            //             select P;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}




            //var result = ProductList.Where(P => P.UnitsInStock > 0).Where(P=>P.Category=="Meat/Poultry");
            //var result = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Meat/Poultry");
            //var result = from P in ProductList
            //             where P.UnitsInStock > 0 && P.Category== "Meat/Poultry"
            //             select P;

            //Indexed Where -> Valid Only In Fluent Syntax
            //Can't Be Written Using Query Syntax

            // result = ProductList.Where((P, Index) => Index < 10 && P.UnitsInStock == 0);
            // var result = ProductList.Where((P, Index) => Index < 5 );
            // var result = ProductList.Where((P, Index) => Index < 5 && P.UnitsInStock>0);
            // var result = ProductList.Where(P=>P.UnitsInStock>0).Where((P,I)=>I<5);


            ArrayList arraylist = new ArrayList() { 1, 2, 3, "Ahmed", "Ali", 1.3, 1.5, 1.7f, 1.8f, 2.3m, 4.5m, ProductList[0], ProductList[1] };

          var result=  arraylist.OfType<float>();


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


























            #endregion



        }
    }
}
