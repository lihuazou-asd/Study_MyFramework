using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//自动挂载式脚本，不需要Awake初始化instance,会在第一次使用该Instance实例化物体并自动挂载脚本
//无需担心切场景带来的问题
public class SingletonAutoMono<T> : MonoBehaviour where T:MonoBehaviour
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if(instance == null){
                //typeof(T).ToString()可以输出T的类名
                GameObject obj = new GameObject(typeof(T).ToString());
                instance = obj.AddComponent<T>();
                DontDestroyOnLoad(obj);
            }
            return instance;
        }
    }
}
