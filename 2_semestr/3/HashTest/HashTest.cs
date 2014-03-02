namespace HashTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Hash;

    [TestClass]
    public class HashTest
    {
        [TestInitialize]
        public void Initialize()
        {
            HashFunctionString hashFunction = new HashFunctionString();
            hashTable = new HashTable<string>(hashFunction);
        }

        [TestMethod]
        public void EmptyTest()
        {
            Assert.IsTrue(hashTable.Empty());
            hashTable.InsertHashTable("12");
            Assert.IsFalse(hashTable.Empty());
        }

        [TestMethod]
        public void ExistHashElementTest()
        {
            Assert.IsFalse(hashTable.ExistHashElement("Not"));
        }

        [TestMethod]
        public void InsertHashTableTest()
        {
            hashTable.InsertHashTable("Stroka");
            Assert.IsTrue(hashTable.ExistHashElement("Stroka"));
        }

        [TestMethod]
        public void RemoveHashTableTest()
        {
            hashTable.InsertHashTable("Strochka");
            hashTable.InsertHashTable("123");
            Assert.IsTrue(hashTable.ExistHashElement("123"));
            hashTable.RemoveHashElement("123");
            Assert.IsFalse(hashTable.ExistHashElement("123"));
        }

        [TestMethod]
        public void PrintHashTableTest()
        {
            hashTable.InsertHashTable("Strochka");
            Assert.AreEqual("Strochka", hashTable.PrintHashTable());
        }

        public HashTable<string> hashTable;
    }
}
