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
}







