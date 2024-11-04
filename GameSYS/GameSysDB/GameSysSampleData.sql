    DELETE FROM RentalItems;
    DELETE FROM Rentals;
    DELETE FROM Members;
    DELETE FROM Games;
    DELETE FROM Categories;
    DELETE FROM Genres;
    DELETE FROM LoginTable;
    DELETE FROM Counties;
  
    
    INSERT INTO Counties(CountyID, CountyName) VALUES (1, 'Kerry');
    INSERT INTO Counties(CountyID, CountyName) VALUES (2, 'Down');
    INSERT INTO Counties(CountyID, CountyName) VALUES (3, 'Cork');
    INSERT INTO Counties(CountyID, CountyName) VALUES (4, 'Dublin');
    INSERT INTO Counties(CountyID, CountyName) VALUES (5, 'Galway');
    INSERT INTO Counties(CountyID, CountyName) VALUES (6, 'Mayo');
    INSERT INTO Counties(CountyID, CountyName) VALUES (7, 'Kilkenny');
    INSERT INTO Counties(CountyID, CountyName) VALUES (8, 'Limerick');
    INSERT INTO Counties(CountyID, CountyName) VALUES (9, 'Wicklow');
    INSERT INTO Counties(CountyID, CountyName) VALUES (10, 'Waterford');
    
    INSERT INTO Genres(GenreID, GenreName) VALUES(1, 'AA-Action-adventure');
    INSERT INTO Genres(GenreID, GenreName) VALUES(2, 'HR-Horror');
    INSERT INTO Genres(GenreID, GenreName) VALUES(3, 'PZ-Puzzlers');
    INSERT INTO Genres(GenreID, GenreName) VALUES(4, 'SB-Sandbox');
    INSERT INTO Genres(GenreID, GenreName) VALUES(5, 'SB-Survival');
    INSERT INTO Genres(GenreID, GenreName) VALUES(6, 'SH-Shooters');
    INSERT INTO Genres(GenreID, GenreName) VALUES(7, 'PL-Platformer');
    INSERT INTO Genres(GenreID, GenreName) VALUES(8, 'RP-Role Playing');
    
    INSERT INTO Categories(CategoryID, CategoryName, Price) VALUES (1, 'NR - New Release', 5.99);
    INSERT INTO Categories(CategoryID, CategoryName, Price) VALUES (2, 'OR - Old Release', 2.99);
    INSERT INTO Categories(CategoryID, CategoryName, Price) VALUES (3, 'TR - Trending ', 3.99);
    
    INSERT INTO Games Values(1,1,1,'Battlefield 4', '28-Feb-2023','A');
    INSERT INTO Games Values(2,1,2,'Minecraft', '21-Mar-2023','A');
    INSERT INTO Games Values(3,1,2,'Hogwarts Legacy', '15-Jan-2023','A');
    INSERT INTO Games Values(4,1,3,'GTA V', '28-Feb-2023','A');
    INSERT INTO Games Values(5,1,1,'Life is Strange', '28-Jan-2023','A');
    INSERT INTO Games Values(6,2,4,'The Last of Us Part II', '19-Jun-2023','A');
    INSERT INTO Games Values(7,2,5,'Red Dead Redemption 2', '26-Oct-2022','A');
    INSERT INTO Games Values(8,2,3,'Assassins Creed Valhalla', '10-Nov-2021','A');
    INSERT INTO Games Values(9,3,2,'Among Us', '15-Sep-2022','A');
    INSERT INTO Games Values(10,3,1,'Overwatch', '24-May-2023','A');
    INSERT INTO Games Values(11,3,3,'Cyberpunk 2077', '10-Dec-2021','A');
    
    INSERT INTO Members VALUES(1,'Alan','Ligman','alan@gmail.com','password','arlinggton','Tralee',1,'V92K64R',0834496565,'28-FEB-05','28-FEB-23','R');
    INSERT INTO Members VALUES(2,'Joe','Bloggs','joebloggs@gmail.com','johny123','Oakview','Killarney',2,'V91FFFF',0834496565,'28-MAR-05','28-FEB-23','R');
    INSERT INTO Members VALUES(3,'Patryk','Ligman','patryk@gmail.com','password','Parkroad','Tralee',1,'V92K64R',1234567890,'28-FEB-02','28-FEB-23','R');
    INSERT INTO Members VALUES(4,'Adam','Ligman','adam@gmail.com','password','Parkroad','Tralee',1,'V92K64R',1234567890,'28-FEB-01','28-FEB-23','R');
    INSERT INTO Members VALUES(5,'Linda','OBrien','linda@gmail.com','password','Parkroad','Tralee',1,'V92K64R',1234567890,'28-FEB-99','28-FEB-23','R');
    INSERT INTO Members VALUES(6,'John','Smith','johnsmith@gmail.com','password','Oakwood','Dublin',2,'D04C123',0851234567,'01-JAN-00','28-FEB-23','R');
    INSERT INTO Members VALUES(7,'Jane','Doe','janedoe@gmail.com','password','Maplewood','Cork',3,'T12X456',0871234567,'01-FEB-02','28-FEB-23','R');
    INSERT INTO Members VALUES(8,'Peter','Parker','peterparker@gmail.com','password','Park Avenue','Galway',4,'H91YK12',0861234567,'01-MAR-04','28-FEB-23','R');
    INSERT INTO Members VALUES(9,'Mary','Johnson','maryjohnson@gmail.com','password','Birchwood','Limerick',5,'V94Z123',0891234567,'01-APR-06','28-FEB-23','R');
    INSERT INTO Members VALUES(10,'David','Williams','davidwilliams@gmail.com','password','Hillside','Waterford',6,'X91K789',0831234567,'01-MAY-08','28-FEB-23','R');

    INSERT INTO Rentals VALUES(1,1,'28-FEB-23','01-MAR-23',5.99);
    INSERT INTO Rentals VALUES(2,5,'28-FEB-23','05-MAR-23',5.99);
    INSERT INTO Rentals VALUES(3,3,'28-FEB-23','06-MAR-23',5.99);
    INSERT INTO Rentals VALUES(4, 6, '12-APR-23', '16-APR-23', 7.99);
    INSERT INTO Rentals VALUES(5, 2, '15-MAY-23', '20-MAY-23', 4.99);
    INSERT INTO Rentals VALUES(6, 10, '21-JUN-23', '25-JUN-23', 9.99);
    INSERT INTO Rentals VALUES(7, 8, '10-JUL-23', '15-JUL-23', 6.99);
    INSERT INTO Rentals VALUES(8, 4, '18-AUG-23', '22-AUG-23', 5.99);
    INSERT INTO Rentals VALUES (9, 6, '09-MAY-22', '12-MAY-22', 3.99);
    INSERT INTO Rentals VALUES (10, 7, '16-JUN-22', '19-JUN-22', 4.99);
    INSERT INTO Rentals VALUES (11, 8, '21-JUL-22', '25-JUL-22', 2.99);
    INSERT INTO Rentals VALUES (12, 9, '05-AUG-22', '08-AUG-22', 5.99);
    INSERT INTO Rentals VALUES (13, 10, '12-SEP-22', '15-SEP-22', 4.99);
    INSERT INTO Rentals VALUES (17, 1, '18-JAN-21', '22-JAN-21', 2.99);
    INSERT INTO Rentals VALUES (18, 2, '05-FEB-21', '08-FEB-21', 5.99);
    INSERT INTO Rentals VALUES (19, 3, '17-MAR-21', '21-MAR-21', 3.99);
    INSERT INTO Rentals VALUES (20, 4, '02-APR-21', '05-APR-21', 4.99);
    INSERT INTO Rentals VALUES (21, 5, '10-MAY-21', '13-MAY-21', 2.99);


    
    
    
    INSERT INTO LoginTable VALUES('admin','admin');
    
    COMMIT;