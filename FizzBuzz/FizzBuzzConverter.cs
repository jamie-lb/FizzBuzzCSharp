using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzConverter
    {
        public String ConvertNumber(Int32 numberToConvert)
        {
            Boolean fizzWord = IsFizzWord(numberToConvert);
            Boolean buzzWord = IsBuzzWord(numberToConvert);
            Boolean fizzBuzzWord = fizzWord && buzzWord;
            return fizzBuzzWord
                ? "FizzBuzz"
                : fizzWord
                    ? "Fizz"
                    : buzzWord
                        ? "Buzz"
                        : numberToConvert.ToString("D");
        }

        private Boolean IsBuzzWord(Int32 numberToConvert)
        {
            return HasSearchValue(numberToConvert, 5);
        }

        private Boolean IsFizzWord(Int32 numberToConvert)
        {
            return HasSearchValue(numberToConvert, 3);
        }

        private Boolean HasSearchValue(Int32 numberToSearch, Int32 searchValue)
        {
            String input = numberToSearch.ToString("D");
            return numberToSearch % searchValue == 0 || input.Contains(searchValue.ToString("D"));
        }
    }
}
