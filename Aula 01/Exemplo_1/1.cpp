#include <stdio.h>
#include <conio.h>
#include <iostream>

 main( ) {

   int c, f;
   
   float  vh, h, sl, sb;

   clrscr();

   gotoxy(10,5);

   printf("Qual seu codigo na empresa?");
   c = getche();  //operador

   gotoxy(10,8);

   printf("Qual seu valor hora?");
   scanf("%f",&vh);

   gotoxy(10,11);
   
   printf("Quantos filhos com idade maior do que 14 anos?");
   f = getche();  //operador

   printf("Numero de horas trabalhadas?");
   scanf("%f",&h);

   sb = vh * h;
   
   gotoxy(10,24);
  
   printf("Codigo na empresa = %i", c, "Valor hora do funcionário = %f", vh, "Horas Trabalhadas = %f", h, "Codigo na empresa = %i", f, "Salário Bruto do funcionário = %f", sb);

   getch(); //pausa
} 


 

   
   











