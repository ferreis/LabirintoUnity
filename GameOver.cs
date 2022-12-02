using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
 
 
    public Texture texture;
    void OnGUI ()
    {
        GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),texture);
 
        if(GUI.Button(new Rect(Screen.width*0.1f,Screen.height*0.8f,Screen.width/3,Screen.height/10),"CONTINUA"))
        {
            SceneManager.LoadScene("scenes/Labirinto");
        }
 
        if(GUI.Button(new Rect(Screen.width*0.6f,Screen.height*0.8f,Screen.width/3,Screen.height/10),"SAIR"))
        {
            Application.Quit();
        }
    }
}