#include <stdio.h>
#include <string.h>

/* Estructuras-2.
El programa muestra la manera en que se declara una estructura, así como la
forma en que se tiene acceso a los campos de los apuntadores de tipo estructura
tanto para lectura como para escritura. Se utiliza además una función que
recibe como parámetro un apuntador de tipo estructura. */

struct alumno
{
    int matricula;
    char nombre[20];
    char carrera[20];
    float promedio;
    char direccion[20];
};

void Lectura(struct alumno *);

void main (void)
{
    struct alumno a0= {120, "Maria", "Contabilidad", 8.9, "Queretaro"};
    struct alumno *a3, *a4, *a5, a6;

    // Observa que las variables *a3, *a4 y *a5 se declaran como apuntadores de tipo estructura alumno
    // a6 es una variable de tipo estructura alumno

    a3 = &a0; 
    // En este caso al apuntador de tipo estructura alumno a3 se le asigna la dirección de la variable de tipo estructura alumno, a0.

    a4 = malloc (struct alumno);  // ERROR 
    /* Nota que al apuntador a4 es necesario asignarle una dirección de memoria.
    Para tener acceso a los campos de un apuntador de tipo estructura, utiliza uno
    de los dos formatos siguientes:
       apuntador->campo
       o bien
       (*apuntador).campo 
    En la lectura de los campos de la variable a4 se utilizan como ejemplo ambos formatos. */

    printf("\nIngrese la matricula del alumno 4: ");
    scanf("%d",&(*a4).matricula);
    fflush(stdin);

    printf("Ingrese el nombre del alumno 4: ");
    gets(a4->nombre);
}