using UnityEngine;


public class teste : MonoBehaviour
{
    public personagem personagem;
    public Viking viking;
   
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        personagem = new personagem();
        
        personagem.LerVelocidade();
        personagem.Pular();
        personagem.viver(2);
        personagem.Nome();
        
        Debug.Log(personagem.LerVelocidade() + personagem.Pular() + personagem.Nome() + personagem.Pular());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
