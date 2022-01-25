using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Xunit;

namespace SmartPulseWebAutomation.Page
{
    public class KGUP
    {

        #region Defination
        public IWebDriver? Chromedriver;
        #endregion

        #region Exit
        internal void Dispose()
        {
            Thread.Sleep(3000);
            Chromedriver?.Quit();
            Chromedriver?.Dispose();
        }
        #endregion

        #region Case
        [Fact]
        public void KGUPPage()
        {


            Chromedriver = new ChromeDriver();
            Chromedriver.Navigate().GoToUrl("https://seffaflik.epias.com.tr/transparency/uretim/planlama/kgup.xhtml");
            Chromedriver.Manage().Window.Maximize();
            Chromedriver.FindElement(By.Id("j_idt226:date1_input")).SendKeys(Keys.Clear);
            Chromedriver.FindElement(By.Id("j_idt226:date1_input")).SendKeys("30.03.2020");
            Chromedriver.FindElement(By.Id("j_idt226:date2_input")).SendKeys(Keys.Clear);
            Chromedriver.FindElement(By.Id("j_idt226:date2_input")).SendKeys("30.03.2020");
            Chromedriver.FindElement(By.Id("j_idt226:goster")).Click();
            Chromedriver.FindElement(By.Id("j_idt226:dt:j_idt276")).Click();
            Dispose();


        }
        #endregion

    }
}