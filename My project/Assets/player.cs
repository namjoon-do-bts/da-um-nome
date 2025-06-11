using JetBrains.Annotations;
using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody _rigidbody;

    public float velocidade = 10;
    public bool andando;
    void Start()
    {
        _rigidbody  = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        andando = false;
        Vector3 posicao = transform.position;
        
       //esquerda x-
       if (Input.GetKey(KeyCode.S))
       {
           posicao.x = posicao.x - velocidade * Time.deltaTime;
           transform.rotation = Quaternion.Euler(0, 90, 0);
           andando = true;
       }
//direita x+
        if (Input.GetKey(KeyCode.W))
        {
            posicao.x = posicao.x + velocidade * Time.deltaTime;    
            transform.rotation = Quaternion.Euler(0, -90, 0);
            andando = true;
            
        }
        
        // frente z+
        
        if (Input.GetKey(KeyCode.A))
        {
            posicao.z = posicao.z + velocidade * Time.deltaTime;   
            transform.rotation = Quaternion.Euler(0, 180, 0);
            andando = true;
            
        }
        
        // trás z-
        
        if (Input.GetKey(KeyCode.D))
        {
            posicao.z = posicao.z - velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            andando = true;

        }
        
        transform.position = posicao;
        
    }
}





    




















