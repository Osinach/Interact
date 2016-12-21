using InteractIntranet.InteractHelper;
using InteractIntranet.InteractPages;
using System;
using TechTalk.SpecFlow;

namespace InteractIntranet.InteractSteps
{
    [Binding]
    public class InteractBookADemoSteps : BaseClass
    {
        InteractHomePage HomePage = new InteractHomePage();
        BookADemoPage DemoPage = new BookADemoPage();

        [Given(@"I navigate to Interact homepage")]
        public void GivenINavigateToInteractHomepage()
        {
            HomePage = GivenINavigateToInteractHomePage();
        }

        [Given(@"I click on Book A Demo button")]
        public void GivenIClickOnBookADemoButton()
        {
            DemoPage = HomePage.AndIClickOnBookADemoButton();
        }

        [When(@"I enter the contact information")]
        public void WhenIEnterTheContactInformation()
        {
            DemoPage.WhenIEnterCustomerName();
            DemoPage.AndIEnterEmailAddress();
            DemoPage.AndIEnterCompanyName();
            DemoPage.AndIEnterPhoneNumber();
            DemoPage.AndISelectCompanySize();


        }

        [When(@"I click submit button")]
        public void WhenIClickSubmitButton()
        {
            DemoPage.AndIClickOnSubmitButton();
        }

        [Then(@"Online confirmation is displayed")]
        public void ThenOnlineConfirmationIsDisplayed()
        {
            DemoPage.ThenConfirmatonMessageIsDisplayed();
        }
    }
}
