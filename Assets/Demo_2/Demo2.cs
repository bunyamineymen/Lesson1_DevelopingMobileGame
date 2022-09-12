using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Demo2 : MonoBehaviour
{


    [Header("MyButton")]

    #region UnityEvent

    public UnityEvent UE_Event;

    public void ButtonClick_UnityEvent()
    {
        Debug.Log("ButtonClick_UnityEvent");
    }

    #endregion

    #region MyButton

    public Button Btn_MyButton;

    public void ButtonClick_MyButton()
    {
        Debug.Log("ButtonClick_MyButton");

        UE_Event?.Invoke();
    }

    #endregion

}
