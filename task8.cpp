/*
----------------------------------------------------------------
https://www.codewars.com/kata/546f922b54af40e1e90001da/train/cpp
----------------------------------------------------------------
*/


#include <string>

using namespace std;
std::string alphabet_position(const std::string& text) {
	string answ;
	for (int i = 0; i < text.size(); i++) {
		if (!(text[i] < 65 || (text[i] > 90 && text[i] < 97) || text[i] > 122)) {
			answ += to_string(tolower(text[i]) - 96) + " ";
		}
	}
	if(!answ.empty()) answ.resize(answ.size() - 1);
	return answ;
}
