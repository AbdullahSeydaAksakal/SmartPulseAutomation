using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using SmartPulseMobileAutomationBdd.Drivers;
using System;
using TechTalk.SpecFlow;

namespace SmartPulseMobileAutomationBdd.StepDefinitions
{
    

  [Binding]
    public class SendMailStepDefinitions
    {
        #region Defination
        //public AndroidDriver<AndroidElement> driver = andr
        public AndroidDriver<AndroidElement>? Driver { get; set; }
        #endregion

        [Given(@"Epias uygulamasini ac")]
        public void GivenEpiasUygulamasiniAc()
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            AndroidElement mcpButton = Driver.FindElementById("com.foreks.android.epias:id/fragmentPtfSmf_imageView_redirect");
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            mcpButton.Click();

            Thread.Sleep(7000);

            throw new PendingStepException();
        }

        [Given(@"Yukarıdaki PTF/SMF simgesinin sagindaki ok dugmesine tıkla")]
        public void GivenYukarıdakiPTFSMFSimgesininSagindakiOkDugmesineTıkla()
        {
            throw new PendingStepException();
        }

        [Given(@"Epias logosunun altındaki Takvim butonuna bas")]
        public void GivenEpiasLogosununAltındakiTakvimButonunaBas()
        {
            throw new PendingStepException();
        }

        [Given(@"Takvim ekranında takvimi '([^']*)' olacak sekilde ayarla")]
        public void GivenTakvimEkranındaTakvimiOlacakSekildeAyarla(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"Tamam Düğmesine Tıkla")]
        public void GivenTamamDuğmesineTıkla()
        {
            throw new PendingStepException();
        }

        [Given(@"Ekranin ortasindaki dugmeye bas")]
        public void GivenEkraninOrtasindakiDugmeyeBas()
        {
            throw new PendingStepException();
        }

        [Given(@"PTF paylasim dugmesine bas\.")]
        public void GivenPTFPaylasimDugmesineBas_()
        {
            throw new PendingStepException();
        }

        [Given(@"Gmaili Sec")]
        public void GivenGmailiSec()
        {
            throw new PendingStepException();
        }

        [Given(@"Gonderen kismina '([^']*)' yaz")]
        public void GivenGonderenKisminaYaz(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"Gonder dugmesine bas")]
        public void WhenGonderDugmesineBas()
        {
            throw new PendingStepException();
        }

        [Then(@"Mailin basarili bir sekilde gönderildigini ve Ana Sayfaya dustugunu gor")]
        public void ThenMailinBasariliBirSekildeGonderildiginiVeAnaSayfayaDustugunuGor()
        {
            throw new PendingStepException();
        }
    }
}
