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


        #region Defination
        private AndroidDriver<AndroidElement>? _driver;
        #endregion

        #region Initialize
        internal void Initialize()
        {
            var cap = new AppiumOptions();
            cap.AddAdditionalCapability("appPackage", "com.foreks.android.epias");
            cap.AddAdditionalCapability("appActivity", "com.foreks.android.epias.view.splash.SplashActivity");
            cap.AddAdditionalCapability("noReset", "true");

            _driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);
        }
        #endregion

        #region Exit
        internal void Exit()
        {
            Thread.Sleep(3000);
            _driver?.Quit();
            _driver?.Dispose();
        }

        #endregion

        #region Case
        [Fact]
        public void PtfSendMail()
        {
            Initialize();

            Thread.Sleep(10000);


            AndroidElement mcpButton = _driver.FindElementById("com.foreks.android.epias:id/fragmentPtfSmf_imageView_redirect");
            mcpButton.Click();

            Thread.Sleep(7000);

            AndroidElement calendarButton = _driver.FindElementById("com.foreks.android.epias:id/layoutEpiasTopSelectionView_imageViewDate");
            calendarButton.Click();

            Thread.Sleep(5000);


            AndroidElement dayButton = _driver.FindElementById("com.foreks.android.epias:id/wheel_date_picker_day");

            TouchAction dayscroll = new TouchAction(_driver);
            dayscroll
              .Press(dayButton)
              .Wait(1000)
              .MoveTo(dayButton, 300, 1300)
              .Release();
            dayscroll.Perform();

            TouchAction dayscroll1 = new TouchAction(_driver);
            dayscroll1
              .Press(dayButton)
              .Wait(1000)
              .MoveTo(dayButton, 300, -250)
              .Release();
            dayscroll1.Perform();

            AndroidElement MonthButton = _driver.FindElementById("com.foreks.android.epias:id/wheel_date_picker_month");


            TouchAction Monthscroll = new TouchAction(_driver);
            Monthscroll
              .Press(MonthButton)
              .Wait(1000)
              .MoveTo(300, -200)
              .Release();
            Monthscroll.Perform();

            AndroidElement YearButton = _driver.FindElementById("com.foreks.android.epias:id/wheel_date_picker_year");


            TouchAction Yearscroll = new TouchAction(_driver);
            Yearscroll
              .Press(YearButton)
              .Wait(1000)
              .MoveTo(300, 150)
              .Release();
            Yearscroll.Perform();

            AndroidElement calendarOkButton = _driver.FindElementById("com.foreks.android.epias:id/layoutFilterDateTime_textView_ok");
            calendarOkButton.Click();

            Thread.Sleep(2000);

            AndroidElement MainScreenUcNoktaButton = _driver.FindElementById("com.foreks.android.epias:id/activityMain_imageView_handle");
            MainScreenUcNoktaButton.Click();

            Thread.Sleep(2000);

            AndroidElement PTFpaylasButton = _driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / androidx.drawerlayout.widget.DrawerLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.view.ViewGroup / android.widget.LinearLayout / android.widget.FrameLayout[3] / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.HorizontalScrollView / android.widget.LinearLayout / androidx.recyclerview.widget.RecyclerView / android.widget.LinearLayout[6] / android.widget.TextView[2]");
            PTFpaylasButton.Click();

            Thread.Sleep(2000);

            AndroidElement GmailIconButton = _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout[2]/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.view.ViewGroup/android.widget.GridView/android.widget.LinearLayout[2]/android.widget.FrameLayout/android.widget.ImageView");
            GmailIconButton.Click();

            Thread.Sleep(2000);

            AndroidElement GmailToTextboxt = _driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.RelativeLayout / android.widget.ScrollView / android.widget.LinearLayout / android.widget.LinearLayout / android.widget.RelativeLayout[1] / android.widget.RelativeLayout / android.widget.RelativeLayout / android.view.ViewGroup / android.widget.EditText");
            GmailToTextboxt.SendKeys("aseydaaksakal@gmail.com");
            Thread.Sleep(2000);
            _driver.LongPressKeyCode(AndroidKeyCode.Enter);

            AndroidElement SubjectTextBox = _driver.FindElementById("com.google.android.gm:id/subject");
            SubjectTextBox.SendKeys("05.04.2020 ait PTF Ortalaması");


            AndroidElement SendButton = _driver.FindElementById("com.google.android.gm:id/send");
            SendButton.Click();

            Thread.Sleep(2000);


            Exit();
            #endregion



        }
    }
}