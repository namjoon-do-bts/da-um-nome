using UnityEngine;

public class Personagem:MonoBehaviour
{
    [ SerializeField ]
    private string nome;
    [ SerializeField ]
    private float energia;
    [ SerializeField ]
    private int atk;
    [ SerializeField ]
    private int pulo;
    [ SerializeField ]
    private float velocidade;
    [ SerializeField ]
    private int numeroPés;
    [ SerializeField ]
    private int numeroMaos;

    void setNome(string nome)
    {
        this.nome = nome;
    }

    public string QualONome()
    {
        return this.nome;
    }

    public void setEnergia (float energia)
    {
        this.energia = energia;
    }

    public float QtEnergia()
    {
        return this.energia;
        
    }

    public void setAtaque (int atk)
    {
        this.atk = atk;
    }

    public int ataque()
    {
        return this.atk;
    }

    public void setPulo(int pulo)
    {
        this.pulo = pulo;
    }

    public int jump()
    {
        return this.pulo;
    }

    public void setVelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }

    public float speed()
    {
        return this.velocidade;
    }

    public void SetPés(int numeroPés)
    {
        this.numeroPés = numeroPés;
    }

    public int pés()
    {
        return this.numeroPés;
        
    }

    public void SetMaos(int numeroMaos)
    {
        this.numeroMaos = numeroMaos;
    }

    public int maos()
    {
        return this.numeroMaos;
    }

}