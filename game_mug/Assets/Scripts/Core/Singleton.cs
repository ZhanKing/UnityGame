/**
*FileName:     Singleton.cs
*Author:       ZhanKing
*Time:         2018-11-13 01:05:12
*Description:   
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Singleton<T> : IDisposable where T : new()
{
    private static Singleton<T> _instance;

    public static Singleton<T> Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Singleton<T>();
            }
            return _instance;
        }
    }

    /// <summary>
    /// 释放资源
    /// </summary>
    public virtual void Dispose()
    {

    }
}