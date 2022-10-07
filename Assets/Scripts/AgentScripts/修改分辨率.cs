using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 修改分辨率 : MonoBehaviour
{
    public Dropdown setresu;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 200;
        setresu.onValueChanged.AddListener((int select) => { SetRe(select); });
    }
    void SetRe(int a)
    {
        if (a == 0)
        {
            Screen.SetResolution(1366,768,false);
        }if(a == 1)
        {
            Screen.SetResolution(1440,810,false);

        }
        if (a == 2)
        {
            Screen.SetResolution(1920, 1080, false);

        }
        if(a == 3)
        {
            Screen.SetResolution(3840,2160, false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
