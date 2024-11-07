// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

string s1 = "Hosna";
string s2 = "Hajimohammadi";
string s3 = s1 + " " + s2;
Console.WriteLine(s3);

StringBuilder stringBuilder = new StringBuilder();

stringBuilder.Append(s1);
Console.WriteLine(stringBuilder.Capacity);

stringBuilder.AppendLine(s2);
Console.WriteLine(stringBuilder.Capacity);

stringBuilder.AppendLine(s3);
Console.WriteLine(stringBuilder.Capacity);

stringBuilder.AppendLine(s3);
Console.WriteLine(stringBuilder.Capacity);

stringBuilder.AppendLine(s3);
Console.WriteLine(stringBuilder.Capacity);

stringBuilder.AppendLine(s3);
Console.WriteLine(stringBuilder.Capacity);

stringBuilder.AppendLine(s3);
Console.WriteLine(stringBuilder.Capacity);

stringBuilder.AppendLine(s3);
Console.WriteLine(stringBuilder.Capacity);

stringBuilder.AppendLine(s3);
Console.WriteLine(stringBuilder.Capacity);
