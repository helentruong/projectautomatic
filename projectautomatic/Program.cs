using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class projectautomatiation
{
	static void Main()
	{
		// Selecting Chrome are the browser
		IWebDriver driver = new ChromeDriver();

		//Opens website on Chrome
		driver.Navigate().GoToUrl("http://opensource.demo.orangehrmlive.com/");

		//Enters john.smith in the username text box
		IWebDriver username = driver.FindElement(By.Name("textUsername"));
		username.SendKeys("john.smith");

		//Enters john.smith in the password text box
		IWebElement password = driver.FindElement(By.Name("txtPassword"));
		password.SendKeys("john.smith");

		//Clicks the login button
		driver.FindElement(By.Id("btnLogin")).Click();

		//Clicks the My Info tab
		driver.FindElement(By.CssSelector("#menu_pim_viewMyDetails > b")).Click();

		//Clicks the Add tab
		driver.FindElement(By.CssSelector(#btnAddContact)).Click();

		//Enters Helen as Emergency Contact
		IWebElement username = driver.FindElement(By.Name("txtName"));
		username.SendKeys("Helen");

		//Clicks Save button
		driver.FindElement(By.CssSelector("#btnSaveEContact")).Click();

		        Thread.Sleep(3000);
        
        driver.Quit();
    }
}
