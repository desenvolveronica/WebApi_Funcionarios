namespace WebApi_Funcionarios.Models
{
    public class ServiceResponse<T>//<T>Significa que receberá dados genéricos, ou seja, pode receber qualquer tipo de objeto
    {
        public T? Dados { get; set; }
        public string Mensagem { get; set; } = string.Empty;//já começa sendo uma string vazia (Empty)
        public bool Sucesso { get; set; } = true;
    }
}
