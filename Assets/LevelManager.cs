using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class LevelManager : MonoBehaviour
{
    SceneControls sceneControl;
    private PhonePopUp ui;
    private Door door;
    
    
    // Start is called before the first frame update
    void Awake()
    {
        ui = FindObjectOfType<PhonePopUp>();
        door = FindObjectOfType<Door>();
        sceneControl = GetComponent<SceneControls>();
        if (sceneControl == null)
        {
            sceneControl = gameObject.AddComponent<SceneControls>();
            Debug.LogWarning("Scene Control not found. Scene Control added to " + gameObject.name);
        }
    }

    public void NextLevel()
    {
        SceneControls.currentLevel++;
        SceneControls.ResetScene();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartLevel()
    {
        door.SetDoor();
    }

    public void WinLevel()
    {
        
        ui.ShowWinScreen();
    }

    public  void LoseLevel()
    {
        ui.ShowLoseScreen();
    }
}
