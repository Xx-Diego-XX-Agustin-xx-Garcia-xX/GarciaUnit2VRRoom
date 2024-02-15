using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotation : MonoBehaviour
{
    [SerializeField]
    private GameObject reticle;
    public float speed;
    public Vector3 direction;
    void Update()
    {
        transform.Rotate(speed * direction * Time.deltaTime);
    }
}
