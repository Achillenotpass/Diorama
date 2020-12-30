using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FreezingScreen : MonoBehaviour
{
    [SerializeField]
    private GameObject m_Character = null;
    [SerializeField]
    private GameObject m_HotPosition = null;
    [SerializeField]
    private float m_HotDistance = 0.0f;
    private float m_MaxOutput = 1.0f;
    [SerializeField]
    private float m_FreezingOutput = 0.0f;
    [SerializeField]
    private Image m_FreezingScreenImage = null;



    // Update is called once per frame
    void Update()
    {
        float l_DistanceToHot = Vector3.Magnitude(m_Character.transform.position - m_HotPosition.transform.position);
        float l_ColdIntensity = l_DistanceToHot - m_HotDistance;
        m_FreezingOutput = Mathf.Clamp(l_ColdIntensity, 0.0f, m_MaxOutput);

        Color l_FreezingScreenColor = m_FreezingScreenImage.color;
        l_FreezingScreenColor.a = m_FreezingOutput;

        m_FreezingScreenImage.color = l_FreezingScreenColor;
    }
}
