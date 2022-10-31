using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct InputFloat
{
    public InputField input;
    public int min;
    public int max;
    public float coefficient;
}

public class UIHandler : MonoBehaviour
{
    public InputFloat time;
    public InputFloat speed;
    public InputFloat distance;

    private int HandleInput(string s)
    {
        int result = 0;
        if (int.TryParse(s, out int val))
        {
            result = val;
        }
        return result;
    }

    private float BoundFloat(InputFloat input)
    {
        int result = HandleInput(input.input.text);
        if (result < input.min)
        {
            result = input.min;
        }
        if (result > input.max)
        {
            result = input.max;
        }
        input.input.text = result.ToString();
        return result * input.coefficient;
    }

    public void EnterTime()
    {
        DataManager.Instance.time = BoundFloat(time);
    }

    public void EnterSpeed()
    {
        DataManager.Instance.speed = BoundFloat(speed);
    }

    public void EnterDistance()
    {
        DataManager.Instance.distance = BoundFloat(distance);
    }
}
