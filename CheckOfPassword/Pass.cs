using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOfPassword
{
    public class Pass
    {
        public int passwd(string password)
        {
            int Point = 0;
            if (password.Length > 10)
            {
                Point++;
            }
            foreach (char c in password) {
                if (char.IsDigit(c))
                {
                    Point++;
                    break;
                }
            }
            foreach (char c in password)
            {
                if (char.IsLower(c))
                {
                    Point++;
                    break;
                }
            }
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    Point++;
                    break;
                }
            }
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    Point++;
                    break;
                }
            }
            return Point;
        }
    }
}
