-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3307
-- Généré le : mar. 29 mars 2022 à 09:04
-- Version du serveur :  10.5.4-MariaDB
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `hackathon`
--

-- --------------------------------------------------------

--
-- Structure de la table `commentaire`
--

DROP TABLE IF EXISTS `commentaire`;
CREATE TABLE IF NOT EXISTS `commentaire` (
  `IdCommentaire` int(11) NOT NULL AUTO_INCREMENT,
  `Texte` varchar(1024) NOT NULL,
  `Date` date NOT NULL,
  `IdHackathon` int(11) NOT NULL,
  PRIMARY KEY (`IdCommentaire`),
  KEY `Commentaire_ibfk_1` (`IdHackathon`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `evenement`
--

DROP TABLE IF EXISTS `evenement`;
CREATE TABLE IF NOT EXISTS `evenement` (
  `IdEvenement` int(30) NOT NULL AUTO_INCREMENT,
  `Theme` varchar(256) NOT NULL,
  `Date` date NOT NULL,
  `HeureDebut` time NOT NULL,
  `HeureFin` time NOT NULL,
  `IdHackathon` int(30) NOT NULL,
  `IdTypeEvenement` int(30) NOT NULL,
  `NbPlaces` int(30) NOT NULL,
  PRIMARY KEY (`IdEvenement`),
  KEY `Evenement_ibfk_2` (`IdTypeEvenement`),
  KEY `Evenement_ibfk_1` (`IdHackathon`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `evenement`
--

INSERT INTO `evenement` (`IdEvenement`, `Theme`, `Date`, `HeureDebut`, `HeureFin`, `IdHackathon`, `IdTypeEvenement`, `NbPlaces`) VALUES
(15, 'Webconférence', '2021-10-25', '10:12:00', '14:25:40', 1, 1, 20),
(16, 'Confé-Web', '2022-09-20', '10:12:00', '14:25:40', 1, 1, 20),
(17, 'La Progra pour les Nuls', '2021-10-25', '10:12:00', '14:25:40', 1, 2, 20),
(18, 'Confé-frère', '2021-10-05', '10:12:00', '14:25:40', 2, 1, 20),
(19, 'Ama-app\'', '2021-01-25', '10:30:00', '14:25:00', 1, 2, 20),
(20, 'Commence-code', '2020-10-25', '10:00:00', '13:05:20', 1, 2, 20),
(21, 'Conférence sur le Numérique', '2021-03-25', '10:12:00', '14:25:40', 3, 1, 20),
(22, 'Hackmateur', '2021-10-25', '10:11:00', '14:25:40', 5, 2, 20),
(23, 'Démarrer le code', '2021-10-25', '10:12:00', '14:25:40', 6, 2, 20),
(24, 'Les limites du code', '2021-10-25', '10:12:00', '14:25:40', 7, 1, 20);

-- --------------------------------------------------------

--
-- Structure de la table `favori`
--

DROP TABLE IF EXISTS `favori`;
CREATE TABLE IF NOT EXISTS `favori` (
  `IdFavori` int(11) NOT NULL AUTO_INCREMENT,
  `IdHackathon` int(11) NOT NULL,
  `IdParticipant` int(11) NOT NULL,
  PRIMARY KEY (`IdFavori`),
  KEY `Favori_ibfk_1` (`IdHackathon`),
  KEY `Favori_ibfk_2` (`IdParticipant`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `hackathon`
--

DROP TABLE IF EXISTS `hackathon`;
CREATE TABLE IF NOT EXISTS `hackathon` (
  `IdHackathon` int(30) NOT NULL AUTO_INCREMENT,
  `DateDebut` date NOT NULL,
  `HeureDebut` time DEFAULT NULL,
  `DateFin` date DEFAULT NULL,
  `HeureFin` time DEFAULT NULL,
  `Lieu` varchar(255) DEFAULT NULL,
  `Rue` varchar(255) DEFAULT NULL,
  `Ville` varchar(255) DEFAULT NULL,
  `CodePostal` char(5) DEFAULT NULL,
  `Theme` varchar(255) NOT NULL,
  `DateLimite` date DEFAULT NULL,
  `NbPlaces` int(11) DEFAULT NULL,
  `Image` varchar(256) DEFAULT NULL,
  PRIMARY KEY (`IdHackathon`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `hackathon`
--

INSERT INTO `hackathon` (`IdHackathon`, `DateDebut`, `HeureDebut`, `DateFin`, `HeureFin`, `Lieu`, `Rue`, `Ville`, `CodePostal`, `Theme`, `DateLimite`, `NbPlaces`, `Image`) VALUES
(1, '2021-10-15', '18:00:00', '2021-10-17', '18:00:00', 'Talent Garden', '100 Avenue Willy Brandt', 'Lille', '59777', 'La nuit du code citoyen', '2021-10-10', 50, 'https://media.fashionnetwork.com/m/aa78/2e76/d314/bf17/bf6d/ebb3/d682/a1f8/bc27/eeac/eeac.jpg'),
(2, '2021-12-08', '09:30:00', '2021-12-22', '18:00:00', 'Loco Numérique', '123 Bd Louis Blanc', 'La Roche Sur Yon', '85000', 'Hackathon sur le changement climatique et la protection de la biodiversité', '2021-11-08', 20, 'https://mvistatic.com/photosmvi/2021/06/14/P26896746D4678929G.jpg'),
(3, '2022-01-27', '18:30:00', '2022-01-30', '20:30:00', 'Lelaptop: atelier modulable', '7 rue Geoffroy Langevin', 'Paris', '75004', 'WomenHack', '2021-12-27', 40, 'https://www.lelaptop.com/wp-content/uploads/Laptop_Atelier_Beaubourg_centre_paris_location_2000.jpg'),
(4, '2022-03-19', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Building The new web', NULL, NULL, 'https://media.lesechos.com/api/v1/images/view/5ca599e8d286c24ccb023f53/1280x720/0601019270795-web-tete.jpg'),
(5, '2022-06-28', NULL, '2022-07-02', NULL, 'Euratechnologies', '165 Avenue de Bretagne ', 'Lille', '59000', 'Hackathon Summer Space Festival', NULL, 150, 'https://www.lille.fr/var/www/storage/images/mediatheque/mairie-de-lille/visuels-annuaire/euratechnologies/47886-1-fre-FR/Euratechnologies_news_image_top.jpg'),
(6, '2021-11-05', '08:00:00', '2021-11-06', '08:00:00', 'Le palace', '4 rue Voltaire', 'Nantes', '44000', 'InnovHathon', '2021-10-20', 25, 'https://cdn-krusty.galaxy.tf/thumb/sizeW1844/unit-media/workin-unit/uploads/images/coworking_gallery/001/596/882/le-palace-coworking-nantes0003-standard.jpg'),
(7, '2022-04-09', NULL, '2022-04-11', NULL, 'La Cantine', '11 Rue La Noue', 'Nantes', '44200', 'Hacking Health', '2022-03-09', 250, 'https://www.coworkingnantes.com/wp-content/uploads/2018/02/estardes.jpg');

-- --------------------------------------------------------

--
-- Structure de la table `intervenant`
--

DROP TABLE IF EXISTS `intervenant`;
CREATE TABLE IF NOT EXISTS `intervenant` (
  `IdIntervenant` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` int(11) NOT NULL,
  `Prenom` int(11) NOT NULL,
  `Mail` int(11) NOT NULL,
  `Telephone` int(11) NOT NULL,
  PRIMARY KEY (`IdIntervenant`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `intervenantevenement`
--

DROP TABLE IF EXISTS `intervenantevenement`;
CREATE TABLE IF NOT EXISTS `intervenantevenement` (
  `IdIE` int(11) NOT NULL AUTO_INCREMENT,
  `IdIntervenant` int(11) NOT NULL,
  `IdEvenement` int(11) NOT NULL,
  PRIMARY KEY (`IdIE`),
  KEY `Intervenantevenement_ibfk_1` (`IdIntervenant`),
  KEY `Intervenantevenement_ibfk_2` (`IdEvenement`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `participant`
--

DROP TABLE IF EXISTS `participant`;
CREATE TABLE IF NOT EXISTS `participant` (
  `IdParticipant` int(30) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(30) NOT NULL,
  `Prenom` varchar(30) NOT NULL,
  `Mail` varchar(100) NOT NULL,
  `Telephone` int(10) DEFAULT NULL,
  `DateDeNaissance` date NOT NULL,
  `LienPortfolio` varchar(256) DEFAULT NULL,
  `Mdp` varchar(256) NOT NULL,
  PRIMARY KEY (`IdParticipant`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `participant`
--

INSERT INTO `participant` (`IdParticipant`, `Nom`, `Prenom`, `Mail`, `Telephone`, `DateDeNaissance`, `LienPortfolio`, `Mdp`) VALUES
(1, 'Pierre', 'Pierre', 'pierre.pierre@pepe.fr', 78944512, '2021-07-22', 'http://localhost/phpmyadmin/tbl_change.php?db=Hackathon&table=Participants&server=2', 'pierre'),
(2, 'Adrien', 'Adrien', 'adrien@adrii.fr', 7528493, '2017-11-02', 'dsfzghjektlrthyj', 'adrien'),
(3, 'BAPTISTE', 'boudaud', 'ewsrxdtc', 5120, '2027-12-10', 'https://portfolioboudaudbaptiste.wordpress.com', 's!wdxfcgvhbn');

-- --------------------------------------------------------

--
-- Structure de la table `participantevenement`
--

DROP TABLE IF EXISTS `participantevenement`;
CREATE TABLE IF NOT EXISTS `participantevenement` (
  `Id` int(30) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(128) NOT NULL,
  `Prenom` varchar(128) NOT NULL,
  `Mail` varchar(255) NOT NULL,
  `IdEvenement` int(30) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `ParticipantEvenement_ibfk_1` (`IdEvenement`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `participantevenement`
--

INSERT INTO `participantevenement` (`Id`, `Nom`, `Prenom`, `Mail`, `IdEvenement`) VALUES
(1, 'Dupont', 'Thomas', 'tomberdupont@abd.com', 16),
(2, 'Dupond', 'Hugue-eau', 'dupond_huguo@wanadoo.fr', 15),
(3, 'LeBourgeois', 'Yvon', 'adrienabderrahmann@adrienabderrahmann.fr', 16),
(4, 'Pakechteldise', 'Nathan', 'troptard@dommage.net', 16),
(5, 'Matin', 'Martin', 'onsennuit@jamais.org', 15);

-- --------------------------------------------------------

--
-- Structure de la table `participation`
--

DROP TABLE IF EXISTS `participation`;
CREATE TABLE IF NOT EXISTS `participation` (
  `IdParticipation` int(30) NOT NULL AUTO_INCREMENT,
  `IdHackathon` int(30) DEFAULT NULL,
  `IdParticipant` int(30) NOT NULL,
  `DateInscription` date NOT NULL,
  PRIMARY KEY (`IdParticipation`),
  KEY `Participation_ibfk_1` (`IdHackathon`),
  KEY `Participation_ibfk_2` (`IdParticipant`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `participation`
--

INSERT INTO `participation` (`IdParticipation`, `IdHackathon`, `IdParticipant`, `DateInscription`) VALUES
(1, 1, 1, '2022-03-23');

-- --------------------------------------------------------

--
-- Structure de la table `typeevenement`
--

DROP TABLE IF EXISTS `typeevenement`;
CREATE TABLE IF NOT EXISTS `typeevenement` (
  `IdType` int(30) NOT NULL AUTO_INCREMENT,
  `Nom type` varchar(256) NOT NULL,
  PRIMARY KEY (`IdType`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `typeevenement`
--

INSERT INTO `typeevenement` (`IdType`, `Nom type`) VALUES
(1, 'Conférence'),
(2, 'Atelier d\'initiation');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `evenement`
--
ALTER TABLE `evenement`
  ADD CONSTRAINT `Evenement_ibfk_1` FOREIGN KEY (`IdHackathon`) REFERENCES `hackathon` (`IdHackathon`),
  ADD CONSTRAINT `Evenement_ibfk_2` FOREIGN KEY (`IdTypeEvenement`) REFERENCES `typeevenement` (`IdType`);

--
-- Contraintes pour la table `participantevenement`
--
ALTER TABLE `participantevenement`
  ADD CONSTRAINT `ParticipantEvenement_ibfk_1` FOREIGN KEY (`IdEvenement`) REFERENCES `evenement` (`IdEvenement`);
  
--
-- Contraintes pour la table `commentaire`
--
ALTER TABLE `commentaire`
  ADD CONSTRAINT `Commentaire_ibfk_1` FOREIGN KEY (`IdHackathon`) REFERENCES `hackathon` (`IdHackathon`);
  
--
-- Contraintes pour la table `participation`
--
ALTER TABLE `participation`
  ADD CONSTRAINT `Participation_ibfk_1` FOREIGN KEY (`IdHackathon`) REFERENCES `hackathon` (`IdHackathon`),
  ADD CONSTRAINT `Participation_ibfk_2` FOREIGN KEY (`IdParticipant`) REFERENCES `participant` (`IdParticipant`);
  
--
-- Contraintes pour la table `favori`
--
ALTER TABLE `favori`
  ADD CONSTRAINT `Favori_ibfk_1` FOREIGN KEY (`IdHackathon`) REFERENCES `hackathon` (`IdHackathon`),
  ADD CONSTRAINT `Favori_ibfk_2` FOREIGN KEY (`IdParticipant`) REFERENCES `participant` (`IdParticipant`);
  
--
-- Contraintes pour la table `intervenantevenement`
--
ALTER TABLE `intervenantevenement`
  ADD CONSTRAINT `Intervenantevenement_ibfk_1` FOREIGN KEY (`IdIntervenant`) REFERENCES `intervenant` (`IdIntervenant`),
  ADD CONSTRAINT `Intervenantevenement_ibfk_2` FOREIGN KEY (`IdEvenement`) REFERENCES `evenement` (`IdEvenement`);
  
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
