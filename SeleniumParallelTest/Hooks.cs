using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumParallelTest
{
    public enum BrowerType
    {
        Chrome,
        Firefox,
        IE
    }


    [TestFixture]
    public class Hooks : Base
    {
        private BrowerType _browserType;


        public Hooks(BrowerType browser)
        {
            _browserType = browser;
        }


        [SetUp]
        public void InitializeTest()
        {
            ChooseDriverInstance(_browserType);
        }

        private void ChooseDriverInstance(BrowerType browserType)
        {
            if (browserType == BrowerType.Chrome)
                Driver = new ChromeDriver();
            else if (browserType == BrowerType.Firefox)
                Driver = new FirefoxDriver();
        }

    }
}
