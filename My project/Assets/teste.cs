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
        fusca.AtribuirNumero_de_rodas(4);
        fusca.AtribuirPreco(2050.90f);
        Debug.Log("0 "+ fusca.NomeDoCarro() +" é "+fusca.NomeDoCarro() + " te");
        gol.AtribuirNome("gol sla");
    }
    
    void Update()
    {
        
    }
}
