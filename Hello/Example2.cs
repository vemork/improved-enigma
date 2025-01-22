namespace Hello
{
     using System;

     public class Example2
     {
          public static void Main(string[] args)
          {
               
               string name = string.Format("{0} {1}", "firstName", "LastName");
               
               Console.WriteLine("Hi, my name is " + name);
               
               var numbers = new[] { 1, 2, 3 };
               string list = string.Join(", ", numbers);
               Console.WriteLine("list " + list);
               
               // string are inmutables
               
               //Verbatim Strings
               var path = "c:\\temp\\file.txt"; //var instead string
               Console.WriteLine("path " + path);
               
               var path2 = @"c:\temp\file.txt"; // use only backslash
               Console.WriteLine("path2 " + path2);
               
               String pronoun = "abc"; // similar to (s)tring 
               Console.WriteLine("pronoun " + pronoun);
               
               var fullName = "John" +" "+ " Doe";
               Console.WriteLine("fullName " + fullName);
          }
     }
}