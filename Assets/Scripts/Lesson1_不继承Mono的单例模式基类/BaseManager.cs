using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//泛型约束，需要继承者是类并且有一个无参构造函数
public class BaseManager<T> where T:class,new()
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if(instance == null){
                instance = new T();
            }
            return instance;
        }
    }
}
