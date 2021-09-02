using OpenQA.Selenium;


namespace KuleOtomasyon
{
    public class Login
    {
        public void login(IWebDriver driver)
        {

            Login loginIslem = new Login();
            IWebElement Username = driver.FindElement(By.XPath("//input[@id='txtkull']"));
            IWebElement Sifre = driver.FindElement(By.XPath("//input[@id='txtparola']"));
            IWebElement Bas = driver.FindElement(By.XPath("//input[@id='btngirs']"));

            Username.SendKeys(Parametreler.UserName);
            Sifre.SendKeys(Parametreler.Pass);
            Bas.Click();


            //RezervasyonIslemleriTestCase r = new RezervasyonIslemleriTestCase();
            //r.login("İsmail", "senem");

        }

        }
}
