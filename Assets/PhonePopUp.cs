using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using UnityEngine;
using TMPro;
using UnityEditor;

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
        phone.currentMessageType = Phone.MessageType.Happy;
        phoneText = "Congrats! Good read on that customer.";
        Invoke(nameof(PopUpScreen), 4);
        phone.Invoke(nameof(Phone.Ring),.5f);    
    }

    private void PopUpScreen()
    {
        popUpUI.SetActive(true);
        textUI.text = phoneText;
        phone.PlayMessageSound();
    }

    public void ShowLoseScreen()
    {
        phone.currentMessageType = Phone.MessageType.Angry;
        phoneText = "Hey these lead lists aren't cheap. Be careful next time.";
        Invoke(nameof(PopUpScreen), 4);
        phone.Invoke(nameof(Phone.Ring),.5f);
    }
}
