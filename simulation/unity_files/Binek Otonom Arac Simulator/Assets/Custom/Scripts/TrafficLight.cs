using System.Collections;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    public float StayAtRedTime;
    public float StayAtYellowTime;
    public float StayAtGreenTime;

    enum ActiveColor
    {
        RED = 0,
        YELLOW = 1,
        GREEN = 2
    }

    private float m_LocalTimer;
    private StateNode m_CurrentState;
    private StateNode m_InitialState;
    private bool m_Advance;
    private Light[] m_Lights;

    private class StateNode
    {
        public StateNode Next;
        public ActiveColor Value;

        public StateNode(ActiveColor value)
        {
            Value = value;
        }
    }

    void Start()
    {
        m_LocalTimer = 0;
        m_Advance = false;
        m_CurrentState = null;
        m_InitialState = null;
        m_Lights = null;

        InitializeStateList();
        m_CurrentState = m_InitialState;

        GetLights();

        StartCoroutine(ControlLights());
    }

    void GetLights()
    {
        m_Lights = GetComponentsInChildren<Light>();
        foreach (var light in m_Lights)
        {
            light.enabled = false;
        }
        m_Lights[(int)m_CurrentState.Value].enabled = true;
    }

    void InitializeStateList()
    {
        m_InitialState = new StateNode(ActiveColor.RED);
        m_CurrentState = m_InitialState;

        m_CurrentState.Next = new StateNode(ActiveColor.YELLOW);
        m_CurrentState = m_CurrentState.Next;

        m_CurrentState.Next = new StateNode(ActiveColor.GREEN);
        m_CurrentState = m_CurrentState.Next;

        m_CurrentState.Next = new StateNode(ActiveColor.YELLOW);
        m_CurrentState = m_CurrentState.Next;
        
        m_CurrentState.Next = m_InitialState;
    }

    void AdvanceState()
    {
        
        m_Lights[(int)m_CurrentState.Value].enabled = false;
        m_CurrentState = m_CurrentState.Next;
        m_Lights[(int)m_CurrentState.Value].enabled = true;
    }


    IEnumerator ControlLights()
    {
        yield return new WaitForSeconds(StayAtRedTime);
        AdvanceState();

        yield return new WaitForSeconds(StayAtYellowTime);
        AdvanceState();

        yield return new WaitForSeconds(StayAtGreenTime);
        AdvanceState();

        yield return new WaitForSeconds(StayAtYellowTime);
        AdvanceState();

        StartCoroutine(ControlLights());
    }


}
