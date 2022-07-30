
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[CreateAssetMenu]

public class IntData : ScriptableObject
{
    public int value;

    public void UpdateValue(int number)
    {
        value += number;
    }

    public void DisplayNumber(Text txt)
    {
        txt.text = value.ToString();
        Debug.Log("Value has been updated: " + value);
    }
}
