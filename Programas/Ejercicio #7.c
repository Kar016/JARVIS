#include<stdio.h>
#include<conio.h>
/* Promedio de sueldos.
El programa, al recibir como datos seis sueldos de un empleado, calcula tanto el
➥ingreso total como el promedio mensual.
CLA: variable de tipo entero.
SU1, SU2, SU3, SU4, SU5, SU6, ING, PRO: variables de tipo real. */

int main ()
{
   int c;
   float u, v, w, x, y, z, i, p;

   printf("Ingrese la clave del trabajador: ");
   scanf("%i",&c);
   printf("\n");

   printf("Ingrese el sueldo del primer empleado: ");
   scanf("%f",&u);

   printf("Ingrese el sueldo del segundo empleado: ");
   scanf("%f",&v);

   printf("Ingrese el sueldo del tercer empleado: ");
   scanf("%f",&w);

   printf("Ingrese el sueldo del cuarto empleado: ");
   scanf("%f",&x);

   printf("Ingrese el sueldo del quinto empleado: ");
   scanf("%f",&y);

   printf("Ingrese el sueldo del sexto empleado: ");
   scanf("%f",&z);

   i = u + v + w + x + y + z;
   p = i / 6;

   printf("Clave de empleado: %i. Ingreso total: %5.2f. Promedio mensual: %5.2f.\n",c,i,p);

    getch ();
    return 0;
};