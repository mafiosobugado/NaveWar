using UnityEngine;
using System.Collections;

public class SpawnerInimigos : MonoBehaviour
{
    public GameObject inimigoPrefab;
    public int quantidadeMinima = 2;
    public int quantidadeMaxima = 6;
    public float minX = -7f, maxX = 7f, posY = 5f;
    public float intervalo = 4f;

    void Start()
    {
        StartCoroutine(SpawnarLevas());
    }

    IEnumerator SpawnarLevas()
    {
        while (true)
        {
            int quantidade = UnityEngine.Random.Range(quantidadeMinima, quantidadeMaxima + 1);
            for (int i = 0; i < quantidade; i++)
            {
                float x = UnityEngine.Random.Range(minX, maxX);
                Vector3 posicao = new Vector3(x, posY, 0);
                Instantiate(inimigoPrefab, posicao, Quaternion.identity);
            }
            yield return new WaitForSeconds(intervalo);
        }
    }
}