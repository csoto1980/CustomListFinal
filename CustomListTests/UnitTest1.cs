using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_List_2020;


namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_OneValue_Test() //TEST1_ADD
        {
            //Arrange | Given | Arrange all necessary preconditions and inputs | Getting everything together
            CustomList<int> myList = new CustomList<int>();
            int value = 10;
            int expected = 1;
            int actual;

            //Act | When | Act on the method under test | What will it take for your action to happen | Act on the method under test
            myList.Add(value);
            actual = myList.Count;

            //Assert (Assert taht the expected result occurred)
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_ValueAtIndex_Test() //TEST2_ADD
        {
            //Arrange | Given | Arrange all necessary preconditions and inputs | Getting everything together
            CustomList<int> myList = new CustomList<int>();
            int expected = 5;

            //Act | When | Act on the method under test | What will it take for your action to happen | Act on the method under test
            myList.Add(expected);

            //Assert | Then | Assert taht the expected result occurred | Outcome of the test
            Assert.AreEqual(expected, myList[0]);
        }
        [TestMethod]
        public void Add_Indexes_Test() //TEST3_ADD
        {
            //Arrange | Given | Arrange all necessary preconditions and inputs | Getting everything together
            CustomList<int> myList = new CustomList<int>();
            int expected = 15;
            int value1 = 1;
            int value2 = 15;

            //Act | When | Act on the method under test | What will it take for your action to happen | Act on the method under test
            myList.Add(value1);
            myList.Add(value2);

            //Assert (Assert taht the expected result occurred)
            Assert.AreEqual(expected, myList[1]);
        }
        [TestMethod]
        public void Add_String_Index_Test() //TEST4_ADD
        {
            //Arrange | Given | Arrange all necessary preconditions and inputs | Getting everything together
            CustomList<string> myList = new CustomList<string>();
            string expected = "Bob";
            string string1 = "Bill";
            string string2 = "Ava";
            string string3 = "Bob";

            //Act | When | Act on the method under test | What will it take for your action to happen | Act on the method under test
            myList.Add(string1);
            myList.Add(string2);
            myList.Add(string3);

            //Assert (Assert taht the expected result occurred)
            Assert.AreEqual(expected, myList[2]);
        }
        [TestMethod]
        public void Add__String_Count_Test() //TEST5_ADD //capacity
        {
            //Arrange | Given | Arrange all necessary preconditions and inputs | Getting everything together
            CustomList<string> myList = new CustomList<string>();
            int expected = 3;
            string string1 = "Yesterday";
            string string2 = "Today";
            string string3 = "Tomorrow";
            int actual;

            //Act | When | Act on the method under test | What will it take for your action to happen | Act on the method under test
            myList.Add(string1);
            myList.Add(string2);
            myList.Add(string3);
            actual = myList.Count;

            //Assert (Assert taht the expected result occurred)
            Assert.AreEqual(expected, actual);
        }
        //[TestMethod]
        //public void Add__Capacity_Test() //TEST6 ADD //capacity
        //{
        //    //Arrange | Given | Arrange all necessary preconditions and inputs | Getting everything together
        //    CustomList<int> myList = new CustomList<int>();
        //    int value1 = 10;
        //    int value2 = 20;
        //    int value3 = 30;
        //    int value4 = 40;
        //    int expected = 0;
        //    int expected2 = 40;

        //    //Act | When | Act on the method under test | What will it take for your action to happen | Act on the method under test
        //    myList.Add(value1);
        //    myList.Add(value2);
        //    myList.Add(value3);
        //    myList.Add(value4);

        //    //Assert (Assert taht the expected result occurred)
        //    Assert.AreEqual(expected, myList[5]);
        //    Assert.AreEqual(expected2, myList[3]);
        //}
        [TestMethod]
        public void Remove_OneValue_Test() //TEST1_Remove //make sure other 10 is in there//when you remove something that isn't there make sure count is still the same.
        {
            //Arrange | Given | Arrange all necessary preconditions and inputs | Getting everything together
            CustomList<int> myList = new CustomList<int>();
            int value1 = 10;
            int value2 = 10;
            int expected = 1;
            int actual;

            //Act | When | Act on the method under test | What will it take for your action to happen | Act on the method under test
            myList.Add(value1);
            myList.Add(value2);
            myList.Remove(value1);
            actual = myList.Count;

            //Assert (Assert taht the expected result occurred)
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ValueAtIndex_Test() //TEST2_Remove
        {
            //Arrange | Given | Arrange all necessary preconditions and inputs | Getting everything together
            CustomList<int> myList = new CustomList<int>();
            int value1 = 10;
            int value2 = 20;
            int value3 = 5;
            int expected = 10;

            //Act | When | Act on the method under test | What will it take for your action to happen | Act on the method under test
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Remove(value3);

            //Assert | Then | Assert taht the expected result occurred | Outcome of the test
            Assert.AreEqual(expected, myList[0]);
        }
        [TestMethod]
        public void Remove_String_Index_Test() //TEST3_Remove //remove string 1
        {
            //Arrange | Given | Arrange all necessary preconditions and inputs | Getting everything together
            CustomList<string> myList = new CustomList<string>();
            string string1 = "Bill";
            string string2 = "Ava";
            string string3 = "Bob";
            string expected = "Bob";

            //Act | When | Act on the method under test | What will it take for your action to happen | Act on the method under test
            myList.Add(string1);
            myList.Add(string2);
            myList.Add(string3);
            myList.Remove(string1);

            //Assert (Assert taht the expected result occurred)
            Assert.AreEqual(expected, myList[1]);
        }
        [TestMethod]
        public void Remove__String_Count_Test() //TEST4_Remove
        {
            //Arrange | Given | Arrange all necessary preconditions and inputs | Getting everything together
            CustomList<string> myList = new CustomList<string>();
            int expected = 2;
            string string1 = "Yesterday";
            string string2 = "Today";
            string string3 = "Tomorrow";
            int actual;

            //Act | When | Act on the method under test | What will it take for your action to happen | Act on the method under test
            myList.Add(string1);
            myList.Add(string2);
            myList.Add(string3);
            myList.Remove(string1);
            actual = myList.Count;

            //Assert (Assert taht the expected result occurred)
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_Test() //TEST5_Remove
        {
            //Arrange | Given | Arrange all necessary preconditions and inputs | Getting everything together
            CustomList<int> myList = new CustomList<int>();
            int value1 = 0;
            int value2 = 10;
            int value3 = 20;
            int value4 = 30;
            int actual;
            int expected = 0;

            //Act | When | Act on the method under test | What will it take for your action to happen | Act on the method under test
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Remove(value1);
            myList.Remove(value2);
            myList.Remove(value3);
            myList.Remove(value4);
            actual = myList.Count;

            //Assert (Assert taht the expected result occurred)
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_Test1() //TEST1_ToString
        {
            //Arrange | Given | Arrange all necessary preconditions and inputs | Getting everything together
            CustomList<string> myList = new CustomList<string>();
            string string1 = "0";
            string string2 = "10";
            string string3 = "20";
            string expected = "01020";

            //Act | When | Act on the method under test | What will it take for your action to happen | Act on the method under test
            myList.Add(string1);
            myList.Add(string2);
            myList.Add(string3);
            string actual = myList.ToString();

            //Assert (Assert taht the expected result occurred)
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ToString_Test2() //TEST2_ToString
        {
            //Arrange | Given | Arrange all necessary preconditions and inputs | Getting everything together
            CustomList<int> myList = new CustomList<int>();
            int value1 = 10;
            int value2 = 20;
            int value3 = 30;
            string expected = "102030";

            //Act | When | Act on the method under test | What will it take for your action to happen | Act on the method under test
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            string actual = myList.ToString();

            //Assert (Assert taht the expected result occurred)
            Assert.AreEqual(expected, actual);
        }
    }
}
