using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilemap : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D cn)
	{
		var nContact = cn.contactCount;
		Debug.Log($"ENTER with {nContact} contact points");
		foreach (var contact in cn.contacts)
		{
			var debugLineOffset00 = new Vector2(-0.1f, -0.1f);
			var debugLineOffset01 = new Vector2(-0.1f, 0.1f);
			var debugLineOffset10 = new Vector2(0.1f, -0.1f);
			var debugLineOffset11 = new Vector2(0.1f, 0.1f);
			var position = contact.point;
			Debug.DrawLine(position + debugLineOffset00, position + debugLineOffset11, Color.white, 3f);
			Debug.DrawLine(position + debugLineOffset10, position + debugLineOffset01, Color.white, 3f);
		}
	}

	void OnCollisionStay2D(Collision2D cn)
	{
		var nContact = cn.contactCount;
		Debug.Log($"STAY with {nContact} contact points");
		foreach (var contact in cn.contacts)
		{
			var debugLineOffset00 = new Vector2(0f, -0.05f);
			var debugLineOffset01 = new Vector2(-0.05f, 0f);
			var debugLineOffset10 = new Vector2(0.05f, 0f);
			var debugLineOffset11 = new Vector2(0f, 0.05f);
			var position = contact.point;
			Debug.DrawLine(position + debugLineOffset00, position + debugLineOffset11, Color.yellow, 0.5f);
			Debug.DrawLine(position + debugLineOffset10, position + debugLineOffset01, Color.yellow, 0.5f);
		}
	}

	void OnCollisionExit2D(Collision2D cn)
	{
		Debug.Log($"EXIT");
	}
}
