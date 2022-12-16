// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//using DataStructuresHashtable.Hashtable;

//MyMapNode<string, string> hashtable = new MyMapNode<string, string>(5);

//hashtable.Add("0", "To");
//hashtable.Add("1", "be");
//hashtable.Add("2", "or");
//hashtable.Add("3", "not");
//hashtable.Add("4", "to");
//hashtable.Add("5", "be");

////string getword = hashtable.GetElement("2");
////Console.WriteLine("2th index value is : " + getword);
//string getword = hashtable.GetElement("3");
//Console.WriteLine("3th index value is : " + getword);

//MyMapNode<string, string> hashtable = new MyMapNode<string, string>(18);

//hashtable.Add("f0", "“Paranoids");
//hashtable.Add("f1", "are");
//hashtable.Add("f2", "not");
//hashtable.Add("f3", "paranoid");
//hashtable.Add("f4", "because");
//hashtable.Add("f5", "they");
//hashtable.Add("f6", "are");
//hashtable.Add("f7", "paranoid");
//hashtable.Add("f8", "but");
//hashtable.Add("f9", "because");
//hashtable.Add("f10", "they");
//hashtable.Add("f11", "keep");
//hashtable.Add("f12", "putting");
//hashtable.Add("f13", "themselves");
//hashtable.Add("f14", "deliberately");
//hashtable.Add("f15", "into");
//hashtable.Add("f16", "paranoid");
//hashtable.Add("f17", "avoidable");
//hashtable.Add("f18", "situations”");

//hashtable.RemovePerticularElement("f17");
//Console.WriteLine(" Word 'avoidable' was deleted from the above paragraph");

using DataStructuresHashtable.BinarySearchTree;

BinarySearch binarytree = new BinarySearch();
binarytree.InsertingNode(56);
binarytree.InsertingNode(30);
binarytree.InsertingNode(70);
binarytree.InsertingNode(22);
binarytree.InsertingNode(40);
binarytree.InsertingNode(60);
binarytree.InsertingNode(95);
binarytree.InsertingNode(11);
binarytree.InsertingNode(65);
binarytree.InsertingNode(3);
binarytree.InsertingNode(16);
binarytree.InsertingNode(63);
binarytree.InsertingNode(67);
binarytree.Display();
binarytree.SearchMethod(63);

