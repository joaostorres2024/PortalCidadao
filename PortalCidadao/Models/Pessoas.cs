public enum Sexo { Masculino, Feminino, NaoInformado }
public enum EstadoCivil { Solteiro, Casado, Divorciado, Viuvo, UniaoEstavel }
public enum SituacaoEleitoral { Regular, Suspensa, Cancelada }
public class Pessoa
{
    // Chave primária
    public int Id { get; set; }
    // Dados Pessoais
    public string Nome { get; set; }
    public string? NomeSocial { get; set; }
    public string CPF { get; set; }
    public string? RG { get; set; }
    public string? OrgaoExpedidor { get; set; }
    public string? UF_RG { get; set; }
    public DateTime DataNascimento { get; set; }
    public Sexo Sexo { get; set; }
    public string Nacionalidade { get; set; } = "Brasileiro";
    public string? NaturalidadeCidade { get; set; }
    public string? NaturalidadeUF { get; set; }
    public string NomeMae { get; set; }
    public string? NomePai { get; set; }
    public EstadoCivil EstadoCivil { get; set; }
    // Contato
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public string? Celular { get; set; }
    // Endereço
    public string? CEP { get; set; }
    public string? Logradouro { get; set; }
    public string? Numero { get; set; }
    public string? Complemento { get; set; }
    public string? Bairro { get; set; }
    public string? Cidade { get; set; }
    public string? UF { get; set; }
    // Dados Eleitorais
    public string? TituloEleitor { get; set; }
    public string? ZonaEleitoral { get; set; }
    public string? SecaoEleitoral { get; set; }
    public string? MunicipioEleitoral { get; set; }
    public string? UF_Eleitoral { get; set; }
    public SituacaoEleitoral SituacaoEleitoral { get; set; } = SituacaoEleitoral.Regular;
    public DateTime? DataCadastroEleitoral { get; set; }
    // Controle
    public DateTime DataCadastro { get; set; } = DateTime.Now;
    public DateTime? DataAtualizacao { get; set; }
    public bool Ativo { get; set; } = true;
}