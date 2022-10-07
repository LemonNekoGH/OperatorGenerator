using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
class Avalator//新建存档类名-声明有一下要存储的变量
{
    public List<string> JsonBST;
    public List<string> JsonMER;
    public List<string> JsonOIT;
    public string JsonPNG;
}
[System.Serializable]
class AvaData//初始化数据，生成新的数据文件-新建一个class类
{
    public Avalator[] avalators;
}

public class 主要数据 : MonoBehaviour
{




    public Button ExportBtn;
    //public Button LoadButton;
    public Toggle LockToggle;//锁定toggle
    public GameObject Operator;
    public Slider ScaleSlider;//缩放滑动条
    public Slider StarSlider;//星星滑动条
    private Vector3 OperatorStandardSacle = new Vector3(1, 1, 1);


    public InputField NameInput;


    #region 修改和保存数据到内存

    public Button Savebutton;
    public Button LoadPngbtn;  //图片
    public Button Importbtn;
    public Text OperatorNameText;

    private void Start()
    {
        NameInput.onEndEdit.AddListener((string s) => { SaveDataSta(); });
        BaseDataText[0].onValueChanged.AddListener((string input) => {OperatorNameText.text = input;游戏界面数据.NameChanged = true; });
        //Initialization();
        //BaseDataString.Capacity = BaseDataText.Count;
        //Savebutton.onClick.AddListener(() => { SaveDataSta(); Debug.Log("Saved!"); }) ;
        //LoadPngbtn.onClick.AddListener(() => { LoadPicture(); }); 
        ExportBtn.onClick.AddListener(() => { SaveDataSta(); });
        Importbtn.onClick.AddListener(() => {});
        LockToggle.onValueChanged.AddListener((bool Lock) => {PicLock=Lock;SaveDataSta(); } );
        ScaleSlider.onValueChanged.AddListener((float Scale) => { SetPicScale(Scale); });
        StarSlider.onValueChanged.AddListener((float star) => { Stars = (int)star; });
        SetImportDataCount();
        

    }
    public void ImportData()
    {
        Debug.Log("准备读取"); 读取数据.Load = true; Reload = true; 游戏界面数据.CoverData = true;
    }
    #region 文本信息
    //-------------------干员档案--------------------//
    public List<InputField> BaseDataText;
    public List<string> BaseDataString;
    public int Stars;
    //------------------综合体检---------------------//
    public List<InputField> Medical_Examination_ReportText;
    public List<string> Medical_Examination;
    //------------------其他信息---------------------//
    public List<InputField> OutherInfoText;
    public List <string> OutherInfo;


    #endregion

    //------------------静态变量---------------------//
    public  static List<string> BSTstatic;
    public static List<string> MERstatic;
    public static List <string> OITstatic;
    public static int StarSta;

    #region //------------------立绘保存---------------------//    立绘打开窗口传入
    //------------->图片相关
    public static string PNGstatic;
    public static List<double> PNSpos; //x-y-scale
    public static bool PNGLock;
    private string OpenPicFileType = "图片文件(.png)\0*.png\0图片文件(.jpg)\0*.jpg\0All Files\0*.*\0\0";//文件保存类型--》Fileopen.cs
    private string OpenPicTitle = "打开图片";//文件打开窗口标题
    private string PicType = "png";//？
    #endregion
    #region 立绘数据
    public RawImage OperatorPic;//原avalaterpic
    private string AvalterPic_x64="re90";//base64码图片
    private string AvalterPicPath;
    public List<double> AvalterPicPos;//图片x-y与缩放
    private bool PicLock;//锁定位置
    public RawImage DataPic;
    

    public void LoadPicture()//载入图片
    {
       AvalterPicPath= FileOpen.OpenFile(OpenPicFileType,OpenPicTitle,PicType);
       AvalterPic_x64= ase64toString.ImgToBase64String(AvalterPicPath);
        OperatorPic.texture = ase64toString.Base64ToImg(AvalterPic_x64);
        OperatorPic.GetComponent<RectTransform>().sizeDelta = new Vector2(OperatorPic.texture.width, OperatorPic.texture.height);
        DataPic.texture =OperatorPic.texture;
        DataPic.GetComponent<RectTransform>().sizeDelta = new Vector2(DataPic.texture.width, DataPic.texture.height);

        游戏界面数据.DataPicx64 = AvalterPic_x64;
    }
    public void SetPicScale(float scale)
    {
        //Debug.Log(scale);
        OperatorPic.transform.localScale = new Vector3(scale,scale,scale);
    }
    public void SetPicPos()
    {
        AvalterPicPos[0]=Operator.GetComponent<Transform>().position.x;
        AvalterPicPos[1]=Operator.GetComponent<Transform>().position.y;
        AvalterPicPos[2] = ScaleSlider.value;
        

    }

