//The computer selects a random number between 0 and 99 
//and asks the user to guess the number. If the user guesses incorrectly, 
//the computer states whether the selected number is smaller or greater 
//than the guess. The guessing repeats until the user guesses the number.
//Avila Gyorki
//9/23/16

#include <iostream>
#include <ctime>
#include <cstdlib>

using std::cout; using std::cin; using std::endl;

int main() {

	
	cout << "I have selected a number between 0 and 99, what is it?" << endl;
	int input;
	cin >> input;
	cout << endl;

	srand(time(0));
	int value = rand() % 100;

	do{

		if (input < value){
			cout << "wrong, it is larger, what is it?" << endl;
			cin >> input;
		}

		else if (input > value){
			cout << "wrong, it is smaller, what is it?" << endl;
			cin >> input;
		}

		else{

			cout << "Correct!" << endl;
			break;
		}


	} while (true);

}