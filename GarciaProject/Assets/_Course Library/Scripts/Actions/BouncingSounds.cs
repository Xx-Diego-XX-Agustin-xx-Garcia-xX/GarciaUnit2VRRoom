using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingSounds : MonoBehaviour
{
    public AudioClip ballImpact;
    public AudioSource audioSource;
    private Rigidbody rigidBody;
    float ballMagnitude;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rigidBody = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter()
    {
        ballMagnitude = rigidBody.velocity.magnitude / 2;
        Debug.Log(ballMagnitude);
        if (ballMagnitude > 1)
        {
            ballMagnitude = 1;
        }
        audioSource.PlayOneShot(ballImpact, ballMagnitude);
    }
}
