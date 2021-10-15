using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Scare.Dialog;
public class DialogTriggerTest : MonoBehaviour
{

    [SerializeField]
    public DialogController controller;
    [SerializeField]
    public Dialog dialogRoot;

    private void Start()
    {
        StartCoroutine(StartConversation());
    }

    private IEnumerator StartConversation()
    {
        yield return new WaitForSeconds(3f);

        controller.StartDialog(dialogRoot);
    }

}
