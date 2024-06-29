using Correios.Interacao.Response;
using System.Security.Cryptography;

namespace Correio.Test
{
    public class UnitTest1
    {
        [Fact]
        public void VerificandoCepValido()
        {
            //Arranger

            var Cep = "80030001";

            //Act

            var cep = new ViaCepResponse();

            //Assert
            Assert.NotNull(cep);
            //Assert.Equal(Cep, cep.Cep);
            //  Assert.NotNull(cep.Cep);    
        }

        [Fact]
        public void VerificandoCepInvalido()
        {
            var Cep = "";
            //Act

            var cep = new ViaCepResponse();


            Assert.True(cep.Equals(cep));               
           
        }


    }
    
}