using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlatFormManager : MonoBehaviour
{
    public Collider[] platFormCollider;
    public LayerMask platFormLayerMask;

    private void Awake()
    {
        platFormCollider = Physics.OverlapSphere(transform.position, 100, platFormLayerMask);
        for (int i = 0; i < platFormCollider.Length; i++)
        {
            platFormCollider[i].AddComponent<PlatForm>();
        }
    }
}
