#include<stdio.h>
#include<conio.h>

void perimetro(int p)
{ 
    int a;
    a = p+p+p+p;
    printf("El perimetro es: %i.\n",a);
}

void superficie(int s)
{
    int b;
    b = s*s;
    printf("La superficie es: %i\n",b);
}


int main ()
{
    int s, p;

    printf("Ingrese el lado del cuadrado: ");
    scanf("%i",&p);
    printf("Ingrese el lado del cuadrado: ");
    scanf("%i",&s);
    printf("\n");

    perimetro(p);
    superficie(s);

    getch ();
    return 0;
}