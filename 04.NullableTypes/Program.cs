//using System.Text.RegularExpressions;

//int age = 0;
//Nullable<int> ageNullable = null;

//if(ageNullable.HasValue)
//{
//    Console.WriteLine(ageNullable.Value);
//}

//int? newSyntax= null;


string? FirstName = null;

if(!string.IsNullOrEmpty(FirstName))
    Console.WriteLine(FirstName.ToUpper());