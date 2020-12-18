using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezingScreen : MonoBehaviour
{
    private Camera m_MainCamera = null;
    [SerializeField]
    private GameObject m_HotPosition = null;
    [SerializeField]
    private float m_HotDistance = 0.0f;
    private float m_MaxOutput = 1.0f;
    [SerializeField]
    private float m_FreezingOutput = 0.0f;


    private void Awake()
    {
        m_MainCamera = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        float l_DistanceToHot = Vector3.Magnitude(m_MainCamera.transform.position - m_HotPosition.transform.position);
        float l_ColdIntensity = l_DistanceToHot - m_HotDistance;
        m_FreezingOutput = Mathf.Clamp(l_ColdIntensity, 0.0f, m_MaxOutput);
    }
}
