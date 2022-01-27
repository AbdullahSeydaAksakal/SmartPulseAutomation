using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPulseMobileAutomationBdd.Drivers
{

    [Binding]
    public class Core
    {
        

        [BeforeScenario]

        #region Initialize
        public AndroidDriver<AppiumWebElement> Initialize()
        {
            var cap = new AppiumOptions();
            cap.AddAdditionalCapability("appPackage", "com.foreks.android.epias");
            cap.AddAdditionalCapability("appActivity", "com.foreks.android.epias.view.splash.SplashActivity");
            cap.AddAdditionalCapability("noReset", "true");


            var AppiumService = new AppiumServiceBuilder().WithIPAddress("127.0.0.1").UsingAnyFreePort().Build();

            AppiumService.Start();

            return new AndroidDriver<AppiumWebElement>(AppiumService, cap);

        }
        #endregion

        #region Defination
        public AndroidDriver<AndroidElement>? _driver { get; set; }
        #endregion

      

        #region Exit
        internal void Exit()
        {
            Thread.Sleep(3000);
            _driver?.Quit();
            _driver?.Dispose();
        }
        #endregion
    }
}
