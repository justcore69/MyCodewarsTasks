/*
----------------------------------------------------------------
https://www.codewars.com/kata/526571aae218b8ee490006f4/train/cpp
----------------------------------------------------------------
*/


#include<iostream>
#include<cmath>

unsigned int countBits(unsigned long long n) {
	std::cout << "Start N: " << n << "\n";

	int answ = 0;
	unsigned long long pow = 2;
	int i = 1;
	while (pow < n) {
		pow = std::pow(2, i);
		std::cout << "pow:" << pow << "\n";
		i++;
	}
	while (n > 0) {
		if (pow <= n) {
			n -= pow;
			answ++;
		}
		pow /= 2;
		std::cout << "n: " << n << "\n";
	}
	return answ;
}
