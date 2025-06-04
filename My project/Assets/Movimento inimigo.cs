
using UnityEngine;
using System;
using Unity.VisualScripting;
using UnityEditor.Build;

public class MovimentoInimigo : MonoBehaviour
{
    private GameObject _player;
    private Rigidbody _rigidbody;
    private float velocidade;
    public float raioDeVisao = 10;
    private bool naVisao = false;
    private SphereCollider _sphereCollider;

    public bool walk;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        velocidade = gameObject.GetComponent<Inimigo>().speed();
        _sphereCollider = gameObject.GetComponent<SphereCollider>();
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        _sphereCollider.radius = raioDeVisao;
        if (naVisao == true)
        {
            transform.LookAt(_player.transform.position);
            transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, velocidade * Time.deltaTime);
        }
    }


    private void OnTriggerStay(Collider colisao)
    {
        if (colisao.gameObject.CompareTag("Player"))
        {
            naVisao = true;
        }
    }

    private void OnTriggerExit(Collider colisao)
    {
        if (colisao.gameObject.CompareTag("Player"))
        {
            naVisao = false;
        }
    }
}




