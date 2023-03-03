#include<stdio.h>
#include<string.h>

char * inverso(char *);

void main (void)
{
    char fra[50], aux[50];

    printf("\nIngrese la linea de texto: ");  // Se copia a aux el resultado de la funcion inversa
    gets(fra);
    strcpy (aux, inverso(fra));

    printf("\nEscribe la linea de texto en forma inversa: ");
    puts(aux);
}

char * inverso (char *cadena)
{
    int i=0, j, lon;
    char cad;
    lon = strlen(cadena);
    j = lon-1;

    while (i)
}

