using UnityEngine;

public class MovimentoInimigo : MonoBehaviour
{
    private GameObject _player;
    
    private Rigidbody _rigidbody;
    private float velocidade;
    
    public float raioDeVisao = 4;

    
    void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        velocidade = gameObject.GetComponent<Inimigo>().getVelocidade();
        
        _player = GameObject.FindGameObjectWithTag("Player");

    }

   
    void Update()
    {
        if (Vector3.Distance(transform.position, _player.transform.position) < raioDeVisao)
        {
            transform.LookAt(_player.transform.position);
            transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, velocidade * Time.deltaTime);
        }
    }
}