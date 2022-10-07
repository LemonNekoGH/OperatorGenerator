using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 技能类型检测 : MonoBehaviour
{
    public List<Color> BGcolor;
    public Dropdown SkillType;
    public Image BGIMG;
    public GameObject SPtype;
    public GameObject CD;

    public void CheckDropDown()
    {
        if(SkillType.value == 3)
        {
            CD.SetActive(false);
            SPtype.SetActive(false);
        }
        else
        {
            CD.SetActive(true);
            SPtype.SetActive(true);
        }
        //修改颜色//
        BGIMG.color = BGcolor[SkillType.value];
        
    }
}
