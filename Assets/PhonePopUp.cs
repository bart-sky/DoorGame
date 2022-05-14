using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using UnityEngine;
using TMPro;

public class PhonePopUp : MonoBehaviour
{
    private Phone phone;
    public string phoneText;
    public TextMeshProUGUI textUI;
    public GameObject popUpUI;
    
    // Start is called before the first frame update
    void Start()
    {
        phone = GetComponent<Phone>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowWinScreen()
    {
        
        Invoke(nameof(PopUpScreen), 3);
        print("Show win ui");
    }

    private void PopUpScreen()
    {
        popUpUI.SetActive(true);
        textUI.text = phoneText;
        phone.PlayMessageSound();
    }

    public void ShowLoseScreen()
    {
        phone.Invoke(nameof(Phone.Ring),3);
    }
}
