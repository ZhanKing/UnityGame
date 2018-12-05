using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using System.IO;
using UnityEngine;

public class AddFileHeadComment:UnityEditor.AssetModificationProcessor
{
    /// <summary>
    /// 此函数在asset被创建完，文件已经生成到磁盘上，但是没有生成.meta文件和import之前被调用
    /// </summary>
    /// <param name="assetName">newfilemeta 是由创建文件的path加上.meta组成的</param>
    private static void OnWillCreateAsset(string assetName)
    {
        //Debug.Log(assetName + "," + Application.dataPath);
        string newFilePath = assetName.Replace(".meta", "");
        string newFileExtension = Path.GetExtension(newFilePath);

        if(!newFileExtension.Equals(".cs"))
        {
            return;
        }

        //Application.dataPath不同平台的路径可能不同
        string realPath = Application.dataPath.Replace("Assets", "") + newFilePath;
        string realScripts = File.ReadAllText(realPath);

        string fileHead = "/**\n*FileName:     #SCRIPTFULLNAME#\n*Author:       #AUTHOR#\n*Time:         #DATE#\n*Description:   \n*/ ";
        fileHead = fileHead.Replace("#SCRIPTFULLNAME#", Path.GetFileName(newFilePath));
        fileHead = fileHead.Replace("#AUTHOR#", "ZhanKing");
        fileHead = fileHead.Replace("#DATE#", System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        
        File.WriteAllText(realPath,fileHead + "\n" + realScripts);

    }
	
}
