using TextSelector;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    
    
    /// <summary>
    ///Это класс теста для StringProcessingTest, в котором должны
    ///находиться все модульные тесты StringProcessingTest
    ///</summary>
    [TestClass()]
    public class StringProcessingTest {


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
        ///Тест для findLengthWord
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TestTask.exe")]
        public void findLengthWordTest() {
            StringProcessing_Accessor target = new StringProcessing_Accessor(); 
            string str = "в виде последовательностей строк, "; 
            int indexStartWord = 2; 
            int expected = 4; 
            int actual;
            actual = target.findLengthWord(str, indexStartWord);
            Assert.AreEqual(expected, actual);
        }
    }
}
