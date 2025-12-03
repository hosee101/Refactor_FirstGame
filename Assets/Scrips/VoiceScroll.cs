using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class VoiceScroll : MonoBehaviour
{

    Scrollbar bar;
    public TMP_InputField InputText;
    // Start is called before the first frame update
    void Start()
    {
        bar = GetComponent<Scrollbar>();
    }

    public void ChangeVoice()
    {
        InputText.text = Mathf.RoundToInt(bar.value*100).ToString();
        Debug.Log(bar.value);
    }

}
