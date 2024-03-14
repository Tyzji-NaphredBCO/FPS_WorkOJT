using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    Weapon weapon;
    [SerializeField]
    AudioClip destroyClip;
    [SerializeField]
    AudioClip impactClip;
    [SerializeField]
    AudioSource source;  

    private void Awake()
    {
        weapon.OnShoot += OnShoot;
        weapon.OnImpact += OnImpact;
    }

    private void OnImpact(Vector3 vector)
    {
        source.PlayOneShot(impactClip);
    }

    private void OnShoot(int ammo)
    {
        Debug.Log($"Remaining Ammo: {ammo}");
        source.PlayOneShot(destroyClip);
    }
}
