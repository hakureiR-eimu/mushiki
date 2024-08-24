using UnityEngine;
using UnityEngine.UI;

public class OnClickFooterItem : MonoBehaviour
{
    void Start()
    {
        this.GetComponent<Button>()
            .onClick
            .AddListener
            (delegate ()
            {
                OnClick(this.gameObject);
            });
    }

    void Update()
    {

    }

    public void OnClick(GameObject _obj)
    {
        Debug.Log("点击了按钮：" + _obj.name);

    }
}