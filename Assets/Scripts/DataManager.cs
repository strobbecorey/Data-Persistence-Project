using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{

    [SerializeField] string playerName;
    [SerializeField] InputField nameField;

    // Start is called before the first frame update
    void Awake()
    {
        if (Application.isPlaying)
        {
            DontDestroyOnLoad(gameObject);
        }

        nameField = nameField.GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetName()
    { 
        playerName = nameField.text.ToString();
    }
}
