using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Capture : MonoBehaviour
{
    public Camera RenderCamera;
    public Rect Resolution;
    public string FilePath;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CaptureCamera(RenderCamera, Resolution);
        }
    }
    Texture2D CaptureCamera(Camera camera, Rect rect)
    {
        // ����һ��RenderTexture����  
        RenderTexture rt = new RenderTexture((int)rect.width, (int)rect.height, 0);
        // ��ʱ������������targetTextureΪrt, ���ֶ���Ⱦ������  
        camera.targetTexture = rt;
        camera.Render();
        //ps: --- ����������ϵڶ������������ʵ��ֻ��ͼĳ����ָ�������һ�𿴵���ͼ��  
        //ps: camera2.targetTexture = rt;  
        //ps: camera2.Render();  
        //ps: -------------------------------------------------------------------  

        // �������rt, �������ж�ȡ���ء�  
        RenderTexture.active = rt;
        Texture2D screenShot = new Texture2D((int)rect.width, (int)rect.height, TextureFormat.RGB24, false);
        screenShot.ReadPixels(rect, 0, 0);// ע�����ʱ�����Ǵ�RenderTexture.active�ж�ȡ����  
        screenShot.Apply();

        // ������ز�������ʹ��camera��������Ļ����ʾ  
        camera.targetTexture = null;
        //ps: camera2.targetTexture = null;  
        RenderTexture.active = null; // JC: added to avoid errors  
        GameObject.Destroy(rt);
        // �����Щ�������ݣ���һ��pngͼƬ�ļ�  
        byte[] bytes = screenShot.EncodeToPNG();
        string filename = FilePath + "/Screenshot.png";
        System.IO.File.WriteAllBytes(filename, bytes);
        Debug.Log(string.Format("������һ����Ƭ: {0}", filename));

        return screenShot;
    }
}