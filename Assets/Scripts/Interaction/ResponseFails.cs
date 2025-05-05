using UnityEngine;
using TMPro;

public class ResponseFails : MonoBehaviour
{
    public GameObject failResponses;
    public GameObject failText1;
    public GameObject failText2;
    public GameObject failText3;
    public GameObject responses;
    public GameObject npcText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        failResponses.SetActive(false);
    }

    public void loadFailText1()
    {
        failText1.SetActive(true);
        failText2.SetActive(false);
        failText3.SetActive(false);
        responses.SetActive(false);
        npcText.SetActive(false);
        failResponses.SetActive(true);
    }
    public void loadFailText2()
    {
        failText1.SetActive(false);
        failText2.SetActive(true);
        failText3.SetActive(false);
        responses.SetActive(false);
        npcText.SetActive(false);
        failResponses.SetActive(true);
    }
    public void loadFailText3()
    {
        failText1.SetActive(false);
        failText2.SetActive(false);
        failText3.SetActive(true);
        responses.SetActive(false);
        npcText.SetActive(false);
        failResponses.SetActive(true);
    }
}
