using UnityEngine;

public class dialogueChoice : MonoBehaviour
{
    public GameObject dialogue1;
    public GameObject dialogue2;
    public GameObject dialogue3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        dialogue1.SetActive(true);
        dialogue2.SetActive(false);
        dialogue3.SetActive(false);
    }
    public void nextDialogue()
    {
        dialogue1.SetActive(false);
        dialogue2.SetActive(true);
    }
    public void nextDialogue2()
    {
        dialogue2.SetActive(false);
        dialogue3.SetActive(true);
    }

    public void nextDialogue3()
    {

    }
}
