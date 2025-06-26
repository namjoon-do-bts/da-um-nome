using UnityEngine;

public class viking : personagem
{
    public int machadoDuplo;
    public int resistencia;
    public string habilidadeEspecial;

    public void Machadada()
    {
        machadoDuplo++;
    }
    public int MachadoDuplo()
    {
        return machadoDuplo;
    }
    
    public void Resistente()
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
