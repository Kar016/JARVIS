#include <stdio.h>
#include<conio.h>
/* Aplicación de operadores. */
void main(void)
{
int i = 15, j, k, l;
j = (15 > i--) > (14 < ++i);

printf("\nEl valor de j es: %d", j);
k = ! ('b' != 'd') > (!i - 1);

printf("\nEl valor de k es: %d", k);  // Como k no tiene un valor asignado va a salir 0

l = (! (34 > (70 % 2)) || 0);
printf("\nEl valor de l es: %d", l);  

getch ();
}