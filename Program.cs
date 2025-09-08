using System.Collections;
using System.ComponentModel;
using System.Net.WebSockets;
using System.Xml.Linq;
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


            //  ArrayList arraylist = new ArrayList() { 1, 2, 3, "Ahmed", "Ali", 1.3, 1.5, 1.7f, 1.8f, 2.3m, 4.5m, ProductList[0], ProductList[1] };

            //var result=  arraylist.OfType<float>();


            //  foreach (var item in result)
            //  {
            //      Console.WriteLine(item);
            //  }


            #endregion

            #region Transformation Operators - Select, SelectMany

            //Fluent Syntax

            //var result = ProductList.Select(P => P);
            //var result = ProductList.Select(P => P.ProductName);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //Query Syntax

            //var result = from P in ProductList
            //             select P.ProductName;


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Fluent Syntax

            //var result = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Seafood")
            //    .Select(P => new {
            //        P.ProductName,
            //        P.Category, 
            //        OldPrice = P.UnitPrice,
            //        NewPrice = P.UnitPrice - P.UnitPrice * 0.1m 
            //    });


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Query Syntax

            //var result = from P in ProductList
            //             where P.UnitsInStock > 0 && P.Category == "Seafood"
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.Category,
            //                 OldPrice = P.UnitPrice,
            //                 NewPrice = P.UnitPrice - P.UnitPrice * 0.1M
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Fluent Syntax:

            // var result = CustomerList.Select(C => C.CustomerName);
            // var result = CustomerList.Select(C => C.Orders); //If One The Property Is Sequence
            // var result = CustomerList.SelectMany(C => C.Orders); //If One The Property Is Sequence

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // Query Syntax :

            //var result = from C in CustomerList
            //             from O in C.Orders 
            //             select O;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //Indexed Select  Valid Only in Fluent Synta
            //Can't Be Written Using Queery Syntax

            //var result = ProductList.Select((P, I) => new { I, P.ProductName }).Where(P => P.I < 5);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Ordering Operators

            //Sorting 

            //var result = ProductList.OrderBy(P => P.UnitPrice);

            // var result = ProductList.OrderBy(P => P.UnitPrice).Select(P => new { P.ProductName, P.UnitsInStock });

            //var result = ProductList.OrderBy(P => P.UnitsInStock)
            //                         .Select(P => new
            //                         {
            //                             P.ProductName,
            //                             P.UnitPrice,
            //                             P.UnitsInStock
            //                         });

            //var result = ProductList.OrderByDescending(P => P.UnitsInStock)
            //                         .Select(P => new
            //                         {
            //                             P.ProductName,
            //                             P.UnitPrice,
            //                             P.UnitsInStock

            //                         });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Fluent Syntax :-

            //var result = ProductList.Where(P => P.Category == "Meat/Poultry")
            //                         .OrderBy(P => P.UnitsInStock)
            //                         .ThenByDescending(P => P.UnitPrice)
            //                         .Select(P => new
            //                         {
            //                           P.ProductName,
            //                           P.UnitPrice,
            //                           P.UnitsInStock

            //                         });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item );
            //}

            // Query Syntax:_

            //var result = from P in ProductList
            //             where P.Category=="Meat/Poultry" && P.UnitsInStock>0
            //             orderby P.UnitPrice, P.UnitsInStock descending
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.UnitPrice,
            //                 P.UnitsInStock
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}




            #endregion

            #region Element Operator 


            // ProductList = new List<Product>();

            //var result =ProductList.First(); May throw Exception [Sequence contains no elements]
            // var result = ProductList.Last(); May throw Exception [Sequence contains no elements]

            // var result = ProductList.First(P => P.UnitsInStock == 1000); //May throw Exception[Sequence contains no elements]
            // var result = ProductList.Last(P => P.UnitsInStock == 0); //May throw Exception[Sequence contains no elements]


            //var result = ProductList.FirstOrDefault();
            //var result = ProductList.FirstOrDefault(new Product() { ProductName="Defalut Product"});
            // var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 1000);
            // var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 1000,new Product() { ProductName = "Defalut Product" });

            //var result = ProductList.LastOrDefault();
            //var result = ProductList.LastOrDefault(new Product() { ProductName = "Defalut Product" });
            //var result = ProductList.LastOrDefault(P => P.UnitsInStock == 1000);
            //var result = ProductList.LastOrDefault(P => P.UnitsInStock == 1000, new Product() { ProductName = "Defalut Product" });


            //var result = ProductList.ElementAt(1); //May Throw Exception [Index Was out of Range] 
            // var result = ProductList.ElementAtOrDefault(1);


            // ProductList = new List<Product>() { new Product() { ProductName = "Only One Product " } };

            //var result = ProductList.Single(); //May  Throw Exception
            //Sequence Contains more than one element
            //Sequence Contains No element 


            // var result = ProductList.Single(P=>P.UnitsInStock==0); //May  Throw Exception
            //Sequence Contains more than one  Matching element
            //Sequence Contains No Matching element 


            //var result = ProductList.SingleOrDefault(); //May  Throw Exception
            //Sequence Contains more than one  element
            //Return Default Value [null] if The Sequence Empty


            //var result = ProductList.SingleOrDefault(new Product() { ProductName="Default Name "}); //May  Throw Exception
            //Sequence Contains more than one  element
            //Return Default Value [null] if The Sequence Empty


            //var result = ProductList.SingleOrDefault(new Product() { ProductName="Default Name "}); //May  Throw Exception
            //Sequence Contains more than one  element
            //Return Default Value new Product() { ProductName="Default Name "}


            //var result = ProductList.SingleOrDefault(P=>P.UnitsInStock==1000); //May  Throw Exception
            // var result = ProductList.SingleOrDefault(P=>P.ProductID==1); //May  Throw Exception
            //Sequence Contains more than one  element
            //Return Default Value [Null] if the Sequence Is Empty 


            //var result = ProductList.SingleOrDefault(P=>P.UnitsInStock==0,new Product() { ProductName = "Default Name " }); //May  Throw Exception
            //var result = ProductList.SingleOrDefault(P=>P.ProductID==1,new Product() { ProductName = "Default Name " }); //May  Throw Exception
            //var result = ProductList.SingleOrDefault(P=>P.ProductID==1000,new Product() { ProductName = "Default Name " }); //May  Throw Exception        
            //Sequence Contains more than one  element
            //Return Default Value [Null] if the Sequence Is Empty 

            //var result = ProductList.DefaultIfEmpty(new Product() { ProductName = "Default" });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            // Console.WriteLine(result?.ProductName??"NA");


            #endregion

            #region Aggregate Operators

            // Count - Sum - Max - Min -Avg 


            // var result = ProductList.Count(); //77
            //var result = ProductList.Count;//77

            //var result = ProductList.Count(P => P.UnitsInStock == 0); //5

            //var result = ProductList.Where(P => P.UnitsInStock == 0).Count(); //5

            //Sum

            // var result = ProductList.Sum(P=>P.UnitPrice);//2222.7100
            // var result = ProductList.Sum(P=>P.UnitsInStock);//3180

            //Avg

            //var result = ProductList.Average(P=>P.UnitPrice);//28.866363636363636363636363636


            //Max

            // var result = ProductList.Max();//$263.50, //Based On IComparable (Price)
            // var result = ProductList.Max(new ProductComparerUnitInStock());//UnitsInStock: 125 Based On IComparable (UnitsInStock)
            // var result = ProductList.Max(P => P.UnitPrice);//263.5000    
            // var result = ProductList.Max(P => P.UnitsInStock);//125

            // var MaxPrice = ProductList.Max(P => P.UnitPrice);

            //var result = ProductList.FirstOrDefault(P => P.UnitPrice==MaxPrice);


            //var result= ProductList.MaxBy(P => P.UnitPrice);// product $263.50,

            //Min 

            //var result= ProductList.Min();
            // var result= ProductList.Min(new ProductComparerUnitInStock ());
            //var result = ProductList.Min(new ProductComparerNameLength ());
            // var result = ProductList.Max(new ProductComparerNameLength ());

            // var result = ProductList.Min(P => P.UnitPrice); //2.5000

            //  var result = ProductList.MinBy(P => P.ProductName,new ProductComparerNameLength01()); //2.5000
            // var result = ProductList.MaxBy(P => P.ProductName,new ProductComparerNameLength01()); //2.5000


            //Aggregate

            //List<string> Names = new List<string>() { "Ahmed", "Ali", "Omar", "Osama" };

            //var result = Names.Aggregate((S01, S02) => $"{S01} {S02}");

            //Console.WriteLine(result);

            #endregion

            #region Casting Operator 

            // List<Product> list = (List<Product>) ProductList.Where(P => P.UnitsInStock == 0);//Invalid
            // List<Product> list =  ProductList.Where(P => P.UnitsInStock == 0).ToList();
            // Product[] list =  ProductList.Where(P => P.UnitsInStock == 0).ToArray();
            //Dictionary<long, Product> list = ProductList.Where(P => P.UnitsInStock == 0).ToDictionary(P => P.ProductID);
            //HashSet<Product> list = ProductList.Where(P => P.UnitsInStock == 0).ToHashSet();

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Generation Operators

            //The Only Way To Call This Method as -> Class Member Throught "Enumerable " Class

            //Range, Empty ,Repeat

            // var result = Enumerable.Range(1, 100);

            // var result = Enumerable.Empty<Product>().ToList();

            //result.Add(new Product() { ProductName = "Product01" });
            //result.Add(new Product() { ProductName = "Product02" });

            // var result = Enumerable.Repeat(ProductList[0], 3);


            //var result = Enumerable.Repeat(1, 3);


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Set Operator 

            //Union Family (Union - Union all - Intersect - Except )
            //var Seq01 = Enumerable.Range(1, 100);//1....100
            //var Seq02 = Enumerable.Range(50, 100);//50....149

            //var result=  Seq01.Union(Seq02); // Like Union in SQL Without Duplication
            //var result=  Seq01.Concat(Seq02); // Like Union in SQL With Duplication


            // result=  result.Distinct(); // Remove Duplication


            // var result= Seq01.Intersect(Seq02); //50 --- 100
            // var result= Seq01.Except(Seq02); //1 ---- 49
            // var result= Seq02.Except(Seq01); //101 ---- 149

            //foreach (var item in result)
            //{
            //    Console.Write( $"{item } ");
            //}

            #endregion

            #region  Quantifiers Operators
            //// 9. Quantifiers Operators - Return Boolean

            //// Any - All - SequanceEqual - Contains


            //var Seq01 = Enumerable.Range(1, 100);
            //var Seq02 = Enumerable.Range(50, 100);


            //// Any() --> Return True If There Are at Least One Element [in Sequance or Match The Condition]

            ////var result = Seq01.Any(N => N %2 == 0);


            //// ProductList = new List<Product>();




            ////var result = ProductList.Any(P => P.UnitsInStock == 0);


            //// All() --> Return True If All Element in the Sequance Match the Condition or is Empty

            ////var result = ProductList.All(P => P.UnitsInStock == 0);
            ////var result = ProductList.All(P => P.UnitPrice> 0);


            //// SequanceEqual() 

            ////var result = Seq01.SequenceEqual(Seq02);

            ////var result = Seq02.Contains(1);

            ////ProductList.Contains();


            //Console.WriteLine(result);

            #endregion

            #region  Zipping Operators
            //  // 10. Zipping Operators
            //  // Zip


            // List<string> words = new List<string>() { "ten","twenty","thirty","fourty"};

            // List<int> numbers = new List<int>() { 10, 20, 30, 40, 50, 60 };
            ////var result = words.Zip(numbers,(W,N) => $"{N} --> {W}");
            //var result = words.Zip(numbers,(W,N) => new {Number = N , word = W});

            // foreach (int item in numbers)
            // {
            //     Console.WriteLine(item);
            // } 
            #endregion

            #region Grouping Operators


            //// Grouping Operators

            ////var result =  ProductList.GroupBy(P => P.Category);


            ////  result = from p in ProductList
            ////           group p by p.Category;



            ////  foreach (var Category in result)
            ////  {
            ////      Console.WriteLine(Category.Key);
            ////      foreach (var product in Category)
            ////      {
            ////          Console.WriteLine($".......{product}");
            ////      }
            ////  }


            ////var result = from P in ProductList
            ////             where P.UnitsInStock > 0
            ////             group P by P.Category
            ////             into Category
            ////             where Category.Count() > 5
            ////             select new {CategoryName = Category.Key, CountCategory = Category.Count()};


            //var result = ProductList.Where(P => P.UnitsInStock > 0)
            //                                            .GroupBy(P => P.Category)
            //                                            .Where(C => C.Count() > 5)
            //                                            .Select(C => new { CategoryName = C.Key, CountCategory = C.Count() });


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            ////foreach (var Category in result)
            ////{
            ////    Console.WriteLine(Category.Key);
            ////    foreach (var product in Category)
            ////    {
            ////        Console.WriteLine($".......{product}");
            ////    }
            ////} 
            #endregion

            #region Partioning Operators
            //// Partioning Operators - Take , TakeLast , Skip, SkipLast , TakeWhile , SkipWhile 

            ////var result = ProductList.Where(P =>P.UnitsInStock ==0 ).Take(3);
            ////var result = ProductList.TakeLast(5);

            ////var result = ProductList.Skip(5).Take(5);

            ////var result = ProductList.SkipLast(5);


            ////int[] Numbers = {9,6,4,1,2,3,4,5};
            //////var result = Numbers.TakeWhile((N) =>N % 3 == 0);
            ////var result = Numbers.SkipWhile((N) =>N % 3 == 0);


            //int[] Numbers = { 9, 6, 4, 1, 2, 3, 4, 5 };
            ////var result = Numbers.TakeWhile((N, I) => N > I);
            //var result = Numbers.SkipWhile((N, I) => N > I);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region let / into

            // // let / into 
            // // Query Syntax

            // // aeoiuAEOIU

            // List<string> Names = new List<string>() { "Ahmed","Ali","omar","Aya","Mona","Fares"};


            // //var result = from Name in Names
            // //             select Regex.Replace(Name, "[aeoiuAEOIU]", string.Empty)
            // //             into NoVolNames
            // //             // into : Restart Query 
            // //             where NoVolNames.Length > 3
            // //             select NoVolNames;


            // var result = from Name in Names
            //              let NoVolNames = Regex.Replace(Name, "[aeoiuAEOIU]", string.Empty)

            //              where NoVolNames.Length > 3
            //              select NoVolNames;



            // foreach (var item in Names)
            // {
            //     Console.WriteLine(item);
            // }


            ////var result = Regex.Replace("Ahmed", "[aeoiuAEOIU]",string.Empty)

            ////     Console.WriteLine(result); 
            #endregion


        }
    }
}
