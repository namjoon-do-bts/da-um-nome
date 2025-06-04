using UnityEngine;

public class inimigomaneger : MonoBehaviour
{
    public Animator animator;
    private MovimentoInimigo bicho;
    public float animationspeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bicho = GetComponent<MovimentoInimigo>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool ("walk",bicho.walk);
        animator.speed = animationspeed;
    }

}
