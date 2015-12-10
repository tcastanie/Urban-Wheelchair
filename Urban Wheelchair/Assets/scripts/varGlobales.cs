using UnityEngine;
using System.Collections;

public static class varGlobales {

    //temps du jeu en secondes
    public static float tempsActuel = 0;          //c le tan ki ses cool
    public static int tempsLast;                //le temps de la course precedente
    public static int tempsBest = 999;          //record du joueur

    //argent du joueur
    public static int moneyStart;               //l'argent du joueur au départ
    public static int moneyCurrent;             //l'argent actuellement detenu par le joueur
    public static bool isFirstTime = true;

    //variables d'etat global du jeu
    public static bool isFinished = false;      //vrai quand le joueur passe la ligne de fin
    public static bool isMoneyNegative = false; //vrai quand le joueur a de l'argent negatif (pour l'empecher de sortir de la vue plan)

    //variable de jeu
    public static int etatJeu = 0;              //0 accueil, 1 jeu fps, 2 mode caméra, 3 mode récap
    public static bool isCamFauteuil = true;    //true si vue fps active, false si vue camera active
    public static int etatRampe;                //0 si escaliers, 1 si rampe, 2 si rampe-escalier
    public static int etatTrottoir;             //0 si trottoir mauvais, 1 si bien, 2 si mieux


}


