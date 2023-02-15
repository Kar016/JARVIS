#include<stdio.h>
#include<conio.h>

void ingresar (int a[6])
{
    for (int f=1; f<=6; f++)
    {
        printf("Ingrese un valor: ");
        scanf("%i",&a[f]);
    }

    printf("\n");
} 

void ascendente (int a[6])
{
    for (int x=1; x<=11; x++)
    {
        for (int y=1; y<=11; y++)
        {
            if (a[y]>a[y+1])
            {
                int z = a[y];
                a[y] = a[y+1];
                a[y+1] = z; 
            }
        }
    }
    printf("\n");
}

void imprimir (int a[5])
{
    for (int y=1; y<=12; y++)
    {
        printf("-%i ",a[y]);
    }
    printf("\n\n");
}

int main ()
{
    int a[6];
    ingresar(a);
    printf("Ordenar de menor a mayor:\n");
    imprimir(a);

    ingresar(a);
    printf("Ordenar de menor a mayor:\n");
    imprimir(a);

    getch ();
    return 0;

}