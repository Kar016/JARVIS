# include <stdio.h>
#include<conio.h>

/* Factorial.
El programa calcula el factorial de un número entero.
FAC, I, NUM: variables de tipo entero. */
void main(void)
{
int I, NUM;
long FAC;
printf("\nIngrese el número: ");
scanf("%d", &NUM);
if (NUM >= 0)
{
FAC = 1;
for (I=1; I <= NUM; I++)
Problema PR3.2
Escribe un diagrama de flujo y el correspondiente programa en C que obtenga y
escriba tanto los términos como la suma de los términos de la siguiente serie:
2, 7, 10, 15, 18, 23, . . ., 2500
Problemas resueltos 111
3
FAC *= I;
printf("El factorial de %d es: %ld", NUM, FAC);
}
else
printf("\nError en el dato ingresado");

getch ();
}