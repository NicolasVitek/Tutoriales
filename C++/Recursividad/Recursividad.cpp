
using namespace std;
#include <iostream>
void mostrar(int cont) {
    cont++;
    cout << "Hola" << cont<<endl;
    if (cont<5)
    {
        mostrar(cont-1);
    }
}

int main()
{
    mostrar(4);
}

