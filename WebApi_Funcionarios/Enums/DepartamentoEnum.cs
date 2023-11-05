using System.Text.Json.Serialization;

namespace WebApi_Funcionarios.Enums
{//inicialmente criado como classe e alterado para enum
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DepartamentoEnum //enum é uma lista de opções
    {
        RH,
        Financeiro,
        Compras,
        Atendimento,
        Zeladoria
    }
}
