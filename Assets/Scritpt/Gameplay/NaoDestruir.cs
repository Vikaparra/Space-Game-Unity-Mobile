using UnityEngine;

public class NaoDestruir : MonoBehaviour
{
    void Start()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);
    }
}
