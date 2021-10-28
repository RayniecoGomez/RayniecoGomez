using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController2 : MonoBehaviour
{
    public GameObject CompleteLevel;
    public Text countText;
    private int count;


    void Start()
    {
        countText.text = "";
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            setCountText();

            if (count == 7)
            {
                CompleteLevel.gameObject.SetActive(true);
            }
        }
    }

    void setCountText()
    {
        countText.text = "Score: " + count.ToString();
    }
}

