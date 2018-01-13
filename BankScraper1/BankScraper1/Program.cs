using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankScraper Bank1 = new BankScraper();
            WebScraper WebScraper1 = new WebScraper();
            Bank1.LogBankScraper();
            Bank1.DB1.StoreData();
        }
    } 
    

    // Authenticate via username/account number & password
    public class Authentication
    {
        public int AccountNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Authentication()
        {

        }

        public Authentication(int accountNumber, string password)
        {
            this.AccountNumber = accountNumber;
            this.Password = password;
        }

        public Authentication(string username, string password)
        {
            this.UserName = username;
            this.Password = password;
        }

        // Login
        public void LogIn(int AccountNumber, string Password)
        {
            Console.WriteLine("Logging in...");
        }
    }

    public class WebScraper
    {
        public static List<string> TempFile { get; set; }

        public string Scrape(string Url)
        {
            var html = "";
            return html;
        }

        public void WriteToFile(List<string> file)
        {
            Console.WriteLine("Writing to file");
        }
    }

    public class DatabaseObj
    {
        public string ConnectionString { get; set; }
        
        public void StoreData()
        {
            var tempfile = WebScraper.TempFile;
            Console.WriteLine("Saving data from the temp file");
        }
    }


    public class BankScraper
    {
        public Authentication Auth1 { get; set; }
        public WebScraper WebScraper1 = new WebScraper();
        public DatabaseObj DB1 = new DatabaseObj();

        public BankScraper()
        {
            Auth1 = new Authentication();
            DB1 = new DatabaseObj();
        }

        public void LogBankScraper()
        {
            Auth1.LogIn(123, "pass");
        }

    }

        
}