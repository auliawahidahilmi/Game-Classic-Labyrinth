using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hole : MonoBehaviour
{
    public UnityEvent OnBallEnter = new UnityEvent();
    //deteksi bola udah masuk ke hole apa belum
    private void OnCollisionEnter(Collision collision)
    {
        OnTriggerEnter(collision.collider);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            OnBallEnter.Invoke();
        }
    }
}
