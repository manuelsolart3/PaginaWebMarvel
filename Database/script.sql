CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    `ProductVersion` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
) CHARACTER SET=utf8mb4;

START TRANSACTION;

ALTER DATABASE CHARACTER SET utf8mb4;

CREATE TABLE `User` (
    `Id` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `FullName` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
    `identification` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
    `UserName` varchar(256) CHARACTER SET utf8mb4 NULL,
    `NormalizedUserName` varchar(256) CHARACTER SET utf8mb4 NULL,
    `Email` varchar(256) CHARACTER SET utf8mb4 NULL,
    `NormalizedEmail` varchar(256) CHARACTER SET utf8mb4 NULL,
    `EmailConfirmed` tinyint(1) NOT NULL,
    `PasswordHash` longtext CHARACTER SET utf8mb4 NULL,
    `SecurityStamp` longtext CHARACTER SET utf8mb4 NULL,
    `ConcurrencyStamp` longtext CHARACTER SET utf8mb4 NULL,
    `PhoneNumber` longtext CHARACTER SET utf8mb4 NULL,
    `PhoneNumberConfirmed` tinyint(1) NOT NULL,
    `TwoFactorEnabled` tinyint(1) NOT NULL,
    `LockoutEnd` datetime(6) NULL,
    `LockoutEnabled` tinyint(1) NOT NULL,
    `AccessFailedCount` int NOT NULL,
    CONSTRAINT `PK_User` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `AspNetUserClaims` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `UserId` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `ClaimType` longtext CHARACTER SET utf8mb4 NULL,
    `ClaimValue` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AspNetUserClaims` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AspNetUserClaims_User_UserId` FOREIGN KEY (`UserId`) REFERENCES `User` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `AspNetUserLogins` (
    `LoginProvider` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `ProviderKey` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `ProviderDisplayName` longtext CHARACTER SET utf8mb4 NULL,
    `UserId` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_AspNetUserLogins` PRIMARY KEY (`LoginProvider`, `ProviderKey`),
    CONSTRAINT `FK_AspNetUserLogins_User_UserId` FOREIGN KEY (`UserId`) REFERENCES `User` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `AspNetUserTokens` (
    `UserId` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `LoginProvider` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `Name` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `Value` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AspNetUserTokens` PRIMARY KEY (`UserId`, `LoginProvider`, `Name`),
    CONSTRAINT `FK_AspNetUserTokens_User_UserId` FOREIGN KEY (`UserId`) REFERENCES `User` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE INDEX `IX_AspNetUserClaims_UserId` ON `AspNetUserClaims` (`UserId`);

CREATE INDEX `IX_AspNetUserLogins_UserId` ON `AspNetUserLogins` (`UserId`);

CREATE INDEX `EmailIndex` ON `User` (`NormalizedEmail`);

CREATE UNIQUE INDEX `UserNameIndex` ON `User` (`NormalizedUserName`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250214015338_InitialCreate', '8.0.13');

COMMIT;

START TRANSACTION;

ALTER TABLE `User` RENAME COLUMN `identification` TO `Identification`;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250214135836_ChangeCamelCase', '8.0.13');

COMMIT;

START TRANSACTION;

CREATE TABLE `Comic` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `Title` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `Description` varchar(2000) CHARACTER SET utf8mb4 NULL,
    `Author` varchar(80) CHARACTER SET utf8mb4 NULL,
    `Reference` varchar(50) CHARACTER SET utf8mb4 NULL,
    `Pages` int NULL DEFAULT 1,
    `ImageUrl` varchar(500) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_Comic` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE UNIQUE INDEX `IX_Comic_Reference` ON `Comic` (`Reference`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250214192448_CeateComic', '8.0.13');

COMMIT;

START TRANSACTION;

CREATE TABLE `UserFavoriteComics` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `UserId` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `ComicId` char(36) COLLATE ascii_general_ci NOT NULL,
    CONSTRAINT `PK_UserFavoriteComics` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_UserFavoriteComics_Comic_ComicId` FOREIGN KEY (`ComicId`) REFERENCES `Comic` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_UserFavoriteComics_User_UserId` FOREIGN KEY (`UserId`) REFERENCES `User` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE INDEX `IX_UserFavoriteComics_ComicId` ON `UserFavoriteComics` (`ComicId`);

CREATE INDEX `IX_UserFavoriteComics_UserId` ON `UserFavoriteComics` (`UserId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20250215230652_CreateUFC', '8.0.13');

COMMIT;

