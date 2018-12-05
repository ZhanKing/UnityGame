/**
*FileName:     EnumDefine.cs
*Author:       ZhanKing
*Time:         2018-12-06 00:57:39
*Description:   枚举定义
*/ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


#region ui窗体类型

/// <summary>
/// UI类型
/// </summary>
public enum UIType
{
    /// <summary>
    /// 普通窗体
    /// </summary>
    Normal,
    /// <summary>
    /// 固定窗体
    /// </summary>
    Fixed,
    /// <summary>
    /// 弹出窗体
    /// </summary>
    PopUp
}

/// <summary>
/// UI窗口显示类型
/// </summary>
public enum UIFormsShowMode
{
    /// <summary>
    /// 普通显示
    /// </summary>
    Normal,
    /// <summary>
    /// 层级显示
    /// </summary>
    ReverseChange,
    /// <summary>
    /// 隐藏其他
    /// </summary>
    HideOther
}

/// <summary>
/// UI窗口弹出方式
/// </summary>
public enum UIFormsStartMode
{
    /// <summary>
    /// 正常弹出，没有动画
    /// </summary>
    Normal
}

/// <summary>
/// UI窗口透明度
/// </summary>
public enum UIFormLucenyType
{
     /// <summary>
     /// 没有遮罩，全面场景
     /// </summary>
     Lucency,
    /// <summary>
    /// 半透明遮罩，不能穿透
    /// </summary>
    Translucence,
    /// <summary>
    /// 低透明度遮罩，不能穿透
    /// </summary>
    ImPenetrable,
    /// <summary>
    /// 没有遮罩，可以穿透
    /// </summary>
    Pentrate
}


#endregion


#region UI窗体种类

/// <summary>
/// UI窗体种类
/// </summary>
public enum UIFormsClass
{
    /// <summary>
    /// 登陆窗口
    /// </summary>
    LogOn,
    /// <summary>
    /// 注册窗口
    /// </summary>
    Registe
}


#endregion
