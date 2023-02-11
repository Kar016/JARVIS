#include<stdio.h>
#include<conio.h>

void funcion ()
{
    int a, b, c;

    printf("Ingrese el primer valor: ");
    scanf("%i",&a);

    printf("Ingrese el segundo valor: ");
    scanf("%i",&b);

    printf("Ingrese el tercer valor: ");
    scanf("%i",&c);

    printf("\n");

    if (a<=b && a<=c)
    {
        printf("%i es menor.",a);
    }
    else
    {
        if (b<=a && b<=c)
        {
            printf("%i es menor.",b);
        }
        else
        {
            printf("%i es menor.",c);
        }
    }

    printf("\n\n");
}

int main ()
{
    funcion();
    funcion();
    funcion();

    getch ();
    return 0;
}