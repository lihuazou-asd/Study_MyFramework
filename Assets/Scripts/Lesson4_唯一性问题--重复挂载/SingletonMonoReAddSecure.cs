using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMonoReAddSecure<T> : MonoBehaviour where T:MonoBehaviour
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
        //如果存在，则删除重复挂载的脚本
        if(instance!=null)
        {
            Destroy(this);
            return;
        }
        instance = this as T;
        DontDestroyOnLoad(this.gameObject);
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
