using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using Xunit;


namespace SmartPulseMobileAutomationNormal
{
    public class UnitTest1
    {

        private AndroidDriver<AndroidElement>? _driver;
        private IPerformsTouchActions ? driver;

        [Fact]
        public void Test1()
        {


            var cap = new AppiumOptions();
            cap.AddAdditionalCapability("appPackage", "com.foreks.android.epias");
            cap.AddAdditionalCapability("appActivity", "com.foreks.android.epias.view.splash.SplashActivity");
            cap.AddAdditionalCapability("noReset", "true");

            _driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);

            Thread.Sleep(5000);


            AndroidElement mcpButton = _driver.FindElementById("com.foreks.android.epias:id/fragmentPtfSmf_imageView_redirect");
            mcpButton.Click();
            Thread.Sleep(5000);
            AndroidElement calendarButton = _driver.FindElementById("com.foreks.android.epias:id/layoutEpiasTopSelectionView_imageViewDate");
            calendarButton.Click();
            Thread.Sleep(2000);
            AndroidElement dayButton = _driver.FindElementById("com.foreks.android.epias:id/wheel_date_picker_day");


            TouchAction a1 = new TouchAction(_driver);
            a1
              .Press(dayButton)
              .Wait(1000)
              .MoveTo(dayButton, 1000, 2000)
              .Release();
            a1.Perform();


            //_driver.ExecuteScript("scroll(0,400)");



            //IWebDriver webDriver = new AndroidDriver<Iwe>;

            //new TouchAction((IPerformsTouchActions)_driver)
            //   .Press(dayButton)
            //   .Wait(1000)
            //   .MoveTo(302, 1058)
            //   .Release().Perform();

            //TouchActions action = new action(driver);
            //action.MoveToElement(x = 302, 1058);
            //action.Release();
            //action.Perform();

            //var touchActions = new TouchActions(_driver);
            //touchActions
            //    .SingleTap(dayButton)
            //    .Build()
            //    .Perform();




            // (new TouchActions(_driver))
            //action.press({ x: 302, y: 1058})
            //   .moveTo({ x: 300: y: 1341})
            //   .release()
            //  .perform()



        }
    }
}