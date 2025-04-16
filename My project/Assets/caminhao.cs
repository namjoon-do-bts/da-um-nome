using UnityEngine;

public class caminhao : carro
{
    private string tipodecarroceria;
    
    public void setTipo(string tipodecarroceria){this.tipodecarroceria = tipodecarroceria;}
    public string tipo(){return this.tipodecarroceria;}
}
