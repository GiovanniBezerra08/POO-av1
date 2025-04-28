using UnityEngine;
public class Personagem
{
    private string nome;
    private int energia;
    private int forca_ataque;
    private int forca_pulo;
    private int velocidade;
    private int numero_de_pes;
    private int numero_de_maos;

    public string getNome()
    {
        return nome;
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }
    
    public int getEnergia()
    {
        return energia;
    }

    public void setEnergia(int energia)
    {
        this.energia = energia;
    }
    
    public int getForca_ataque()
    {
        return forca_ataque;
    }

    public void setForca_ataque(int forca_ataque)
    {
        this.forca_ataque = forca_ataque;
    }
    
    public int getForca_pulo()
    {
        return forca_pulo;
    }

    public void setForca_pulo(int forca_pulo)
    {
        this.forca_pulo = forca_pulo;
    }
    
    public int getVelocidade()
    {
        return velocidade;
    }

    public void setVelocidade(int velocidade)
    {
        this.velocidade = velocidade;
    }
    
    public int getNumero_de_pes()
    {
        return numero_de_pes;
    }

    public void setNumero_de_pes(int numero_de_pes)
    {
        this.numero_de_pes = numero_de_pes;
    }
    
    public int getNumero_de_maos()
    {
        return numero_de_maos;
    }

    public void setNumero_de_maos(int numero_de_maos)
    {
        this.numero_de_maos = numero_de_maos;
    }
}