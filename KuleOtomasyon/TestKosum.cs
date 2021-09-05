using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Drawing.Drawing2D;


namespace KuleOtomasyon
{
    public class TestKosum
    {



        public static void Main()


        {


            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait.

            //#region Navigasyon


            //Navigate navigateIslemi = new Navigate();
            //navigateIslemi.navigate(driver);
            //#endregion
            //Thread.Sleep(3000);
            //#region Login

            //Login loginIslemi = new Login();
            //loginIslemi.login(driver);
            //#endregion
            //Thread.Sleep(3000);
            //#region Tarih Alanı
            //DatePicker dateIslemi = new DatePicker();
            //dateIslemi.datepicker(driver);
            //Thread.Sleep(3000);
            //#endregion
            //Thread.Sleep(3000);
            //#region DrobdownMenu-Kat
            //DrobDownMenu drobDownMenu = new DrobDownMenu();
            //drobDownMenu.drobdownMenu(driver);
            //#endregion


            #region Rezervasyon Yapma Testcase


            Navigate.NavigateRezervasyon nR = new Navigate.NavigateRezervasyon();
            nR.navigateR(driver);

            #endregion

            #region Ay ve Gün Seçimi
            
            var rand = new Random();
            var week = rand.Next(2, 5);
            var day = rand.Next(1, 8);

            driver.FindElement(By.Id("calendar-icon")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//button[@id='mc-picker__month--next']")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("/ html[1] / body[1] / div[3] / div[2] / div[2] / table[1] / tbody[1] / tr[" + week + "] / td[" + day + "]")).Click();
            Thread.Sleep(500);
            #endregion

            #region Saat Seçimi

            var row = rand.Next(1, 3);
            var col = rand.Next(1, 3);

            driver.FindElement(By.XPath(" / html[1] / body[1] / div[2] / div[1] / div[1] / div[1] / div[1] / div[1] / div[5] / div["+row+"] / div["+col+"] / label[1]")).Click();
            Thread.Sleep(1000);
            #endregion

            #region Kat Seçimi

            var col1 = rand.Next(1, 3);
            //var col2 = rand.Next(1, 3);

            driver.FindElement(By.XPath("/ html / body / div[2] / div / div[1] / div[1] / div / div / div[8] / div / div["+col1+"] ")).Click();
            Thread.Sleep(500);
            

            #endregion

            #region Kişi Sayısı Seçimi
            var kisi = rand.Next(1, 10);
            //var randomNumbers = Enumerable.Range(0, 4).OrderBy(x => rand.Next()).Take(4).ToList();


            //driver.FindElement(By.CssSelector("#first-step > div:nth-child(20) > div.number-input.col-4 > button.plus")).Click();
            Thread.Sleep(500);
            //driver.FindElement(By.Id("NumberOfPerson")).SendKeys("value", "your value");
            for(int i=1; i<kisi; i++)
            {
                driver.FindElement(By.XPath("//body/div[@id='main-container']/div[@id='index-container']/div[@id='reservation-form']/div[@id='reservation-form-FirstStep']/div[@id='rezervation-form']/div[@id='first-step']/div[7]/div[1]/button[2]")).Click();
            
            }
       
            #endregion

            #region Kişi Adı - Tel No
 
            driver.FindElement(By.Id("NameSurname")).SendKeys("İsmail Afşin Baran");
            Int64 telNo = rand.Next(100000000,999999999);

            driver.FindElement(By.Id("PhoneNumber")).SendKeys(""+telNo+"");
            driver.FindElement(By.Id("PhoneNumber")).SendKeys("1");
            #endregion

            #region Masa Seçimi (Aslıhan'dan alındı.)

            IList<IWebElement> tableList = driver.FindElements(By.ClassName("masa"));

            tableList = tableList.Where(t => int.Parse(t.GetAttribute("minperson")) <= kisi).ToList();

            
            int randomTableIndexValue = rand.Next(0, (tableList.Count()));
            var tableclick = tableList[randomTableIndexValue];
            tableclick.Click();

            #endregion
            Thread.Sleep(500);


            #region Rezervasyon Butonu Click İşlemi
            driver.FindElement(By.XPath("//button[contains(text(),'Rezervasyona Devam Et')]")).Click();

            #endregion

            driver.FindElement(By.Id("card-name")).SendKeys(Parametreler.Ad);
            driver.FindElement(By.Id("card-number")).SendKeys(Parametreler.KrediKart);
            driver.FindElement(By.XPath("//input[@id='tarihsx']")).SendKeys(Parametreler.Ay);
            driver.FindElement(By.XPath("//input[@id='cvv']")).SendKeys(Parametreler.CVV);
            driver.FindElement(By.Id("chkAccept")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//button[contains(text(),'Tamam')]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[@id='confirm']")).Click();

            Thread.Sleep(3000);
            driver.FindElement(By.Id("smsCode")).SendKeys("283126");
            driver.FindElement(By.Id("submitBtn")).Click();
            Thread.Sleep(500);
            IWebElement IWait = IWait.Until(e => e.FindElement(By.Id("proceed-button")));
            driver.FindElement(By.Id("proceed-button")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div[10]/button[1]")).Click();
            //if (Element.displayed)
            //{
            //    System.Console.WriteLine("evet");
            //}
        }
    }

    }
