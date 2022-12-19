using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class PlatForm : MonoBehaviour
{
    private Material _material;
    public void Start()
    {
        _material = transform.GetComponent<Renderer>().material;
    }

    private void OnMouseOver()
    {
        _material.color = Color.cyan;
    }

    private void OnMouseExit()
    {
        _material.color = Color.white;
    }
}
