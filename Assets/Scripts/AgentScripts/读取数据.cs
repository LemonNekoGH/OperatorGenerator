using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;
using System;

[System.Serializable]
public class SaveGame
{
    #region 基础数据资源
    public List<string> BST_2bit;
    public List<string> MER_2bit;
    public List<string> OIT_2bit;
    public int Star_2bit;
    public string PIC_2bit;
    public List<double> PNS_2bit;
    public bool PL_2bit;
    #endregion
    #region 游戏界面
    public string DPIC2bit;
    public List<int> OPP2bit;
    public List<string> OPP2bit2;
    public  string CPLG2bit;
    public List<float> PPOS2bit;//x，y，缩放
    public List<string> TAG2bit;
    public int PRF2bit;
    public List<int> LVL2bit;
    public List<string> SKL12bit;////技能图片64码，技能起始【bool、数值】，技能需求【bool、数值】，技能名字
    public List<string> SKL22bit;
    public List<string> SKL32bit;

    #endregion
    #region 技能区域
    public  List <string> SDS_2bit;
    public List<int> SPT_2bit;
    public List<int> UST_2bit;
    public List<int> CD_2bit;
    public List<bool> CDU_2bit;


    #endregion
    public List <string> Abi_2bit;
}
public class 读取数据 : MonoBehaviour
{
    // 用于导出数据
    [DllImport("__Internal")]
    private static extern void JSExport(string data);

    public List<string> MonoName;
    private void Start()
    {
        //SaveBybin();
        //LoadByBin();
    }
    
    //读取数据 ReadBin =new 读取数据();
    public static bool Save=false;
    public static bool Load=false;

    private void Update()
    {
        if (Save == true)
        {
            Save = false;
            SaveBybin();
        }
        
        if(Load == true)
        {
            Load = false;
            LoadByBin();
        }
       
    }
    private string SavePath; 
    public bool AlreadyRead = false;//检测已经读取，保存将保存至原文档
    private string LoadPath;


    //调试

    public GameObject Savetip;
    public GameObject tipParent;
    public static string DebugStr;
    public static string STALoadPath;
    IEnumerator WaitForWrite()
    {
        yield return new WaitForSeconds(0.8f);
        if (AlreadyRead == false)
        {
            SavePath = Application.dataPath + "/" + "" + 主要数据.BSTstatic[0] + ".OGF";
        }
        else
        {
            SavePath = LoadPath;
        }

        SaveGame SVD = new SaveGame();
        #region 基础数据导出
        SVD.BST_2bit = 主要数据.BSTstatic;
        SVD.MER_2bit = 主要数据.MERstatic;
        SVD.OIT_2bit = 主要数据.OITstatic;
        SVD.PIC_2bit = 主要数据.PNGstatic;
        SVD.PNS_2bit = 主要数据.PNSpos;
        SVD.PL_2bit = 主要数据.PNGLock;
        SVD.Star_2bit = 主要数据.StarSta;
        #endregion
        #region 游戏界面数据导出

        SVD.DPIC2bit = 游戏界面数据.DataPicx64;
        SVD.OPP2bit = 游戏界面数据.OPP_static;
        SVD.OPP2bit2 = 游戏界面数据.OPP_static2;
        SVD.CPLG2bit = 游戏界面数据.CPLG_static;
        SVD.PPOS2bit = 游戏界面数据.PPOS_static;
        SVD.TAG2bit = 游戏界面数据.TAG_static;
        SVD.PRF2bit = 游戏界面数据.PRF_static;
        SVD.LVL2bit = 游戏界面数据.LVL_static;
        SVD.SKL12bit = 游戏界面数据.SKL1_static;
        SVD.SKL22bit = 游戏界面数据.SKL2_static;
        SVD.SKL32bit = 游戏界面数据.SKL3_static;
        SVD.Abi_2bit = 天赋区域.ABI_Static;

        Debug.Log("<color=#3decc9>数据：</color>" + SVD.Abi_2bit[1]);
        print("1");

        #endregion
        #region 技能界面
        SVD.SDS_2bit = 技能区域.SDS_STA;
        SVD.SPT_2bit = 技能区域.SPT_STA;
        SVD.UST_2bit = 技能区域.UST_STA;
        SVD.CD_2bit = 技能区域.CD_sta;
        SVD.CDU_2bit = 技能区域.CDU_sta;
        #endregion
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        // WebGL 平台导出方式
        if (Application.platform == RuntimePlatform.WebGLPlayer)
        {
            Debug.Log("检测到 WebGL 平台");
            // 新建内存流
            MemoryStream ms = new MemoryStream();
            // 将数据导入到内存中
            binaryFormatter.Serialize(ms, SVD);
            // 转成 Base64
            string base64GameData = Convert.ToBase64String(ms.ToArray());
            // 交给 JS 处理
            JSExport(base64GameData);
            // 关闭流
            ms.Close();
        } else
        {
            FileStream fileStream = File.Create(SavePath);
            binaryFormatter.Serialize(fileStream, SVD);
            STALoadPath = SavePath;
            Instantiate(Savetip, new Vector3(0, 4, 95), Quaternion.identity, tipParent.transform);
            fileStream.Close();
        }
        Debug.Log("已导出数据!");
        yield break;
    }
    public void SaveBybin()
    {
        StartCoroutine(WaitForWrite());
        
    }


