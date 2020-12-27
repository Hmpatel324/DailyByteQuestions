Boolean RobotVacuumToOrigin(string s){
	(int x, int y) currPosition = (0,0);
	foreach(var i in s){
		switch(i){
			case 'U':
				currPosition.y += 1;
				break;
			case 'D':
				currPosition.y -= 1;
				break;
			case 'L':
				currPosition.x -= 1;
				break;
			case 'R':
				currPosition.x += 1;
				break;
			default:
				Console.WriteLine("Invalid Direction");
				break;
		}
	}
	return (currPosition.x == 0 && currPosition.y == 0);
}

//This question is asked by Amazon.Given a string representing the sequence of moves a robot vacuum makes, 
//return whether or not it will return to its original position.The string will only contain L, R, U, and D characters, representing left, right, up, and down respectively.
//Ex: Given the following strings...
//"LR", return true
//Console.WriteLine(RobotVacuumToOrigin("LR"));
//"URURD", return false
//Console.WriteLine(RobotVacuumToOrigin("URURD"));
//"RUULLDRD", return true
//Console.WriteLine(RobotVacuumToOrigin("RUULLDRD"));


bool ReturnToOrigin(string s){
	(int x, int y) position = (0,0);
	foreach(var pos in s){
		switch(pos){
			case 'L': 
				position.x -= 1;
				break;
			case 'R':
				position.x += 1;
				break;
			case 'U':
				position.y += 1;
				break;
			case 'D':
				position.y -= 1;
				break;
			default:
				break;
		}
	}
	return position == (0,0);
}

//string input;
//input = "LR";
//Console.WriteLine(ReturnToOrigin(input));
//input = "URURD";
//Console.WriteLine(ReturnToOrigin(input));
//input = "RUULLDRD";
//Console.WriteLine(ReturnToOrigin(input));

//This question is asked by Amazon.
//Given a string representing the sequence of moves a robot vacuum makes, return whether or not it will return to its original position.
//The string will only contain L, R, U, and D characters, representing left, right, up, and down respectively.
//Ex: Given the following strings...
//"LR", return true
//"URURD", return false
//"RUULLDRD", return true