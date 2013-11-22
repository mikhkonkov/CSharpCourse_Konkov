using TextSelector;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    
    
    /// <summary>
    ///Это класс теста для FileProcessingTest, в котором должны
    ///находиться все модульные тесты FileProcessingTest
    ///</summary>
    [TestClass()]
    public class FileProcessingTest {


        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext {
            get {
                return testContextInstance;
            }
            set {
                testContextInstance = value;
            }
        }

        #region Дополнительные атрибуты теста
        // 
        //При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        //ClassInitialize используется для выполнения кода до запуска первого теста в классе
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //TestInitialize используется для выполнения кода перед запуском каждого теста
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //TestCleanup используется для выполнения кода после завершения каждого теста
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Тест для getCountLinesInText
        ///</summary>
        [TestMethod()]
        public void getCountLinesInTextTest() {
            FileProcessing target = new FileProcessing(); 
            string pathInputFile = "..\\..\\inputText.txt"; 
            int expected = 6; 
            int actual;
            actual = target.getCountLinesInText(pathInputFile);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для getSentenceBeforeDot
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TestTask.exe")]
        public void getSentenceBeforeDotTest() {
            FileProcessing_Accessor target = new FileProcessing_Accessor(); 
            string line = "строки. Файл_с_текстом содержит текст "; 
            string expected = "строки."; 
            string actual;
            actual = target.getSentenceBeforeDot(line);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для getSentenceAfterDot
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TestTask.exe")]
        public void getSentenceAfterDotTest() {
            FileProcessing_Accessor target = new FileProcessing_Accessor(); 
            string line = "строки. Файл_с_текстом содержит текст "; 
            string expected = " Файл_с_текстом содержит текст "; 
            string actual;
            actual = target.getSentenceAfterDot(line);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для findLastIndexDot
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TestTask.exe")]
        public void findLastIndexDotTest() {
            FileProcessing_Accessor target = new FileProcessing_Accessor(); 
            string str = "строки. Файл_с_текстом содержит текст ";  
            int expected = 6;
            int actual;
            actual = target.findLastIndexDot(str);
            Assert.AreEqual(expected, actual);
        }
    }
}
