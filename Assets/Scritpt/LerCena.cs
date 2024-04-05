using UnityEngine;
using UnityEngine.SceneManagement;

public class LerCena : MonoBehaviour
{
    public void CarregarCena(string cena)
    {
        SceneManager.LoadScene(cena);
    }
}
