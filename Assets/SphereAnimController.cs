using UnityEngine;
using System.Collections;

public class SphereAnimController : MonoBehaviour {
	[SerializeField]
	private Animator _animator;

	[SerializeField]
	KeyCode _key;

	private bool _isAnimOn;

	public void AnimationEvent1()
	{
		print ("Somethin");
	}

	void OnGUI()
	{
		//if (Input.GetKeyDown(KeyCode.Space)) {
			//_isAnimOn = !_isAnimOn;
		//	_animator.SetBool("UpDownStart", _isAnimOn);
		//}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(_key)) {
			//_isAnimOn = !_isAnimOn;
			_animator.SetBool("UpDownStart",!_animator.GetBool("UpDownStart"));
		}
	}
}
