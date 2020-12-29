using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    [SerializeField]
    private float m_Speed = 1.0f;

    private void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(Input.GetAxisRaw("Vertical"), 0.0f, -Input.GetAxisRaw("Horizontal")) * m_Speed * Time.deltaTime, Space.Self);
        transform.Rotate(0.0f, Input.GetAxisRaw("Mouse X"), 0.0f);
    }
}
