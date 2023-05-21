using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hole : MonoBehaviour
{
    [SerializeField] CustomEvent customEvent;
    AudioSource audioSource;
    //deteksi bola udah masuk ke hole apa belum
    private void OnCollisionEnter(Collision collision)
    {
        OnTriggerEnter(collision.collider);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            customEvent.OnInvoked.Invoke();            
        }
    }
}
