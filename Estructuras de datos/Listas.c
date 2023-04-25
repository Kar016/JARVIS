#include<stdio.h>
#include<conio.h>
#include<stdlib.h>

typedef struct alumno
{
    char nombre[50];
    char apellido[50];
    int fecha;

    struct alumno *p; // la p indica el nodo siuiente
}bloque;

bloque* primero = NULL; // Indica el primer nodo
bloque* ultimo = NULL;  // Indica el ultimo nodo

//void nuevo();

int main ()
{
   int menu = 0;

   do
   {
       printf("------------------\n");
       printf("        MENU      \n");
       printf("------------------\n");
       printf("0. Salir          \n");
       printf("1. Nuevo          \n");
       printf("2. Borrar         \n");
       printf("3. Buscar         \n");
       printf("4. Guardar        \n");

       printf("\n\n Eliga una opcion: ");
       scanf("%i",&menu);

       switch(menu)
       {
       case 0:
        printf("\n\n Programa finalizado.\n\n");
        break;

       case 1:
        printf("\n\nIngresar nuevo estudiante\n\n");
        nuevo();
        break;

        case 2:
        printf("\n\n Borrar datos del estudiante\n\n");
       // eliminar();
        break;

        case 3:
        printf("\n\n Buscar datos del estudiante\n\n");
        buscar();
        break;

        case 4:
        printf("\n\n Guardar datos del estudiante\n\n");
        //nuevo();
        break;

        default:
        printf("\n\n Opcion no valida \n\n");
       }
   }while (menu != 0);

    getch ();
    return 0;
}

void nuevo ()
{
    bloque* n = (bloque*) malloc(sizeof(bloque));  // Para almacenar la informacion de la estructura

    printf("Ingrese el nombre del estudiante: ");
    scanf("%s",&n->nombre);

    printf("Ingrese el apellido del estudiante: ");
    scanf("%s",&n->apellido);

    printf("Ingrese la fecha de nacimiento del estudiante: ");
    scanf("%i",&n->fecha);
    printf("\n");

    // Creacion de la lista

    if (primero==NULL)  // creacion del primer bloque
    {
        primero = n;
        primero->p = NULL;
        ultimo = NULL;
    }
    else // Creacion del bloque siguiente
    {
        ultimo->p = n;
        n->p = NULL;
        ultimo = n;
    }

}

void buscar ()
{
   bloque* a = (bloque*) malloc(sizeof(bloque));  // Para almacenar informacion
   a = primero; // la variable sera igual al primero bloque

   char b; // b = Buscar
   int e = 0; // e = Encontrar

    printf("Nombre: ");
    scanf("%s",&b);

    if (primero != NULL)
    {
        while (a != NULL && e != 1)
        {
            if (a->nombre == b)
            {
                printf("El bloque (%s) encontrado",b);
                e = 1;
            }
            a = a->p;
        }

        if (e == 0)
        {
            printf("El usuario no se encuentra.");
        }
    }
    else
    {
        printf("\nLa lista se encuentra vacia.");
    }
}
