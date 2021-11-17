using UnityEngine;
using UnityEngine.EventSystems;

namespace SimpleInputNamespace
{


	public class AxisInputUIArrows : MonoBehaviour, ISimpleInputDraggable
	{
		public int frenar;
		public WheelCollider Llanta1, Llanta2, Llanta3, Llanta4;
		public Camerachange camerachange;
		public float CantidadADisminuir;
		public float CantidadAAumentar;
		 static float pitch = 1.3f;
		public float minPitch = 2.88f;
		public float VelocidadDelpitch;
		public float velocidadDeRotacion;
		public float velocidadAlSotar;
		public int Traking = 0;
		public AudioSource Acelerar6;
		public AudioSource DesAcelerar;
		public Transform Tacometro;
		public Transform TacometroInside;
		public float SpeedPerc = 0.72f;
		public SimpleInput.AxisInput xAxis = new SimpleInput.AxisInput( "Horizontal" );
		public SimpleInput.AxisInput yAxis = new SimpleInput.AxisInput( "Vertical" );

		public float valueMultiplier = 1f;

#pragma warning disable 0649
		[Tooltip( "Radius of the deadzone at the center of the arrows that will yield no input" )]
		[SerializeField]
		private float deadzoneRadius;
		private float deadzoneRadiusSqr;
#pragma warning restore 0649

		private RectTransform rectTransform;

		private Vector2 m_value = Vector2.zero;
		public Vector2 Value { get { return m_value; } }


		private void Awake()
		{

			rectTransform = (RectTransform) transform;
			gameObject.AddComponent<SimpleInputDragListener>().Listener = this;

			deadzoneRadiusSqr = deadzoneRadius * deadzoneRadius;
		}

		private void OnEnable()
		{
			xAxis.StartTracking();
			yAxis.StartTracking();
		}

		private void OnDisable()
		{
			xAxis.StopTracking();
			yAxis.StopTracking();
		}

#if UNITY_EDITOR
		private void OnValidate()
		{
			deadzoneRadiusSqr = deadzoneRadius * deadzoneRadius;
		}
#endif

		public void OnPointerDown( PointerEventData eventData )
		{
			Traking = 1;//Rastrea las pulsaciones

			CalculateInput( eventData );
		}

