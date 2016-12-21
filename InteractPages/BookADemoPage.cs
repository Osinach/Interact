using InteractIntranet.InteractHelper;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractIntranet.InteractPages
{
    public class BookADemoPage : BaseClass
    {
        private IWebElement Name;
        private IWebElement Email;
        private IWebElement CompanyName;
        private IWebElement Phone;
        private IWebElement CompanySize;
        private IWebElement SubmitButton;
        private IWebElement ConfirmationMsg;


        public void WhenIEnterCustomerName()
        {
            Name = GetElementByName("input_1");
            Name.SendKeys("Jude Smith");
        }

        public void AndIEnterEmailAddress()
        {
            Email = GetElementByName("input_2");
            Email.SendKeys("bimatuns@yahoo.com");
        }

        public void AndIEnterCompanyName()
        {
            CompanyName = GetElementByName("input_3");
            CompanyName.SendKeys("SJM");
        }

        public void AndIEnterPhoneNumber()
        {
            Phone = GetElementByName("input_6");
            Phone.SendKeys("01617168000");
        }

        public void AndISelectCompanySize()
        {
            CompanySize = GetElementByName("input_17");
            SelectByValue(CompanySize, "100 - 299 users");
        }

        public void AndIClickOnSubmitButton()
        {
            SubmitButton = GetElementByCssSelector(".gform_button.button");
            SubmitButton.Click();
        }

        public void ThenConfirmatonMessageIsDisplayed()
        {
            ConfirmationMsg = GetElementById("gform_confirmation_message_33");
            Assert.True(ConfirmationMsg.Displayed);
        }
    }
}
