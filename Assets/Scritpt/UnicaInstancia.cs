using UnityEngine;

public class UnicaInstancia : MonoBehaviour
{
    void Start()
    {
        var outrasInstancias = GameObject.FindGameObjectsWithTag(this.tag);
        foreach (var instancia in outrasInstancias)
        {
            if (instancia != this.gameObject)
            {
                GameObject.Destroy(instancia.gameObject);
            }
        }
    }
}
