using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NovaPontuacao : MonoBehaviour
{
    [SerializeField]
    private TextoDinamico textoPontuacao;
    private Pontuacao pontuacao;
    [SerializeField]
    private Ranking ranking;
    private int id;

    void Start()
    {
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
        var totalDePontos = this.pontuacao ? this.pontuacao.Pontos : -1;
        this.textoPontuacao.AtualizarTexto(totalDePontos);
        this.id = this.ranking.AdicionarPontuacao(totalDePontos, "Ribamar");
    }

    public void AlterarNome(string novoNome)
    {
        this.ranking.AlterarNome(novoNome, this.id);
    }
}
