public class Platform : MonoBehaviour
{
	[SerializeField] private float speed;
	[SerializeField] private Transform upperPoint;
	[SerializeField] private Transform bottomPoint;

	bool goingUp;
	
	// Start is called before the first frame update
	void Start()
	{
        	goingUp = false;
	}
	// Update is called once per frame
	void Update()
	{
        	if (transform.position.y > upperPoint)
		{
			goingUp = false;
		}
		if (transform.position.y < bottomPoint)
		{
			goingUp = true;
		}
	}
	private void OnCollisonStay(Collision collison)
	{
		if (collison.gameObject.CompareTag("Player"))
		{
			if (goingUp)
			{
				transform.Translate(Vector2.up * speed * Time.deltaTime);
			}
			else
			{
				transform.Translate(Vector2.down * speed * Time.deltaTime);		
			}
		}
	}
}
