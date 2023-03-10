#include<stdio.h>
#include<conio.h>

void f1 (void);
int K = 5; // Variable global

void main (void)
{
    int I; 

    for(I=1; I<=3; I++)
    f1();

    getch ();
}

void f1(void)
{
    int a = 2; // Variable local
    a+=a;
    printf("\n\nEl valor de la variable local es:%i.",a);

    K = K + a;
    printf("\nEl valor de la variable global es:%i.",K);

}