using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public SelectedButton[] buttons;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateButton(int buttonValue)
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            if (i == buttonValue)
            {
                buttons[i].SetButton();
            }
            else
            {
                buttons[i].ResetButton();
            }
        }
    }
}
