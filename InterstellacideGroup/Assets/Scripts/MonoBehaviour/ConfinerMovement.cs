using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConfinerMovement : MonoBehaviour
{


    
    void Awake()
    {
        // DontDestroyOnLoad(Character);
        // DontDestroyOnLoad(this.gameObject);
    }

    

    public float moveSpeed = 0.01f;
    Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2){
            moveSpeed = 0f;
        }
        transform = GetComponent<Transform>();
        Debug.Log(moveSpeed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

         if (SceneManager.GetActiveScene().buildIndex == 3){
            moveSpeed = 0f;
        }
         
        Debug.Log(moveSpeed);

        transform.Translate(moveSpeed, 0, 0);
    }
}
