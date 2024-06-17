using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// 事件中心模块 
/// </summary>
public class EventCenter : BaseManagerConSecure<EventCenter>
{
    //用于记录对应事件 关联的 对应的逻辑
    private Dictionary<string, UnityAction> eventDic = new Dictionary<string, UnityAction>();

    private EventCenter() { }

    /// <summary>
    /// 触发事件 
    /// </summary>
    /// <param name="eventName">事件名字</param>
    public void EventTrigger(string eventName)
    {
        //存在关心我的人 才通知别人去处理逻辑
        if(eventDic.ContainsKey(eventName))
        {
            //去执行对应的逻辑
            eventDic[eventName]?.Invoke();
        }
    }

    /// <summary>
    /// 添加事件监听者
    /// </summary>
    /// <param name="eventName"></param>
    /// <param name="func"></param>
    public void AddEventListener(string eventName, UnityAction func)
    {
        //如果已经存在关心事件的委托记录 直接添加即可
        if (eventDic.ContainsKey(eventName))
            eventDic[eventName] += func;
        else
        {
            eventDic.Add(eventName, null);
            eventDic[eventName] += func;
        }
            
    }

    /// <summary>
    /// 移除事件监听者
    /// </summary>
    /// <param name="eventName"></param>
    /// <param name="func"></param>
    public void RemoveEventListener(string eventName, UnityAction func)
    {
        if (eventDic.ContainsKey(eventName))
            eventDic[eventName] -= func;
    }

    /// <summary>
    /// 清空所有事件的监听
    /// </summary>
    public void Clear()
    {
        eventDic.Clear();
    }

    /// <summary>
    /// 清除指定某一个事件的所有监听
    /// </summary>
    /// <param name="eventName"></param>
    public void Claer(string eventName)
    {
        if (eventDic.ContainsKey(eventName))
            eventDic.Remove(eventName);
    }
}
