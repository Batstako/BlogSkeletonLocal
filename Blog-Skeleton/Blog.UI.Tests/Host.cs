using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using TestStack.Seleno;
using TestStack.Seleno.Configuration;

namespace Blog.UI.Tests
{
    public static class BrowserHost
    {
        public static readonly SelenoHost Instance = new SelenoHost();
        public static readonly string RootUrl = "http://localhost:60634/Article/List";

        static BrowserHost()
        {
            //Instance.Run("Blog", 60634); // това пуска само срещу Firefox - не е възможно да работи на един и същи порт като IIS DataBase за това се променя на 60639-примерно, на локално не е проблем но под TeamCity гърми
            //Instance.Run("Blog", 60634, w => w.WithRemoteWebDriver(() => new ChromeDriver())); // Това пуска на Chrome
            Instance.Run("Blog", 60639, w => w.WithRemoteWebDriver(() => new ChromeDriver())); // това пуска когато е през TeamCity - променя се порта

        }
    }
}
