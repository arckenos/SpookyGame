
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //print(gameObject.GetComponent<Animator>().GetBool("movingDown"));
        if (Input.GetKey("left"))
        {
            gameObject.transform.Translate(-5f * Time.deltaTime, 0, 0);
            gameObject.GetComponent<Animator>().SetBool("movingDown", false);
            gameObject.GetComponent<Animator>().SetBool("movingUp", false);
            gameObject.GetComponent<Animator>().SetBool("movingRight", false);
            gameObject.GetComponent<Animator>().SetBool("movingLeft", true);
            return;

        }
        else
        if (Input.GetKey("right"))
        {
            gameObject.transform.Translate(5f * Time.deltaTime, 0, 0);
            gameObject.GetComponent<Animator>().SetBool("movingDown", false);
            gameObject.GetComponent<Animator>().SetBool("movingLeft", false);
            gameObject.GetComponent<Animator>().SetBool("movingUp", false);
            gameObject.GetComponent<Animator>().SetBool("movingRight", true);
            return;
        }
        else
        if (Input.GetKey("up"))
        {
            gameObject.transform.Translate(0, 5f * Time.deltaTime, 0);
            gameObject.GetComponent<Animator>().SetBool("movingDown", false);
            gameObject.GetComponent<Animator>().SetBool("movingLeft", false);
            gameObject.GetComponent<Animator>().SetBool("movingRight", false);
            gameObject.GetComponent<Animator>().SetBool("movingUp", true);
            return;
        }
        else
        if (Input.GetKey("down"))
        {
            gameObject.transform.Translate(0, -5f * Time.deltaTime, 0);
            gameObject.GetComponent<Animator>().SetBool("movingLeft", false);
            gameObject.GetComponent<Animator>().SetBool("movingRight", false);
            gameObject.GetComponent<Animator>().SetBool("movingUp", false);
            gameObject.GetComponent<Animator>().SetBool("movingDown", true);
            return;
        }
        else
        {
            gameObject.GetComponent<Animator>().SetBool("movingLeft", false);
            gameObject.GetComponent<Animator>().SetBool("movingRight", false);
            gameObject.GetComponent<Animator>().SetBool("movingUp", false);
            gameObject.GetComponent<Animator>().SetBool("movingDown", false);
        }


    }
}
