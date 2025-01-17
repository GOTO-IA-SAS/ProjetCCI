using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerSecondScene : MonoBehaviour
{
    private string m_strSceneName = string.Empty;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
        m_strSceneName = "Second_Scene";
        Invoke("UnLoadScene", 5f);
    }
    

    private void UnLoadScene()
    {
        if(!String.IsNullOrEmpty(m_strSceneName))
        {
            SceneManager.UnloadSceneAsync(m_strSceneName);
        }
        else
        {
            Debug.Log("Erreur de dechargement de la scene");
        }
        
    }
}
