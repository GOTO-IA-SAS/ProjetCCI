using System.Threading.Tasks;
using UnityEngine;

public class IaTask : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    async void Start()
    {
        //await IATask();
        Task.Run(()=>IA_Task());
    }


    async Task IATask()
    {
        
        for(int i = 0; i < 10; i++)
        {
            Debug.Log("IaTask");
            
        }
        
        await Task.Delay(1000);
        
    }

    void IA_Task()
    {
        
        for(int i = 0; i < 10; i++)
        {
            Debug.Log("IaTask");
            System.Threading.Thread.Sleep(1000);    
            
        }
    }
    
    
}
