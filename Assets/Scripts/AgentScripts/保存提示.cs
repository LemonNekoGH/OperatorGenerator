using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 保存提示 : MonoBehaviour
{
    public Text SaveTips;
    public GameObject TipsBKG;
    public GameObject TIPOBj;
    public Button Closebtn;

    private void Start()
    {
        Closebtn.onClick.AddListener(() => DestoryTIp());
        //this.gameObject.transform.Translate(new Vector3(0,78,0),Space.Self);
        this.gameObject.transform.localScale = new Vector3(0.106f, 0.106f, 0.106f);
        SaveTips.text ="已经保存至<color=orange>"+ 读取数据.STALoadPath+"</color>";
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            DestoryTIp();
        }
    }

    public void DestoryTIp()
    {
        Destroy(TIPOBj);
    }
}
