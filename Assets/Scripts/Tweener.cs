using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweener : MonoBehaviour
{
    private List<Tween> activeTweens = new List<Tween>();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        for(int i = 0; i < activeTweens.Count; i++)
        {
            if(Vector3.Distance(activeTweens[i].Target.position, activeTweens[i].EndPos) > 0.1f)
            {
                float timeFraction = (Time.time - activeTweens[i].StartTime)/activeTweens[i].Duration;
                //timeFraction = timeFraction * timeFraction * timeFraction;
                activeTweens[i].Target.position = Vector3.Lerp(activeTweens[i].StartPos, activeTweens[i].EndPos, timeFraction);
            }

            else
            {
                 activeTweens[i].Target.position = activeTweens[i].EndPos;
                 activeTweens.RemoveAt(i);
            }
        }
    }

    public bool AddTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
    {

        if(TweenExists(targetObject))
        {
            return false;
        }

        else
        {
            activeTweens.Add(new Tween(targetObject, startPos, endPos, Time.time, duration));
            return true;
        }
    }

    public bool TweenExists(Transform target)
    {
        if(activeTweens.Find(item => item.Target.position.Equals(target.position)) != null)
        {
            return true;
        }

        else
        {
            return false;
        }
    }
}
