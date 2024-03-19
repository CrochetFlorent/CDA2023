-- CREATE DATABASE Vehicules;
-- USE vehicules;
-- 
-- CREATE TABLE Personnes(id_personne int AUTO_INCREMENT,nom VARCHAR(30) NOT NULL,prenom VARCHAR(30) NOT NULL,num_rue SMALLINT NOT NULL,
-- rue VARCHAR(30) NOT NULL,cp CHAR(5) NOT NULL,ville VARCHAR(30) NOT NULL,
-- PRIMARY KEY	(id_personne));
-- 
-- CREATE TABLE Vehicules(immatriculation CHAR(8) NOT NULL,marque VARCHAR(20) NOT NULL,kilometrage INT NOT NULL,
-- date_mise_en_service DATETIME NOT NULL,id_personne INT NOT NULL,
-- PRIMARY KEY (immatriculation),FOREIGN KEY(id_personne) REFERENCES	personnes(id_personne));	
-- 
CREATE DATABASE etudiant2;
USE etudiant2;

CREATE TABLE etudiant(id_etudiant INT AUTO_INCREMENT, nom VARCHAR(30) NOT NULL, prenom VARCHAR(30) NOT NULL,
 date_entree DATETIME NOT NULL,
 PRIMARY KEY (id_etudiant));
 
CREATE TABLE matiere(id_matiere INT AUTO_INCREMENT,lib_matiere VARCHAR(30) NOT NULL,coefficient CHAR(1),id_etudiant INT NOT NULL,
PRIMARY KEY (id_matiere), FOREIGN KEY (id_etudiant) REFERENCES etudiant(id_etudiant));
 

CREATE TABLE evaluation(id_etudiant int NOT NULL,id_matiere INT NOT NULL,note int NOT NULL, CONSTRAINT fk_etudiant FOREIGN KEY (id_etudiant) REFERENCES etudiant(id_etudiant),CONSTRAINT fk_matiere FOREIGN KEY (id_matiere) REFERENCES matiere(id_matiere));
-- 
-- CREATE DATABASE commandes;
-- USE commandes;
-- 
-- CREATE TABLE Livre(ISBN CHAR(13) NOT NULL,Titre VARCHAR(20) NOT NULL,
-- PRIMARY KEY	(ISBN));
-- CREATE TABLE Exemplaire(num_Exempl INT AUTO_INCREMENT,etat VARCHAR(30) NOT NULL,ISBN CHAR(13) NOT NULL,PRIMARY KEY (num_Exempl),FOREIGN KEY (ISBN) REFERENCES Livre(ISBN));
-- 
-- CREATE DATABASE magasin;
-- USE magasin;
-- 
-- CREATE TABLE Magasin(CodeM INT(16) AUTO_INCREMENT, NomM VARCHAR(30) NOT NULL,
-- PRIMARY KEY	(CodeM));
-- 
-- CREATE TABLE Rayon(NomR VARCHAR(30) NOT NULL,
-- PRIMARY KEY	(NomR));
-- 
-- CREATE TABLE Article(CodeA INT(16) AUTO_INCREMENT, NomA VARCHAR(30) NOT NULL, TypeA  VARCHAR(30) NOT NULL,
-- PRIMARY KEY	(CodeA));
-- 
-- CREATE TABLE Veetudiant2nte(CodeM INT(16) NOT NULL,NomR VARCHAR(30) NOT NULL,CodeA INT(16) NOT NULL,quantités CHAR(3) NOT NULL,
-- FOREIGN KEY (CodeM) REFERENCES magasin(CodeM),
-- FOREIGN KEY (CodeA) REFERENCES article(CodeA),
-- FOREIGN KEY (NomR) REFERENCES rayon(NomR));
-- 
-- CREATE DATABASE vigneron;
-- USE vigneron;
-- 
-- CREATE TABLE vigneron(num_vig INT AUTO_INCREMENT, nom_vig VARCHAR(30) NOT NULL,prenom_vig VARCHAR(30) NOT NULL,ville VARCHAR(30) NOT NULL,
-- PRIMARY KEY	(num_vig));
-- 
-- CREATE TABLE vin(num_vin INT AUTO_INCREMENT, cru VARCHAR(30) NOT NULL,millesium VARCHAR(30) NOT NULL,
-- PRIMARY KEY	(num_vin));
-- 
-- CREATE TABLE commande(num_coacheterm INT AUTO_INCREMENT, date_commande DATE NOT NULL,
-- PRIMARY KEY (num_com));

-- CREATE TABLE buveur(num_buv INT AUTO_INCREMENT,num_com INT NOT NULL, nom_buv varchar(30) NOT NULL,prenom_buv VARCHAR(30) NOT NULL,ville_buv VARCHAR(30) NOT NULL,
-- PRIMARY KEY	(num_buv),
-- FOREIGN KEY	(num_com) REFERENCES commande(num_com));
-- 
-- CREATE TABLE produire(num_vig INT NOT NULL,num_vin INT NOT NULL,
-- FOREIGN KEY	(num_vig) REFERENCES vigneron(num_vig),
-- FOREIGN KEY	(num_vin) REFERENCES vin(num_vin));
-- 
-- CREATE TABLE acheter(num_vin INT NOT NULL, num_com INT NOT NULL,quantite CHAR(3) NOT NULL,
-- FOREIGN KEY	(num_vin) REFERENCES vin(num_vin),
-- FOREIGN KEY	(num_com) REFERENCES commande(num_com));

