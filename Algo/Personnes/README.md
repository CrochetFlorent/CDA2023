# TP 01

<p>Le programme demande la saisie d'un nom et d'un prénom à l'utilisateur dans le but de voir s'il est déja dans une liste prédéterminée de trois personnes.<br>
Si la personne est présente dans la liste, il est proposé à l'utilisateur de supprimer la personne, sinon elle y est ajoutée.<br>
Ensuite le choix de trier par nom ou par prénom est proposé à l'utilisateur pour ensuite lui demander s'il veut tester si une autre personne est présente dans la liste
et recommencer les actions précédentes<br>
Sinon, on lui propose de remplir un fichier JSON avec les personnes présentes dans la liste.Ensuite quelque soit le choix on quitte le programme.</p>

<br><br><br><br>
## Les classes

### La classe Person

<p>Contient:<br><br>
Deux propriétés: nom visant à stocker le nom d'une personne et prénom visant à stocker le prénom d'une personne.<br><br>
Un constructeur avec paramètres(nom,prénom) permettant d'instancier des objets.<br><br>
Une méthode comparer permettant de comparer deux objets, et retourner l'objet s'il est déja présent dans la liste.<br><br>
Une méthode remplissage qui prends 2 paramètres en entrée: une liste de personne et une personne.
La personne est ajoutée à la liste de personnes si (grâce à la méthode comparer) elle n'est pas présente dans la liste</p>

### La classe PeopleContainer

<p>Contient:<br><br>
Un attribut: liste de personne visant à stocker toutes les personnes que l'on doit y ajouter<br><br>
Un constructeur avec paramètre(liste de personnes) permttant d'instanicer des objets.<br><br>
Une méthode de tri par ordre alphabétique pour les prénoms(SortByFirstName) <br><br>
Une méthode de tri par ordre alphabétique pour les noms(SortByLastName) <br><br></p>

### La classe Program

<p>Contient:<br><br>
Une méthode (affichageSaisie)permettant la demande d'un nom ou d'un prénom à l'utilisateur qui sera récupéré par Readline et retourné par la fonction.<br><br>
Une méthode d'affichage(affichage) des valeurs d'une liste permttant l'affichage des noms ou des prénoms en fonction de choix<br><br>
Une méthode de remplissage du fichier JSON(remplissageJSON) qui écrit dans une fichier JSON tous les couples noms/prénoms de la liste donnée en paramètre d'entrée.<br><br>
Une méthode qui supprime une personne prise en paramètre, de la liste de personnes prise en paramètre, si elle est dans la liste(en utilisant la méthode comparer de la classe Person).<br><br>

### En ce qui concerne le main:

<p>Nous définisons les listes visant à etre traitées.<br>
Nous créons trois objets Person.<br>
Nous entrons dans une boucle do/while, instancions une personne avec pour paramètres la fonction affichageSaisie utilisée pour le nom et le prénom.<br>
Nous instancions une personne avec pour nom et prénom des saisie clavier (avec la méthode affichageSaisie)<br>
Nous ajoutons la personne ,si elle n'y est pas déja présente, dans la liste de personnes.<br>
Nous prévenons si la personne était déja présente dans la liste de personnes.<br>
Nous demandons à l'uilisateur s'il veut supprimer la personne, et le faisons si oui (avec supprimerPersonne)
Nous instancions un objet PeopleContainer avec la liste de personnes<br>
Nous demandons à l'utilisateur s'il veut trier par nom ou pas prénoms,puis affichons la liste triée (avec la méthode affichage et SortByLastName/SortByFirstName).<br>
Nous demandons à l'utilisateur s'il veut ajouter une personne à la liste de personnes:<br>
Si oui nous passons/repassons dans le while,<br>
Si non, nous sortons du while.<br>
Enfin nous demandons à l'utilsateur s'il veut stocker les personnes dans une fichier JSON.Et nous appelons la methode remplissageJSON si oui.Enfin, nous quittons le programme après ce choix.













