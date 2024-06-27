using EstudosPooCsharp.Pagamento;
using EstudosPooCsharp.Pagamento.Impl;

namespace EstudosPooCsharp;

public class SelecionarPagamento
{
    public static IPagamento Informar()
    {
        Console.WriteLine("Informe a forma de pagamento (BOLETO | CARTAO | PIX ): ");
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "BOLETO": return new PagamentoBoleto();
            case "CARTAO": return new PagamentoCartaoCredito();
            case "PIX": return new PagamentoPix();
            default: return new PagamentoNaoRealizado();
        }
    }
}
