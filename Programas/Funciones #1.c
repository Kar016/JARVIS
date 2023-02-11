#include<stdio.h>
#include<conio.h>

void presentacion()
{

    printf("Programa que permite cargar dos valores por teclado.\n");
    printf("Efectuar la suma de dichos valores.\n");
    printf("Muestra del resultado\n");
    printf("_________________________________________________________\n");
    
}

void sumar()
{
    int a, b, suma;

    printf("Ingrese el primer valor: ");
    scanf("%i",&a);

    printf("Ingrese el segundo valor: ");
    scanf("%i",&b);

    suma = a + b;

    printf("La suma de los dos valores es %i.\n",suma);
}

void finalizacion()
{
    printf("________________________________________________________________\n");
    printf("Gracias por utilizar este programa.\n");
}

int main ()
{
    presentacion();
    sumar();
    finalizacion();

    getch ();
    return 0;
}