		private void FixedUpdate()
		{

			
		
			if(camerachange.clicks == 0 || camerachange.clicks == 3 || camerachange.clicks == 2){
			//CODIGO PARA EL TACOMETRO DESDE LA ARTE DE AFUERA
			if(Tacometro.localEulerAngles.z < 138){
				CantidadADisminuir = 0;
			}else{
				CantidadADisminuir = -0.3f;
				velocidadDeRotacion = velocidadAlSotar = 0.5f;
				}

			//Limite  positivo de Rotacion
			 if(Tacometro.localEulerAngles.z > 298.6f){
				velocidadDeRotacion = 0;
				CantidadAAumentar = 0;
			}else{
				velocidadDeRotacion = 0.4f;
				CantidadAAumentar = 0.2f;
			}

			//Limite Negativo de Rotacion
			if(Tacometro.localEulerAngles.z < 138){
				velocidadAlSotar = 0;
				
			}else{
				velocidadAlSotar = 0.5f;
				}

			if(Traking == 1 && xAxis.value==1){
				Acelerar6.pitch += CantidadAAumentar *Time.deltaTime;
				Tacometro.Rotate(0f,0f,velocidadDeRotacion);
				if(!Acelerar6.isPlaying){
					Acelerar6.Play();
			}
			}

			if(Acelerar6.pitch == 3.2f){
				CantidadAAumentar = 0;
			}
			//Activa el sonido en descenso al desAcelerar
			if(Traking == 2 || xAxis.value == -1){
				CantidadAAumentar = 0;
				Acelerar6.pitch += CantidadADisminuir * Time.deltaTime;
				Tacometro.Rotate(0f,0f,-velocidadAlSotar);
			}

			if(Acelerar6.pitch < 1.2){
				CantidadADisminuir = 0;
				Acelerar6.pitch = pitch;
			}
			}





			if(camerachange.clicks == 1){
			//CODIGO PARA EL TACOMETRO DESDE LA ARTE DE Adentro
			if(TacometroInside.localEulerAngles.z < 5){
				CantidadADisminuir = 0;
			}else{
				CantidadADisminuir = -0.3f;
				velocidadDeRotacion = velocidadAlSotar = 0.5f;
				}

			//Limite  positivo de Rotacion
			 if(TacometroInside.localEulerAngles.z > 181){
				velocidadDeRotacion = 0;
				CantidadAAumentar = 0;
			}else{
				velocidadDeRotacion = 0.4f;
				CantidadAAumentar = 0.2f;
			}

			//Limite Negativo de Rotacion
			if(TacometroInside.localEulerAngles.z < 3){
				velocidadAlSotar = 0;
				
			}else{
				velocidadAlSotar = 0.5f;
				}

			if(Traking == 1 && xAxis.value==1){
				Acelerar6.pitch += CantidadAAumentar *Time.deltaTime;
				TacometroInside.Rotate(0f,0f,velocidadDeRotacion);
				if(!Acelerar6.isPlaying){
					Acelerar6.Play();
			}
			}

			if(Acelerar6.pitch == 3.2f){
				CantidadAAumentar = 0;
			}
			//Activa el sonido en descenso al desAcelerar
			if(Traking == 2){
				CantidadAAumentar = 0;
				Acelerar6.pitch += CantidadADisminuir * Time.deltaTime;
				TacometroInside.Rotate(0f,0f,-velocidadAlSotar);
			}

			if(Acelerar6.pitch < 1.2){
				CantidadADisminuir = 0;
				Acelerar6.pitch = pitch;
			}

		
			}

				if(xAxis.value == -1){
				CantidadAAumentar = 0f;
				Acelerar6.Stop();
				frenar = 8000;
				Llanta1.brakeTorque = frenar;
				Llanta2.brakeTorque = frenar;
				Llanta3.brakeTorque = frenar;
				Llanta4.brakeTorque = frenar;
			}else{
				Llanta1.brakeTorque = 0;
				Llanta2.brakeTorque = 0;
				Llanta3.brakeTorque = 0;
				Llanta4.brakeTorque = 0;
			}
		}

		public void Freno(){
			Acelerar6.Stop();	
		}




		public void OnDrag( PointerEventData eventData )
		{
			Traking = 1;
			CalculateInput( eventData );
			
		}

		public void OnPointerUp( PointerEventData eventData )
		{
			Traking = 2;
			m_value = Vector2.zero;

			xAxis.value = 0f;
			yAxis.value = 0f;
		}

		private void CalculateInput( PointerEventData eventData )
		{
			Vector2 pointerPos;
			RectTransformUtility.ScreenPointToLocalPointInRectangle( rectTransform, eventData.position, eventData.pressEventCamera, out pointerPos );

			if( !yAxis.IsKeyValid() )
			{
				
				if( pointerPos.x * pointerPos.x <= deadzoneRadiusSqr )
					m_value.Set( 0f, 0f );
				else
					m_value.Set( pointerPos.x >= 0f ? valueMultiplier : -valueMultiplier, 0f );
			}
			else if( !xAxis.IsKeyValid() )
			{
				if( pointerPos.y * pointerPos.y <= deadzoneRadiusSqr )
					m_value.Set( 0f, 0f );
				else
					m_value.Set( 0f, pointerPos.y >= 0f ? valueMultiplier : -valueMultiplier );
			}
			else
			{
				if( pointerPos.sqrMagnitude <= deadzoneRadiusSqr )
					m_value.Set( 0f, 0f );
				else
				{
					float angle = Vector2.Angle( pointerPos, Vector2.right );
					if( pointerPos.y < 0f )
						angle = 360f - angle;

					if( angle >= 45f && angle <= 135f )
						m_value.Set( 0f, valueMultiplier );
					else if( angle >= 135f && angle <= 225f )
						m_value.Set( -valueMultiplier, 0f );
					else if( angle >= 225f && angle <= 315f )
						m_value.Set( 0f, -valueMultiplier );
					else
						m_value.Set( valueMultiplier, 0f );
				}
			}

			xAxis.value = m_value.x;
			yAxis.value = m_value.y;
		}


	}
				}


