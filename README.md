
<!-- # ![mg-builder](/img~/mg-builder.png) -->

# Lesson 1

Developing Mobile Game lesson for Ankara university - Week 1

## Demo 1 

* Create Canvas and basic canvas components
* Canvas Scaler - UI Scale Mode
* Text & TextMeshPRO
* Basic RectTransform
* Image component and use as background
* Button component and basic use

<table>

  <tr>
    <td><img src="https://raw.githubusercontent.com/bunyamineymen/Lesson1_DevelopingMobileGame/main/Assets/_Resources/demo1.png" width=250 height=535></td>

  </tr>
 </table>

  `Use In Project` : By calling this method `HMSAccountKitManager.Instance.SignIn();` at GameManager.cs 121

   ```csharp

public class Demo1 : MonoBehaviour
{
    #region MyButton

    public Button Btn_MyButton;

    private void Awake()
    {
        Btn_MyButton.onClick.AddListener(ButtonClick_MyButton);
    }

    public void ButtonClick_MyButton()
    {
        Debug.Log("ButtonClick_MyButton");
    }

    #endregion
}

  ```

## Demo 2

* Create Canvas and basic canvas components
* Canvas Scaler - UI Scale Mode
* Text & TextMeshPRO
* Basic RectTransform
* Image component and use as background
* Button component and basic use

<table>

  <tr>
    <td><img src="https://raw.githubusercontent.com/bunyamineymen/Lesson1_DevelopingMobileGame/main/Assets/_Resources/demo_1.png" width=250 height=535></td>

  </tr>
 </table>

  `Use In Project` : By calling this method `HMSAccountKitManager.Instance.SignIn();` at GameManager.cs 121

   ```csharp

public class Demo1 : MonoBehaviour
{
    #region MyButton

    public Button Btn_MyButton;

    private void Awake()
    {
        Btn_MyButton.onClick.AddListener(ButtonClick_MyButton);
    }

    public void ButtonClick_MyButton()
    {
        Debug.Log("ButtonClick_MyButton");
    }

    #endregion
}

  ```
  



