using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldManager : MonoBehaviour
{
    // inputオブジェクト
    [SerializeField] private GameObject inputObject;
    private TMP_InputField inputField;
    
    // outputオブジェクト
    [SerializeField] private GameObject previewObject;
    private TMPro.TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        // inputFieldの初期化
        inputField = inputObject. GetComponent<TMP_InputField>();

        // onValidateイベントにUpdateTextを追加
        inputField.onValueChanged.AddListener(UpdateText);

        // 出力先の設定
        text = previewObject.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateText(string inputText)
    {
        Debug.Log(inputText);
        text.SetText(inputText);
    }
}
