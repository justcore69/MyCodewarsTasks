/*
----------------------------------------------------------------
https://www.codewars.com/kata/58f5c63f1e26ecda7e000029/train/cpp
----------------------------------------------------------------
*/


#include <vector>
#include <string>

std::vector<std::string> wave(std::string y) {
	std::vector<std::string> answ = {};

	for (int i = 0; i < y.size(); i++) {
		std::string str = y;
		if (str[i] != ' '){
			str[i] = std::toupper(str[i]);
			answ.push_back(str);
		}
	}
	return answ;
}
