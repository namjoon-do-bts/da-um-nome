using UnityEngine;

public class teste : MonoBehaviour
{
    carro fusca = new carro();
    carro gol = new carro();

    private caminhao caminhao = new caminhao();
    
    void Start()
    {
        fusca.AtribuirNome("Fusca de Pai");
        Debug.Log("0 "+ fusca.NomeDoCarro());
        fusca.AtribuirNome("Amarelo");
        fusca.AtribuirNumeroDeRodas(4);
        fusca.AtribuirPreco(2050.90f);
        Debug.Log("0 "+ fusca.NomeDoCarro() +" é "+fusca.CorDoCarro() + " tem " + fusca.NumeroDeRodas() + " Rodas e custa " + fusca.GetPreco() + " reais." );
        gol.AtribuirNome("gol sla");
        
        gol.AtribuirNome("Gol do falstão");
        gol.AtribuirCor("Verde");
        gol.AtribuirNumeroDeRodas(4);
        gol.AtribuirPreco(2050.90f);S
    }
    
    void Update()
    {
        
    }
}




