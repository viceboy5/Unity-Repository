
using UnityEngine;
using UnityEngine.Events;

public class DiscoverObject : MonoBehaviour
{
    public UnityEvent nameObject;

    private void OnMouseDown()
    {
        nameObject.Invoke();
    }
}
