﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using DataStructuresHashtable.Hashtable;

MyMapNode<string, string> hashtable = new MyMapNode<string, string>(5);

hashtable.Add("0", "To");
hashtable.Add("1", "be");
hashtable.Add("2", "or");
hashtable.Add("3", "not");
hashtable.Add("4", "to");
hashtable.Add("5", "be");

//string getword = hashtable.GetElement("2");
//Console.WriteLine("2th index value is : " + getword);
string getword = hashtable.GetElement("3");
Console.WriteLine("3th index value is : " + getword);
