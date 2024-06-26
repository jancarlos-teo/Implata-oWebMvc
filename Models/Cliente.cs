namespace LHPet.Models;

public class Cliente
{ // inicio
    /* No trecho de código a seguir são criados os atributos de 
    clientes e seus getters e setters correpondentes*/
    /* dica digite o comando  prop + enter. para criar as propriedades */
    public int Id { get; set; }
    public string Nome {get ; set ;}
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Paciente { get; set; }

    

    /* Nesse trecho do código, é criado o Construtor do
    model Cliente e determinado quais parâmetros são
    necessários na criação das instâncias. */

/* dica para iniciar o construtor digite o comando  ctor + enter.*/
    public Cliente(int id, string nome, string Cpf, string email, string paciente)
    {
        this.Id = id;
        this.Nome= nome;
        this.Cpf = Cpf;
        this.Email = email;
        this.Paciente = paciente;
    }
}//fim

