using UnityEngine;
using UnityEngine.UIElements;

public class UIControls : MonoBehaviour
{

    [SerializeField] private UIDocument _uiDocument;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var root = _uiDocument.rootVisualElement;
        var button = root.Q<Button>("Button");

        button.clicked += () => Debug.Log("Bouton cliqué avec UI ToolKit");

    }

    
}
