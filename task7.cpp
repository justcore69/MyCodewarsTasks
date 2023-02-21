/*
----------------------------------------------------------------
https://www.codewars.com/kata/5287e858c6b5a9678200083c/train/cpp
----------------------------------------------------------------
*/


#include <cmath>

using namespace std;
bool narcissistic(int value) {
	int answ = 0;
	int temp = value;
	for (; temp > 0; temp /= 10) answ += pow(temp % 10, (int)log10(value) + 1);
	return value == answ;
}
