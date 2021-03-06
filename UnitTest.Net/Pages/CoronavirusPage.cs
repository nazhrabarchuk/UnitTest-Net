﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using FinalTaskBBC.pages;

namespace FinalTaskBBC.Pages
{
    public class CoronavirusPage : BasePage
    {
        public CoronavirusPage(IWebDriver driver) : base(driver) { }

        [FindsBy(How = How.XPath, Using = "//nav[@role='navigation' and @class='nw-c-nav__wide']//span[contains(text(),'Coronavirus')]/parent::a")]
        public IWebElement CoronovirusButton { get; private set; }

        [FindsBy(How = How.XPath, Using = "//nav[@role='navigation' and @class='nw-c-nav__wide-secondary']//span[contains(text(),'Your Coronavirus Stories')]/parent::a")]
        private IWebElement YouCoronovirusStoriesButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'How to share with BBC News')]/parent::a")]
        private IWebElement HowToShareBBCNewsButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='hearken-embed cleanslate']//textarea")]
        private IWebElement UserStoryTexarea { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='hearken-embed cleanslate']//input[@aria-label='Name']")]
        private IWebElement UserNameInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='hearken-embed cleanslate']//input[@aria-label='Email address']")]
        private IWebElement UserEmailInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='hearken-embed cleanslate']//input[@aria-label='Contact number ']")]
        private IWebElement UserNumberInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='hearken-embed cleanslate']//input[@aria-label='Location ']")]
        private IWebElement UserLocationInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='hearken-embed cleanslate']//p[contains(text(),'I am over 16 years old')]/parent::div/parent::span/parent::label/input[@type='checkbox']")]
        private IWebElement UserAdultCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='hearken-embed cleanslate']//p[contains(text(),'I accept the ')]/parent::div/parent::span/parent::label/input[@type='checkbox']")]
        private IWebElement UserConfirmServiceCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='hearken-embed cleanslate']//button[contains(text(),Submit)]")]
        private IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='input-error-message']")]
        private IWebElement ErrorMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='social-buttons-container']")]
        private IWebElement ConfirmNotification { get; set; }

        public void ClickCoronovirusButton()
        {
             CoronovirusButton.Click();
        }

        public void ClickYouCoronovirusStoriesButton()
        {
            YouCoronovirusStoriesButton.Click();
        }

        public void ClickHowToShareBBCNewsButton()
        {
             HowToShareBBCNewsButton.Click();
        }

        public void LogInKeys(
            string userStory,
            string userName,
            string userEmail,
            string userNumber,
            string userLocation
        ){
            UserStoryTexarea.SendKeys(userStory);
            UserNameInput.SendKeys(userName);
            UserEmailInput.SendKeys(userEmail);
            UserNumberInput.SendKeys(userNumber);
            UserLocationInput.SendKeys(userLocation);
        }

        public void LogInCheckboxCheck()
        {
            UserAdultCheckbox.Click();
            UserConfirmServiceCheckbox.Click();
        }

        public void ClickSubmit() => SubmitButton.Submit();      
        public bool IsErrorMessageExist() => ErrorMessage.Displayed;
        public bool IsConfirmNotificationExist() => ConfirmNotification.Displayed;
    }
}
