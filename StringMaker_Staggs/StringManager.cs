﻿using System; using System.Collections; using System.Collections.Generic; using System.Linq; using System.Reflection.Metadata.Ecma335; using System.Security.Cryptography.X509Certificates; using System.Text; using System.Threading.Tasks; using System.Windows.Markup;  namespace StringMaker_Staggs {     internal class StringManager     {         private Stack<char> stack = new Stack<char>();         private Stack<String> lastString = new Stack<String>();         public string Reverse(string str)         {             return Reverse(str, false);         }         public string Reverse(string str, bool preserveCaseLocation)         {             lastString.Push(str);             stack.Clear();             if (preserveCaseLocation == false)             {                 foreach (char c in str)                 {                     stack.Push(c);                 }             }             else             {                 int revIndex = str.Length - 1;                 for(int i = 0; i < str.Length; i++)                 {                     if (char.IsUpper(str[revIndex]))                     {                         stack.Push(char.ToUpper(str[i]));                     }                     else                     {                         stack.Push(char.ToLower(str[i]));                     }                     revIndex--;                 }             }             return sb(stack);         }         public bool symmetric(string str)         {             lastString.Push(str);             stack.Clear();             foreach (char c in str)              {                 stack.Push(c);             }             foreach (char c in str)             {                 char? stackPop = (char?)stack.Pop();                 if(stackPop != c)                 {                     return false;                 }             }             return true;         }         public override string ToString()         {             string str = lastString.Peek();             Queue que = new Queue();             if (str == string.Empty)             {                 return "Negative One";             }             int charValues = 0;             foreach (char c in stack)             {                 charValues += (int)c;             }             foreach (char c in charValues.ToString())             {                 switch (c)                 {                     case '0':                         que.Enqueue("Zero ");                         break;                     case '1':                         que.Enqueue("One ");                         break;                     case '2':                         que.Enqueue("Two ");                         break;                     case '3':                         que.Enqueue("Three ");                         break;                     case '4':                         que.Enqueue("Four ");                         break;                     case '5':                         que.Enqueue("Five ");                         break;                     case '6':                         que.Enqueue("Six ");                         break;                     case '7':                         que.Enqueue("Seven ");                         break;                     case '8':                         que.Enqueue("Eight ");                         break;                     case '9':                         que.Enqueue("Nine ");                         break;                 }             }             return sb(que);                 }         public override bool Equals(object? obj)         {             if (obj == null || (string)obj != lastString.Peek())             {                 return false;             }             return true;         }         private string sb(dynamic? obj) //Returns stack or queue back to string         {             string ret = "";             foreach (dynamic c in obj)             {                 ret += c;             }             return ret;         }     } } 