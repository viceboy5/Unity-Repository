using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchBehaviour : MonoBehaviour
{
    public ID idObj;
    private void OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehaviour>();
        if (tempObj == null)
            return;
            
        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            Debug.Log("Matched");
        }
        else
        {
            Debug.Log("No Match");
        }
    }
}
