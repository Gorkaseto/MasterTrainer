using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pink : Wild
{
    [SerializeField]
    List<int> m_catchSuccess = new List<int> { 3, 4, 5 };
    [SerializeField]
    List<int> m_extendedCatch = new List<int> { 3, 4, 5 };

    public override List<int> catchSuccess
    {
        get
        {
            return m_catchSuccess;
        }
    }
    public override List<int> extendedCatch
    {
        get
        {
            return m_extendedCatch;
        }
        set
        {
            m_extendedCatch = value;
        }
    }

}
