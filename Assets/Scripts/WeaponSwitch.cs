using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    /// <summary>
    /// Arma seleccionada en el holder
    /// </summary>
    public int m_selectedWeapon = 0;

    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon();  
    }

    // Update is called once per frame
    void Update()
    {
        int previousWeapon = m_selectedWeapon;

        //Al mover la rueda del ratón cambiamos el arma seleccionada. Si el valor es mayor al número de armas, seleccionamos la primera
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (m_selectedWeapon >= transform.childCount - 1)
                m_selectedWeapon = 0;
            else
                m_selectedWeapon++;
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (m_selectedWeapon <= 0)
                m_selectedWeapon = transform.childCount - 1;
            else
                m_selectedWeapon--;
        }

        //Al pulsar en el los números del teclado cambiamos de arma. Comprobamos el número de hijos del transform en el caso de tener más de un arma
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            m_selectedWeapon = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2)
        {
            m_selectedWeapon = 1;
        }

        //Solo cambiamos el arma si la anterior es distinta a la seleccion actual
        if (previousWeapon != m_selectedWeapon)
            SelectWeapon();
    }

    /// <summary>
    /// Cambio de arma visible. En función del valor seleccionado activamos o desactivamos el gameobject
    /// </summary>
    ///
    void SelectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == m_selectedWeapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);

            i++;
        }
    }
}
