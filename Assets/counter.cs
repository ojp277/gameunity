using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counter : MonoBehaviour
{

    Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }

    private void Update()
    {
        text.text = Counter.count.ToString();
    }
}

public static class Counter
{
    public static int count;
}