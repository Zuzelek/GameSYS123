DROP TABLE LoginTable;
DROP TABLE RentalItems;
DROP Table Rentals;
DROP TABLE Members;
DROP TABLE Counties;
DROP TABLE Games;
DROP TABLE Genres;
DROP TABLE Categories;

CREATE TABLE LoginTable (
    username VARCHAR2(30) NOT NULL,
    password VARCHAR2(30) NOT NULL,
    CONSTRAINT pk_LoginTable PRIMARY KEY (username)
);

CREATE TABLE Genres (
    GenreID NUMERIC(2) NOT NULL,
    GenreName VARCHAR2(20) NOT NULL,
    CONSTRAINT pk_GenreID PRIMARY KEY (GenreID)
);

CREATE TABLE Categories (
    CategoryID NUMERIC(2) NOT NULL,
    CategoryName VARCHAR2(25) NOT NULL,
    Price NUMERIC(4, 2) NOT NULL,
    CONSTRAINT pk_CategoryID PRIMARY KEY (CategoryID)
);

CREATE TABLE Games (
    GameID NUMERIC(3) NOT NULL,
    CategoryID NUMERIC(2) NOT NULL,
    GenreID NUMERIC(2) NOT NULL,
    Title VARCHAR2(25) NOT NULL,
    Year VARCHAR2(11) NOT NULL,
    Status CHAR(1) DEFAULT 'A',
    CONSTRAINT pk_GameID PRIMARY KEY (GameID),
    CONSTRAINT fk_CategoryID FOREIGN KEY (CategoryID) REFERENCES Categories (CategoryID),
    CONSTRAINT fk_GenreID FOREIGN KEY (GenreID) REFERENCES Genres (GenreID)
);

CREATE TABLE Counties (
    CountyID NUMERIC(2) NOT NULL,
    CountyName VARCHAR2(20) NOT NULL,
    CONSTRAINT pk_CountyID PRIMARY KEY (CountyID)
);

CREATE TABLE Members (
    MemberID NUMERIC(4) NOT NULL,
    Forename VARCHAR2(20) NOT NULL,
    Surname VARCHAR2(20) NOT NULL,
    EmailAddress VARCHAR2(35) NOT NULL,
    Password VARCHAR2(20) NOT NULL,
    Street VARCHAR2(20) NOT NULL,
    City VARCHAR2(20) NOT NULL,
    CountyID NUMERIC(2) NOT NULL,
    Eircode VARCHAR2(7) NOT NULL,
    Phone NUMERIC(10) NOT NULL,
    DOB DATE NOT NULL,
    RegDate DATE,
    RegStatus CHAR(1),
    CONSTRAINT pk_MemberID PRIMARY KEY (MemberID),
    CONSTRAINT fk_CountyID FOREIGN KEY (CountyID) REFERENCES Counties (CountyID)
);

CREATE TABLE Rentals (
    RentalID NUMERIC(4) NOT NULL,
    MemberID NUMERIC(4) NOT NULL,
    RentalDate DATE NOT NULL,
    ReturnDate DATE NOT NULL,
    Price NUMERIC(6, 2) NOT NULL,
    CONSTRAINT pk_RentalID PRIMARY KEY (RentalID),
    CONSTRAINT fk_MemberID FOREIGN KEY (MemberID) REFERENCES Members (MemberID)
);

CREATE TABLE RentalItems (
    RentalID NUMERIC(4) NOT NULL,
    GameID NUMERIC(3) NOT NULL,
    CONSTRAINT pk_RentalItem PRIMARY KEY (RentalID, GameID),
    CONSTRAINT fk_RentalID FOREIGN KEY (RentalID) REFERENCES Rentals (RentalID),
    CONSTRAINT fk_GameID FOREIGN KEY (GameID) REFERENCES Games (GameID)
);