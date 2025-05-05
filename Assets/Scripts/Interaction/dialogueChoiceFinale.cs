using UnityEngine;

public class dialogueChoiceFinale : MonoBehaviour
{
    public GameObject dialogue1;
    public GameObject dialogue2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        dialogue1.SetActive(true);
        dialogue2.SetActive(false);

    }
    public void nextDialogue()
    {
        dialogue1.SetActive(false);
        dialogue2.SetActive(true);
    }
}
