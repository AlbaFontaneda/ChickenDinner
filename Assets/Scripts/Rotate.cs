using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public Transform m_AnotherCube;
    public Vector3 m_AxisVelocity;
    
    [SerializeField]
    private Vector3 m_AnotherRotationSpd;

    [System.Serializable]
    public class SerializableDataStruct
    {
        public int m_Indice;
        public string m_Valor;
    }
    public SerializableDataStruct m_SerializedStruct;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(3.4f, 0f, 0f);

        //GameObject go = GameObject.Find("AnotherObject");
        //go.transform.Rotate(0f, 0f, 5f);
        m_AnotherCube.transform.Rotate(m_AxisVelocity);
    }
}
