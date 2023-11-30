using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public class Validacao
{
    public string cpf { get; set; }

    public Validacao(string cpf)
    {
        this.cpf = cpf;
    }
    public static bool ValidarCpf(string cpf)
    {
        // Remove pontos e hífen
        cpf = cpf.Replace(".", "").Replace("-", "");

        // Verifica se tem 11 dígitos
        if (cpf.Length != 11)
        {
            return false;
        }

        // Verifica o primeiro dígito
        int soma = 0;

        for (int i = 0; i < 9; i++)
        {
            soma += Convert.ToInt32(cpf[i].ToString()) * (10 - i);
        }

        int resto = soma % 11;
        int primeiroDigito = (resto >= 2) ? 11 - resto : 0;

        if (Convert.ToInt32(cpf[9].ToString()) != primeiroDigito)
        {
            return false;
        }

        // Verifica o segundo dígito
        soma = 0;
        for (int i = 0; i < 10; i++)
        {
            soma += Convert.ToInt32(cpf[i].ToString()) * (11 - i);
        }

        resto = soma % 11;
        int segundoDigito = (resto >= 2) ? 11 - resto : 0;

        if (Convert.ToInt32(cpf[10].ToString()) != segundoDigito)
        {
            return false;
        }

        // Se todas as verificações passaram, o CPF é válido
        return true;
    }

    public static bool ValidarEmail(string email)
    {
        string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

        Regex regex = new Regex(pattern);

        return regex.IsMatch(email);
    }
    //verificação do cnpj
    private static bool ValidarCnpj(string cnpj)
    {
        int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

        cnpj = cnpj.Trim().Replace(".", "").Replace("-", "").Replace("/", "");
        if (cnpj.Length != 14)
            return false;

        string tempCnpj = cnpj.Substring(0, 12);
        int soma = 0;

        for (int i = 0; i < 12; i++)
            soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

        int resto = (soma % 11);
        if (resto < 2)
            resto = 0;
        else
            resto = 11 - resto;

        string digito = resto.ToString();
        tempCnpj = tempCnpj + digito;
        soma = 0;
        for (int i = 0; i < 13; i++)
            soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

        resto = (soma % 11);
        if (resto < 2)
            resto = 0;
        else
            resto = 11 - resto;

        digito = digito + resto.ToString();

        return cnpj.EndsWith(digito);
    }

}