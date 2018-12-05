/**
*FileName:     Menu.cs
*Author:       ZhanKing
*Time:         2018-12-06 00:20:03
*Description:   
*/ 
/**
*FileName:     Menu.cs
*Author:       ZhanKing
*Time:         2018-11-15 00:55:00
*Description:   
*/ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class Menu 
{

    [MenuItem("Tools/AssetBundleCreat")]
    public static void AssetBundleCreat()
    {
        string path = Application.dataPath + "/../AssetBundles";
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        AssetBundleBuild[] assetBundles = new AssetBundleBuild[1];
        Object[] objects = Selection.GetFiltered(typeof(Object), SelectionMode.DeepAssets);
        string[] pathStrings = new string[objects.Length];

        for (int i = 0; i < objects.Length; i++)
        {
            pathStrings[i] = AssetDatabase.GetAssetPath(objects[i]);
            Debug.Log(pathStrings[i]);
        }

        assetBundles[0].assetNames = pathStrings;
        assetBundles[0].assetBundleName = objects[0].name;
        BuildPipeline.BuildAssetBundles(path, assetBundles, BuildAssetBundleOptions.None,
            BuildTarget.StandaloneWindows64);
        AssetDatabase.Refresh();

    }
}
