using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Networking.Match;

public class CollisionHelper : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.name == "Vehicle")
        {
            var particleSystem = gameObject.GetComponent<ParticleSystem>();
            if (particleSystem != null && !particleSystem.isPlaying)
            {
                particleSystem.Play();
                Destroy(gameObject, 1.5f);
            }
        }
    }
}
