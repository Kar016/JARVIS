#include<stdio.h>
#include<conio.h>

void imprimir(int v1, int v2)
{
    if (v1>v2)
    {
        printf("El mayor es %i.",v1);
    }
    else
    {
        printf("El mayor es %i.",v2);
    }
}

    int main ()
    {
        int v1, v2;

        printf("Ingrese el primer valor: ");
        scanf("%i",&v1);

        printf("Ingrese el segundo valor: ");
        scanf("%i",&v2);

        imprimir(v1,v2);

        getch ();
        return 0;
    }
