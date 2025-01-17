using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControllerManager : MonoBehaviour
{
    [SerializeField]private Button m_button;
    [SerializeField]private TMP_Text m_text;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_text.text = "Titre de mon projet";
        
        // m_button.onClick.AddListener(() =>
        // {
        //     m_text.text = "Bouton cliqué";
        // });
        
       // m_button.onClick.AddListener(OnButtonClick);
    }

   public void OnButtonClick()
    {
        m_text.text = "Bouton cliqué";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
