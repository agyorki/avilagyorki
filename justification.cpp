// Justifies text from one file and places it into another. 
// Avila Gyorki	
// 10/28/2016




#include <string>
#include <fstream>
#include <iostream>

using std::cout; using std::endl; using std::cin; using std::string;
using std::ifstream; using std::ofstream;


string textJustification(string& text);
int main()
{
	string file;
	file = "unjustified.txt";
	ifstream unjust(file.c_str());

	ofstream just;
	just.open("justified.txt");



	//takes text from unjustified one line at a time.
	string line;

	if (unjust.is_open()) {

		// While the file is good the text is written to justified.txt
		while (unjust.good()) {

			// Gets the current line in the file and 
			// ensures that each line inputted starts on a new line
			getline(unjust, line);
			just << textJustification(line) << endl;
		}
	}

	just.close();
	unjust.close();
	return 0;
}


string textJustification(string& text) {

	const int length = 80;
	int space = 0;
	bool x = false;

	int n = rand() % 10;

	space = text.find(' ', space);

		while (text.length() < length) {

			if (text.length() < 40) {
				break;
			}

			if (space == -1) {
				space = 0;
			}

			//these if statements check before executing if the line length is correct.
			//If it is, they find the punctuation and while the string isn't npos 
			//they insert a space and find the next occurance of the punctuation.
			if (text.length() < length) {
				space = text.find('.');
				if (space != string::npos) {
					text.insert(space + 2, 1, ' ');
					space = text.find('.', space + 3);
				}
			}

			if (text.length() < length) {
				space = text.find('?');
				if (space != string::npos) {
					text.insert(space + 2, 1, ' ');
					space = text.find('?', space + 3);
				}
			}

			if (text.length() < length) {
				space = text.find('!');
				if (space != string::npos) {
					text.insert(space + 2, 1, ' ');
					space = text.find('!', space + 3);
				}
			}

			if (text.length() < length) {
				space = text.find(':');
				if (space != string::npos) {
					text.insert(space + 2, 1, ' ');
					space = text.find(':', space + 3);
				}
			}

			if (text.length() < length) {
				space = text.find(';');
				if (space != string::npos) {
					text.insert(space + 2, 1, ' ');
					space = text.find(';', space + 3);
				}
			}

			if (space == -1) {
				space = 0;
			}

			//adds spaces in between randomly chosen words.
			n = rand() % 10;
			if (n >= 5 && text.length() < 80) {

				n = true;
				space = text.find(' ', space);
				text.insert(space, 1, ' ');
				space += 2;
				
			}

			if (space == -1) {
				space = 0;
			}

			//brings you to the next character position to check 
			else if (n < 5) {
				space = text.find(' ', space);
				space += 1;
				
			}

			n = rand() % 10;

	}

	
		cout << text << endl;
		return text;

}
