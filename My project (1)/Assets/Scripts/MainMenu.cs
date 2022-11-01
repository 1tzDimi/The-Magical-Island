using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    
    

    public void OnNewGameClicked() 
    {
    
       
        DataPersistenceManager.instance.NewGame();
        
        SceneManager.LoadScene(2);
    }

    public void OnContinueGameClicked() 
    {
        
        
        SceneManager.LoadScene(2);
    }

    public void OptionMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    
}