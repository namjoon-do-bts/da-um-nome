using System;
using UnityEngine;

public class TesteDeDano : MonoBehaviour
{
    private Personagem personagem;
    
    private void OnCollisionEnter(Collision colisao)
    {
        if (colisao.gameObject.CompareTag("Inimigo"))
        {
            float energia_atual = personagem.QtEnergia() - colisao.gameObject.GetComponent<Inimigo>().DanoDoInimigo();
           
            personagem.setEnergia(energia_atual);
           
            Debug.Log("O personagem " + personagem.QualONome()+" tem agora "+ personagem.QtEnergia());
        }
    }

    void Start()
    {
        personagem = this.GetComponent<Personagem>();
    }

  
    void Update()
    {
        
    }
}