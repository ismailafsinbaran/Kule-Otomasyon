using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace KuleOtomasyon
{
    public class DrobDownMenu
    {
        public void drobdownMenu(IWebDriver driver)   //1.Fonksiyon>2.Parametre
        {


            DrobDownMenu drobDownMenuIslem = new DrobDownMenu();
            IWebElement duzenledrobDownMenuTikla = driver.FindElement(By.CssSelector("#reservationTable > tbody > tr:nth-child(2) > td:nth-child(13) > input"));
            duzenledrobDownMenuTikla.Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//select[@id='AreaId']")).Click();

            var Kat = driver.FindElement(By.XPath("//select[@id='AreaId']"));
            var selectKat = new SelectElement(Kat);


            selectKat.SelectByText("Restoran");


            Console.WriteLine("Adamsın");
            //List<WebElement> selects = driver.findElements(By.xpath("//*[@role='menu']"));
            //Random rand = new Random();
            //for (WebElement select : selects)
            //{
            //    List<WebElement> options = // get every option in itint list = rand.nextInt(options.size());
            //    options.get(list).click();
            //}

            //try
            //{ //Pass the filepath and filename to the StreamWriter Constructor 
            //    StreamWriter sw = new StreamWriter("D:\\TestOtomasyon.txt");
            //    //Write a line of text 
            //    sw.WriteLine("Adamsın 2"); 
            //    //Close the file 
            //    sw.Close();
            //} catch(Exception e)
            //{ Console.WriteLine("Exception: " + e.Message); }
            //finally {
            //    Console.WriteLine("Executing finally block.");
            //}


            }

    }
}

