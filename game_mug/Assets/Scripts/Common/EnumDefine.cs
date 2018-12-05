/**
*FileName:     EnumDefine.cs
*Author:       ZhanKing
*Time:         2018-12-06 00:57:39
*Description:   ö�ٶ���
*/ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


#region ui��������

/// <summary>
/// UI����
/// </summary>
public enum UIType
{
    /// <summary>
    /// ��ͨ����
    /// </summary>
    Normal,
    /// <summary>
    /// �̶�����
    /// </summary>
    Fixed,
    /// <summary>
    /// ��������
    /// </summary>
    PopUp
}

/// <summary>
/// UI������ʾ����
/// </summary>
public enum UIFormsShowMode
{
    /// <summary>
    /// ��ͨ��ʾ
    /// </summary>
    Normal,
    /// <summary>
    /// �㼶��ʾ
    /// </summary>
    ReverseChange,
    /// <summary>
    /// ��������
    /// </summary>
    HideOther
}

/// <summary>
/// UI���ڵ�����ʽ
/// </summary>
public enum UIFormsStartMode
{
    /// <summary>
    /// ����������û�ж���
    /// </summary>
    Normal
}

/// <summary>
/// UI����͸����
/// </summary>
public enum UIFormLucenyType
{
     /// <summary>
     /// û�����֣�ȫ�泡��
     /// </summary>
     Lucency,
    /// <summary>
    /// ��͸�����֣����ܴ�͸
    /// </summary>
    Translucence,
    /// <summary>
    /// ��͸�������֣����ܴ�͸
    /// </summary>
    ImPenetrable,
    /// <summary>
    /// û�����֣����Դ�͸
    /// </summary>
    Pentrate
}


#endregion


#region UI��������

/// <summary>
/// UI��������
/// </summary>
public enum UIFormsClass
{
    /// <summary>
    /// ��½����
    /// </summary>
    LogOn,
    /// <summary>
    /// ע�ᴰ��
    /// </summary>
    Registe
}


#endregion
