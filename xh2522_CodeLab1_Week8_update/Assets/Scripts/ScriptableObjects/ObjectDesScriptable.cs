using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(
    fileName = "New Object Information", menuName = "ScriptableObjects/NewObj", order = 0)]



public class ObjectDesScriptable : ScriptableObject
{
    
    public string objectName;
    public string objectDescription;
    public ObjectDesScriptable previousObj;
    public ObjectDesScriptable nextObj;
    public GameObject currentObject;
    
    
    
}
