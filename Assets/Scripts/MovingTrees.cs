using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTrees : MonoBehaviour
{
    [SerializeField]
    private float m_Duration = 1.0f;
    [SerializeField]
    private float m_AngleMovement = 3.0f;

    private void Start()
    {
        StartCoroutine(TreesRotation(m_Duration));
    }

    private IEnumerator TreesRotation(float p_Duration)
    {
        float l_Timer = 0.0f;
        Quaternion l_OriginRotation = transform.rotation;

        while (l_Timer <= p_Duration)
        {
            l_Timer = l_Timer + Time.deltaTime;
            if (l_Timer > p_Duration)
            {
                break;
            }
            transform.rotation = Quaternion.Lerp(l_OriginRotation, Quaternion.Euler(0.0f, l_OriginRotation.y + m_AngleMovement, 0.0f), l_Timer/p_Duration);
            yield return null;
        }

        m_AngleMovement = m_AngleMovement * -1;
        StartCoroutine(TreesRotation(m_Duration));
    }

}
