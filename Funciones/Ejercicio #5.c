#include<stdio.h>
#include<conio.h>

void f1(int *);

void main (void)
{
    int I, K = 4;

    for(I=1; I<=3; I++)
    {
        printf("\n\nValor de K antes de llamar a la función: %d",++K);
        printf("\nValor de K después de llamar a la función: %d",&K);
    }

    getch ();
}

void f1(int *R)
{
    *R += *R;
}