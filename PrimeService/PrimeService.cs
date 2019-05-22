
using System;

namespace Prime.Services {
    public class PrimeService {
        public bool IsPrime(int candidate)
        {
            if (candidate == 1)
            {
                return false;
            }
            throw new NotImplementedException("Please create a test first");
        }

        public bool IsEven(int candidate)
        {
            return candidate % 2 == 0;
        }
    }

}