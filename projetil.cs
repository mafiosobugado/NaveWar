using UnityEngine;

public class Projetil : MonoBehaviour
{
    public float velocidade = 10f;
    public float tempoDeVida = 5f;

    void Start()
    {
        // Destroi o projétil após tempoDeVida segundos
        Destroy(gameObject, tempoDeVida);
    }

    void Update()
    {
        // Move o projétil para cima no eixo Y global
        transform.Translate(Vector3.up * velocidade * Time.deltaTime, Space.World);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Inimigo"))
        {
            Destroy(other.gameObject); // Destroi o inimigo
           // Destroy(gameObject);       // Destroi o projétil
        }
    }
}