﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace FinalTaskBBC.Pages
{
    public static class Driver
    {
        private static IWebDriver _driver;

        public static IWebDriver Instance
        {
            get
            {
                if (_driver == null)
                {
                    Start();
                }
                return _driver;
            }
            set { _driver = value; }
        }
        public static void Close() => Instance.Close();
        public static void Quit() => Instance.Quit();
        public static void Navigate(string url) => Instance.Url = url;
        public static void MaximizeWindow() => Instance.Manage().Window.Maximize();
        public static void Start() => Instance = new ChromeDriver();
    }
}
