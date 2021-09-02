using OpenQA.Selenium;


namespace KuleOtomasyon
{
    public class DatePicker
    {
        public void datepicker(IWebDriver driver)
        {

            DatePicker datepickerIslem = new DatePicker();
            IWebElement DatePickerTikla = driver.FindElement(By.XPath("//input[@id='filterDate']"));
            DatePickerTikla.Click();
            driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div[1]/table/tbody/tr[5]/td[6]")).Click();
            driver.FindElement(By.XPath("/ html / body//div[@class='drp-buttons']/button[2]")).Click();





        }

    }
}
