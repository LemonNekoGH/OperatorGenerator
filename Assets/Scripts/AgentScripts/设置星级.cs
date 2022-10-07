using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 设置星级 : MonoBehaviour
{
    public Text Startext;
    public Slider StarSli;
    // Start is called before the first frame update
    void Start()
    {
        StarSli.onValueChanged.AddListener((float star) => Startext.text = (star+1).ToString    ());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
