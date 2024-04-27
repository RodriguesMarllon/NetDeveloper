using Calculadora.Services;

namespace calculadoraTEstes;

public class CalculadoraTestes
{

    private CalculadoraImp _calc;

    public  CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }  

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //
    }
}