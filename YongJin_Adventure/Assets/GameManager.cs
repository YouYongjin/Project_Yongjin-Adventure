using System.Collections;                               
using System.Collections.Generic;                       
using UnityEngine;                                      
                                                        
public class GameManager : MonoBehaviour                
{                                                       
    public PlayerController playerController;           
                                                        
    //public Transform playerTransform;                   /* Player ĳ������ Transform�� ����. */
    //public float baseHeight = 0f;                       /* ���� ���� ���� ����. */
                                                        
    //public float playerYPos = 0f;                       
    //public float resultYPos = 0f;                       
                                                        
    //void Awake()                                        
    //{                                                   
    //    playerTransform = playerController.transform;   
    //}                                                    
                                                        
    //void FixedUpdate()                                  
    //{                                                   
    //    // Player ĳ������ Y�� ��ġ.                    
    //    playerYPos = playerTransform.position.y;        
                                                        
    //    //���� ���� ���� ���Ͽ� ���� ��ġ ���.                                                
    //    resultYPos = playerYPos + baseHeight;           
                                                        
    //    Debug.Log($"Player Y Position: {playerYPos:F2}, Base Height: {baseHeight:F2}, Result Y Position: {resultYPos:F2}");
    //}            
    
    public void PlayerCurrentLocation(Transform playerTransform, float baseHeight, float playerYPos, float resultYPos)
    {
        playerTransform = playerController.transform;
        baseHeight = 0f;
        playerYPos = playerTransform.position.y;
        resultYPos = playerYPos + baseHeight;

        playerYPos = playerTransform.position.y;

        //���� ���� ���� ���Ͽ� ���� ��ġ ���.                                                
        resultYPos = playerYPos + baseHeight;

        Debug.Log($"Player Y Position: {playerYPos:F2}, Base Height: {baseHeight:F2}, Result Y Position: {resultYPos:F2}");
    }
}                                                       