#include<stdio.h>

void mezcla(FILE *, FILE *, FILE *);

void main(void)
{
    FILE *ar, *ar1, *arc2;
    ar = fopen("arc9.dat", "r");
    ar1 = fopen("arc10.dat", "r");
    ar2 = fopen("arc11.dat", "w");

    if((ar != NULL) && (ar1 != NULL) && (arc2 != NULL))
    {
        mezcla(ar, ar1, ar2);
        fclose(ar);
        fclose(ar1);
        fclose(ar2);
    }
    else
    {
        pintf("No se puede abrir los archivos.");
    }
}

void mezcla(FILE *ar, FILE *ar1, FILE *ar2)
{
    int i, mat, mat1, b=1, b1=1;
    float ca[3], ca1[3], cal;

    while (((!feof(ar)) || !b) && ((!feof(ar1)) || !b1))
    {
        if (b)
        {

        }
    }
}
