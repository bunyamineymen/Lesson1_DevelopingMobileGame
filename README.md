
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
    <td><img src="https://raw.githubusercontent.com/bunyamineymen/Lesson1_DevelopingMobileGame/main/Assets/_Resources/demo1.png"></td>

  </tr>
 </table>

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

* Unityevent
* EventSystem
* Graphic Raycaster
* Canvas - Render Mode

<table>

  <tr>
    <td><img src="https://raw.githubusercontent.com/bunyamineymen/Lesson1_DevelopingMobileGame/main/Assets/_Resources/demo2.png"></td>

  </tr>
 </table>

   ```csharp

public class Demo2 : MonoBehaviour
{

    public UnityEvent UE_Event;

    public void Run_UnityEvent()
    {
        Debug.Log("ButtonClick_UnityEvent");
    }

    public void ButtonClick_MyButton()
    {
        UE_Event?.Invoke();
    }

}

  ```
  
## Demo 3

* GameObject.Find unity command
* Console window
* Inspector window
* Project window
* Shortcut: CTRL D , CTRL E
* Time Offset : Ienumarator , System.Threading.Tasks

<table>

  <tr>
    <td><img src="https://raw.githubusercontent.com/bunyamineymen/Lesson1_DevelopingMobileGame/main/Assets/_Resources/demo3.png"></td>

  </tr>
 </table>

   ```csharp

public class Demo3 : MonoBehaviour
{

    private Button Btn_MyButton;

    public async void ButtonClick_MyButton()
    {
        Debug.Log("ButtonClick_MyButton phase_1");
        await Task.Delay(1000);
        StartCoroutine(ButtonClick_MyButton_IEnumerator());
    }

    private void Awake()
    {
        Btn_MyButton = GameObject.Find("MyButton").GetComponent<Button>();

        Btn_MyButton.onClick.AddListener(ButtonClick_MyButton);
    }

    IEnumerator ButtonClick_MyButton_IEnumerator()
    {
        Debug.Log("ButtonClick_MyButton phase_2");

        yield return new WaitForSeconds(1f);

        Debug.Log("ButtonClick_MyButton phase_3");
    }

}

  ```
  
## Demo 4

* GameObject.Find unity command
* Console window
* Inspector window
* Project window
* Shortcut: CTRL D , CTRL E
* Time Offset : Ienumarator , System.Threading.Tasks

<table>

  <tr>
    <td><img src="https://raw.githubusercontent.com/bunyamineymen/Lesson1_DevelopingMobileGame/main/Assets/_Resources/demo4.png"></td>

  </tr>
 </table>

   ```csharp

public class Demo4 : MonoBehaviour
{

    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    private void Start()
    {
        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    private void Update()
    {
        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }
}

  ```
  

