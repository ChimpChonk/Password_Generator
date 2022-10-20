using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordLogic
{
    public class AppLogic
    {
        private Random randomPassword;

        private string _password = "";
        private string letters = "abcdefghijklmnopqrstuvwxyz";
        private string numbers = "0123456789";
        private string symbols = "!@£$%^&*()_+=-#';/.,";

        public string NewPassword(bool capitalLetter, bool smallLetter, bool numbers, bool symbols, int passwordlength)
        {
            //checkbox slected or not
            if (capitalLetter == false && smallLetter == false && numbers == false && symbols == false)
            {
                return "Select one of the options";

            }

            else
            {
                return Password(CombinedPassword(capitalLetter, smallLetter, numbers, symbols, passwordlength));

            }
        }

        private string CombinedPassword(bool capital, bool small, bool number, bool symbol, int passwordLength)
        {
            randomPassword = new Random();

            for (int i = 0; i < passwordLength; i++)
            {


                if (capital == true)
                {
                    letters = letters.ToUpper();
                    _password += letters[randomPassword.Next(0, letters.Length)];

                    if (_password.Length == passwordLength) break;
                }

                if (small == true)
                {
                    letters = letters.ToLower();
                    _password += letters[randomPassword.Next(0, letters.Length)];

                    if (_password.Length == passwordLength) break;
                }

                if (number == true)
                {
                    _password += numbers[randomPassword.Next(0, this.numbers.Length)];
                    if (_password.Length == passwordLength) break;
                }

                if (symbol == true)
                {
                    _password += symbols[randomPassword.Next(0, this.symbols.Length)];
                    if (_password.Length == passwordLength) break;
                }


            }
            return _password;


        }

        private string Password(string word)
        {
            randomPassword.Next();


            char[] chr = word.ToCharArray();

            for (int i = 0; i < chr.Length; i++)
            {
                int j = randomPassword.Next(chr.Length);

                char temp = chr[i];
                chr[i] = chr[j];
                chr[j] = temp;
            }

            return new string(chr);
        }
    }
}
