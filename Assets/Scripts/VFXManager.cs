using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    [SerializeField]
    Weapon weapon;

    [SerializeField]
    GameObject impactObj;

    private void Awake()
    {
        weapon.OnImpact += OnImpact;
    }

    private void OnImpact(Vector3 impactLocation)
    {
        var distance = Vector3.Distance(impactLocation, weapon.gameObject.transform.position);
        

        GameObject vfx = Instantiate(impactObj);
        vfx.transform.localScale = Vector3.one * (distance / 3f);
        vfx.transform.position = impactLocation;    
    } 
}
