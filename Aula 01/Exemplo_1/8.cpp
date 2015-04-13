#include <stdio.h>
#include <conio2.h>
#include <iostream>

main(){

float total;
int cod,quant;

clrscr;   // limpa tela

gotoxy(10,10);

printf("\n Cardapio: \n \n 100 - Cachorro-quente R$ 1.50 \n 101 - Bauru Simples R$ 4,20 \n 102 - Bauru C/Ovo   R$ 4.50 \n 103 - Hamburguer   R$ 2.00 \n 104 - Cheeseburger R$ 2.50 \n 105 - Refrigerante R$ 1.00 \n 106 - fim \n \n         Digite o codigo: ");
scanf("%i",&cod);

gotoxy(10,25);
printf("Digite a quantidade: ");
scanf("%i",&quant);

gotoxy(10,35);

 switch(cod){
  	
  	case 100 :  //printf("Cachorro-quente R$ 1.50");
  	
  		total = quant * 1.50;
	  
	  break;
	  
  	case 101 :  //printf("Bauru Simples R$ 4,20");
  	
  	  total = quant * 4.20;
	  
	  break;
	  
	case 102 :  //printf("Bauru C/Ovo   R$ 4.50");
	
	  	total = quant * 4.20;
	  
	  break;  
	  
	case 103:  //printf("Hamburguer   R$ 2.00");
	
	  	total = quant * 2.00;
	  
	  break;  
	  
	case 104 : // printf("Cheeseburger R$ 2.50");
	
	   total = quant * 2.5;
	  
	  break; 
	  
	case 105 : // printf("Refrigerante R$ 1.00");
	
	  total = quant * 1.00;
	  
	  break;   
	  
  	case 106 :  printf("Fim!"); break;
  } 
   
gotoxy(10,30);   

printf("O valor fica = %.2f",total);

getch();
   
   
  
}

