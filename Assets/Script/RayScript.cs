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

            // Hit�� �������� ray�� �׷��ش�.
            Gizmos.DrawRay(transform.position, transform.forward * hitInfo.distance);
        }
        else
        {
            // Hit�� ���� �ʾ����� �ִ� ���� �Ÿ��� ray�� �׷��ش�.
            Gizmos.DrawRay(transform.position, transform.forward * rayRange);
        }
    }
}
