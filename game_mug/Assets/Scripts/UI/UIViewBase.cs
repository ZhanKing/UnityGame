/**
*FileName:     UIViewBase.cs
*Author:       ZhanKing
*Time:         2018-12-03 00:17:25
*Description:   ui窗口基类
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// UI窗口基类
/// </summary>
public class UIViewBase : MonoBehaviour
{
    private UIType _currentUIType = UIType.Normal;

    /// <summary>
    /// 当前窗体类型
    /// </summary>
    internal UIType CurrentUIType
    {
        set { _currentUIType = value; }
        get { return _currentUIType; }
    }

    /// <summary>
    /// 页面显示
    /// </summary>
    public virtual void Display()
    {
        this.gameObject.SetActive(true);
    }

    /// <summary>
    /// 页面隐藏
    /// </summary>
    public virtual void Hiding()
    {
        this.gameObject.SetActive(false);
    }

    /// <summary>
    /// 页面再次显示
    /// </summary>
    public virtual void ReDisplay()
    {
        this.gameObject.SetActive(true);
    }


}
