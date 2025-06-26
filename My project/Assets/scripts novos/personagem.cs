using UnityEngine;

public class personagem : MonoBehaviour
{
    public int velocidade;
    public string nome;
    public int vida;
    public int pular;

    public void Correr(int velocidade)
    {
        this.velocidade = velocidade + 5;
    }
    public int LerVelocidade()
    {
        return velocidade;
    }

    public void apelido(string nome)
    {
        this.nome = nome + "viking";
    }
    public string Nome()
    {
        return nome;
    }

    public void viver(int vida)
    {
        this.vida = vida + 2;
    }
    public int LerVida()
    {
        return vida;
    }

    public void toin(int pular)
    {
        this.pular = pular + 3;
    }
    public int Pular()
    {
        return pular;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
