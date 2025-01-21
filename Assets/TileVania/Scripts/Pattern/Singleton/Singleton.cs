using UnityEngine;

// Classe générique Singleton
public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;
    private static object _lock = new object();

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    // Chercher une instance existante dans la scène
                    _instance = FindObjectOfType<T>();

                    if (_instance == null)
                    {
                        // Créer un nouvel objet si aucune instance n'existe
                        GameObject singletonObject = new GameObject(typeof(T).Name);
                        _instance = singletonObject.AddComponent<T>();
                        DontDestroyOnLoad(singletonObject);
                    }
                }
            }

            return _instance;
        }
    }

    protected virtual void Awake()
    {
        // S'assurer qu'il n'y a qu'une seule instance
        if (_instance == null)
        {
            _instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
    }
}