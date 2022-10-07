using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class 切换区域 : MonoBehaviour
{
    public Button Openbtn;
    public string Filepath;
    //主要数据 Maindata = new 主要数据();
    //------------------切换的按钮-----------------//
    public Toggle BaseDescribe;
    public Toggle BaseData;
    public Toggle SkillData;
    private void Start()
    {
        
       // Openbtn.onClick.AddListener(() => Filepath = FileOpen.OpenFile());

        BaseData.onValueChanged.AddListener((bool value) => 主要数据.SaveDataSta()) ;
        SkillData.onValueChanged.AddListener((bool value) => 主要数据.SaveDataSta());
        BaseDescribe.onValueChanged.AddListener((bool value) => 主要数据.SaveDataSta());
    }  
}
