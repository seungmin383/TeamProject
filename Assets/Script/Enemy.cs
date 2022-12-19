using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float rotateSpeed;

    public GameObject enemy;
    RayScript rayScript;
    private void Start()
    {
        rayScript = GetComponentInChildren<RayScript>();
    }
    private void Update()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        
        if(rayScript.hitInfo.distance <= 0.1 || rayScript.hitInfo.distance >=3)
        {
            transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);

        }

        if (rayScript.hitInfo.distance > 0)
        {
            if (rayScript.hitInfo.collider.tag == "StartPoint")
            {
                Destroy(enemy);
            }
        }
        
    }
    


}
