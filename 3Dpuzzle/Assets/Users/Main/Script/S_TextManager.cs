using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S_TextManager : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI jumpCount;
    [SerializeField] private TextMeshProUGUI resurrectCount;
    // Start is called before the first frame update
    void Start()
    {
        jumpCount.text = "Jump";
        resurrectCount.text = "Resurrect";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
