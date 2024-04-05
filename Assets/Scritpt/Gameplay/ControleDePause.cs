using System.Collections;
using UnityEngine;

public class ControleDePause : MonoBehaviour
{
    [SerializeField, Range(0, 1)]
    private float escalaDeTempoDurantePause;
    [SerializeField]
    private GameObject painelPause;
    private bool jogoEstaParado;

    void Update()
    {
        if (this.EstaoTocandoNaTela())
        {
            if (this.jogoEstaParado)
            {
                this.ContinuarJogo();
            }
        }
        else
        {
            if (!this.jogoEstaParado)
            {
                this.PararJogo();
            }
        }
    }

    private void ContinuarJogo()
    {
        StartCoroutine(this.EsperarEContinuarJogo());
    }

    private void PararJogo()
    {
        this.painelPause.SetActive(true);
        MudarEscalaDeTempo(escalaDeTempoDurantePause);
        this.jogoEstaParado = true;
    }

    private IEnumerator EsperarEContinuarJogo()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        this.painelPause.SetActive(false);
        MudarEscalaDeTempo(1);
        this.jogoEstaParado = false;
    }

    private bool EstaoTocandoNaTela()
    {
        return Input.touchCount > 0;
    }

    private void MudarEscalaDeTempo(float escala)
    {
        Time.timeScale = escala;
        Time.fixedDeltaTime = 0.02f * escala;
    }
}
