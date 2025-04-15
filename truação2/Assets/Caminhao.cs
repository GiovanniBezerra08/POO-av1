using UnityEngine;

public class Caminhao : Carro
{
    private string tipoDeCarroceria;

    public void AtribuirTipoDeCarroceria(string tipoDeCarroceria)
    {
        this.tipoDeCarroceria = tipoDeCarroceria;
    }

    public string ObterTipoDeCarroceria()
    {
        return tipoDeCarroceria;
    }
}