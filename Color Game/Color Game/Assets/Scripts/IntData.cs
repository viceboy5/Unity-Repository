
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[CreateAssetMenu]

public class IntData : ScriptableObject
{
    public int value;

    public void SetValue(int num)
    {
        value = num;
    }

    public void CompareValue(IntData obj)
    {
        if (value >= obj.value)
        {

        }
        else
        {
            value = obj.value;
        }
        
    }

    public void SetValue (IntData obj)
    {
        value = obj.value;
    }

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
