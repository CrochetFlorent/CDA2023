-- SELECT client_ref,client_nom
-- FROM clients
-- WHERE client_telephone LIKE '04%';

-- SELECT client_ref,client_nom,type_clients.type_client_libelle
-- FROM clients,type_clients
-- WHERE clients.type_client_id = type_clients.type_client_id AND type_clients.type_client_id = 1;

-- SELECT client_ref,client_nom,type_clients.type_client_libelle
-- FROM clients,type_clients
-- WHERE clients.type_client_id = type_clients.type_client_id AND type_clients.type_client_id <> 1;

-- SELECT projet_ref
-- FROM projets
-- WHERE projets.projet_date_fin_prevue < projets.projet_date_fin_effective;

-- SELECT projet_date_depot,projet_date_fin_prevue,projet_superficie_totale,projet_superficie_batie,client_nom,emp_nom
-- FROM projets,fonctions,clients,employes
-- WHERE fonctions.fonction_id = employes.fonction_id AND clients.client_ref = projets.client_ref AND fonctions.fonction_id = 1;

-- SELECT projet_date_fin_prevue,projet_superficie_totale,projet_superficie_batie,projet_prix
-- FROM projets,participer
-- WHERE projets.projet_ref = participer.projet_ref
-- GROUP BY projets.projet_ref;

-- SELECT projets.type_projet_id,avg(projets.projet_prix),COUNT(projets.type_projet_id)
-- FROM projets
-- GROUP BY projets.type_projet_id;

-- SELECT type_travaux.type_travaux_id,MAX(projets.projet_superficie_totale)
-- FROM projets,type_travaux
-- WHERE projets.type_travaux_id = type_travaux.type_travaux_id
-- GROUP BY type_travaux_id;

-- SELECT projets.projet_ref,clients.client_nom,clients.client_telephone,CONCAT(adresses.adresse_num_voie," ",adresses.adresse_voie," ",adresses.adresse_code_postal," ",adresses.adresse_ville) AS 'Adresses du client',
-- type_projets.type_projet_libelle,type_travaux.type_travaux_libelle
-- FROM projets,type_projets,type_travaux,clients,adresses
-- WHERE projets.client_ref = clients.client_ref AND type_travaux.type_travaux_id = projets.type_travaux_id 
-- AND type_projets.type_projet_id = projets.type_projet_id
-- AND adresses.adresse_id = clients.adresse_id
-- GROUP BY projets.projet_ref;

-- SELECT projets.projet_ref,adresses.adresse_id,clients.adresse_id
-- FROM projets,clients,adresses
-- where projets.client_ref = clients.client_ref AND adresses.adresse_id = clients.adresse_id;
-- 