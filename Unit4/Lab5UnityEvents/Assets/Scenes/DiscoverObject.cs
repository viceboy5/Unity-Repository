
using UnityEngine;
using UnityEngine.Events;

public class DiscoverObject : MonoBehaviour
{
    public UnityEvent nameObject, removeText;

    private void OnMouseDown()
    {
        nameObject.Invoke();
    }

    private void OnMouseUp()
    {
        removeText.Invoke();
    }
}
