using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 天赋区域 : MonoBehaviour
{
    public static List<string> ABI_Static;
    public static List<string> ABI_IMP;
    public List<string> ABI_Temp;//图片，天赋文本，天赋1文本，天赋2文本，启用。

    public Button ImportBtn;
    public InputField Characteristic;
    public List<InputField> AbilityInput;
    public Toggle SecAbilityOnOff;

    public RawImage AbiPic;


    private string OpenPicFileType = "图片文件(.png)\0*.png\0图片文件(.jpg)\0*.jpg\0All Files\0*.*\0\0";//文件保存类型--》Fileopen.cs
    private string OpenPicTitle = "打开图片";//文件打开窗口标题
    private string PicType = "png";//？
    // Start is called before the first frame update
    void Start()
    {
        ImportBtn.onClick.AddListener(()=>SelectAbiPic());
    }
    public void SetAbility()
    {
        ABI_Temp[1] = Characteristic.text;
        ABI_Temp[2] = AbilityInput[0].text;
        ABI_Temp[3] = AbilityInput[1].text;
        if (SecAbilityOnOff.isOn == true)
        {
            ABI_Temp[4] = "1";
        }
        else
        {
            ABI_Temp[4] = "0";
        }
        ABI_Static = ABI_Temp;
        Debug.Log("<color=#e15353>天赋已写入</color>"+ABI_Static[1]);
    }
    public void SelectAbiPic()
    {
        string path =FileOpen.OpenFile(OpenPicFileType,OpenPicTitle,PicType);
        ABI_Temp[0]=ase64toString.ImgToBase64String(path);
        AbiPic.texture=ase64toString.Base64ToImg(ABI_Temp[0]);
        SetAbility();
    }
    // Update is called once per frame
    void Update()
    {
     ReloadData();  
    }
    IEnumerator WaitForDataLoad()
    {
        yield return new WaitForSeconds(0.8f);

        ABI_Temp = ABI_IMP;
        Debug.Log("<color=#ec3dc1>ABI:</color>" + ABI_IMP[2]);
        SetData();
        SetAbility();
    }
    void ReloadData()
    {
        if (主要数据.Reload == true &&主要数据. AlreadyRead == true)
        {

            StartCoroutine(WaitForDataLoad());

            
        }
    }
    void SetData()
    {
        AbiPic.texture = ase64toString.Base64ToImg(ABI_IMP[0]);
        Characteristic.text=ABI_IMP[1];
        AbilityInput[0].text = ABI_Temp[2];
        AbilityInput[1].text = ABI_Temp[3];
        Debug.Log("<color=#ec3dc1>ABI:</color>" + ABI_IMP[2] + "+" + ABI_Static[3]);

        if (ABI_IMP[4] == "1")
        {
            SecAbilityOnOff.isOn = true;
        }
        else
        {
            SecAbilityOnOff.isOn = false;
        }
    }
}
