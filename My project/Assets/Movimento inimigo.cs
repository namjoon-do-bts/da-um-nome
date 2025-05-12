using UnityEngine;

public class Movimentoinimigo : MonoBehaviour
{
    private GameObject _player;
    
    private Rigidbody _rigidbody;
    private float _velocidade;

    public float raioDeVisao = 10;
    private bool naVisao = false;

    private SphereCollider _sphereCollider;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
