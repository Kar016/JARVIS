#include<stdio.h>
#include<conio.h>

/* Superficie del triángulo.
El programa, al recibir como datos la base y la altura de un triángulo,
➥calcula su superficie. */

int main ()
{
    int b, h, s;

    printf("Ingrese la base y altura de un triangulo: ");
    scanf("%i,%i",&b,&h);
    printf("\n");

    s = b * h;

    printf("La superficie del triangulo es %i.",s);

    getch ();
    return 0;
}
