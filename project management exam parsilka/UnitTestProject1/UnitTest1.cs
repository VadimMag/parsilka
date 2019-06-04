using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using project_management_exam_parsilka;
namespace UnitTestProject1
{
<<<<<<< HEAD
=======

>>>>>>> tests
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program pr = new Program();

            Dictionary<string, int> asd = pr.Parsilka(@"c:\temp\test1.txt");//пустой файл
            Assert.IsNotNull(asd);//проверка на возврат null
            Assert.AreEqual(asd.Count,0);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Program pr = new Program();

            Dictionary<string, int> asd = pr.Parsilka(@"c:\temp\test2.txt");//2 правильных слова
            Assert.AreEqual(asd.Count, 2);

        }
        [TestMethod]
        public void TestMethod3()
        {
            Program pr = new Program();

            Dictionary<string, int> asd = pr.Parsilka(@"c:\temp\test3.txt");//2 слова asd и 2 других
            Assert.AreEqual(asd["asd"], 2);
            Assert.AreEqual(asd.Count, 3);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Program pr = new Program();

            Dictionary<string, int> asd = pr.Parsilka(@"c:\temp\test4.txt");//2 нормальных слова и 2 ненормальных
            Assert.AreEqual(asd.Count, 2);
        }
        [TestMethod]
        public void TestMethod5()
        {
            Program pr = new Program();

            Dictionary<string, int> asd = pr.Parsilka(@"c:\temp\test5.txt");//5 нормальных слов с дефизами и кавычками
            Assert.AreEqual(asd.Count, 5);
<<<<<<< HEAD


=======
>>>>>>> tests
        }
    }
}
