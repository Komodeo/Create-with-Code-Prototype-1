using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinText : MonoBehaviour
{

    public Text textArea;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.gameWon == true)
        {
            textArea.text = PlayerController.winText;
        }
    }
}
