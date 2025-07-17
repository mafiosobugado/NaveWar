using UnityEngine;

public class movimento : MonoBehaviour
{
    public float velocidade = 5f;
    public GameObject projetilPrefab;

    void Update()
    {
        // Movimento horizontal
        float movimentoHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * movimentoHorizontal * velocidade * Time.deltaTime);

        // Atirar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projetilPrefab, transform.position, Quaternion.identity);
        }
    }
}