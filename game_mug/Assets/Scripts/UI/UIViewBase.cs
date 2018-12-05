/**
*FileName:     UIViewBase.cs
*Author:       ZhanKing
*Time:         2018-12-03 00:17:25
*Description:   ui���ڻ���
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// UI���ڻ���
/// </summary>
public class UIViewBase : MonoBehaviour
{
    private UIType _currentUIType = UIType.Normal;

    /// <summary>
    /// ��ǰ��������
    /// </summary>
    internal UIType CurrentUIType
    {
        set { _currentUIType = value; }
        get { return _currentUIType; }
    }

    /// <summary>
    /// ҳ����ʾ
    /// </summary>
    public virtual void Display()
    {
        this.gameObject.SetActive(true);
    }

    /// <summary>
    /// ҳ������
    /// </summary>
    public virtual void Hiding()
    {
        this.gameObject.SetActive(false);
    }

    /// <summary>
    /// ҳ���ٴ���ʾ
    /// </summary>
    public virtual void ReDisplay()
    {
        this.gameObject.SetActive(true);
    }


}
