 using UnityEditor;
using UnityEngine;

public class Teste : MonoBehaviour
{
  private Carro fusca = new Carro();
  private Carro gol = new Carro();
  private Caminhao caminhao = new Caminhao();
  private void Start()
  {
    fusca.setNome("Fusca de Pai");
    fusca.setCor("verde");
    fusca.setNumero_de_rodas(4);
    fusca.setPreco(2050.90f);
    Debug.Log(fusca.getNome() + " é " + fusca.getCor() + ", vale " + fusca.getPreco() + " e tem " + fusca.getNumero_de_rodas() + " rodas ");
    
    gol.setNomedocarro("Gol Trulimero");
    gol.setCor("rosa");
    gol.setNumero_de_rodas(4);
    gol.setPreco(5000.50f);
    Debug.Log("0 "+ gol.getNomedocarro() + " é " + gol.getCor() + ", vale " + gol.getPreco() + " e tem " + gol.getNumero_de_rodas() + " rodas ");
    
    caminhao.setNomedocarro("Giga");
    caminhao.setCor("azul");
    caminhao.setNumero_de_rodas(6);
    caminhao.setPreco(8000f);
    caminhao.setTipoDeCarroceria(5000.50f);
    Debug.Log("0 "+ caminhao.getNomedocarro() + " é " + caminhao.getCor() + ", vale " + caminhao.getPreco() + " e tem " + caminhao.getNumero_de_rodas() + " rodas ") + caminhao.getTipoDeCarroceria() + " carroceria ");  
  }
}
