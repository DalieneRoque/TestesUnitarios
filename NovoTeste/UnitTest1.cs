using Novo;

namespace NovoTeste
{
    public class UnitTest1
    {

        public Calculadora construirClasse()
        {
            string data = "02/07/1998";
            Calculadora calculadora = new Calculadora();
            return calculadora;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]

        public void TesteSomar(int n1, int n2, int resultado)
        {
            Calculadora calculadora = construirClasse();

            int resultadoCalculadora = calculadora.somar(n1, n2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(4, 1, 3)]
        public void TesteSubtrair(int n1, int n2, int resultado)
        {
            Calculadora calculadora = construirClasse();

            int resultadoCalculadora = calculadora.subtrair(n1, n2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(2, 1, 2)]
        public void TesteMultiplicar(int n1, int n2, int resultado)
        {
            Calculadora calculadora = construirClasse();

            int resultadoCalculadora = calculadora.multiplicar(n1, n2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        public void TesteDividir(int n1, int n2, int resultado)
        {
            Calculadora calculadora = construirClasse();

            int resultadoCalculadora = calculadora.dividir(n1, n2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calculadora = construirClasse();

            Assert.Throws<DivideByZeroException>(() => calculadora.dividir(3, 0));

        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calculadora = construirClasse();

            calculadora.somar(1, 2);
            calculadora.somar(2, 8);
            calculadora.somar(3, 7);
            calculadora.somar(4, 1);

            var lista = calculadora.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);

        }
    }
}