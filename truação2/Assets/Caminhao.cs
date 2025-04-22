using UnityEngine;

public class Caminhao : Carro
{
    private string tipoDeCarroceria;

    public void setTipoDeCarroceria(string tipoDeCarroceria)
    {
        this.tipoDeCarroceria = tipoDeCarroceria;
    }

    public string getTipoDeCarroceria()
    {
        return tipoDeCarroceria;
    }
}