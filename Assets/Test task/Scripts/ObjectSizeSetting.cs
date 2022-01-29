using System;
using UnityEngine;

[Serializable]
public class ObjectSizeSetting : MonoBehaviour
{
    [field:SerializeField, HideInInspector]
    public int _objSize;

    public void SetSizeObject() 
    { 
        gameObject.transform.localScale = new Vector2(_objSize, _objSize);
    }
}
