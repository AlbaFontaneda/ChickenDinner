using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlane : MonoBehaviour
{
    /// <summary>
	/// El jugador
	/// </summary>
	public GameObject m_Player = null;

    /// <summary>
    /// Game Manager para hacer respawn del jugador
    /// </summary>
    private GameObject m_GameManager = null;
    // Start is called before the first frame update
    void Start()
    {
        m_GameManager = GameObject.FindGameObjectWithTag("GameManager");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == m_Player.tag)
        {
            m_GameManager.SendMessage("RespawnPlayer");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
