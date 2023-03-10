#include<stdio.h>
#include<conio.h>

void carga(int x, int y, int z)
{

    if (x>y && x>z)
    {
        printf("x es mayor.\n");
    }
    else
    {
        if (y>x && y>z)
        {
            printf("y es mayor.\n");
        }
        else
        {
            if (z>x && z>y)
            {
                printf("z es mayor.\n");
            }
        }
    }
}

int main ()
{
    int x, y, z;

    printf("Ingrese el valor de x: ");
    scanf("%i",&x);

    printf("Ingrese el valor de y: ");
    scanf("%i",&y);

    printf("Ingrese el valor de z: ");
    scanf("%i",&z);

    printf("\n");

    carga(x,y,z);

    getch ();
    return 0;
}
