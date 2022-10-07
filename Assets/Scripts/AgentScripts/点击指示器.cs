using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class 点击指示器 : MonoBehaviour
{
    public Button Button1;
    // Start is called before the first frame update
    void Start()
    {
        Button1.onClick.AddListener(() => { });
        
    }
    public void showdata()
    {
        Debug.Log("点击了"); Debug.Log(游戏界面数据.ABI_static[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
