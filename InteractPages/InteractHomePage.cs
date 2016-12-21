using InteractIntranet.InteractHelper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractIntranet.InteractPages
{
    public class InteractHomePage : BaseClass
    {

        private IWebElement DemoButton;



        public BookADemoPage AndIClickOnBookADemoButton()
        {
            DemoButton = GetElementByCssSelector(".try [href='/resources/book-a-demo/']");
            DemoButton.Click();
            return new BookADemoPage();
        }
    }
}
