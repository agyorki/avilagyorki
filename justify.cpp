/// Justifies a string to 80 characters by adding spaces
// Avila Gyorki
// 10/24/2016

#include <string>
#include <iostream>
using std::cout; using std::endl; using std::cin; using std::string;

int main() {

	cout << "input line: " << endl;
	string userString;
	getline(cin, userString);

	const int length = 80;
	int space = 0;

	do {

		int n = rand() % 10;

		space = userString.find(' ', space);
		if (space == -1) {
			space = 0;
			continue;

			
			
			while (userString.length() < length)
			{
				if (userString.length() < length) {
					space = userString.find('.');
					while (space != string::npos) {
						userString.insert(space + 2, 1, ' ');
						space = userString.find('.', space + 3);
					}
				}

				if (userString.length() < length) {
					space = userString.find('?');
					while (space != string::npos) {
						userString.insert(space + 2, 1, ' ');
						space = userString.find('?', space + 3);
					}
				}

				if (userString.length() < length) {
					space = userString.find('!');
					while (space != string::npos) {
						userString.insert(space + 2, 1, ' ');
						space = userString.find('!', space + 3);
					}
				}

				if (userString.length() < length) {
					space = userString.find(':');
					while (space != string::npos) {
						userString.insert(space + 2, 1, ' ');
						space = userString.find(':', space + 3);
					}
				}

				if (userString.length() < length){
					space = userString.find(';');
					while (space != string::npos){
						userString.insert(space + 2, 1, ' ');
						space = userString.find(';', space + 3);
					}
				}

			} while (userString.length() < length);
		}
		 
		//adds spaces in between randomly chosen words 
		if (n >= 5) {

			n = true;

			userString.insert(space, 1, ' ');
			space += 2;
		}

		else {
			space += 1;
		}



	} while (userString.length() < length);


	cout << userString << endl;


}

