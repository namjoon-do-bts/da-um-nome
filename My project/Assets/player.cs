using JetBrains.Annotations;
using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody _rigidbody;

    public float velocidade = 10;
    
    void Start()
    {
        _rigidbody  = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        Vector3 posicao = transform.position;
        
       //esquerda x-
       if (Input.GetKey(KeyCode.W))
       {
           posicao.x = posicao.x - velocidade * Time.deltaTime;
       }
//direita x+
        if (Input.GetKey(KeyCode.S))
        {
            posicao.x = posicao.x + velocidade * Time.deltaTime;    
            
        }
        
        // frente z+
        
        if (Input.GetKey(KeyCode.D))
        {
            posicao.z = posicao.z + velocidade * Time.deltaTime;    
            
        }
        
        // trás z-
        
        if (Input.GetKey(KeyCode.A))
        {
            posicao.z = posicao.z - velocidade * Time.deltaTime;    
            
        }
        
        transform.position = posicao;
        
    }
}





    




















