#include<stdio.h>
#include<conio.h>

#define falso 0
#define verdadero 1
#define final 3

int main ()
{
    unsigned int i = 0;
    char fin = falso;
    int tmp = 0;
    int a[4];
    a[0] = 10;
    a[1] = 1;
    a[2] = 8;
    a[3] = 6;

    printf("Elemento a[0]: %d\n",a[0]);
    printf("Elemento a[1]: %d\n",a[1]);
    printf("Elemento a[2]: %d\n",a[2]);
    printf("Elemento a[3]: %d\n",a[3]);

    fin = falso;

    while(fin == falso)
    {
        fin = verdadero;
        for(i=0; i<3; i++)
        {
            if (a[i]>a[i+1])
            {
              tmp = a[i];
              a[i] = a[i+1];
              a[i+1] = tmp;
              fin = falso;
            }

        }
    }

    printf("\n------ Ordenados ------\n");
    printf("\nElemento a[0]: %d",a[0]);
    printf("\nElemento a[1]: %d",a[1]);
    printf("\nElemento a[2]: %d",a[2]);
    printf("\nElemento a[3]: %d",a[3]);

    getch ();
    return 0;
}