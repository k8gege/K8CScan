#include <iostream>
using namespace std;

extern "C" _declspec(dllexport) int scan(char* string) 
{ 
	 printf("%s\n",string);
	 return 0; 
}
