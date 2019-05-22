using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;
        private readonly OtherService _otherService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
            _otherService = new OtherService();
        }

        [Fact]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }

        [Fact]
        public void Test01(){
            int n = _otherService.AddANumberToSeven(5);
            Assert.Equal(n,5+7);
        }


         [Fact]
        public void Test02(){
            string test = _otherService.GenerateString(10);
            Assert.Equal(test.Length,10);
        }
    }
}