using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using UnityEngine;

public class Ranking : MonoBehaviour
{
    [SerializeField]
    private List<Colocado> listaDeColocados;
    private static string NOME_DO_ARQUIVO = "Ranking.json";
    private string caminhoParaOArquivo;

    private void Awake()
    {
        this.caminhoParaOArquivo = Path.Combine(Application.persistentDataPath, NOME_DO_ARQUIVO);
        if (File.Exists(this.caminhoParaOArquivo))
        {
            var textoJson = File.ReadAllText(this.caminhoParaOArquivo);
            JsonUtility.FromJsonOverwrite(textoJson, this);
        }
        else
        {
            this.listaDeColocados = new List<Colocado>();
        }
    }

    public int AdicionarPontuacao(int pontos, string nome)
    {
        var id = this.listaDeColocados.Count * UnityEngine.Random.Range(1, 10000);
        var novoColocado = new Colocado(nome, pontos, id);
        this.listaDeColocados.Add(novoColocado);
        this.SalvarRanking();

        return id;
    }

    private void SalvarRanking()
    {
        var textoJson = JsonUtility.ToJson(this);
        File.WriteAllText(this.caminhoParaOArquivo, textoJson);
    }

    public void AlterarNome(string novoNome, int id)
    {
        foreach (var item in this.listaDeColocados)
        {
            if (item.id == id)
            {
                item.nome = novoNome;
                break;
            }
        }
        this.SalvarRanking();
    }

    public int Quantidade()
    {
        return this.listaDeColocados.Count;
    }

    public ReadOnlyCollection<Colocado> GetColocados()
    {
        return this.listaDeColocados.AsReadOnly();
    }
}

[Serializable]
public class Colocado
{
    public string nome;
    public int pontos;
    public int id;

    public Colocado(string nome, int pontos, int id)
    {
        this.nome = nome;
        this.pontos = pontos;
        this.id = id;
    }
}