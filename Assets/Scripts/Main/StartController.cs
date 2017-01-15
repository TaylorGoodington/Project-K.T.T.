using UnityEngine;

public class StartController : MonoBehaviour
{
    private Animator animator;
    private string levelDestination;

	void Start ()
    {
        animator = GetComponent<Animator>();
	}

    public void TransitionOut (string destination)
    {
        levelDestination = destination;
        animator.Play("transitionOut");
    }

    public void CallGoToLevel ()
    {
        GameControl.GoToLevel(levelDestination);
    }
}