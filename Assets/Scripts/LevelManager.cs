using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour

{

  public void LoadLevel(string name)
   {

	Debug.Log("New Level Load:" + name);
   // Application.LoadLevel(name); 
    SceneManager.LoadScene(name , LoadSceneMode.Single);
     }

   public void QuitRequest()
   {
    Debug.Log("Level quit");
    Application.Quit();

   }
}

