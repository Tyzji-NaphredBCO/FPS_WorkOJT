using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Action OnDestroy;
    public Action<Vector3> OnImpact;

    private void OnCollisionEnter(Collision collision)
    {
        OnImpact?.Invoke(transform.position);
        if (collision.gameObject.CompareTag("Target"))
        {
            print("Hit " + collision.gameObject.name + " !");
            OnDestroy?.Invoke();
            Destroy(collision.gameObject);
        }

        Destroy(gameObject);
    }
}
