using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDebug : MonoBehaviour
{
    public Toggle miToggle;
    public Slider miSlider;
    public InputField miInputField;
    
   public void OnChangeToggle()
    {
        if(miToggle.isOn == true)
        {
            Debug.Log("el toggle esta en verdadero");
        }
        else
            Debug.Log("el toggle esta en falso");
    }
    public void OnChangeSlider()
    {
        Debug.Log("El valor del slider es " + miSlider.value);
    }
    public void OnChangeInputfield()
    {
        Debug.Log("El ususario ha escrito " + miInputField.text);
    }
}
