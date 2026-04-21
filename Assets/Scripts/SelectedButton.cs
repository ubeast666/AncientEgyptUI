using UnityEngine;
using UnityEngine.UI;

public class SelectedButton : MonoBehaviour
{
    [SerializeField] Image imageComp;
    public int buttonValue;
    public Sprite defaultImage; 
    public Sprite selectedImage;
    public ButtonController buttonController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void selectbutton(int buttonValue)
    {
        buttonController.UpdateButton(buttonValue);
    }

    public void ResetButton()
    {
        imageComp.sprite = defaultImage;
    }

    public void SetButton()
    {
        imageComp.sprite = selectedImage;
    }

}
