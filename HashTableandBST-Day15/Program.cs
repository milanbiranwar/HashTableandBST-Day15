﻿// See https://aka.ms/new-console-template for more information
using HashTableandBST_Day15;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hash table demo");
HashTable<string, string> hash = new HashTable<string, string>(5);
hash.Add("0", "To");
hash.Add("1", "be");
hash.Add("2", "or");
hash.Add("3", "not");
hash.Add("4", "to");
hash.Add("5", "be");
string hash5 = hash.Get("5");
Console.WriteLine("5th index value: " + hash5);
string hash2 = hash.Get("2");

Console.WriteLine("2th index value: " + hash2);


//BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
//binarySearch.Insert(30);
//binarySearch.Insert(70);
//binarySearch.Insert(22);
//binarySearch.Insert(40);
//binarySearch.Insert(60);
//binarySearch.Insert(95);
//binarySearch.Insert(11);
//binarySearch.Insert(65);
//binarySearch.Insert(3);

//binarySearch.Insert(16);
//binarySearch.Insert(63);
//binarySearch.Insert(67);
//binarySearch.Display();
//bool result = binarySearch.IfExists(67, binarySearch);
//Console.WriteLine(result);

Console.ReadKey();
