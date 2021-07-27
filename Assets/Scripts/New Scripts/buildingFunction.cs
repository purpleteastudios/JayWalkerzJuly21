using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingFunction : MonoBehaviour
{
    public GameMechanics GameOverScript;

    // Start is called before the first frame update
    void Start()
    {
        GameOverScript = GameObject.Find("Scripts").GetComponent<GameMechanics>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collision){
        //Debug.Log(collision.name);
        if(collision.name == "Player"){
            Debug.Log("collision");
            GameOverScript.GameOver();
            
        }
    }

    
}
