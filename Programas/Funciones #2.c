#include<stdio.h>
#include<conio.h>

/*
void suma1 ()
{
    int a, b, suma;

    printf("Ingrese los valores de la primera suma.\n\n");

    printf("Ingrese el primer valor: ");
    scanf("%i",&a);

    printf("Ingrese el segundo valor: ");
    scanf("%i",&b);

    suma = a + b;

    printf("La suma de los primeros valores es %i.\n",suma);
    printf("_____________________________________________________\n");
}

void suma2 ()
{
    int a, b, suma;

    printf("Ingrese los valores de la segunda suma.\n\n");

    printf("Ingrese el primer valor: ");
    scanf("%i",&a);

    printf("Ingrese el segundo valor: ");
    scanf("%i",&b);

    suma = a + b;

    printf("La suma de los segundos valores es %i.\n",suma);
    printf("_____________________________________________________\n");
}

int main ()
{
    suma1();
    suma2();

    getch ();
    return 0;
} */

void suma ()
{
    int a, b, suma;

    printf("Ingresar los valores de la suma.\n\n");

    printf("Ingrese el primer valor: ");
    scanf("%i",&a);

    printf("Ingrese el segundo valor: ");
    scanf("%i",&b);

    suma = a + b;

    printf("La suma de los valores es %i.\n",suma);
}

void separacion ()
{
    printf("_______________________________________________________________________\n");
}

int main ()
{
    suma();
    separacion();
    suma();
    separacion();

    getch ();
    return 0;
}