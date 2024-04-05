﻿using UnityEngine;
using UnityEngine.Events;

public class EventoDeColisao : MonoBehaviour
{

    [SerializeField]
    private UnityEvent aoBater;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.aoBater.Invoke();
        GameObject.Destroy(this.gameObject);
    }
}
