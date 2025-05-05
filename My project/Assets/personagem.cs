using UnityEngine;

public class Personagem 
{
    private string nome;
    private float energia;
    private int atk;
    private int pulo;
    private float velocidade;
    private int numeroPés;
    private int numeroMaos;

    void setNome(string nome){
        this.nome = nome;
    }

    public string QualONome(){
        return this.nome;
    }

    void setEnergia (float energia){
        this.energia = energia;
    }

    public float QtEnergia (){return this.energia;}

    void setAtaque (int atk){
        this.atk = atk;
    }

    public int ataque(){
        return this.atk;
    }
        
    void setPulo(int pulo){this.pulo = pulo;}

    public int jump(){return this.pulo;}

    void setVelocidade(float velocidade){this.velocidade = velocidade;}

    public float speed(){return this.velocidade;}

    void SetPés(int numeroPés){
        this.numeroPés = numeroPés;

    }

    public int pés()
    {
        return this.numeroPés;}

    void SetMaos(int numeroMaos){
        this.numeroMaos = numeroMaos;
    }

    public int maos(){
        return this.numeroMaos;
    }

}