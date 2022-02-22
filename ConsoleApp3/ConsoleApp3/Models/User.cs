using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class User : IAccount
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }



        public string ShowInfo()
        {

            return $"istifade adi: {FullName} \n istifadeci emaili: {Email}";
        }

        
        

        public void PasWordChecker(string _pasword)
        {
            

                bool check = true;
                while (check)
                {
                    bool boyukherf = false;

                    bool kicikherf = false;

                    bool reqem = false;

                    if (_pasword.Length >= 8)
                    {
                        foreach (char item in _pasword)
                        {
                            if (char.IsDigit(item))
                            {
                                reqem = true;
                            }
                            else if (char.IsLower(item))
                            {
                                kicikherf = true;


                            }
                            else if (char.IsUpper(item))
                            {
                                boyukherf = true;

                            }
                            if (boyukherf && kicikherf && reqem)
                            {

                                check = false;
                                break;


                            }
                        }
                    }

                    if (!boyukherf || !kicikherf || !reqem)
                    {
                        Console.WriteLine("qoydugunuz shifre parol standartlarimizi qarshilamir.parolunuzu yeniden daxil edin");
                        _pasword = Console.ReadLine();

                    }
                }


            
        }
    }
}
