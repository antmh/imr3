using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(ActionBasedController))]
public class HandController : MonoBehaviour
{
    public GameObject hand;
    private ActionBasedController controller;
    private Animator animator;

    void Start()
    {
        animator = hand.GetComponent<Animator>();
        controller = GetComponent<ActionBasedController>();
    }

    void Update()
    {
        animator.SetFloat("Grab", controller.selectAction.action.ReadValue<float>());
        animator.SetFloat("Trigger", controller.activateAction.action.ReadValue<float>());
    }
}
