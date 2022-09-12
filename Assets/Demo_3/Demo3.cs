using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Demo3 : MonoBehaviour
{

    #region MyButton

    private Button Btn_MyButton;

    public void ButtonClick_MyButton()
    {
        Debug.Log("ButtonClick_MyButton");
    }

    #endregion

    private void Awake()
    {
        Btn_MyButton = GameObject.Find("MyButton").GetComponent<Button>();

        Btn_MyButton.onClick.AddListener(ButtonClick_MyButton);
    }

}
