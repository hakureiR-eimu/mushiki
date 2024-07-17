using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Strategy : ScriptableObject
{
    public string id;
    public string strategyName;
    public virtual void OnExcute()
    {
        Debug.Log("重写此方法以实现策略的效果");
    }
}
