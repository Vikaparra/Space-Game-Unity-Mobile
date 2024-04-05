using UnityEngine;

public class Pontuavel : MonoBehaviour
{
    private Pontuacao pontuacao;

    public void SetPontuacao(Pontuacao pontuacao)
    {
        this.pontuacao = pontuacao;
    }
    public void Pontuar()
    {
        this.pontuacao.Pontuar();
    }
}
