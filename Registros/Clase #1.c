#include<stdio.h>
#include<conio.h>

int main()
{
    char nombre;
    int a;
    FILE *archivo;

    if ((archivo=fopen("Lista.txt", "w")) != NULL)
    {
        printf("Escribe su monbre: ");
        scanf("%s",&nombre);

        while((nombre = getchar()) != NULL)
        {
            fputc(nombre,archivo);
        }

        fclose(archivo);
    }
    else
    {
        printf("No se puede abrir el archivo.");
    }



    getch();
    return 0;
}
