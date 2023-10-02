using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OutputFieldManager : MonoBehaviour
{
    [SerializeField] private GameObject previewObject;
    private TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = previewObject.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPreview(string inputText)
    {
        string previewText = MDtoTMPConverter.Convert(inputText);
        ChangePreview(previewText);
    }

    public void ChangePreview(string previewText)
    {
        Debug.Log("changePreview: " + previewText);
        this.text.SetText(previewText);
    }
}
