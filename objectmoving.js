#pragma strict

private var Xpos : float;
private var Ypos : float;
private var max : boolean;

var Vert : boolean;
var maxAmount : float;
var step : float;

public static var movementEnabled: boolean;

movementEnabled = false;

function changeState(){
	if(movementEnabled){ 
			movementEnabled=false;
			}
	else{ 
			movementEnabled=true;
			}
}


function Start () {
	this.gameObject.tag = "movingObjects";
	Xpos = transform.position.x;
	Ypos = transform.position.y;
}



function Update () {
	if(movementEnabled){
	
	//SET THE MAX
	if(Vert){ //Vertical
		if(transform.position.y >= Ypos + maxAmount){
			max = true;
			} 
		else if(transform.position.y <= Ypos){
			max = false;
			}
		}
	else {
		if(transform.position.x >= Xpos + maxAmount){
			max = true;
			}
		else if(transform.position.x <= Xpos){
			max=false;
			}
			}
	


	
	//MOVING THE PLATFORM
	if(Vert){ // Vertical movement
			if(!max){
					transform.position.y += step;
			}
			else {
					transform.position.y -= step;
			}
	}
	
	else { //Horizontal movement
			if(!max){
					transform.position.x += step;
			}
			else {
					transform.position.x -= step;
				}
		}
}
}