    //接收导入的数据
    public List<string> BST;
    public List<string> MER;
    public List<string> OIT;
    public string PIC;
    public List<double> PNS;
    public bool PL;
    public int STAR;
    //--------------
    public string DPI;
    public List<int> OPP;
    public List<string> OPP2;
    public string CPLG;
    public List<float> PPOS;//x，y，缩放
    public List<string> TAG;
    public int PRF;
    public List<int> LVL;
    public List<string> SKL1;////技能图片64码，技能起始【bool、数值】，技能需求【bool、数值】，技能名字
    public List<string> SKL2;
    public List<string> SKL3;
    public List<string> ABI;
    //--------------

    public List<string> SDS;
    public List<int> SPT;
    public List<int> UST;
    public List<int> CD;
    public List<bool> CDU;
    //--------------
    private string OpenOGFFileType = "OGF文件(.OGF)\0*.OGF\0\0";//文件保存类型--》Fileopen.cs
    private string OpenOGFTitle = "打开干员档案";//文件打开窗口标题
    private string OGFType = "OGF";//？

    
    public void LoadByBin() 
    {
        AlreadyRead = true;
        LoadPath = FileOpen.OpenFile(OpenOGFFileType, OpenOGFTitle, OGFType);
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        FileStream fileStream = File.Open(LoadPath,FileMode.Open);
        SaveGame LDD=(SaveGame)binaryFormatter.Deserialize(fileStream);
        fileStream.Close();
        Debug.Log("<color=#3dec3d>准备读取主要数据资源</color>");

        #region  主要数据资源
        BST = LDD.BST_2bit;
        MER=LDD.MER_2bit;
        OIT = LDD.OIT_2bit;
        PIC=LDD.PIC_2bit;
        PNS = LDD.PNS_2bit;
        PL=LDD.PL_2bit;
        STAR = LDD.Star_2bit;
        #endregion
        Debug.Log("<color=#3dec3d>准备读取游戏界面数据</color>");

        #region 游戏界面数据导出
        DPI = LDD.DPIC2bit;
        OPP = LDD.OPP2bit;
        OPP2 = LDD.OPP2bit2;
        CPLG = LDD.CPLG2bit;
        PPOS = LDD.PPOS2bit; 
        TAG = LDD.TAG2bit;
        PRF = LDD.PRF2bit;
        LVL=LDD.LVL2bit;
        SKL1 = LDD.SKL12bit;
        SKL2 = LDD.SKL22bit;
        SKL3 = LDD.SKL32bit;
        ABI = LDD.Abi_2bit;

        #endregion
        #region 技能界面
        SDS= LDD.SDS_2bit;
        SPT = LDD.SPT_2bit;
        UST = LDD.UST_2bit;
        CD= LDD.CD_2bit;
        CDU= LDD.CDU_2bit;
        #endregion
        Debug.Log("<color=#3dec3d>准备覆盖数据,ABI:</color>"+ABI[1]+"+"+LDD.Abi_2bit[1]);
        if (BST!= null)
        {
            CoverMainData();
            Debug.Log("Loaded!");
        }
        主要数据.AlreadyRead = true;
        //LoadedString = saveGame.Name[0].ToString();
        //Debug.Log(LoadedString);
    }
    //--------将导入数据覆盖到主要数据
    public void CoverMainData()
    {
        主要数据.BST_IMP = BST;
        主要数据.MER_IMP = MER;
        主要数据.OIT_IMP = OIT;
        主要数据.PIC_IMP = PIC;
        主要数据.PNS_IMP = PNS;
        主要数据.PL_IMP = PL;
        主要数据.STAR_IMP = STAR;
        //----------------------
        游戏界面数据.DPI_IMP = DPI;
        游戏界面数据.OPP_IMP = OPP;
        游戏界面数据.OPP_IMP2 = OPP2;
        游戏界面数据.CPLG_IMP = CPLG;
        游戏界面数据.PPOS_IMP = PPOS;
        游戏界面数据.TAG_IMP = TAG;
        游戏界面数据.PRF_IMP = PRF;
        游戏界面数据.LVL_IMP=LVL;
        游戏界面数据.SKL1_IMP = SKL1;
        游戏界面数据.SKL2_IMP = SKL2;
        游戏界面数据.SKL3_IMP = SKL3;
        //-----------------------
        技能区域.SDS_IMP = SDS;
        技能区域.SPT_IMP = SPT;
        技能区域.UST_IMP=UST;
        技能区域.CDU_IMP = CDU;
        技能区域.CD_IMP = CD;

        天赋区域.ABI_IMP = ABI;
        Debug.Log("<color=#3dec3d>数据已覆盖</color>"+ABI[1]+"+"+ 天赋区域.ABI_IMP[1]);
    }
}
