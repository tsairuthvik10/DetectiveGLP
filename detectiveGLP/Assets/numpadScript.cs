using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class numpadScript : MonoBehaviour
{
    public GameObject clue;
    public GameObject partition;
    bool isOK = false;
    public float destime;

    [SerializeField]
    Text inputField;

    string inputString;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inputString == "359" && isOK == true)
        {
            destime += Time.deltaTime;
            clue.SetActive(true);
            partition.SetActive(false);
            if (destime > 1.0f)
            {
                Destroy(gameObject);
            }

        }

        if(inputString != "359" && isOK == true)
        {
           destime += Time.deltaTime;
            if (destime > 1.0f)
            {
                //explosion
                Application.Quit();
            }
        }
    }

    public void buttonPressed()
    {
        string buttonValue = EventSystem.current.currentSelectedGameObject.name;
        inputString += buttonValue;
        inputField.text = inputString;
        
    }

    public void okpressed()
    {
        isOK = true;
    }
}
