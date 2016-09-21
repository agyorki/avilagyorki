// This program inputs a two-digit natural number (from 1 to 99) and outputs this number spelled out in English. 
// Avila Gyorki
// 9/12/2016

#include <iostream>

using std::cin; using std::cout; using std::endl;

int main() {

	cout << "Input number from 01 to 99: ";
	int number;
	cin >> number;

	const int singles = number % 10;
	const int tens = number / 10;

	if (tens == 1) {

		switch (singles) {
		case 0:
			cout << "ten" << endl;	
			break;
		case 1: 
			cout << "eleven" << endl;
			break;
		case 2: 
			cout << "twelve" << endl;
			break;
		case 3:
			cout << "thirteen" << endl;
			break;
		case 4:
			cout << "fourteen" << endl;
			break;
		case 5:
			cout << "fifteen" << endl;	
			break;
		case 6:
			cout << "sixteen" << endl;
			break;
		case 7:
			cout << "seventeen" << endl;
			break;
		case 8:
			cout << "eighteen" << endl;
			break;
		case 9:
			cout << "nineteen" << endl; 
			break;

		}

	}

	else {
		switch (tens) {
		case 0:
			cout << "" << endl;
			break;
		case 2:
			cout << "twenty";
			break;
		case 3:
			cout << "thirty";
			break;
		case 4:
			cout << "fourty";
			break;
		case 5:
			cout << "fifty";
			break;
		case 6:
			cout << "sixty";
			break;
		case 7:
			cout << "seventy";
			break;
		case 8:
			cout << "eighty";
			break;
		case 9:
			cout << "ninety";
			break;
		}
		switch (singles) {
		case 0:
			cout << "" << endl;
			break;
		case 1:
			cout << "one" << endl;
			break;
		case 2: 
			cout << "two" << endl;
			break;
		case 3:
			cout << "three" << endl;
			break;
		case 4:
			cout << "four" << endl;
			break;
		case 5: 
			cout << "five" << endl;
			break;
		case 6:
			cout << "six" << endl;
			break;
		case 7:
			cout << "seven" << endl;
			break;
		case 8:
			cout << "eight" << endl;
			break;
		case 9:
			cout << "nine" << endl;
			break;
		}
	}

		
	
}