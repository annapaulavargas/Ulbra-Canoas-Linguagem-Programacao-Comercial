#include <stdio.h>
#include <conio2.h>
#include <iostream>

main( ) {
   int c, f;
   float  vh, h, sl, sb;
   clrscr();
   gotoxy(10,5);
   printf("Digite seu codigo?");
   scanf("%i",&c); 
   gotoxy(10,8);
   printf("Qual seu valor hora?");
   scanf("%f",&vh);
   gotoxy(10,11);
   printf("Quantas horas voce trabalhou no mes que deseja calcular?");
   scanf("%f",&h);
   sb = h * vh;
   gotoxy(10,14);
   printf("O numero de filhos com idade menor do que 14 anos? ");
   scanf("%i",&f);
   gotoxy(10,17);
   printf("Codigo = %i \n", c);
   gotoxy(10,20);
   printf("Valor hora do funcionario = %f \n", vh); 
   gotoxy(10,23);
   printf("Horas Trabalhadas do funcionario = %f \n", h);
   gotoxy(10,26);
   printf("Salario Bruto do funcionario = %f \n", sb);
   gotoxy(10,29);
   printf("Numero de filhos = %i \n", f );
   getch(); //pausa
} 

