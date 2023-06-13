using System;

class Pessoa
{
    private string nome;
    private string cpf;
    private int idade;
    private string sexo;
    private double peso;
    private double altura;

    public Pessoa(string nome, string cpf, int idade, string sexo, double peso, double altura)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.idade = idade;
        this.sexo = sexo;
        this.peso = peso;
        this.altura = altura;
    }
    public string getNome()
    {
        return this.nome;
    }
    public void SetNome(string nome)
    {
        this.nome = nome;
    }
    public string getCpf()
    {
        return this.cpf;
    }
    public void SetCpf(string cpf)
    {
        this.cpf = cpf;
    }
    public int getIdade()
    {
        return this.idade;
    }
    public void SetIdade(int idade)
    {
        this.idade = idade;
    }
    public string getSexo()
    {
        return this.sexo;
    }
    public void SetSexo(string sexo)
    {
        this.sexo = sexo;
    }
    public double getPeso()
    {
        return this.peso;
    }
    public void SetPeso(double peso)
    {
        this.peso = peso;
    }
    public double getAltura()
    {
        return this.altura;
    }
    public void SetAltura(double altura)
    {
        this.altura = altura;
    }

    public (double, string,string) CalcularImc()
    {
        double imc = peso / (altura * altura);

        if(imc < 18.5)
        {
            return (imc, "Magreza", "O"); 
        }
        else if(imc >= 18.5 && imc <= 24.9)
        {
            return (imc, "Normal", "O");
        }
        else if(imc >= 25.0 && imc <= 29.9)
        {
            return (imc, "Sobrepeso", "I");
        }
        else if (imc >= 30.0 && imc <= 39.9)
        {
            return (imc, "Obesidade", "II");
        }
        else
        {
            return (imc, "Obesidade Grave", "III");
        }
    }
}