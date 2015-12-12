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
    public static int etatJeu;              //0 accueil, 1 jeu fps, 2 mode caméra, 3 mode récap
    public static bool isCamFauteuil = true;    //true si vue fps active, false si vue camera active
    public static int etatRampe;                //0 si escaliers, 1 si rampe, 2 si rampe-escalier
    public static int etatTrottoir;             //0 si trottoir mauvais, 1 si bien, 2 si mieux

    public static int moneyEsc;
    public static int moneyTrottoir;
    public static int moneyTerrasse;
    public static int moneyTravaux;
    public static int moneyCorum;

    public static int prixEsc = 0;
    public static int prixRampe = 5000;
    public static int prixRampeEsc = 7500;
    public static int prixTrottoirBad = 0;
    public static int prixTrottoirBien = 3500;
    public static int prixTrottoirMieux = 5000;
    public static int prixTerrasseBad = 0;
    public static int prixTerrasseGood = 10000;
    public static int prixTravauxBad = 0;
    public static int prixTravauxGood = 6000;
    public static int prixCorumBad = 0;
    public static int prixCorumGood = 40000;

    public static string currentExp;
    public static string expEscalier = "Cet escalier est adapté aux piétons, mais il ne l'est pas envers les personnes en fauteuil roulant\n\n" + prixEsc + "€";
    public static string expRampe = "Cette rampe est idéale pour les personnes en fauteuil roulant, mais n'est pas pratique pour le reste des piétons\n\n" + prixRampe + "€";
    public static string expRampeEsc = "Cet équipement s'adapte aux besoins de tous les usagers\n\n" + prixRampeEsc + "€";
    public static string expTrottoirBad = "Ce trottoir empêche un fauteuil roulant de traverser la route\n\n" + prixTrottoirBad + "€";
    public static string expTrottoirBien = "Ce trottoir qui possède un pente douce vers la route est adapté aux fauteuils roulants\n\n" + prixTrottoirBien + "€";
    public static string expTrottoirMieux = "En plus d'être adapté aux fauteuils roulants, ce trottoir possède des picots afin de signaler la présence d'un passage piéton aux personnes aveugles\n\n" + prixTrottoirMieux + "€";
    public static string expTerrasseBad = "Le restaurateur a placé ses tables en terrasse sans se soucier des passants utilisant un fauteuil roulant ou une pousette\n\n" + prixTerrasseBad + "€";
    public static string expTerrasseGood = "Les tables de ce restaurant sont maintenant placées convenablement et permettent un passage à tout type de piétons\n\n" + prixTerrasseGood + "€" + "\n(frais de dossier pour la création d'une norme municipale";
    public static string expTravauxBad = "Le passage laissé à l'attention des piétons est trop étroit pour qu'un fauteuil roulant puisse passer\n\n" + prixTravauxBad + "€";
    public static string expTravauxGood = "Le passage destiné aux piétons est suffisament large pour passer\n\n" + prixTravauxGood + "€" + "\n(nécéssaires à la perte engendrée par la restructuration du plan du chantier)";
    public static string expCorumBad = "Cet immense escalier est un obstacle long et fatiguant à contourner\n\n" + prixCorumBad + "€";
    public static string expCorumGood = "L'ascenseur permet aux personnes à mobilité réduite d'accéder au sommet des marches sans se fatiguer\n\n" + prixCorumGood + "€";


}


