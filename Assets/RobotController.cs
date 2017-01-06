using UnityEngine;
using System.Collections;

public class RobotController : MonoBehaviour {
	[SerializeField]
	private Animator _animator;
	private bool _isWalk;
	[SerializeField,Range(0,1)]
	private float _speed;
	[SerializeField]
	private SpriteRenderer _sprite;
	
	void Update () {
		if (Input.GetKey(KeyCode.RightArrow)) {
			_animator.SetBool("Walk",true);
			_sprite.flipX = false;
			_animator.transform.Translate (new Vector3(1,0)*_speed);
		}

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			_animator.SetBool("Walk",true);
			_sprite.flipX = true;
			_animator.transform.Translate (new Vector3(-1,0)*_speed);
		}

		if (Input.GetKeyUp (KeyCode.RightArrow)) 
		{
			_animator.SetBool("Walk",false);
		}

		if (Input.GetKeyUp (KeyCode.LeftArrow))
		{
			_animator.SetBool("Walk",false);
		}
	}
}
