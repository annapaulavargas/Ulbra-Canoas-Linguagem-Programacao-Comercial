#include <iostream.h>
int main () 

{
    int Num[5], X = 0, NumNega = 0, NumPosi = 0, NumNeu = 0;
    while (X < 5){
          system ("cls");
          cout << "Digite o "<<X+1<<"§ numero: ";
          cin >> Num[X];
          if (Num[X] < 0) NumNega++;
          else if (Num[X] > 0) NumPosi++;
          else if (Num[X] == 0) NumNeu++;
          X++;
    }
    cout << "Quantidade de numeros Negativos: "<<NumNega<<"\n";
    cout << "Quantidade de numeros Positivos: "<<NumPosi<<"\n";
    cout << "Quantidade de numeros Neutros: "<<NumNeu<<"\n";
    system ("pause");
}

