#include<stdio.h>
#include<conio.h>

int main ()
{
    char nombre[20];
    int edad;

    edad = 0;

    printf("Cual es tu nombre?:\n");
    scanf("%s",&nombre);

    printf("Cual es tu edad?:\n");
    scanf("%i",&edad);

    printf("Hola %s Bienvenido al curso.\n",nombre);

    getch ();
    return 0;
}