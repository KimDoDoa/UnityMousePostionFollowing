// 마우스 좌표
Vector3 mousePos = Input.mousePosition;

//카메라로부터 오브젝트가 놓일 거리
mousePos.z = 값; 

//월드 좌표로 변환
Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

//부드럽게 따라가기 
transform.position = Vector3.Lerp(transform.position, worldPos, 0.1f);
