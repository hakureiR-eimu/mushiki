using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopButton : MonoBehaviour
{
    public virtual void OnClick()
    {
        Debug.Log($"你点击了{gameObject.name},重写此方法以弹出弹窗");
    }
}
