using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        int a = 0;
        int b = 0;
        int c;
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (c == 0)
            {
                //a = (Convert.ToInt32(textBox3.Text)) * 60;
                int rndmin = Convert.ToInt16(textMin.Text);
                int rndmax = Convert.ToInt16(textMax.Text);
                a = rnd.Next(rndmin, rndmax);
                b = 0;
                yagma();
            }
            c = a - b;
            label3.Text = c.ToString();
            b++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        public void yagma()
        {
            //new DriverManager().SetUpDriver(new EdgeConfig());
            new DriverManager().SetUpDriver(new ChromeConfig());

            //var service = EdgeDriverService.CreateDefaultService();
            var service = ChromeDriverService.CreateDefaultService();

            service.HideCommandPromptWindow = true;

            //var driver = new EdgeDriver(service);
            var driver = new ChromeDriver(service);


            driver.Navigate().GoToUrl("https://ts31.x3.europe.travian.com/dorf1.php");
            Thread.Sleep(1000);

            var asd = driver.FindElements(By.XPath("/html/body/div[1]/div[1]/div[2]/span[1]/a/span"));
            foreach (var x in asd)
            {
                if (x != null)
                {
                    x.Click();
                }
            }
            Thread.Sleep(1000);
            IWebElement id = driver.FindElement(By.XPath("//*[@id='loginForm']/tbody/tr[1]/td[2]/input"));
            IWebElement pw = driver.FindElement(By.XPath("//*[@id='loginForm']/tbody/tr[2]/td[2]/input"));
            IWebElement login = driver.FindElement(By.XPath("//button[@type='submit']"));

            id.SendKeys(textBox1.Text);
            Thread.Sleep(1000);
            pw.SendKeys(textBox2.Text);
            Thread.Sleep(1000);
            login.Click();
            Thread.Sleep(1000);

            driver.Navigate().GoToUrl("https://ts31.x3.europe.travian.com/build.php?id=39&gid=16&tt=99");
            Thread.Sleep(1000);

            var yagmalist = driver.FindElements(By.XPath("//button[@value='Baþlangýç']"));

            foreach (var el in yagmalist)
            {
                el.Click();
                Thread.Sleep(1500);
            }
            driver.Close();
        }

        public void Kisla()
        {
            IWebDriver driver = new EdgeDriver(@"C:\Users\Pc\source\repos\WinFormsApp1\WinFormsApp1\edgedriver");

            driver.Navigate().GoToUrl("https://ts31.x3.international.travian.com/login.php");

            Thread.Sleep(1000);

            IWebElement id = driver.FindElement(By.Name("name"));
            IWebElement pw = driver.FindElement(By.Name("password"));
            IWebElement login = driver.FindElement(By.XPath("//button[@value='Login']"));

            id.SendKeys(textBox1.Text);
            Thread.Sleep(1000);
            pw.SendKeys(textBox2.Text);
            Thread.Sleep(1000);
            login.Click();

            Thread.Sleep(1000);


            driver.Navigate().GoToUrl("https://ts31.x3.international.travian.com/build.php?id=22&gid=19");


            Thread.Sleep(1000);

            if (textBox4.Text != null)
            {
                IWebElement text1 = driver.FindElement(By.XPath("//input[@name='t1']"));
                text1.Clear();
                text1.SendKeys(textBox4.Text);
            }
            if (textBox5.Text != "")
            {
                IWebElement text2 = driver.FindElement(By.XPath("//input[@name='t2']"));
                text2.Clear();
                text2.SendKeys(textBox5.Text);
            }
            if (textBox6.Text != "")
            {
                IWebElement text3 = driver.FindElement(By.XPath("//input[@name='t3']"));
                text3.Clear();
                text3.SendKeys(textBox6.Text);
            }
            if (textBox7.Text != "")
            {
                IWebElement text4 = driver.FindElement(By.XPath("//input[@name='t4']"));
                text4.Clear();
                text4.SendKeys(textBox7.Text);
            }


            IWebElement btn = driver.FindElement(By.XPath("//button[@name='s1']"));

            btn.Click();

            driver.Close();
        }

        public void Ahir()
        {
            IWebDriver driver = new EdgeDriver(@"C:\Users\Pc\source\repos\WinFormsApp1\WinFormsApp1\edgedriver");

            driver.Navigate().GoToUrl("https://ts31.x3.international.travian.com/login.php");

            Thread.Sleep(1000);

            IWebElement id = driver.FindElement(By.Name("name"));
            IWebElement pw = driver.FindElement(By.Name("password")); ;
            IWebElement login = driver.FindElement(By.XPath("//button[@value='Login']"));

            id.SendKeys(textBox1.Text);
            Thread.Sleep(1000);
            pw.SendKeys(textBox2.Text);
            Thread.Sleep(1000);
            login.Click();

            Thread.Sleep(1000);


            driver.Navigate().GoToUrl("https://ts31.x3.international.travian.com/dorf2.php");

            Thread.Sleep(1000);

            IWebElement AhirB = driver.FindElement(By.XPath("//div[@data-name='Barracks"));
            AhirB.Click();

            Thread.Sleep(1000);

            IWebElement text5 = driver.FindElement(By.XPath("//input[@name='t5"));
            IWebElement text6 = driver.FindElement(By.XPath("//input[@name='t6"));
            IWebElement text7 = driver.FindElement(By.XPath("//input[@name='t7"));
            IWebElement text8 = driver.FindElement(By.XPath("//input[@name='t8"));
            IWebElement btn = driver.FindElement(By.XPath("//button[@name='s1"));

            if (textBox8.Text != null)
            {
                text5.Clear();
                text5.SendKeys(textBox4.Text);
            }
            if (textBox9.Text != null)
            {
                text6.Clear();
                text6.SendKeys(textBox5.Text);
            }
            if (textBox10.Text != null)
            {
                text7.Clear();
                text7.SendKeys(textBox6.Text);
            }
            if (textBox11.Text != null)
            {
                text8.Clear();
                text8.SendKeys(textBox7.Text);
            }


            btn.Click();

            driver.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (c == 0)
            {
                a = (Convert.ToInt32(textBox12.Text)) * 60;
                b = 0;
                Kisla();
            }

            c = a - b;
            label6.Text = c.ToString();
            b++;

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (c == 0)
            {
                a = (Convert.ToInt32(textBox13.Text)) * 60;
                b = 0;
                Ahir();
            }

            c = a - b;
            label7.Text = c.ToString();
            b++;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            timer2.Enabled = true;

            Thread.Sleep(2000);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;

            Thread.Sleep(2000);
        }
    }
}