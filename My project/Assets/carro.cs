using UnityEngine;

public class carro
{
    private string nome;
    private string cor;
    private int numero_de_rodas;
    private float preco;

    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }

    public string NomeDoCarro()
    {
        return this.nome;
    }

    public void AtribuirCor(string cor)
    {
        this.cor = cor;
    }
    
    public string CorDoCarro(){return this.cor;}
    
    public  void AtribuirNumeroDeRodas(int numero_de_rodas){this.numero_de_rodas = numero_de_rodas;}
    
    public int  NumeroDeRodas(){return this.numero_de_rodas;}
    
    public void  AtribuirPreco(float preco){this.preco = preco;}
    
    public float  GetPreco(){return this.preco;}
    
}







