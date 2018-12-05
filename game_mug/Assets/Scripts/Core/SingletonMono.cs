/**
*FileName:     SingletonMono.cs
*Author:       ZhanKing
*Time:         2018-12-06 00:24:49
*Description:   
*/ 
/**
*FileName:     SingletonMono.cs
*Author:       ZhanKing
*Time:         2018-12-02 23:57:20
*Description:   
*/ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMono<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject obj = new GameObject(typeof(T).Name);
                DontDestroyOnLoad(obj);
                instance = obj.GetComponent<T>();
                if (instance == null)
                    instance = obj.AddComponent<T>();
            }

            return instance;
        }
    }

    private void Awake()
    {
        OnAwake();
    }

    private void Start()
    {
        OnStart();
    }

    private void Update()
    {
        OnUpdate();
    }

    private void OnDestory()
    {
        BeforeOnDestory();
    }

    protected virtual void OnAwake(){}
    protected virtual void OnStart() { }
    protected virtual void OnUpdate() { }
    protected virtual void BeforeOnDestory() { }


}
