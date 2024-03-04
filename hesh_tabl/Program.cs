using System;

class Program
{
    static void Main(string[] args)
    {
        HashTable hashTable = new HashTable();

        byte hash1 = hashTable.Add("apple");
        byte hash2 = hashTable.Add("banana");
        byte hash3 = hashTable.Add("orange");

        Console.WriteLine("Hash for 'apple': " + hash1);
        Console.WriteLine("Hash for 'banana': " + hash2);
        Console.WriteLine("Hash for 'orange': " + hash3);

        string word1 = hashTable.Get(hash1);
        string word2 = hashTable.Get(hash2);
        string word3 = hashTable.Get(hash3);

        Console.WriteLine("\nWord for hash " + hash1 + ": " + word1);
        Console.WriteLine("Word for hash " + hash2 + ": " + word2);
        Console.WriteLine("Word for hash " + hash3 + ": " + word3);

        Console.ReadLine();
    }
}