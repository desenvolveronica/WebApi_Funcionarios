namespace WebApi_Funcionarios.Models
{//encapsula o funcionarioModel para um retorno mais amigável para o front
    public class ServiceResponse<T>//<T>Significa que receberá dados genéricos, ou seja, pode receber qualquer tipo de objeto
    {
        public T? Dados { get; set; }
        public string Mensagem { get; set; } = string.Empty;//já começa sendo uma string vazia (Empty)
        public bool Sucesso { get; set; } = true;
    }
}
