#include<stdio.h>
#include<conio.h>

void solicitar (int pago, int horas)
{
    int a;

    a = pago * horas;
    printf("Total de pago es : %i$RD.",a);
}

int main ()
{
    int pago, horas;

    printf("Ingrese la cantidad de su sueldo: ");
    scanf("%i",&pago);

    printf("Ingrese las horas de trabajo: ");
    scanf("%i",&horas);
    printf("\n");

    solicitar(pago,horas);

    getch ();
    return 0;
}