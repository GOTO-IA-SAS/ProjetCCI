using UnityEngine;
using System.Collections.Generic;


public class InventaireManager : MonoBehaviour
{
    [SerializeField] private List<Object> objets = new List<Object>();
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created  
    void Start()
    {
        Debug.Log("Inventaire managers");

        
    }
    
    public void addObjectToList(Object_ obj)
    {
        objets.Add(obj);
        Debug.Log("Objet ajouté à la liste :"+obj.name);
    }


    public void UpdateInventaire()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Object_ newObject = new Object_();
            newObject.m_name = "Objet";
            newObject.m_description = "Description de l'objet";
            newObject.m_sprite = null;
            
            addObjectToList(newObject);

        }
        
    }


}
