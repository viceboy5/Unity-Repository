using UnityEngine;
using System.Collections;

public class ScopeAndAccessModifiers : MonoBehaviour
{
    public int alpha;

    private int beta = 0;
    private int gamma = 5;

    void Start()
    {
        alpha = 29;

        myOtherClass = AnotherClass();
        myOtherClass.FruitMachine(int a, int b)
    }

    void Example(int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }

    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}
