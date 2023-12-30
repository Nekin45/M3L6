using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngene.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUT coinsCounterText;
    public Slider healthSlider;


    void Update()
    {
        coinsCounterText.text = player.coins.ToString();

        helthSlider.maxValue = player.maxealth;
        healthSlider.value = player.health;
    }
}
