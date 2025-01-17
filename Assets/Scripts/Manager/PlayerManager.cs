using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private GameObject m_prefabInventaire;
    [SerializeField] private GameObject m_prefabPlayer;
    

     async void Start()
     {
            
           // StartCoroutine(Loading());
           
           if(m_prefabPlayer is not null && m_prefabInventaire is not null)
           {
               Quaternion playerRotation = m_prefabPlayer.transform.rotation;
               GameObject instance=Instantiate(m_prefabInventaire,m_prefabPlayer.transform.position,playerRotation);
               instance.transform.SetParent(m_prefabPlayer.transform);
               
           }
         

     }
     
     

     async Task LoadDate()
     {
         await Task.Delay(3000);
         Debug.Log("Données chargées");
     }

    public void UpdatePlayer()
    {
        Debug.Log("PlayerManager UpdatePlayer");
        
        m_prefabInventaire.GetComponent<InventaireManager>().UpdateInventaire();

    }

    IEnumerator Loading()
    {
        Debug.Log("Debut du chargement");
        yield return new WaitForSeconds(3);
        Debug.Log("Fin du chargement");
        
    }
    
    
}
