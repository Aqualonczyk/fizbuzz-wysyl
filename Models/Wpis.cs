using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fizbuzz_wysyl.Models
{
    public class Wpis
    {
        [Display(Name = "Podaj liczbe:")]
        [Range(1,1000), Required(ErrorMessage = "Podaj liczbe z zakresu 1 - 1000")]



        public int Number { get; set; }
        public string Wynik { get; set; }
        public DateTime data { get; set; }

        public void Fizz()
        {
            Wynik = "";
            if (Number % 3 == 0)
                Wynik += "Fizz";
            if (Number % 5 == 0)
                Wynik += "Buzz";
            if (Wynik == "")
                Wynik += "Liczba: " + Number + " złe dane";
            data = DateTime.Now;
        }


    }
}
