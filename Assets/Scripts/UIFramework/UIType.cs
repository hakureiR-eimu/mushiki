using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 存储单个UI的信息，包括名字和路径
/// </summary>
public class UIType
{
    /// <summary>
    /// UI名字
    /// </summary>
    public string Name { get;private set; }

    /// <summary>
    /// UI路径
    /// </summary>
    public string Path {  get; private set; }

    public UIType(string _path)
    {
        this.Path = _path;
        this.Name = _path.Substring(_path.LastIndexOf('/')+1);
    }

}
