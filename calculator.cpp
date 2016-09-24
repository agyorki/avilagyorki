//Program calculates the absolute value, square root, ceiling, 
//or power of a user inputted number on a loop until an invalid
//number is entered.
//Avila Gyorki
//9/23/16


#include <iostream>
#include <cmath>
using namespace std;

int main() {
	int operation, abval;
	double x, y, num;


	while (true) {

		cout << endl;
		cout << "1. Absolute Value " << endl;
		cout << "2. Square Root " << endl;
		cout << "3. Ceiling " << endl;
		cout << "4. Power " << endl;

		cout << endl;

		cout << "Select an operation: " << endl;
		cin >> operation;

		cout << endl;


		if (operation == 1) {
			cout << "Enter a number: " << endl;
			cin >> abval;
			cout << "The absolute value is " << abs(abval) << endl;
		}


		else if (operation == 2) {
			cout << "Enter the number whose square root you want: " << endl;
			cin >> num;
			cout << "The Square Root is " << sqrt(num) << endl;

		}


		else if (operation == 3) {
			cout << "Enter the number whose ceiling you want: " << endl;
			cin >> num;
			cout << "The Ceiling is " << ceil(num) << endl;
		}


		else if (operation == 4) {
			cout << "Enter base: " << endl;
			cin >> x;
			cout << "Enter Exponent: " << endl;
			cin >> y;
			cout << "The Result is: " << pow(x, y) << endl;
		}


		else

			break;
	}

	cout << "Goodbye!" << endl;

	return 0;
}