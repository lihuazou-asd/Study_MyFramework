using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//挂载式Mono单例基类，需要提供Awake初始化instance，需要游戏开始前就在场景上构建物体并添加脚本
//不推荐使用
public class SingletonMono<T> : MonoBehaviour where T:MonoBehaviour
{
    private static T instance;
    public static T Instance
    {
        get
        {
            return instance;
        }
    }
    //目的是为子类提供Awake重写的功能以实现初始化，需要添加base.Awake();
    protected virtual void Awake()
    {
        instance = this as T;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
