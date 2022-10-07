using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class 游戏界面数据 : MonoBehaviour
{
    #region 变量区域
    public static string DataPicx64= "iVBORw0KGgoAAAANSUhEUgAAAIAAAACACAYAAADDPmHLAAAACXBIWXMAAA7EAAAOxAGVKw4bAAAF0WlUWHRYTUw6Y29tLmFkb2JlLnhtcAAAAAAAPD94cGFja2V0IGJlZ2luPSLvu78iIGlkPSJXNU0wTXBDZWhpSHpyZVN6TlRjemtjOWQiPz4gPHg6eG1wbWV0YSB4bWxuczp4PSJhZG9iZTpuczptZXRhLyIgeDp4bXB0az0iQWRvYmUgWE1QIENvcmUgNS42LWMxNDUgNzkuMTYzNDk5LCAyMDE4LzA4LzEzLTE2OjQwOjIyICAgICAgICAiPiA8cmRmOlJERiB4bWxuczpyZGY9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkvMDIvMjItcmRmLXN5bnRheC1ucyMiPiA8cmRmOkRlc2NyaXB0aW9uIHJkZjphYm91dD0iIiB4bWxuczp4bXA9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC8iIHhtbG5zOnhtcE1NPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvbW0vIiB4bWxuczpzdEV2dD0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL3NUeXBlL1Jlc291cmNlRXZlbnQjIiB4bWxuczpkYz0iaHR0cDovL3B1cmwub3JnL2RjL2VsZW1lbnRzLzEuMS8iIHhtbG5zOnBob3Rvc2hvcD0iaHR0cDovL25zLmFkb2JlLmNvbS9waG90b3Nob3AvMS4wLyIgeG1wOkNyZWF0b3JUb29sPSJBZG9iZSBQaG90b3Nob3AgQ0MgMjAxOSAoV2luZG93cykiIHhtcDpDcmVhdGVEYXRlPSIyMDIyLTAxLTIyVDIwOjE4OjU0KzA4OjAwIiB4bXA6TWV0YWRhdGFEYXRlPSIyMDIyLTAxLTIyVDIwOjE4OjU0KzA4OjAwIiB4bXA6TW9kaWZ5RGF0ZT0iMjAyMi0wMS0yMlQyMDoxODo1NCswODowMCIgeG1wTU06SW5zdGFuY2VJRD0ieG1wLmlpZDo5ZjY5OGM2Yy0zNzg5LTk5NGUtOGQ5OC1mMGNlMGMzODI1MmIiIHhtcE1NOkRvY3VtZW50SUQ9ImFkb2JlOmRvY2lkOnBob3Rvc2hvcDo5MWY0ODkzYy0yMzZhLTU0NGMtYmIyNS0zMDcxODMzZWMzOTIiIHhtcE1NOk9yaWdpbmFsRG9jdW1lbnRJRD0ieG1wLmRpZDoyYzY3MzgyNC0xMDU3LTkxNDMtOWQxOC1mZmE4M2MwNDg3ZjEiIGRjOmZvcm1hdD0iaW1hZ2UvcG5nIiBwaG90b3Nob3A6Q29sb3JNb2RlPSIzIj4gPHhtcE1NOkhpc3Rvcnk+IDxyZGY6U2VxPiA8cmRmOmxpIHN0RXZ0OmFjdGlvbj0iY3JlYXRlZCIgc3RFdnQ6aW5zdGFuY2VJRD0ieG1wLmlpZDoyYzY3MzgyNC0xMDU3LTkxNDMtOWQxOC1mZmE4M2MwNDg3ZjEiIHN0RXZ0OndoZW49IjIwMjItMDEtMjJUMjA6MTg6NTQrMDg6MDAiIHN0RXZ0OnNvZnR3YXJlQWdlbnQ9IkFkb2JlIFBob3Rvc2hvcCBDQyAyMDE5IChXaW5kb3dzKSIvPiA8cmRmOmxpIHN0RXZ0OmFjdGlvbj0ic2F2ZWQiIHN0RXZ0Omluc3RhbmNlSUQ9InhtcC5paWQ6OWY2OThjNmMtMzc4OS05OTRlLThkOTgtZjBjZTBjMzgyNTJiIiBzdEV2dDp3aGVuPSIyMDIyLTAxLTIyVDIwOjE4OjU0KzA4OjAwIiBzdEV2dDpzb2Z0d2FyZUFnZW50PSJBZG9iZSBQaG90b3Nob3AgQ0MgMjAxOSAoV2luZG93cykiIHN0RXZ0OmNoYW5nZWQ9Ii8iLz4gPC9yZGY6U2VxPiA8L3htcE1NOkhpc3Rvcnk+IDwvcmRmOkRlc2NyaXB0aW9uPiA8L3JkZjpSREY+IDwveDp4bXBtZXRhPiA8P3hwYWNrZXQgZW5kPSJyIj8+Bxet1gAAAmVJREFUeJzt3GFOg0AQQOHBeAPv08P3Pp5h/SPJikUrZbvOvPclTTUxQDKPBZu2S2stxPUy+wA0lwHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwL3OPoDfvF8usw/hi7frdfYhnIqyAiyfD238+xXggGXn5/73/lsx0N+QUSmAZef5XsgQKgRwZPB7f4OLIHsA/bX96DV+e8loAQoh803gsnmcsb1+uwhZAzhz8Nvt9tsvL2MAo4bfbx8j+z3AKH0Epe8HsgUw+uzf7mtVNoJslwDU8vwMmQJ49N+9o/ssHV2mAGYqG0GmAMqfjTNkCmCW0tFlCWD2EGbvf5gsAWgQA4AzALgsAcx+JW72/ofJEsBMZYcfkSsA1Bs1niVTADOVDS9TAG3z/Kx9lh1+RK4AIooPY4Zs7wfoAxj96lwLVwAsxPAj8q0AEeNXgfJD72UMIGJcBP2NJiKErAFEfB/QoyH0Q0cMPyJ3ABG3B3X0M4GYs76XPYCI/aH9FMKtTwfjhh9RI4DVdoAt7vsQKHLwq0oBrBzuH/g6ANzSmicJmSsAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwH0Aa988HpqvVMUAAAAASUVORK5CYII=";//游戏数据区立绘64码
    public  List<int> OpProperties;//生命，攻击，防御，cost，阻挡
    public List<string> OpProp2;//在部署，攻速
    public string OpCamp_x64;//阵营图片64码
    public int Profession;//职业
    public int Potential;//潜能（1-6）
    public List<float> PicPostion;//x，y，，缩放
    public List<string> OpTag;//tag1,tag2
    public List<int> OpLevel;//最大等级，当前等级，最大经验，当前经验
    public int SkillRank;//等级
    public List<string> OpSkill1;//技能图片64码，技能起始【bool、数值】，技能需求【bool、数值】，技能名字
    public List<string> OpSkill2;
    public List<string> OpSkill3;
    public List<string> Ability;//天赋 分支文本，天赋1，2名字
    #endregion

    #region 游戏组件
    public Button ExportBtn;
    public Button SaveBtn;//save按钮
    public Slider StarSlider;
    public List<Sprite> StarTex;

    public Slider PicScaleSli;//缩放滑动条
    public RawImage OperatorPic;//立绘
    public GameObject OperatorPicParent;//立绘
    public List<InputField> Input_Prop;//数字属性
    public List<InputField> Input_Prop2;//文本属性
    public Button InputCLogo;//阵营图标导入
    public Button ICLbtn;
    public RawImage CampLogo;//阵营图标
    public Dropdown Input_Prf;//职业选择
    public List<Texture> PrfImg;
    public RawImage PrfLogo;
    public List <InputField> Input_Tag;//tag 输入
    public List <InputField> Input_OpLevel;//等级相关
    public List <Text> OpLevel_text;//非经验text （最大等级。当前等级）
    public Text OpLevelEXP;//123/456 经验text
    public Button Save_ChangeLevel;//保存等级修改
    public Button InputPotential;//潜能按钮
    public Image PotentialLogo;//潜能图标
    //public List<InputField> Input_Ability;//天赋1，2的名字，描述--名字/描述/名字/描述
    public Dropdown Input_AbiLogo;//天赋logo输入
    //-------------天赋区域--------------//
    public bool 一一一一一分割线一一一一一一一一一;
    public Button LoadAbilityLogo;// 天赋logox64
    public RawImage AbilityPic;
    public InputField AbilityType;//分支种类
    public List<InputField> AbilityName;//天赋名字
    public bool 一一一一一分割线一一一一一一一一一一;
    //-------------技能区域--------------//
    public InputField Input_Rank;
    public bool 一一一一一分割线一一一一一一;
    #region 一技能组件
    public Button Skl1_ImgSelBtn;
    public RawImage Skl1_Img;
    public string Skl1_Img64;
    public List<Toggle> Skl1_Toggle;
    public List<InputField> Skl1_SP;
    public InputField Skl1_Name;
    #endregion
    public bool 一一一一一分割线一一一一一一一;
    #region 二技能组件
    public Button Skl2_ImgSelBtn;
    public RawImage Skl2_Img;
    public string Skl2_Img64;
    public List<Toggle> Skl2_Toggle;
    public List<InputField> Skl2_SP;
    public InputField Skl2_Name;
    #endregion
    public bool 一一一一一分割线一一一一一一一一;
    #region 3技能组件
    public Button Skl3_ImgSelBtn;
    public RawImage Skl3_Img;
    public string Skl3_Img64;
    public List<Toggle> Skl3_Toggle;
    public List<InputField> Skl3_SP;
    public InputField Skl3_Name;
    #endregion
    public bool 一一一一一分割线一一一一一一一一一一一;

    //-------------调用其他面板的-------------//
    public static bool NameChanged=false;
    public Image StarImg;
    public InputField CHinput;
    public InputField ENinput;
    public Text EngName;
    public Text ChName;
    #endregion
    #region 静态变量
    public static string DataPic = "iVBORw0KGgoAAAANSUhEUgAAAIAAAACACAYAAADDPmHLAAAACXBIWXMAAA7EAAAOxAGVKw4bAAAF0WlUWHRYTUw6Y29tLmFkb2JlLnhtcAAAAAAAPD94cGFja2V0IGJlZ2luPSLvu78iIGlkPSJXNU0wTXBDZWhpSHpyZVN6TlRjemtjOWQiPz4gPHg6eG1wbWV0YSB4bWxuczp4PSJhZG9iZTpuczptZXRhLyIgeDp4bXB0az0iQWRvYmUgWE1QIENvcmUgNS42LWMxNDUgNzkuMTYzNDk5LCAyMDE4LzA4LzEzLTE2OjQwOjIyICAgICAgICAiPiA8cmRmOlJERiB4bWxuczpyZGY9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkvMDIvMjItcmRmLXN5bnRheC1ucyMiPiA8cmRmOkRlc2NyaXB0aW9uIHJkZjphYm91dD0iIiB4bWxuczp4bXA9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC8iIHhtbG5zOnhtcE1NPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvbW0vIiB4bWxuczpzdEV2dD0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL3NUeXBlL1Jlc291cmNlRXZlbnQjIiB4bWxuczpkYz0iaHR0cDovL3B1cmwub3JnL2RjL2VsZW1lbnRzLzEuMS8iIHhtbG5zOnBob3Rvc2hvcD0iaHR0cDovL25zLmFkb2JlLmNvbS9waG90b3Nob3AvMS4wLyIgeG1wOkNyZWF0b3JUb29sPSJBZG9iZSBQaG90b3Nob3AgQ0MgMjAxOSAoV2luZG93cykiIHhtcDpDcmVhdGVEYXRlPSIyMDIyLTAxLTIyVDIwOjE4OjU0KzA4OjAwIiB4bXA6TWV0YWRhdGFEYXRlPSIyMDIyLTAxLTIyVDIwOjE4OjU0KzA4OjAwIiB4bXA6TW9kaWZ5RGF0ZT0iMjAyMi0wMS0yMlQyMDoxODo1NCswODowMCIgeG1wTU06SW5zdGFuY2VJRD0ieG1wLmlpZDo5ZjY5OGM2Yy0zNzg5LTk5NGUtOGQ5OC1mMGNlMGMzODI1MmIiIHhtcE1NOkRvY3VtZW50SUQ9ImFkb2JlOmRvY2lkOnBob3Rvc2hvcDo5MWY0ODkzYy0yMzZhLTU0NGMtYmIyNS0zMDcxODMzZWMzOTIiIHhtcE1NOk9yaWdpbmFsRG9jdW1lbnRJRD0ieG1wLmRpZDoyYzY3MzgyNC0xMDU3LTkxNDMtOWQxOC1mZmE4M2MwNDg3ZjEiIGRjOmZvcm1hdD0iaW1hZ2UvcG5nIiBwaG90b3Nob3A6Q29sb3JNb2RlPSIzIj4gPHhtcE1NOkhpc3Rvcnk+IDxyZGY6U2VxPiA8cmRmOmxpIHN0RXZ0OmFjdGlvbj0iY3JlYXRlZCIgc3RFdnQ6aW5zdGFuY2VJRD0ieG1wLmlpZDoyYzY3MzgyNC0xMDU3LTkxNDMtOWQxOC1mZmE4M2MwNDg3ZjEiIHN0RXZ0OndoZW49IjIwMjItMDEtMjJUMjA6MTg6NTQrMDg6MDAiIHN0RXZ0OnNvZnR3YXJlQWdlbnQ9IkFkb2JlIFBob3Rvc2hvcCBDQyAyMDE5IChXaW5kb3dzKSIvPiA8cmRmOmxpIHN0RXZ0OmFjdGlvbj0ic2F2ZWQiIHN0RXZ0Omluc3RhbmNlSUQ9InhtcC5paWQ6OWY2OThjNmMtMzc4OS05OTRlLThkOTgtZjBjZTBjMzgyNTJiIiBzdEV2dDp3aGVuPSIyMDIyLTAxLTIyVDIwOjE4OjU0KzA4OjAwIiBzdEV2dDpzb2Z0d2FyZUFnZW50PSJBZG9iZSBQaG90b3Nob3AgQ0MgMjAxOSAoV2luZG93cykiIHN0RXZ0OmNoYW5nZWQ9Ii8iLz4gPC9yZGY6U2VxPiA8L3htcE1NOkhpc3Rvcnk+IDwvcmRmOkRlc2NyaXB0aW9uPiA8L3JkZjpSREY+IDwveDp4bXBtZXRhPiA8P3hwYWNrZXQgZW5kPSJyIj8+Bxet1gAAAmVJREFUeJzt3GFOg0AQQOHBeAPv08P3Pp5h/SPJikUrZbvOvPclTTUxQDKPBZu2S2stxPUy+wA0lwHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwL3OPoDfvF8usw/hi7frdfYhnIqyAiyfD238+xXggGXn5/73/lsx0N+QUSmAZef5XsgQKgRwZPB7f4OLIHsA/bX96DV+e8loAQoh803gsnmcsb1+uwhZAzhz8Nvt9tsvL2MAo4bfbx8j+z3AKH0Epe8HsgUw+uzf7mtVNoJslwDU8vwMmQJ49N+9o/ssHV2mAGYqG0GmAMqfjTNkCmCW0tFlCWD2EGbvf5gsAWgQA4AzALgsAcx+JW72/ofJEsBMZYcfkSsA1Bs1niVTADOVDS9TAG3z/Kx9lh1+RK4AIooPY4Zs7wfoAxj96lwLVwAsxPAj8q0AEeNXgfJD72UMIGJcBP2NJiKErAFEfB/QoyH0Q0cMPyJ3ABG3B3X0M4GYs76XPYCI/aH9FMKtTwfjhh9RI4DVdoAt7vsQKHLwq0oBrBzuH/g6ANzSmicJmSsAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwH0Aa988HpqvVMUAAAAASUVORK5CYII=";
    public static List<int> OPP_static;
    public static List<string> OPP_static2;
    public static string CPLG_static= "iVBORw0KGgoAAAANSUhEUgAAAIAAAACACAYAAADDPmHLAAAACXBIWXMAAA7EAAAOxAGVKw4bAAAF0WlUWHRYTUw6Y29tLmFkb2JlLnhtcAAAAAAAPD94cGFja2V0IGJlZ2luPSLvu78iIGlkPSJXNU0wTXBDZWhpSHpyZVN6TlRjemtjOWQiPz4gPHg6eG1wbWV0YSB4bWxuczp4PSJhZG9iZTpuczptZXRhLyIgeDp4bXB0az0iQWRvYmUgWE1QIENvcmUgNS42LWMxNDUgNzkuMTYzNDk5LCAyMDE4LzA4LzEzLTE2OjQwOjIyICAgICAgICAiPiA8cmRmOlJERiB4bWxuczpyZGY9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkvMDIvMjItcmRmLXN5bnRheC1ucyMiPiA8cmRmOkRlc2NyaXB0aW9uIHJkZjphYm91dD0iIiB4bWxuczp4bXA9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC8iIHhtbG5zOnhtcE1NPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvbW0vIiB4bWxuczpzdEV2dD0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL3NUeXBlL1Jlc291cmNlRXZlbnQjIiB4bWxuczpkYz0iaHR0cDovL3B1cmwub3JnL2RjL2VsZW1lbnRzLzEuMS8iIHhtbG5zOnBob3Rvc2hvcD0iaHR0cDovL25zLmFkb2JlLmNvbS9waG90b3Nob3AvMS4wLyIgeG1wOkNyZWF0b3JUb29sPSJBZG9iZSBQaG90b3Nob3AgQ0MgMjAxOSAoV2luZG93cykiIHhtcDpDcmVhdGVEYXRlPSIyMDIyLTAxLTIyVDIwOjE4OjU0KzA4OjAwIiB4bXA6TWV0YWRhdGFEYXRlPSIyMDIyLTAxLTIyVDIwOjE4OjU0KzA4OjAwIiB4bXA6TW9kaWZ5RGF0ZT0iMjAyMi0wMS0yMlQyMDoxODo1NCswODowMCIgeG1wTU06SW5zdGFuY2VJRD0ieG1wLmlpZDo5ZjY5OGM2Yy0zNzg5LTk5NGUtOGQ5OC1mMGNlMGMzODI1MmIiIHhtcE1NOkRvY3VtZW50SUQ9ImFkb2JlOmRvY2lkOnBob3Rvc2hvcDo5MWY0ODkzYy0yMzZhLTU0NGMtYmIyNS0zMDcxODMzZWMzOTIiIHhtcE1NOk9yaWdpbmFsRG9jdW1lbnRJRD0ieG1wLmRpZDoyYzY3MzgyNC0xMDU3LTkxNDMtOWQxOC1mZmE4M2MwNDg3ZjEiIGRjOmZvcm1hdD0iaW1hZ2UvcG5nIiBwaG90b3Nob3A6Q29sb3JNb2RlPSIzIj4gPHhtcE1NOkhpc3Rvcnk+IDxyZGY6U2VxPiA8cmRmOmxpIHN0RXZ0OmFjdGlvbj0iY3JlYXRlZCIgc3RFdnQ6aW5zdGFuY2VJRD0ieG1wLmlpZDoyYzY3MzgyNC0xMDU3LTkxNDMtOWQxOC1mZmE4M2MwNDg3ZjEiIHN0RXZ0OndoZW49IjIwMjItMDEtMjJUMjA6MTg6NTQrMDg6MDAiIHN0RXZ0OnNvZnR3YXJlQWdlbnQ9IkFkb2JlIFBob3Rvc2hvcCBDQyAyMDE5IChXaW5kb3dzKSIvPiA8cmRmOmxpIHN0RXZ0OmFjdGlvbj0ic2F2ZWQiIHN0RXZ0Omluc3RhbmNlSUQ9InhtcC5paWQ6OWY2OThjNmMtMzc4OS05OTRlLThkOTgtZjBjZTBjMzgyNTJiIiBzdEV2dDp3aGVuPSIyMDIyLTAxLTIyVDIwOjE4OjU0KzA4OjAwIiBzdEV2dDpzb2Z0d2FyZUFnZW50PSJBZG9iZSBQaG90b3Nob3AgQ0MgMjAxOSAoV2luZG93cykiIHN0RXZ0OmNoYW5nZWQ9Ii8iLz4gPC9yZGY6U2VxPiA8L3htcE1NOkhpc3Rvcnk+IDwvcmRmOkRlc2NyaXB0aW9uPiA8L3JkZjpSREY+IDwveDp4bXBtZXRhPiA8P3hwYWNrZXQgZW5kPSJyIj8+Bxet1gAAAmVJREFUeJzt3GFOg0AQQOHBeAPv08P3Pp5h/SPJikUrZbvOvPclTTUxQDKPBZu2S2stxPUy+wA0lwHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwL3OPoDfvF8usw/hi7frdfYhnIqyAiyfD238+xXggGXn5/73/lsx0N+QUSmAZef5XsgQKgRwZPB7f4OLIHsA/bX96DV+e8loAQoh803gsnmcsb1+uwhZAzhz8Nvt9tsvL2MAo4bfbx8j+z3AKH0Epe8HsgUw+uzf7mtVNoJslwDU8vwMmQJ49N+9o/ssHV2mAGYqG0GmAMqfjTNkCmCW0tFlCWD2EGbvf5gsAWgQA4AzALgsAcx+JW72/ofJEsBMZYcfkSsA1Bs1niVTADOVDS9TAG3z/Kx9lh1+RK4AIooPY4Zs7wfoAxj96lwLVwAsxPAj8q0AEeNXgfJD72UMIGJcBP2NJiKErAFEfB/QoyH0Q0cMPyJ3ABG3B3X0M4GYs76XPYCI/aH9FMKtTwfjhh9RI4DVdoAt7vsQKHLwq0oBrBzuH/g6ANzSmicJmSsAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwBkAnAHAGQCcAcAZAJwBwH0Aa988HpqvVMUAAAAASUVORK5CYII=";
    //阵营logox64
    public static List<float> PPOS_static;//x，y，缩放
    public static List<string> TAG_static;
    public static int PRF_static;
    static public List<int> LVL_static;
    public static List<string> SKL1_static;////技能图片64码，技能起始【bool、数值】，技能需求【bool、数值】，技能名字
    public static List<string> SKL2_static;
    public static List<string> SKL3_static;
    public static List<string> ABI_static;//天赋-------------去别的脚本了------------------------[图片，天赋文本，天赋1文本，天赋2启用、文本。
    #endregion
    #region 缓存
    private int OPP_Temp;
    private string OPP2_Temp;
    private string Tag_Temp;
    private int Level_Temp;
    private static string Skl1_Temp="";
    private float PPos_Temp;
    private string Skl2_Temp;
    private string Skl3_Temp;
    private string ABI_Temp;

    #endregion
    private void Start()
    {
        //ChangeCampLogo();
        ExportBtn.onClick.AddListener(() => { GameViewSave = true;Debug.Log("Ready to save"); });
        SaveBtn.onClick.AddListener(() => SaveGameData());
        Input_Prf.onValueChanged.AddListener((int select) => { PrfLogo.texture = PrfImg[select];PRF_static = select;Debug.Log("<color=#0096ff>PRF Saved!</color>"); });
        StarSlider.onValueChanged.AddListener((float select) => { StarImg.sprite = StarTex[(int)select]; });
        InputCLogo.onClick.AddListener(() => { Debug.Log("ReadyToChangeLogo"); ChangeCampLogo(); });
        //ICLbtn.onClick.AddListener(() => { Debug.Log("123"); }); 
        //Save_ChangeLevel.onClick.AddListener(() => {  SetLevelData();/* SaveGameData(); */});
        PicScaleSli.onValueChanged.AddListener((float scale) => { OperatorPic.gameObject.transform.localScale = new Vector3(scale, scale, scale); });

        Skl1_ImgSelBtn.onClick.AddListener(() =>
        {
            Debug.Log("<color=#0096ff>准备写入图像64x</color>");
            string S1ImgPath = SKLimg2x64();
            Skl1_Img64 = ase64toString.ImgToBase64String(S1ImgPath);
            Skl1_Temp = Skl1_Img64;
            Skl1_Img.texture = ase64toString.Base64ToImg(Skl1_Img64);
            OpSkill1[0] = Skl1_Temp;
            Debug.Log("<color=#0096ff>图像64x已设置</color>");
             

        });

        Skl2_ImgSelBtn.onClick.AddListener(() =>
        {
            Debug.Log("<color=#0096ff>准备写入图像64x</color>");
            string S1ImgPath = SKLimg2x64();
            Skl2_Img64 = ase64toString.ImgToBase64String(S1ImgPath);
            Skl2_Temp = Skl2_Img64;
            Skl2_Img.texture = ase64toString.Base64ToImg(Skl2_Img64);
            OpSkill2[0] = Skl2_Temp;
            Debug.Log("<color=#0096ff>图像64x已设置</color>");


        });

        Skl3_ImgSelBtn.onClick.AddListener(() =>
        {
            Debug.Log("<color=#0096ff>准备写入图像64x</color>");
            string S1ImgPath = SKLimg2x64();
            Skl3_Img64 = ase64toString.ImgToBase64String(S1ImgPath);
            Skl3_Temp = Skl3_Img64;
            Skl3_Img.texture = ase64toString.Base64ToImg(Skl3_Img64);
            OpSkill3[0] = Skl3_Temp;
            Debug.Log("<color=#0096ff>图像64x已设置</color>");


        });

        

        CHinput.onValueChanged.AddListener((string s) => ChName.text = s);
        ENinput.onValueChanged.AddListener((string s) =>EngName.text = s);
    }
    private void Update()
    {
        

        SetPropData();
        
        if (CoverData == true)
        {
            CoverData = false;
            if (OPP_IMP!= null)
            {
                CoverThisData();
            }
        }
        if (NameChanged == true)
        {
           
           //SetName();
            //NameChanged = false;
        }
    }
    private void SetName()
    {
        //NameChanged = false;
        EngName.text = 主要数据.BSTstatic[1];
        ChName.text = 主要数据.BSTstatic[0];
       
    }
    private string OpenPicFileType = "图片文件(.png)\0*.png\0图片文件(.jpg)\0*.jpg\0All Files\0*.*\0\0";//文件保存类型--》Fileopen.cs
    private string OpenPicTitle = "打开图片";//文件打开窗口标题
    private string PicType = "png";//？
    private void ChangeCampLogo()
    {
        Debug.Log("open");
        string FilePath=FileOpen.OpenFile(OpenPicFileType,OpenPicTitle,PicType);
        OpCamp_x64 = ase64toString.ImgToBase64String(FilePath);
        CampLogo.texture=ase64toString.Base64ToImg(OpCamp_x64);
        CPLG_static = OpCamp_x64;
        Debug.Log("<color=#0096ff>PicSaved!</color>");
    }
    public GameObject Circleimg;
    public float circleamont;
    public void SetLevelData()
    {
        // Debug.Log("等级已设置");
        OpLevel_text[0].text = "/"+OpLevel[0].ToString();
        OpLevel_text[1].text = OpLevel[1].ToString();
        OpLevelEXP.text = "<color=#FED802>" + OpLevel[3].ToString() + "</color>/" + OpLevel[2].ToString();
        Debug.Log("等级已设置");
        if (OpLevel[2] != 0) { 
            circleamont=(float) OpLevel[3] / (float)OpLevel[2];
            Circleimg.GetComponent<Image>().fillAmount = circleamont;
    }
    }
    public static bool GameViewSave=false;

    private string SKLimg2x64()
    {
        string FilePath=FileOpen.OpenFile(OpenPicFileType, OpenPicTitle, PicType);
        /**/
        return FilePath;

    }
    public static void SaveGameData()
    {
        GameViewSave=true;
    }
    private void SetSKL1Data()
    {

        if (Skl1_Toggle[0].isOn == true)
        {
            Debug.Log("<color=#0096ff>一技能起始准备设置</color>");
            Skl1_Temp = "1";
            Debug.Log(Skl1_Temp);
            OpSkill1[1] = Skl1_Temp;
        }
        else
        {
            Skl1_Temp = "0";
            OpSkill1[1] = Skl1_Temp;
        }
        Skl1_Temp = Skl1_SP[0].text.ToString();
        OpSkill1[2] = Skl1_Temp;
        if (Skl1_Toggle[1].isOn == true)
        {
            Skl1_Temp = "1";
            OpSkill1[3] = Skl1_Temp;
            Debug.Log("<color=#0096ff>"+Skl1_Temp+"</color>");
        }
        else
        {
            Skl1_Temp = "0";
            OpSkill1[3] = Skl1_Temp;
            Debug.Log("<color=#0096ff>" + Skl1_Temp + "</color>");

        }
        Skl1_Temp=Skl1_SP[1].text.ToString();
        OpSkill1[4] = Skl1_Temp;
        Debug.Log("<color=#0096ff>1技能起始已设置</color>");

        OpSkill1[5] = Skl1_Name.text.ToString();
        Debug.Log("<color=#0096ff>1技能名称已设置</color>" + OpSkill1);
        
    }
    private void SetSkl2Data()
    {

        if (Skl2_Toggle[0].isOn == true)
        {
            Debug.Log("<color=#0096ff>一技能起始准备设置</color>");
            Skl2_Temp = "1";
            Debug.Log(Skl2_Temp);
            OpSkill2[1] = Skl2_Temp;
        }
        else
        {
            Skl2_Temp = "0";
            OpSkill2[1] = Skl2_Temp;
        }
        Skl2_Temp = Skl2_SP[0].text.ToString();
        OpSkill2[2] = Skl2_Temp;
        if (Skl2_Toggle[1].isOn == true)
        {
            Skl2_Temp = "1";
            OpSkill2[3] = Skl2_Temp;
            Debug.Log("<color=#0096ff>" + Skl2_Temp + "</color>");
        }
        else
        {
            Skl2_Temp = "0";
            OpSkill2[3] = Skl2_Temp;
            Debug.Log("<color=#0096ff>" + Skl2_Temp + "</color>");

        }
        Skl2_Temp = Skl2_SP[1].text.ToString();
        OpSkill2[4] = Skl2_Temp;
        Debug.Log("<color=#0096ff>1技能起始已设置</color>");

        OpSkill2[5] = Skl2_Name.text.ToString();
        Debug.Log("<color=#0096ff>1技能名称已设置</color>" + OpSkill2);

    }
    private void SetSkl3Data()
    {

        if (Skl3_Toggle[0].isOn == true)
        {
            Debug.Log("<color=#0096ff>一技能起始准备设置</color>");
            Skl3_Temp = "1";
            Debug.Log(Skl3_Temp);
            OpSkill3[1] = Skl3_Temp;
        }
        else
        {
            Skl3_Temp = "0";
            OpSkill3[1] = Skl3_Temp;
        }
        Skl3_Temp = Skl3_SP[0].text.ToString();
        OpSkill3[2] = Skl3_Temp;
        if (Skl3_Toggle[1].isOn == true)
        {
            Skl3_Temp = "1";
            OpSkill3[3] = Skl3_Temp;
            Debug.Log("<color=#0096ff>" + Skl3_Temp + "</color>");
        }
        else
        {
            Skl3_Temp = "0";
            OpSkill3[3] = Skl3_Temp;
            Debug.Log("<color=#0096ff>" + Skl3_Temp + "</color>");

        }
        Skl3_Temp = Skl3_SP[1].text.ToString();
        OpSkill3[4] = Skl3_Temp;
        Debug.Log("<color=#0096ff>1技能起始已设置</color>");

        OpSkill3[5] = Skl3_Name.text.ToString();
        Debug.Log("<color=#0096ff>1技能名称已设置</color>" + OpSkill3);

    }

    private void SetAbility()
    {
        Ability[1] = AbilityType.text;
        Ability[2] = AbilityName[0].text;
        Ability[3] = AbilityName[1].text;
        Debug.Log("<color=#e15353>天赋已写入</color>" + Ability);
        ABI_static = Ability;
    }

    private void SetPropData()
    {
        if (GameViewSave == true )
        {
            GameViewSave = false;
            Debug.Log("Click");
            #region 技能数据
            SetSKL1Data();
            SetSkl2Data();
            SetSkl3Data();
           
            #endregion
            #region 等级区域
            for (int k = 0; k < Input_OpLevel.Count; k++)
            {
                Debug.Log("准备写入等级");
                Level_Temp = int.Parse(Input_OpLevel[k].text);
                OpLevel[k] = Level_Temp;
                Debug.Log("等级已写入");
            }
            SetLevelData();
            #endregion
            #region 属性区域
            for (int i = 0; i < Input_Prop2.Count; i++)
            {
                OPP2_Temp = Input_Prop2[i].text;
                Debug.Log("OPP2Writed");

                OpProp2[i] = OPP2_Temp;
                Debug.Log("OPP2Saved");

            }
            for(int i = 0; i < Input_Prop.Count; i++)
            {

                OPP_Temp = int.Parse(Input_Prop[i].text);
                Debug.Log("OPP1Writed");

                OpProperties[i] = OPP_Temp;
                Debug.Log("OPP1Saved");
            }
            #endregion
            #region tag区域
            for(int i=0; i < Input_Tag.Count; i++)
            {
                Tag_Temp=Input_Tag[i].text;
                OpTag[i] = Tag_Temp;
            }
            #endregion
            #region 立绘调整
            PPos_Temp = OperatorPic.transform.position.x;
            PicPostion[0] = PPos_Temp;
            PicPostion[1] = OperatorPic.transform.position.y;
            PicPostion[2] = PicScaleSli.value;
            #endregion
           // SetAbility();


            OPP_static = OpProperties;
            OPP_static2 = OpProp2;
            TAG_static = OpTag;
            LVL_static = OpLevel;
            SKL1_static = OpSkill1;
            SKL2_static = OpSkill2;
            SKL3_static = OpSkill3;
            PPOS_static = PicPostion;
           

        }
    }
    public static bool CoverData=false;
    //--------------导入数据----------------//
    public static string DPI_IMP;
    public static List<int> OPP_IMP;
    public static List<string> OPP_IMP2;
    public static string CPLG_IMP;
    public static List<float> PPOS_IMP;//x，y，缩放
    public static List<string> TAG_IMP;
    public static int PRF_IMP;
    public static List<int> LVL_IMP;
    public static List<string> SKL1_IMP;////技能图片64码，技能起始【bool、数值】，技能需求【bool、数值】，技能名字
    public static List<string> SKL2_IMP;
    public static List<string> SKL3_IMP;
    public static List<string> ABI_IMP;
    private void CoverThisData()
    {
        //-------写入动态变量--------//
        DataPicx64 = DPI_IMP;
        OpProperties = OPP_IMP;
        OpProp2 = OPP_IMP2;
        OpCamp_x64 = CPLG_IMP;
        PicPostion = PPOS_IMP;
        OpTag = TAG_IMP;
        OpLevel = LVL_IMP;
        Profession = PRF_IMP;
        OpSkill1 = SKL1_IMP;
        OpSkill2 = SKL2_IMP;
        OpSkill3 = SKL3_IMP;
        Ability = ABI_IMP;
        Debug.Log("<color=#e15353>变量已读取</color>");
        //--------更新组件---------//
        for (int i = 0; i < OPP_IMP.Count; i++)
        {
            Debug.Log("<color=#FED802>准备写入OPP动态变量</color>");
            Input_Prop[i].text = OpProperties[i].ToString();
        }
        for (int i = 0; i < OPP_IMP2.Count; i++)
        {
            Debug.Log("<color=#FED802>准备写入OPP2动态变量</color>");

            Input_Prop2[i].text = OpProp2[i].ToString();
        }
        Debug.Log("<color=#53c5e1>属性已写入</color>");


        //OperatorPic.transform.position = new Vector2(PicPostion[0], PicPostion[1]);
        //OperatorPic.transform.localScale = new Vector2(PicPostion[2], PicPostion[2]);
        Debug.Log("<color=#53c5e1>位置已写入</color>");
        for (int i = 0; i < Input_Tag.Count; i++)
        {
            Input_Tag[i].text = OpTag[i].ToString();
        }
        Debug.Log("<color=#53c5e1>TAG已写入</color>");
        Input_Prf.value = Profession;
        Debug.Log("<color=#53c5e1>职业已写入</color>");
        for (int i = 0; i < Input_OpLevel.Count; i++)
        {
            Input_OpLevel[i].text = OpLevel[i].ToString();
        }
        Debug.Log("<color=#53c5e1>等级已写入</color>");

        SetLevelData();

        #region 一技能读取
        Skl1_Img.texture = ase64toString.Base64ToImg(OpSkill1[0]);
        if (int.Parse(OpSkill1[1]) == 1)
        {
            Skl1_Toggle[0].isOn = true;
        }
        else
        {
            Skl1_Toggle[0].isOn = false;
        }
        Skl1_SP[0].text = OpSkill1[2].ToString();
        if (int.Parse(OpSkill1[3]) == 1)
        {
            Skl1_Toggle[1].isOn = true;
        }
        else
        {
            Skl1_Toggle[1].isOn = false;
        }
        Skl1_SP[1].text = OpSkill1[4].ToString();
        Skl1_Name.text = OpSkill1[5].ToString();
        #endregion
        #region 2技能读取
        Skl2_Img.texture = ase64toString.Base64ToImg(OpSkill2[0]);
        if (int.Parse(OpSkill2[1]) == 1)
        {
            Skl2_Toggle[0].isOn = true;
        }
        else
        {
            Skl2_Toggle[0].isOn = false;
        }
        Skl2_SP[0].text = OpSkill2[2].ToString();
        if (int.Parse(OpSkill2[3]) == 1)
        {
            Skl2_Toggle[1].isOn = true;
        }
        else
        {
            Skl2_Toggle[1].isOn = false;
        }
        Skl2_SP[1].text = OpSkill2[4].ToString();
        Skl2_Name.text = OpSkill2[5].ToString();
        #endregion
        #region 3技能读取
        Skl3_Img.texture = ase64toString.Base64ToImg(OpSkill3[0]);
        if (int.Parse(OpSkill3[1]) == 1)
        {
            Skl3_Toggle[0].isOn = true;
        }
        else
        {
            Skl3_Toggle[0].isOn = false;
        }
        Skl3_SP[0].text = OpSkill3[2].ToString();
        if (int.Parse(OpSkill3[3]) == 1)
        {
            Skl3_Toggle[1].isOn = true;
        }
        else
        {
            Skl3_Toggle[1].isOn = false;
        }
        Skl3_SP[1].text = OpSkill3[4].ToString();
        Skl3_Name.text = OpSkill3[5].ToString();
        #endregion
        Debug.Log("<color=#3decc9>技能已写入</color>");
        Debug.Log("<color=#53c5e1>准备写入阵营</color>");

        CampLogo.texture = ase64toString.Base64ToImg(CPLG_IMP);
        Debug.Log("<color=#53c5e1>准备写入立绘</color>");
        OperatorPic.texture = ase64toString.Base64ToImg(DataPicx64);
        Debug.Log("<color=#53c5e1>准备修改立绘位置</color>");
        OperatorPic.GetComponent<RectTransform>().sizeDelta = new Vector2(OperatorPic.texture.width, OperatorPic.texture.height);
        
        OperatorPic.transform.position =  new Vector3((float)PicPostion[0],(float)PicPostion[1],OperatorPic.transform.position.z);
        PicScaleSli.value = (float)PicPostion[2];
        //OperatorPic.transform.localScale = new Vector2(PicPostion[2], PicPostion[2]);
        Debug.Log("<color=#ec3d3d>立绘位置载入成功</color>");
     


        SetPropData();
        

    }
}
