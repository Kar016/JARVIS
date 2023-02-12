#include<stdio.h>
#include<conio.h>

void main (void)
{
    int a, b, c = 0;
    int z[100];

    for (a=0; a<=100; a++)
    {
        printf("Ingrese el elemento %d del arreglo: ",a+1);
        scanf("%d", &z[a]);
    }

    printf("\n\nIngrese el número que se va a buscar en el arreglo: ");
    scanf("%d",&b);
    for (a=0; a<100; a++)
    {
    if (z[a] == b)
    {
        c++;
        printf("printf(“\n\nEl %d se encuentra %d veces en el arreglo",b,c);
    }

    }

    getch ();
}