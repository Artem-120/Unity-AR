using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseObject : MonoBehaviour
{
    private ProgrammManager ProgrammManagerScript;

    private Button button;

    public GameObject ChoosedObject;

    void Start()
    {
        ProgrammManagerScript = FindObjectOfType<ProgrammManager>();

        button = GetComponent<Button>();
        button.onClick.AddListener(ChooseObjectFunction);

    }

    void ChooseObjectFunction()
    {
        ProgrammManagerScript.ObjectToSpawn = ChoosedObject;
        ProgrammManagerScript.ChooseObject = true;
        ProgrammManagerScript.ScrollView.SetActive(false);
    }
}
