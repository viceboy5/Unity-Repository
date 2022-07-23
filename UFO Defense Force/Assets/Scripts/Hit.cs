using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public AudioSource UFODestroyed;
    private void OnTriggerEnter(Collider other)
    {
        UFODestroyed.Play();
    }
}
