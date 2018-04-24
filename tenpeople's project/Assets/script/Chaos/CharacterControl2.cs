using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof(Rigidbody2D))] //防止脚本用
[RequireComponent (typeof(Animator))]
public class CharacterControl2 : MonoBehaviour {
	private Rigidbody2D m_rigid;
	private Animator m_animator;
	private float horizontal = 0;
	private float vertical = 0;
	public float MoveSpeed = 5;
	private float move1 = 0;
	private float move2 = 0;

	void Awake()
	{
		LoadPosition ();
	}

	// Use this for initialization
	void Start () {
		m_rigid = GetComponent<Rigidbody2D>();
		m_animator = GetComponent<Animator>();
		Physics2D.queriesStartInColliders = false;
	}
	void Move(){
		horizontal = Input.GetAxis("Horizontal");
		Debug.Log ("horizontal"+horizontal);
		vertical = Input.GetAxis ("Vertical");
		Debug.Log("vertical"+vertical);
		move1 = horizontal * MoveSpeed;
		move2 = vertical * MoveSpeed;
		m_rigid.velocity = new Vector2 (move1, move2);
		if (move1 < 0) {
			this.transform.localScale = new Vector3(-Mathf.Abs (this.transform.localScale.x),this.transform.localScale.y,this.transform.localScale.z);

		} else if (move1 > 0) {
			this.transform.localScale = new Vector3(Mathf.Abs (this.transform.localScale.x),this.transform.localScale.y,this.transform.localScale.z);
		}
		if (horizontal == 0) {
			m_animator.SetFloat ("Movespeed", 1);
		}

		if (horizontal != 0) {
			m_animator.SetFloat("Movespeed", -1);
		}
		if (vertical == 0) {
			m_animator.SetFloat ("Movespeed1", 1);
			m_animator.SetFloat ("Movespeed2", 1);
		}

		if (vertical > 0) {
			m_animator.SetFloat("Movespeed1", -1);
		}
		if (vertical < 0) {
			m_animator.SetFloat("Movespeed2", -1);
		}
	}
	// Update is called once per frame
	void Update () {
		Move ();
	}

	public void ResetPosition()
	{
		RecordBurger.PreviousPosition = Vector3.zero;
	}

	public void LoadPosition()
	{
		if (RecordBurger.PreviousPosition != Vector3.zero)
		transform.position = RecordBurger.PreviousPosition;
	}

	public void SavePosition()
	{
		RecordBurger.PreviousPosition = transform.position;
	}
	public void StopControl(){
		this.enabled = false;
	}
	public void CanControl(){
		this.enabled = true;
	}
}
