using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System;

public class ase64toString : MonoBehaviour
{
    static string recordBase64String;

    /// <summary>
    /// ͼƬת����base64�����ı�
    /// </summary>
    public static string ImgToBase64String(string path)
    {
        try
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, (int)fs.Length);
            string base64String = Convert.ToBase64String(buffer);
            //Debug.Log("��ȡ��ǰͼƬbase64Ϊ---" + base64String);
            recordBase64String = base64String;
        }
        catch (Exception e)
        {
            Debug.Log("ImgToBase64String ת��ʧ��:" + e.Message);
        }
        return recordBase64String;
    }

    /// <summary>
    /// base64�����ı�ת����ͼƬ
    /// </summary>
    public static Texture2D Base64ToImg(string Importx64)
    {
        string base64 = Importx64;
        byte[] bytes = Convert.FromBase64String(base64);
        Texture2D tex2D = new Texture2D(100, 100);
        tex2D.LoadImage(bytes);
        Sprite s = Sprite.Create(tex2D, new Rect(0, 0, tex2D.width, tex2D.height), new Vector2(0.5f, 0.5f));
        //importimg.sprite = s;
        Resources.UnloadUnusedAssets();
        return tex2D;
    }
}