# MvcClient

**Prérequis**

- Une base de donnée MySQL 

**Configuration de base**

Avant de commencer : 

- Créer une table client 

create table client(
    id int primary key auto_increment,
    civilite varchar(5) not null,
    nom varchar(50) not null,
    prenom varchar(50) not null,
    dateNaissance date not null,
    codePostale int not null,
    adresse varchar(500),
	  pays varchar(50) not null,
    mail varchar(100),
    telephone varchar(10) not null,
    ville varchar(50) not null
)

- Configurez vos informations de connexion à la BD dans le fichier `appsetting.json`


