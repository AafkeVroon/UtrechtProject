using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGizmos : MonoBehaviour
{
    [SerializeField]private Color color = Color.green;
    [Range(0.1f,1)]
    [SerializeField]private float gizmosSize = 0.4f;

    private void OnDrawGizmos()
    {
        if (color != null)
            Gizmos.color = color;

        Gizmos.DrawWireSphere(transform.position, gizmosSize);
    }
}
