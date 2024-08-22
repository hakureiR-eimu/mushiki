using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 存储所有UI信息，并可以创造或销毁UI
/// </summary>
public class UIManager
{
    /// <summary>
    /// 存储所有UI信息的字典，每一个UI信息都会对应一个GameObject
    /// </summary>
    private Dictionary<UIType, GameObject> dicUI;

    public UIManager() 
    {
        dicUI = new Dictionary<UIType, GameObject>();
    }

    /// <summary>
    /// 获取一个UI对象
    /// </summary>
    /// <param name="_type">UI信息</param>
    /// <returns></returns>
    public GameObject GetSingleUI(UIType _type) {
        
        
        GameObject parent = GameObject.Find("Canvas");

        if (!parent)
        {
            Debug.LogError("Canvas不存在，请仔细查找有无这个对象");
            return null;
        }
        if(dicUI.ContainsKey(_type))
        {
            return dicUI[_type];
        }
        else
        {
            GameObject ui = GameObject.Instantiate(Resources.Load<GameObject>(_type.Path),parent.transform);
            ui.name = _type.Name;
            dicUI.Add(_type, ui);
            return ui;
        }
    }

    /// <summary>
    /// 销毁一个UI对象
    /// </summary>
    /// <param name="_type">UI信息</param>
    public void DestroyUI(UIType _type)
    {
        if(dicUI.ContainsKey(_type))
        {
            dicUI.Remove(_type);
        }
    }

}
