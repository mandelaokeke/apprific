using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class myDBconnection
    {
        public string conStr = @"Data Source=DESKTOP-UUJDJS9;Initial Catalog=atmApp;Integrated Security=True";
        public int AccountNumber()
        {
            Random rand = new Random();
            int accountNumber = rand.Next(000000000, 999999999);
            return accountNumber;
        }
        public int UniqueAccountNumber()
        {
            Random random = new Random();
            int _uniqueNum = random.Next(000000000, 999999999);
            return _uniqueNum;
        }

    }
    
}
