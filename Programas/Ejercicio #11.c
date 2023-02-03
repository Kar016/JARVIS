#include <stdio.h>
#include<conio.h>
/* Aplicación de operadores. */
void main(void)
{

int i= 5, j = 7, k = 3, m1;
float x = 2.5, z = 1.8, t;

m1 = ((j % k) / 2) + 1; // El resultado del residuo es 1, luego se divide entre 2 su respuesta es 1/2 o 0.5 sumado con 1 = 1.5
m1 += i; // 1.5 + 5 = 6.5
m1 %= --i; // El residuo de 6.5/4 = 2.5 como la variable es de tipo entero se muestra el 2

printf("\nEl valor de m1 es: %d", m1);

t = ((float) (j % k) / 2); // Residuo es 1, dividido entre dos es 0.5
t++;  // Incrementas 0.5 = 1.5
x *= ++z;  // Incrementas z = 2.8 a 2.5, x * z = 7.
t -= (x += ++i); // 7+2=9, (9+1.5) = -10.5

printf("\nEl valor de t es: %.2f", t);

getch ();
}