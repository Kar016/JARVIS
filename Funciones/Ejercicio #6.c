#include<stdio.h>
#include<conio.h>

int f1 (int);

void main(void)
{
    int I, A, K = 4;

    A += f1;

    for(I=1; I<=3; I++)
    {
        printf("\n\nValor de K antes de llamar a la función: %d",++K);
        printf("\nValor de K después de llamar a la función: %d",A);
    }

    getch ();
}

int f1(int R)
{
    R += R;
    return (R);
}