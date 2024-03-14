CREATE TABLE Images(
   id_img COUNTER,
   url_img VARCHAR(250) NOT NULL,
   nom_img VARCHAR(100) NOT NULL,
   text_img VARCHAR(300) NOT NULL,
   ext_img VARCHAR(5) NOT NULL,
   PRIMARY KEY(id_img)
);

CREATE TABLE Realisations_1(
   id_rea COUNTER,
   titre_rea VARCHAR(255) NOT NULL,
   date_rea DATE NOT NULL,
   texte_rea TEXT NOT NULL,
   PRIMARY KEY(id_rea)
);

CREATE TABLE Images_1(
   id_img COUNTER,
   url_img VARCHAR(250) NOT NULL,
   nom_img VARCHAR(100) NOT NULL,
   text_img VARCHAR(300) NOT NULL,
   ext_img VARCHAR(5) NOT NULL,
   PRIMARY KEY(id_img)
);

CREATE TABLE Realisations(
   id_rea COUNTER,
   titre_rea VARCHAR(255) NOT NULL,
   date_rea DATE NOT NULL,
   texte_rea TEXT NOT NULL,
   id_img INT NOT NULL,
   PRIMARY KEY(id_rea),
   FOREIGN KEY(id_img) REFERENCES Images(id_img)
);

CREATE TABLE Associer_1(
   id_rea INT,
   id_img INT,
   PRIMARY KEY(id_rea, id_img),
   FOREIGN KEY(id_rea) REFERENCES Realisations_1(id_rea),
   FOREIGN KEY(id_img) REFERENCES Images_1(id_img)
);

