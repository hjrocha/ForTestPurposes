using System;

namespace Prime.Services {
    public class OtherService {
         public int AddANumberToSeven(int number)
        {
            return number +7;
        }

        public string GenerateString(int length){
            return new string('x',length);
        }
    }
}