 #pragma strict


 
function OnTriggerEnter2D(other : Collider2D) //Check if something has entered the trigger ( and declares this object in "other" )
 {
    if(other.tag == "Player") //Checks if the Player is inside the trigger
    {
	objectmoving.movementEnabled=true;
	objectmoving1.movementEnabled=false;
	objectmoving2.movementEnabled=false;
	objectmoving3.movementEnabled=false;
	objectmoving4.movementEnabled=false;
	objectmoving5.movementEnabled=false;
	objectmoving6.movementEnabled=false;
	objectmoving7.movementEnabled=false;
    }
 }

 