    #endregion




    #region//------------------保存模块---------------------//
    private string Temporary;
    private string Temporary_MER;
    private string Temporary_OIT;
    private static bool SaveIt=false;
    public static void SaveDataSta()
    {
        SaveIt = true;
        
    }
    public void SaveAllData()
    {
        //GetSavePath();
        //-----保存文本-----//
        if (SaveIt == true)
        {
            if (SaveIt == true)
            {
                PNGstatic = AvalterPic_x64;
                PNSpos = AvalterPicPos;
                PNGLock = PicLock;
                PNSpos = AvalterPicPos;
                Debug.Log("<color=#3decc9>位置已导入</color>");
                Debug.Log("<color=#3decc9>图片已导入</color>");
            }
            SaveIt = false;
            for (int i = 0; i < BaseDataText.Count; i++)
            {
                Temporary = BaseDataText[i].text;
                BaseDataString[i] = Temporary;
            }
            for (int i = 0; i < Medical_Examination_ReportText.Count; i++)
            {
                Temporary_MER = Medical_Examination_ReportText[i].text;
                Medical_Examination[i] = Temporary_MER;
            }
            for (int j = 0; j < OutherInfoText.Count; j++)
            {
                Temporary_OIT = OutherInfoText[j].text;
                OutherInfo[j] = Temporary_OIT;

            }
            BSTstatic = BaseDataString;
            MERstatic = Medical_Examination;
            OITstatic = OutherInfo;
            StarSta = Stars;
        }
        //-----保存图片-----//
       
        
    }
   
    #endregion
    #region//------------------导入模块---------------------//
    public static List<string> BST_IMP;
    public static List<string> MER_IMP;
    public static List<string> OIT_IMP;
    public static string PIC_IMP;
    public static List<double> PNS_IMP;
    public static bool PL_IMP;
    public static int STAR_IMP;

    public static bool AlreadyRead=false;
    private void SetImportDataCount()
    {
        BST_IMP.Capacity = 9;
        MER_IMP.Capacity = 6;
        OITstatic.Capacity = 3;
    }
    //------------------重载数据---------------------//
    public static bool Reload = false;
    IEnumerator WaitForDataLoad()
    {
       
        yield return new WaitForSeconds(1);
        AlreadyRead = false;
        Reload = false;

        AlreadyRead = false;
        Reload = false;
        Debug.Log("<color=#ecd53d>准备覆盖数据</color>");


        #region 将存档导入动态变量
        BaseDataString = BST_IMP;
        Medical_Examination = MER_IMP;
        OutherInfo = OIT_IMP;
        PNGstatic = PIC_IMP;
        PNSpos = PNS_IMP;
        PNGLock = PL_IMP;
        StarSta = STAR_IMP;
        Debug.Log("<color=#ecd53d>主要数据已导入</color>");
        Debug.Log(BST_IMP);
        #endregion
        #region 文本部分内容更新
        for (int i = 0; i < BaseDataText.Count; i++)
        {
            BaseDataText[i].text = BST_IMP[i];
        }
        for (int i = 0; i < Medical_Examination_ReportText.Count; i++)
        {
            Medical_Examination_ReportText[i].text = MER_IMP[i];
        }
        for (int i = 0; i < OutherInfoText.Count; i++)
        {
            OutherInfoText[i].text = OIT_IMP[i];
        }
        #endregion
        OperatorPic.texture = ase64toString.Base64ToImg(游戏界面数据.DataPicx64);
        AvalterPic_x64 = PNGstatic;
        游戏界面数据.DataPic = AvalterPic_x64;
        Debug.Log("<color=#3decc9>图片已重载</color>");

        OperatorPic.GetComponent<RectTransform>().sizeDelta = new Vector2(OperatorPic.texture.width, OperatorPic.texture.height);
        OperatorPic.transform.localScale = new Vector3((float)PNSpos[2], (float)PNSpos[2], (float)PNSpos[2]);
        ScaleSlider.value = (float)PNSpos[2];
        StarSlider.value = StarSta;
        Operator.GetComponent<Transform>().position = new Vector3((float)PNSpos[0], (float)PNSpos[1], Operator.transform.position.z);

        // = 
        SaveDataSta();
        AlreadyRead = false;
        Reload = false;
        Debug.Log("<color=#ecd53d>执行结束</color>");
        yield break;


    }
    public void ReloadData()
    {
        if (Reload == true && AlreadyRead == true)
        {
            AlreadyRead = false;
            Reload = false;
            StartCoroutine(WaitForDataLoad());


        }
    }

    private void MainReload()
    {

    }
    #endregion
    private void Update()
    {
        SaveAllData();
        SetPicPos();
        ReloadData()
            ;
        SetPicScale(ScaleSlider.value);
    }
    #endregion
   
}
