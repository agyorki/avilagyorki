// the program sorts three integers
// in increasing order.
// Avila Gyorki
// 9/12/2016

#include <iostream>

using std::cin; using std::cout; using std::endl;

int main() {

	// inputs the numbers
	cout << "Enter three numbers: ";
	int x, y, z;
	cin >> x >> y >> z;

	int tmp;

	// orders x and y
	if (x > y) {
		tmp = x;
		x = y;
		y = tmp;
	}

	// orders y and z
	if (y > z) {
		tmp = y;
		y = z;
		z = tmp;
	}

	// reorders x and y
	if (x > y) {
		tmp = x;
		x = y;
		y = tmp;
	}


	// outputs the sorted numbers
	cout << "The sorted numbers are: ";
	cout << x << " " << y << " " << z << endl;
}
