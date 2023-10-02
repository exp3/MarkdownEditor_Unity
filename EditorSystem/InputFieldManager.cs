using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldManager : MonoBehaviour
{
    // input�I�u�W�F�N�g
    [SerializeField] private GameObject inputObject;
    private TMP_InputField inputField;

    // output�I�u�W�F�N�g
    [SerializeField] private GameObject outputObject;
    private OutputFieldManager outputFieldManager;

    // Start is called before the first frame update
    void Start()
    {
        // inputField�̏�����
        inputField = inputObject. GetComponent<TMP_InputField>();

        // onValidate�C�x���g��UpdateText��ǉ�
        inputField.onValueChanged.AddListener(UpdateText);

        // �o�͐�̐ݒ�
        outputFieldManager = outputObject. GetComponent<OutputFieldManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateText(string inputText)
    {
        Debug.Log(inputText);
        outputFieldManager.SetPreview(inputText);
    }
}
