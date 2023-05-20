using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    
    private Rigidbody playerRigidbody;
    public float speed;
        public Text skor;
        int score = 0;

        void Start() {
            playerRigidbody = GetComponent<Rigidbody>();

        }

        void Update()
        {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
    }
           /* if (Input.GetKey (KeyCode.LeftArrow)){
                transform.Translate (0,0,speed);
            }
            if (Input.GetKey (KeyCode.RightArrow)){
                transform.Translate (0,0,-speed);
            }
            if (Input.GetKey (KeyCode.UpArrow)){
                transform.Translate (speed,0,0);
            }
            if (Input.GetKey (KeyCode.DownArrow)){
                transform.Translate (-speed,0,0);
            }
        }*/
    
    public GameObject LvWonUI;
        void OnTriggerEnter(Collider obj){
            if (obj.gameObject.tag == "target"){
                Destroy (obj.gameObject);
                score += 5;
                skor.text ="Skor :"+ score.ToString();
            }
            if (score == 245){
                LvWonUI.SetActive(true);
            }
        }
}
