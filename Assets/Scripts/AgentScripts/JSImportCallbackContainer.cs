using UnityEngine;
using System.Collections;
using System.IO;
using System;

// 挂在导入按钮上
public class JSImportCallbackContainer : MonoBehaviour
{
    // 等待被 JS 调用
    public void JSImportCallback(string base64GameData)
    {
        if (base64GameData.Equals(""))
        {
            Debug.Log("用户取消了文件选择");
            return;
        }
        // 把 base64 转换回来
        byte[] gameData = Convert.FromBase64String(base64GameData);
        // 写入内存流
        MemoryStream s = new MemoryStream();
        s.Write(gameData);
        // 将缓冲区内容写入
        s.Flush();
        读取数据.importDataFromJS = s;
    }
}
