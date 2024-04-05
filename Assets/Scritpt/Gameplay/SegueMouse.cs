using UnityEngine;

public class SegueMouse : MonoBehaviour
{
    void Update()
    {
        var posicao = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = posicao;
    }
}
