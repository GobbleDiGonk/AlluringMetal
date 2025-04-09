using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class SeductiomBar : MonoBehaviour
{
    public Image seductionBar;
    public float currentLust;
    public float maxLust = 100;
    public float fillSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    public void updateHealthBar(float amount)
    {
        currentLust += amount;
        addLust();
    }

    private void addLust()
    {
        float addAmount = currentLust / maxLust;
        seductionBar.DOFillAmount(addAmount, fillSpeed);
    }
}
