using NSE.Pagamentos.API.Models;

namespace NSE.Pagamentos.API.Facade
{
    public interface IPagamentoFacade
    {
        Task<Transacao> AutorizarPagamento(Pagamento pagamento);
        Task<Transacao> CancelarAutorizacao(Transacao transacao);
        Task<Transacao> CapturarPagamento(Transacao transacao);

    }
}
