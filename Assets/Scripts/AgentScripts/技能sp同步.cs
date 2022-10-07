using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 技能sp同步 : MonoBehaviour
{
    public List<Toggle> StrspaToggle;
    public List<Text> StrspaINT;
    public List<Toggle> EndspaToggle;
    public List<Text> EndspaINT;
    public List<Toggle> StrSPtar;
    public List<InputField> StrSPIF;
    public List<Toggle> EndSPtar;
    public List<InputField> EndSPIF;
    public Toggle ChangeToggle;
    public void SyncSptoggleAndValue()
    {
        for(int i = 0; i < StrspaToggle.Count; i++)
        {
            StrspaToggle[i].isOn=StrSPtar[i].isOn;
            StrspaINT[i].text = StrSPIF[i].text;
            EndspaToggle[i].isOn = EndSPtar[i].isOn;
            EndspaINT[i].text=EndSPIF[i].text;
        }
    }
}
