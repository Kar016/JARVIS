#include<stdio.h>
#include<conio.h>

void cubo (int, int*);

int main ()
{
    int result = 0;
    int I;

    for(I=1; I<100; I++)
    {
        cubo(I,&result);
        printf("El cubo de %i es: %i.\n",I,result);
    }

    getch ();
    return 0;
}

void cubo(int a, int *b)
{
    *b = a*a*a;
}