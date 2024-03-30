using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour
{
    public GameObject door;
    public ParticleSystem pickup;

    void Start()
    {
        pickup.Stop();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin")) OnCoinTriggerEnter(other);
    }

    void OnCoinTriggerEnter (Collider other)
    {
        Destroy(door);
        Destroy(other.gameObject);
    }
}
