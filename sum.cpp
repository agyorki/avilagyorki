// program asks user for numbers and then prints the sum of positive numbers that the user has input.  
// Avila Gyorki
// 9/19/2016


#include <iostream>

using std::cin; using std::cout; using std::endl;

int main() {

  	int sum = 0;
	int num;

		cout << "Input sequence of integers (zero to stop): ";
		cin >> num;

		while (num != 0) {    //so the loop only takes the numbers input before 0 
			cin >> num;
			if (num > 0) sum += sum + num;      //only adds the positive numbers
		}

	cout << "The sum of positive numbers is: " << sum << endl;
}