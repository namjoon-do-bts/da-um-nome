using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public Animator animator;
    private  player Jogador;
    public float animSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Jogador = GetComponent<player>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("andando",Jogador.andando);
        animator.speed = animSpeed;
    }
}