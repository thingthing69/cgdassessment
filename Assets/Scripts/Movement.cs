using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private GameObject item;
    private Tweener tweener;
    public Animator animatorController;

    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
    }

    // Update is called once per frame
    void Update()
    {
          if(Vector3.Equals(item.transform.position, new Vector3(-12.5f, 13.5f, 0.0f)))
          {
              animatorController.ResetTrigger("Triggerrrr");
              animatorController.SetTrigger("Trigger");
              tweener.AddTween(item.transform, item.transform.position, new Vector3(-7.5f, 13.5f, 0.0f), 1.5f);
          }

          if(Vector3.Equals(item.transform.position, new Vector3(-7.5f, 13.5f, 0.0f)))
          {
              animatorController.ResetTrigger("Trigger");
              animatorController.SetTrigger("Triggerr");
              tweener.AddTween(item.transform, item.transform.position, new Vector3(-7.5f, 9.5f, 0.0f), 1.5f);
          }

          if(Vector3.Equals(item.transform.position, new Vector3(-7.5f, 9.5f, 0.0f)))
          {
              animatorController.ResetTrigger("Triggerr");
              animatorController.SetTrigger("Triggerrr");
              tweener.AddTween(item.transform, item.transform.position, new Vector3(-12.5f, 9.5f, 0.0f), 1.5f);
          }

          if(Vector3.Equals(item.transform.position, new Vector3(-12.5f, 9.5f, 0.0f)))
          {
              animatorController.ResetTrigger("Triggerrr");
              animatorController.SetTrigger("Triggerrrr");
              tweener.AddTween(item.transform, item.transform.position, new Vector3(-12.5f, 13.5f, 0.0f), 1.5f);
            }
    }
}
