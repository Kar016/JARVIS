#include<conio.h>
#include<stdio.h>
#include<math.h>

void potencia ()
{
    int a, p;

    printf("Ingrese un valor: ");
    scanf("%i",&a);

    p = pow(a,2);

    printf("El cuadrado del numero es %i.\n",p);
    printf("______________________________________________________________\n");
}

void producto ()
{
    int a, b, p;

    printf("Ingrese el primer valor: ");
    scanf("%i",&a);

    printf("Ingrse el segundo valor: ");
    scanf("%i",&b);

    p = a * b;

    printf("El producto de los valores es %i.\n",p);
    printf("______________________________________________________________\n");
}

int main ()
{
    potencia();
    producto();

    getch ();
    return 0;
}