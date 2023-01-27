#include<stdio.h>
#include<conio.h>

int main ()
{
    float x, b;

    printf("Ingrese un numero decimal: ");
    scanf("%f", &x);

    x = 0.0;
    b = 0.0;

    b = x;

    while (!(b == (x/b)))
    {
        b = 0.5 * ((x/b)+b);
    }

    printf("La raiz cuadrada de %f es: %f",x,b);

    getch ();
    return 0;
}