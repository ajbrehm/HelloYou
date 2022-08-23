#include <stdio.h>
#include <malloc.h>
#define BUFFERSIZE 100

void main()
{
	printf("Hello. What is your name?\n");
	char* name = (char*)malloc(BUFFERSIZE);
	if (NULL == name) {
		return;
	}//if
	scanf_s("%s", name, BUFFERSIZE);
	printf("Hello, %s.\n", name);
	free(name);
}