using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI Name;
    public TextMeshProUGUI Description;

    public ObjectDesScriptable currentObject;
    public Button previous;
    public Button next;
    private GameObject currentObj;
    
 
    // Start is called before the first frame update
    void Start()
    {
        UpdateObject();

    }

   
    void UpdateObject()
    {
        Name.text = currentObject.objectName;
        Description.text = currentObject.objectDescription;
        currentObj = Instantiate(currentObject.currentObject);
        

        
        if (currentObject.nextObj == null)
        {
            next.gameObject.SetActive(false);
        }
        else
        {
            next.gameObject.SetActive(true);
            currentObject.nextObj.previousObj = currentObject;
        }

        if (currentObject.previousObj == null)
        {
            previous.gameObject.SetActive(false);
        }
        else
        {
            previous.gameObject.SetActive(true);
            currentObject.previousObj.nextObj = currentObject;
        }

        
        
        //if (currentObject.currentObject==null)
        {
            //currentObject.nextObj.currentObject.SetActive(false);
            //currentObject.previousObj.currentObject.SetActive(false);
            //Destroy(currentObject.previousObj.currentObject);
            //Destroy(currentObject.nextObj.currentObject);
        }
        //else
        {
            //Instantiate(currentObject.currentObject);
        }
        
    }

    public void MoveDirection(int dir)
    {
        
        switch (dir)
        {
            case 0:
                Destroy(currentObj);
                currentObject = currentObject.nextObj;
                break;
            case 1:
                Destroy(currentObj);
                currentObject = currentObject.previousObj;
                break;
        }
        
        UpdateObject();
    }
    
}
