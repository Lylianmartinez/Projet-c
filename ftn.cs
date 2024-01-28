#include <stdio.h>
#include <stdlib.h>
#include <time.h>

struct Joueur { int pointsDeVie, munitions; };
struct Arme { int puissance; };
struct Ennemi { int pointsDeVie, puissance; };

void initialiser(struct Joueur *j, struct Arme *a, struct Ennemi *e) {
    j->pointsDeVie = 100; j->munitions = 30;
    a->puissance = 20;
    e->pointsDeVie = 50; e->puissance = 10;
}

void combat(struct Joueur *j, struct Arme *a, struct Ennemi *e) {
    while (j->pointsDeVie > 0 && e->pointsDeVie > 0)
    {
        e->pointsDeVie -= a->puissance;
        j->munitions--;
        j->pointsDeVie -= e->puissance;
        print ("Joueur: PV = %d, Munitions = %d\n", j->pointsDeVie, j->munitions);
        printf("Ennemi: PV = %d\n\n", e->pointsDeVie);
        for (int i = 0; i < 100000000; i++) ;
    }
    printf(j->pointsDeVie > 0 ? "Victoire!\n" : "Défaite!\n");
}

int main()
{
    srand(time(NULL));
    struct Joueur joueur;
struct Arme arme;
struct Ennemi ennemi;
initialiser(&joueur, &arme, &ennemi);
combat(&joueur, &arme, &ennemi);
return 0;
}
