using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
    //Arrange

    //Assemble

    //Assert

        
        [TestMethod]
        public void Add_AddToEmptyList_PutAtIndexZero()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            //Assemble
            testList.Add(1);
            actual = testList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddToList_CountLength()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            //Assemble
            testList.Add(123);
            actual = testList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddMiltipleItems_FillList()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 10;
            int actual;

            //Assemble
            for(int i = 0; i < 10; i++)
            {
                testList.Add(1);
            }
            actual = testList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddMultipleItemsToEmptyList_FillFromIndexZeroOn()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;

            //Assemble
            testList.Add(1);
            testList.Add(2);
            actual = testList[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddMultipleItemsToIncreaseCapacity_CheckItemFromOldArray()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;

            //Assemble
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);
            actual = testList[3];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        //-------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------
        [TestMethod]
        public void Remove_RemoveValueFromList_DecreaseCount()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 3;
            int actual;


            //Assemble
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Remove(3);
            actual = testList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveValueFromList_ItemsShifted()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 3;
            int actual;


            //Assemble
            testList.Add(1);//0
            testList.Add(2);//1
            testList.Add(3);//2
            testList.Add(4);//3
            testList.Remove(2);
            actual = testList[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveValueFromListThatAppearsMoreThanOnce_CheckIfTheCorrectValueWasRemoved()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;


            //Assemble
            testList.Add(1);//0
            testList.Add(2);//1
            testList.Add(1);//2
            testList.Add(4);//3
            testList.Remove(1);
            actual = testList[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveItemFromList_CheckBool()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            bool expected = true;
            bool actual;


            //Assemble
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            actual = testList.Remove(3);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveItemFromListThatsNotThere_CheckBool()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            bool expected = false;
            bool actual;


            //Assemble
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            actual = testList.Remove(5);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveLastNumberInArray_HaveLastIndexRemoved()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            bool expected = true;
            bool actual = false;

            //Assemble
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Remove(4);
            try
            {
               Console.WriteLine(testList[3]);
            }
            catch(ArgumentOutOfRangeException)
            {
                actual = true;
            }
            
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Remove_RemoveMultipleItemsfromList_CheckFirstIndex()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;
            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Remove(1);
            testList.Remove(2);
            testList.Remove(3);
            actual = testList[0];
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveMultipleItemsfromList_CheckCount()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;
            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Remove(1);
            testList.Remove(2);
            testList.Remove(3);
            actual = testList.Count;
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Convert_InputOneInt_ConvertToString()
        {
            //Assemble
            CustomList<int> testList = new CustomList<int>();
            string expected = "123";
            string actual;

            //Arrange
            testList.Add(123);
            actual = testList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
            
        }
        [TestMethod]
        public void Convert_InputMultipleInts_ConvertToString()
        {
            //Assemble
            CustomList<int> testList = new CustomList<int>();
            string expected = "1, 2, 3";
            string actual;

            //Arrange
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            actual = testList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Overload_OverloadAddTwoLists_CombineLists()
        {
            //Arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            CustomList<string> testList3 = new CustomList<string>();
            CustomList<string> testList4 = new CustomList<string>();
            testList4.Add("1");
            testList4.Add("2");
            testList4.Add("3");
            testList4.Add("4");
            testList4.Add("5");
            testList4.Add("6");
            string expected = testList4.ToString();
            string actual;
            //Assemble     
            testList1.Add("1");
            testList1.Add("2");
            testList2.Add("3");
            testList2.Add("4");
            testList3.Add("5");
            testList3.Add("6");
            actual = (testList1 + testList2 + testList3).ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Overload_OverloadAddTwoLists_CheckCount()
        {
            //Arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            CustomList<string> testList3 = new CustomList<string>();
            CustomList<string> testList4 = new CustomList<string>();
            testList4.Add("1");
            testList4.Add("2");
            testList4.Add("3");
            testList4.Add("4");
            testList4.Add("5");
            testList4.Add("6");
            int expected = 6;
            int actual;
            //Assemble     
            testList1.Add("1");
            testList1.Add("2");
            testList2.Add("3");
            testList2.Add("4");
            testList3.Add("5");
            testList3.Add("6");
            actual = testList4.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Minus_MinusOneListFromAnother_OnlyShowItemsLeftFromOriginalList()
        {
            //Arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            CustomList<string> testList3 = new CustomList<string>();
            testList3.Add("2");
            string expected = testList3.ToString();
            string actual;
            //Assemble     
            testList1.Add("1");
            testList1.Add("2");
            testList2.Add("1");
            testList2.Add("3");
            actual = (testList1 - testList2).ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Minus_MinusOneListFromAnother_CheckCount()
        {
            //Arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            CustomList<string> testList3 = new CustomList<string>();
            int expected = 1;
            int actual;
            //Assemble     
            testList1.Add("1");
            testList1.Add("2");
            testList2.Add("1");
            testList2.Add("3");
            testList3 = testList1 - testList2;
            actual = testList3.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Enumerator_GetEachInt_LogEachInt()
        {
            //Arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> expected = new CustomList<int>();
            CustomList<int> actual;
            //Assemble
            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList1.Add(4);
            foreach(int item in testList1)
            {
                expected.Add(item);
            }
            actual = testList1;
            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod]
        public void Enumerator_GetEachString_LogEachString()
        {
            //Arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> expected = new CustomList<string>();
            CustomList<string> actual;
            //Assemble
            testList1.Add("1");
            testList1.Add("2");
            testList1.Add("3");
            testList1.Add("4");
            foreach (string item in testList1)
            {
                expected.Add(item);
            }
            actual = testList1;
            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod]
        public void Zip_TakeEachList_AddEachValueInOrder()
        {
            //Arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            CustomList<string> testList3 = new CustomList<string>();
            string expected = "1, 2, 3, 4, 5, 6" ;
            CustomList<string> actual;
            
            //Assemble
            testList1.Add("1");
            testList1.Add("3");
            testList1.Add("5");

            testList2.Add("2");
            testList2.Add("4");
            testList2.Add("6");
            
            actual = testList3.Zip(testList1, testList2);
           
            

            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod]
        public void Zip_FirstListIsBigger_AddEachValueInOrder()
        {
            //Arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            CustomList<string> testList3 = new CustomList<string>();
            string expected = "1, 2, 3, 4, 5";
            CustomList<string> actual;

            //Assemble
            testList1.Add("1");
            testList1.Add("3");
            testList1.Add("5");
            testList2.Add("2");
            testList2.Add("4");
            


            actual = testList3.Zip(testList1, testList2);



            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod]
        public void Zip_SecondListIsBigger_AddEachValueInOrder()
        {
            //Arrange
            CustomList<string> testList1 = new CustomList<string>() { "1","3","5" };
            CustomList<string> testList2 = new CustomList<string>() { "2", "4", "6", "8" };
            CustomList<string> testList3 = new CustomList<string>();
            string expected = "1, 2, 3, 4, 5, 6, 8";
            CustomList<string> actual;

            //Assemble
            actual = testList3.Zip(testList1, testList2);

            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod]
        public void Sort_TakeUnorderedNumbers_SortThemLowestToHighest()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>() { 1, 3, 2, 5 };
            CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 5 };
            CustomList<int> actual;
            //Assemble
            //testList.Sort();
            actual = testList;
            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
    
}
