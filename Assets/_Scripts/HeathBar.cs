using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class HeathBar : MonoBehaviour
{
    [Range(0, 100)]
    public int currentHealth;

    [Range(1, 100)]
    public int maximunHealth;

    public Slider healthBarSlider;

    // Start is called before the first frame update
    void Start()
    {
        healthBarSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            TakeDamage(10);
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            TakeDamage(-10);
        }
    }

    public void Reset()
    {
        healthBarSlider.value = maximunHealth;
        currentHealth -= (int)healthBarSlider.value;
    }

    public void TakeDamage(int damage)
    {
        healthBarSlider.value -= damage;
        currentHealth -= (int)healthBarSlider.value;
    }
}
