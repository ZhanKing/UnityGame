/**
*FileName:     EventTriggerListener.cs
*Author:       ZhanKing
*Time:         2018-12-06 00:25:00
*Description:   
*/ 
/**
*FileName:     EventTriggerListener.cs
*Author:       ZhanKing
*Time:         2018-12-02 23:20:40
*Description:   
*/ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventTriggerListener : UnityEngine.EventSystems.EventTrigger
{

    public delegate void VoidDelegate(GameObject obj);

    public VoidDelegate onclick;
    public VoidDelegate onDown;
    public VoidDelegate onEnter;
    public VoidDelegate onExit;
    public VoidDelegate onUp;
    public VoidDelegate onSelect;
    public VoidDelegate onUpdateSelct;

    public static EventTriggerListener Get(GameObject obj)
    {
        EventTriggerListener eventTrigger = obj.GetComponent<EventTriggerListener>();
        if (eventTrigger == null)
        {
            eventTrigger = obj.gameObject.AddComponent<EventTriggerListener>();
        }

        return eventTrigger;
    }

    public override void OnPointerEnter(PointerEventData eventData)
    {
        if (onEnter != null)
            onEnter(gameObject);
    }

    public override void OnPointerExit(PointerEventData eventData)
    {
        if (onExit != null)
            onExit(gameObject);
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        if (onDown != null)
            onDown(gameObject);
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        if (onUp != null)
            onUp(gameObject);
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        if (onclick != null)
            onclick(gameObject);
    }

    public override void OnUpdateSelected(BaseEventData eventData)
    {
        if (onUpdateSelct != null)
            onUpdateSelct(gameObject);
    }

    public override void OnSelect(BaseEventData eventData)
    {
        if (onSelect != null)
            onSelect(gameObject);
    }
}
