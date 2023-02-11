#include<stdio.h>
#include<conio.h>

int cubo (void);
int I;

void main (void)
{
    int cub;

    for(I=1; I<=10; I++)
    {
        cub = cubo();
        printf("El cubo de %i es: %i.\n",I,cub);
    }

}

int cubo (void)
{
    getch ();
    return (I*I*I);
}