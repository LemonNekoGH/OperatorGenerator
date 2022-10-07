using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 设置滑动条 : MonoBehaviour
{
    public InputField valuefield;
    public Slider valueslider;
    void Start()
    {
        valuefield.onValueChanged.AddListener((string s) => { valueslider.value = int.Parse(s); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
