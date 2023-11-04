using WebApi_Funcionarios.Models;

namespace WebApi_Funcionarios.Service.FuncionarioService
{//Interface é um contrato ou seja, quem implementar essa interface precisa implementar os seu métodos
    public interface IFuncionarioInterface
    {//uso da Task para podermos implementar métodos assincronos
     //dentro do <> colocamos o que ela vai retornar
        Task<ServiceResponse<List<FuncionarioModel>>> GetFuncionarios();
        Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncionario(FuncionarioModel novoFuncionario);
        Task<ServiceResponse<FuncionarioModel>> GetFuncionarioById(int id);
        Task<ServiceResponse<List<FuncionarioModel>>> UpdateFuncionario(FuncionarioModel editadoFuncionario);
        Task<ServiceResponse<List<FuncionarioModel>>> DeleteFuncionario(int id);
        Task<ServiceResponse<List<FuncionarioModel>>> InativaFuncionario(int id);
    }
}
