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
            HashFunctionString hashFunctionString = new HashFunctionString();
            hashTableString = new HashTable<string>(hashFunctionString);
            OtherHashFunctionInt hashFunctionInt = new OtherHashFunctionInt();
            hashTableInt = new HashTable<int>(hashFunctionInt);
        }

        [TestMethod]
        public void EmptyTest()
        {
            Assert.IsTrue(hashTableString.Empty());
            hashTableString.InsertHashTable("12");
            Assert.IsFalse(hashTableString.Empty());
        }

        [TestMethod]
        public void ExistHashElementTest()
        {
            Assert.IsFalse(hashTableString.ExistHashElement("Not"));
        }

        [TestMethod]
        public void InsertHashTableTest()
        {
            hashTableString.InsertHashTable("Stroka");
            Assert.IsTrue(hashTableString.ExistHashElement("Stroka"));
        }

        [TestMethod]
        public void RemoveHashTableTest()
        {
            hashTableString.InsertHashTable("Strochka");
            hashTableString.InsertHashTable("123");
            Assert.IsTrue(hashTableString.ExistHashElement("123"));
            hashTableString.RemoveHashElement("123");
            Assert.IsFalse(hashTableString.ExistHashElement("123"));
        }

        [TestMethod]
        public void PrintHashTableTest()
        {
            hashTableString.InsertHashTable("Strochka");
            Assert.AreEqual("Strochka", hashTableString.PrintHashTable());
        }

        [TestMethod]
        public void ChangeHashFunctionTest()
        {
            HashFunctionInt hashFunction = new HashFunctionInt();
            hashTableInt.InsertHashTable(12345);
            hashTableInt.ChangeHashFunction(hashFunction);
            Assert.IsTrue(hashTableInt.ExistHashElement(12345));
        }

        public HashTable<string> hashTableString;
        public HashTable<int> hashTableInt;
    }
}
