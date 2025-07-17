using UnityEngine;

public class inimigo : MonoBehaviour
{
    public float velocidadeVertical = 1.5f;
    public float velocidadeHorizontal = 1f;
    public float amplitudeHorizontal = 2f;
    private float posicaoInicialX;
    private float tempo;

    void Start()
    {
        posicaoInicialX = transform.position.x;
        tempo = UnityEngine.Random.Range(0f, 2f * Mathf.PI); // Para variar o movimento entre inimigos
    }

    void Update()
    {
        // Movimento vertical constante para baixo
        transform.Translate(Vector3.down * velocidadeVertical * Time.deltaTime, Space.World);

        // Movimento horizontal suave (vai e volta)
        float deslocamentoX = Mathf.Sin(Time.time * velocidadeHorizontal + tempo) * amplitudeHorizontal;
        Vector3 novaPosicao = transform.position;
        novaPosicao.x = posicaoInicialX + deslocamentoX;
        transform.position = novaPosicao;
    }
}