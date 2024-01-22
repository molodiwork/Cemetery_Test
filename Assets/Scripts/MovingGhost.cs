using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingGhost : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.SetParent(gameObject.transform);
    }
    private void OnTriggerExit(Collider other)
    {
        other.gameObject.transform.SetParent(null);
    }
}
