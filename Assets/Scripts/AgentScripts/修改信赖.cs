using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 修改信赖 : MonoBehaviour
{
    public Slider turstsli;
    public Text turstsText;
    // Start is called before the first frame update
    void Start()
    {
        turstsli.onValueChanged.AddListener((float a) => { turstsText.text = a.ToString() + "%"; });
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
