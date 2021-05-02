using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour{
    public void GoToMainMenu(){
        Application.LoadLevel("menu");
    }

    public void GoToMainCamera(){
        Application.LoadLevel("AR_Camera");
    }

    public void ExitApplication(){
        Application.Quit();
    }
}