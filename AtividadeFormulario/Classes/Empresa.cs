using System;

public class Empresa
{
    public string Id { get; set; }
    public string Cnpj { get; set; }
    public string RazaoSocial { get; set; }
    public string NomeFantasia { get; set; }
    public string Situacao { get; set; }
    public string RegimeTrib { get; set; }
    public DateTime DataInicio { get; set; }
    public string Telefone { get; set; }
    public double CapitalSocial { get; set; }
    public string Estado { get; set; }
    public string Cidade { get; set; }
    public string CEP { get; set; }
    public string Numero{ get; set; }
    public string Bairro { get; set; }
    public string Rua { get; set; }
    public string Tipo { get; set; }
    public string PorteEmpresa { get; set; }
    public string NaturezaJuridica { get; set; }
    public string NomeProprietario { get; set; }
    public string CpfDoProprietario { get; set; }

    public Empresa()
    { }
    public Empresa(string Id, string Cnpj, string RazaoSocial, string NomeFantasia, string Situacao, string RegimeTrib, DateTime DataInicio, string Telefone, double CapitalSocial,
     string Estado,string Cidade, string CEP, string Numero, string Bairro, string Rua, string Tipo, string PorteEmpresa, string NaturezaJuridica, string NomeProprietario, string CpfDoProprietario)
    {
        this.Id= Id;
        this.Cnpj = Cnpj;
        this.RazaoSocial = RazaoSocial;
        this.NomeFantasia = NomeFantasia;
        this.Situacao = Situacao;
        this.RegimeTrib = RegimeTrib;
        this.DataInicio = DataInicio;
        this.Telefone = Telefone;
        this.CapitalSocial = CapitalSocial;
        this.Estado = Estado;
        this.Cidade = Cidade;
        this.CEP = CEP;
        this.Numero = Numero;
        this.Bairro = Bairro;
        this.Rua = Rua;
        this.Tipo = Tipo;
        this.PorteEmpresa = PorteEmpresa;
        this.NaturezaJuridica = NaturezaJuridica;
        this.NomeProprietario = NomeProprietario;
        this.CpfDoProprietario = CpfDoProprietario;
    }


}
