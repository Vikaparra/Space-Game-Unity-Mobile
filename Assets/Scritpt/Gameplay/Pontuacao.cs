using System;
using UnityEngine;
using UnityEngine.Events;

public class Pontuacao : MonoBehaviour
{
    [SerializeField]
    private MeuEventoPersonalizadoInt aoPontuar;
    public int Pontos { get; private set; }

    public void Pontuar()
    {
        this.Pontos++;
        this.aoPontuar.Invoke(this.Pontos);
    }
}

[Serializable]
public class MeuEventoPersonalizadoInt : UnityEvent<int>
{

}