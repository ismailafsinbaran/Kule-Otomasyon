using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace KuleOtomasyon
{
    public class Navigate
    {
        #region Navigasyon
        public void navigate(IWebDriver driver)

        

        {
            Navigate navigateIslem = new Navigate();
            driver.Navigate().GoToUrl(Parametreler.BaseURL);

        }
        #endregion

        //Rezervasyon Testcase
        #region NavigasyonRezervasyon 
        public class NavigateRezervasyon
        
        {
            public void navigateR (IWebDriver driver)


            {
                NavigateRezervasyon nr = new NavigateRezervasyon();
                driver.Navigate().GoToUrl(Parametreler.RezervasyonURL);

            }
            #endregion
        }
        
    }
}
