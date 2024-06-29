using Correios.Interacao.Response;
using Refit;

namespace Correios.Interacao.Refit
{
    public interface IViaCepIntegracaoRefit
    {
        [Get("/ws/{cep}/json")]
        Task<ApiResponse<ViaCepResponse>> ObterDadosViaCep( string cep);
    }
}
