using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 技能区域 : MonoBehaviour
{
    //技能区域图片=数据面板图片
    //触发类型为点击
    //描述单独存储
    //名字使用数据面板
    public Button ReloadBtn;
    public Button loadbtn;
    #region 使用的其他场景的组件
    public List<InputField> SkillName;
    //public List<InputField> SkillSTRSP;
    //public List<InputField> SkillENDSP;
    public List<RawImage> SkillImage ;
    //public List<Toggle> SkillStrTog;
    //public List<Toggle> SkillEndTog;
    #endregion
    #region 本地组件
    public List<Text> SklName;
    public List<InputField> SkillDes;//技能描述
    public List<RawImage> Skillimg2;//技能图像‘
    public List<Dropdown> SkillStrObj;
    public List<Dropdown> SkillEndObj;//技能属性
    public List<InputField> SkillCD;
    public List<Toggle> CDtrue;

    #endregion
    #region 本地变量
    public List<string> SkillDesSTR;
    public List<int> SPtype;
    public List<int> USEtype;
    public List<int> CD;
    public List<bool> CDUSE;
    #endregion
    #region 静态变量
    public static List<string> SDS_STA;
    public static List<int> SPT_STA;
    static public List<int> UST_STA;
    public static List<int> CD_sta;
    public static List<bool> CDU_sta;
    #endregion
   

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator LoadWaittime()
    {
        yield return new WaitForSeconds(0.1f);
        LoadData();
    }
    public void ReadyLoadData()
    {
        StartCoroutine(LoadWaittime());
    }
    void LoadData()//同步数据
    {

        for (int i = 0; i < SkillName.Count; i++)
        {
            SklName[i].text = SkillName[i].text;
        }
        for (int i = 0; i < SkillImage.Count; i++)
        {
            Skillimg2[i].texture = SkillImage[i].texture;
        }

    }
    public void SaveDES()//将技能描述写入动态变量
    {
        for(int i = 0;i < SkillDes.Count; i++)
        {
            SkillDesSTR[i] = SkillDes[i].text;
        }
        for (int i = 0; i < SkillCD.Count; i++)
        {
            CD[i] = int.Parse(SkillCD[i].text);
        }
        for (int i = 0; i < CDUSE.Count; i++)
        {
            CDUSE[i] = CDtrue[i].isOn;
        }
        for(int i = 0;i<SkillStrObj.Count; i++)
        {
            SPtype[i] = SkillStrObj[i].value ;
        }
        for(int i = 0;i<SkillEndObj.Count; i++)
        {
            USEtype[i] = SkillEndObj[i].value;
        }
        SaveDesSta();
    }
     void SaveDesSta()
    {
        SDS_STA = SkillDesSTR;
        SPT_STA = SPtype;
        UST_STA = USEtype;
        CD_sta = CD;
        CDU_sta = CDUSE;
        Debug.Log("<color=#f86d07>技能已写入</color>");
    }
    public static List<string> SDS_IMP;
    public static List<int> SPT_IMP;
    public static List<int> UST_IMP;
    public static List<int> CD_IMP;
    public static List<bool> CDU_IMP;
    //导入变量//
    public void LoadIMPData()//准备覆写到当前文本q
    {
        StartCoroutine(WaitforloaddataToImport());
    }
    IEnumerator WaitforloaddataToImport()
    {
        yield return new WaitForSeconds(1);
        if (SDS_IMP != null)
        {
            for (int i = 0; i < SkillDes.Count; i++)
            {
                SkillDes[i].text = SDS_IMP[i];
            }
            for (int i = 0; i < SkillCD.Count; i++)
            {
                SkillCD[i].text = CD_IMP[i].ToString();
            }
            for (int i = 0; i < CDUSE.Count; i++)
            {
                CDtrue[i].isOn = CDU_IMP[i];
            }
            for (int i = 0; i < SkillStrObj.Count; i++)
            {
                SkillStrObj[i].value = SPT_IMP[i];
            }
            for (int i = 0; i < SkillEndObj.Count; i++)
            {
                SkillEndObj[i].value = UST_IMP[i];
            }
            SaveDesSta();
        }

    }
}
