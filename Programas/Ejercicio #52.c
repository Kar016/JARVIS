#include<stdio.h>
#include<conio.h>

int cubo(int);
int sumaInt(int a, int b);

void main( void)
{
    int I;
    int B;
    int r;
    int cub;

    for(I=1,B=100; I<=10; I++,B--)
    {
        r = sumaInt(I,B);
        cub = cubo(I);
        printf("El cubo de %i es: %i.\n",I,cub);
        printf("La suma de %i mas %i es: %i.\n",I,B,r);
    }
}

int cubo (int a)
{
    getch ();
    return(a*a*a);
}

int sumaInt(int a, int b)
{
    getch ();
    return a+b;
}