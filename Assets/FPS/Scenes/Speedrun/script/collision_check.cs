using UnityEngine;
using UnityEngine.Events;

public class collisioncheck : MonoBehaviour
{

    public UnityEvent m_OnCollisionEnter;
    public UnityEvent m_OnCollisionStay;
    public UnityEvent m_OnCollisionExit;

   public void OnCollisionEnter(Collision collision)
    {
        m_OnCollisionEnter.Invoke();
    }
    public void OnCollisionStay(Collision collision)
    {
        m_OnCollisionStay.Invoke();
    }
    public void OnCollisionExit(Collision collision)
    {
        m_OnCollisionExit .Invoke();
    }

}
