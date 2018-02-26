using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.PhantomJS;
using System;
using System.Drawing;
using OpenQA.Selenium.Support.UI;

namespace MercuryHealth.AutomatedTest.Pages
{
    public class BasePage
    {
        protected IWebDriver _driver;

        protected BasePage()
        {

        }

        #region helpers
        protected IWebElement WaitForElement(By by)
        {
            var clock = new SystemClock();
            var totalWaitTimeout = new TimeSpan(0, 0, 10);
            var waitInterval = new TimeSpan(0, 0, 0, 0, 50);
            var wait = new WebDriverWait(clock, _driver, totalWaitTimeout, waitInterval);

            return wait.Until(webdriver => webdriver.FindElement(by));
        }

        protected void WaitForPageLoad()
        {
            var clock = new SystemClock();
            var totalWaitTimeout = new TimeSpan(0, 0, 10);
            var waitInterval = new TimeSpan(0, 0, 0, 0, 50);
            var wait = new WebDriverWait(clock, _driver, totalWaitTimeout, waitInterval);

            wait.Until(webDriver => ((IJavaScriptExecutor)webDriver).ExecuteScript("return document.readyState").Equals("complete"));
        }

        #endregion


        #region Actions
        public void Close()
        {
            _driver.Close();
            _driver.Dispose();
        }

        public HomePage BrowseToHomePage(string homePageUrl)
        {
            // browse to the home page
            _driver.Navigate().GoToUrl(homePageUrl);
            return new HomePage(_driver);
        }

        public NutritionPage ClickNutritionLink()
        {
            try
            {
                var nutritionLink = _driver.FindElement(By.LinkText("Nutrition"));
                nutritionLink.Click();
            }
            catch (Exception e)
            {
                Assert.Fail("Could not find nutrition link: " + e.Message);
            }
            return new NutritionPage(_driver);
        }

        public ExercisePage ClickExercisesLink()
        {
            try
            {
                var nutritionLink = _driver.FindElement(By.LinkText("Exercises"));
                nutritionLink.Click();
            }
            catch (Exception e)
            {
                Assert.Fail("Could not find exercises link: " + e.Message);
            }
            return new ExercisePage(_driver);
        }

        public MyMetricsPage ClickMyMetricsLink()
        {
            try
            {
                var nutritionLink = _driver.FindElement(By.LinkText("My Metrics"));
                nutritionLink.Click();
            }
            catch (Exception e)
            {
                Assert.Fail("Could not find my metrics link: " + e.Message);
            }
            return new MyMetricsPage(_driver);
        }

        #endregion


        #region Launch selenium web driver
        //public static HomePage Launch(string homePageUrl, string browser = "ie")
        public static HomePage Launch(string homePageUrl, string browser, string browserExecutableLocation)
        {
            // based on the browser passed in, created your web driver
            IWebDriver driver;
            if (browser.StartsWith("chrome"))
            {
                var chromeOptions = new ChromeOptions();

                if (browser.EndsWith("headless"))
                {
                    chromeOptions.AddArgument("--headless");
                }

                if(!String.IsNullOrEmpty(browserExecutableLocation))
                {
                    chromeOptions.BinaryLocation = browserExecutableLocation;
                }

                driver = new ChromeDriver(chromeOptions);
            }
            else if (browser.StartsWith("firefox"))
            {
                var firefoxOptions = new FirefoxOptions();

                if (browser.EndsWith("headless"))
                {
                    firefoxOptions.AddArgument("--headless");
                }

                if (!String.IsNullOrEmpty(browserExecutableLocation))
                {
                    firefoxOptions.BrowserExecutableLocation = browserExecutableLocation;
                }
                
                driver = new FirefoxDriver(firefoxOptions);
            }
            else if (browser.StartsWith("edge"))
            {
                var edgeOptions = new EdgeOptions();

                driver = new EdgeDriver(edgeOptions);
            }

            else if (browser.Equals("phantomjs"))
            {
                driver = new PhantomJSDriver();
            }
            else
            {
                var ieOptions = new InternetExplorerOptions();
                ieOptions.IgnoreZoomLevel = true;

                driver = new InternetExplorerDriver(ieOptions);
            }

            // set the window size of the browser and browse to the home page
            driver.Manage().Window.Size = new Size(1920, 1080);
            driver.Navigate().GoToUrl(homePageUrl);
            return new HomePage(driver);
        }
        #endregion

    }
}
