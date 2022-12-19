using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayScript : MonoBehaviour
{
    public RaycastHit hitInfo;

    [SerializeField]
    private float rayRange;

    private void Update()
    {
        Physics.Raycast(this.transform.position, this.transform.forward, out hitInfo);

        Debug.Log(hitInfo.distance);
    }
    private void OnDrawGizmos()
    {
        DrawRay();
    }

    void DrawRay()
    {
        Gizmos.color = Color.red;

        if (Physics.Raycast(this.transform.position, this.transform.forward, out hitInfo))
        {

            // Hit된 지점까지 ray를 그려준다.
            Gizmos.DrawRay(transform.position, transform.forward * hitInfo.distance);
        }
        else
        {
            // Hit가 되지 않았으면 최대 검출 거리로 ray를 그려준다.
            Gizmos.DrawRay(transform.position, transform.forward * rayRange);
        }
    }
}
