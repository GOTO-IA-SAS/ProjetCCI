using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager_ : MonoBehaviour
{

   [SerializeField] private PlayerManager m_playerManager;
   

    public static event Action OnPlayerMangerUpdate;
    
    private string m_strSceneName = string.Empty;

    private Controls controls;
    
    private void Awake()
    {
        controls = new Controls();
        controls.LoadScene.Load.performed += ctx => KeyLoaderScene();
        controls.UnloadScene.Unload.performed += ctx => KeyUnloaderScene();
    }

    private void OnEnable()
    {
        controls.Enable();
    }
    
    private void OnDisable()
    {
        controls.Disable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
        //LoadScene
       // StartCoroutine(LoadScene("Second_Scene"));
       
       
        #if UNITY_IOS
        //iOS specific code
        Debug.Log("Code IOS");
        #elif UNITY_ANDROID
        //Android specific code
        Debug.Log("Code Android");
        #elif UNITY_EDITOR
        //Editor specific code
        Debug.Log("Code Editor");
        #endif
        



    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(("GameManager Update"));

        if (m_playerManager is not null)
        {
            m_playerManager.UpdatePlayer();
        }

        
    }

    


    private void KeyLoaderScene()
    {
        if(Input.GetButtonDown("LoadScene"))
        {
            SceneManager.LoadScene(m_strSceneName,LoadSceneMode.Additive);
            
        }
        
    }
    
    private void KeyUnloaderScene()
    {
        if(Input.GetButtonDown("UnloadScene"))
        {
            SceneManager.UnloadSceneAsync(m_strSceneName);
            
        }
        
    }

    IEnumerator LoadScene(string sceneName)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);

        while (!asyncLoad.isDone)
        {
            Debug.Log("Progression : {operation.progress*100}%");
            yield return null;
        }
    }
   

}
