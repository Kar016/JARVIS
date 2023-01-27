#include <stdio.h>
#include<conio.h>
/* Invierte datos
El programa, al recibir como dato un conjunto de datos de entrada, invierte el
➥orden de los mismos cuando los imprime.
A, B, C y D: variables de tipo entero. */
void main(void)
{
 int a, b, c, d;

printf("Ingrese cuatro datos de tipo entero: ");
scanf("%i",&a);

printf("Ingrese cuatro datos de tipo entero: ");
scanf("%i",&b);

printf("Ingrese cuatro datos de tipo entero: ");
scanf("%i",&c);

printf("Ingrese cuatro datos de tipo entero: ");
scanf("%i",&d);

printf("\n %i %i %i %i ",d,c,b,a);
getch ();
}