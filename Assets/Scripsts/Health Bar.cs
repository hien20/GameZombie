using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image _healthBar;
    public void updateHealthBar(float _health, float _maxHealth)
    {
        _healthBar.fillAmount = _health / _maxHealth;
    }

}
