using UnityEngine;

public class Inimigo : Personagem
{

    private string armadura;
    private string arma;

    public string getArmadura()
    {
        return armadura;
    }

    public void setArmadura(string armadura)
    {
        this.armadura = armadura;
    }

    public string getArma()
    {
        return arma;
    }

    public void setArma(string arma)
    {
        this.arma = arma;
    }

    private int DanoDoInimigo()
    {
        int dano = 0;

        switch (arma)
        {
            case "Espada":
                dano = getForca_ataque() + 10;
                break;
            case "Machado":
                dano = getForca_ataque() + 18;
                break;
            case "Adaga":
                dano = getForca_ataque() + 5;
                break;
        } 
    
        return dano;
        
    } 
    
}
