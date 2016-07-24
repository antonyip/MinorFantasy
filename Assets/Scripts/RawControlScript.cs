using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class RawControlScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		/*
		//default to android / any other platform
		#if UNITY_ANDROID
		const float SOME_TOLERANCE = 5;
		#elif UNITY_IPHONE
		const float SOME_TOLERANCE = 40;
		#endif
		
		List<Vector2> startVecs = new List<Vector2>();
		List<Vector2> dragVecs = new List<Vector2>();
		
		//iterate reverse so we can remove entries
		for( int i = Input.touches.Length-1 ; i >= 0 ; --i ) 
		{
			Touch touch = Input.touches[i];
			//you track the phase of the touch, you can store the position at TouchPhase.Began as start position and while phase != TouchPhase.Ended you can consider the touch as held or dragging and track the position-startPosition as draggingVector.
			if( touch.phase == TouchPhase.Began )
			{
				if( i >= startVecs.Count )
				{
					startVecs.Add(touch.position);
					dragVecs.Add(Vector2.zero);
				}
				else
				{
					startVecs[i] = touch.position;
					dragVecs[i] = Vector2.zero;
				}
			}
			
			dragVecs[i] = touch.position - startVecs[i];
			
			if( touch.phase == TouchPhase.Ended )
			{
				if( dragVecs[i].sqrMagnitude < SOME_TOLERANCE )
				{
					//it was a release without dragging, hence a tap (which could've been held for ages if the user wants to, he just pressed and released on the same place)
				}
				else
				{
					//it was a dragging operation
				}
			}
			
			
			if( touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled )
			{
				startVecs.RemoveAt(i);
				dragVecs.RemoveAt(i);
			}
		}
		*/
	}

}
