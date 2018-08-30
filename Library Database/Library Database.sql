CREATE DATABASE LibraryMS;
GO
USE LibraryMS;

CREATE TABLE LIBRARY_BRANCH (
BranchID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
BranchName VARCHAR (50) NOT NULL,
Address VARCHAR (100) NOT NULL,
);

INSERT INTO LIBRARY_BRANCH (BranchName, Address)
VALUES ('Sharpstown', '12 Smith Street, Sharpstown, OR 97001'),
('Central', '801 SW 10th Avenue, Portland, OR 97205'),
('Kamiville', '16 Massachusetts Lane, Kamiville, OR 97160'),
('Boston', '50 New England Road, New Boston, OR 97111'),
('Ledding', '10660 SE 21st Ave, Milwaukie, OR 97222');

CREATE TABLE PUBLISHER (
Name VARCHAR (50) NOT NULL PRIMARY KEY,
Address VARCHAR (100) NOT NULL,
Phone VARCHAR (20) NOT NULL
);

INSERT INTO PUBLISHER (Name, Address, Phone)
VALUES ('Simon & Schuster', '1230 6th Ave, New York, NY 10020', '1-800-223-2336'),
('HarperCollins', '195 Broadway, New York, NY 10007', '1-800-242-7737'),
('Penguin Classics', '375 Hudson St, New York, NY 10014', '1-800-726-0600'),
('Scribner', '153-157 5th Ave, New York, NY 10010', '1-212-632-4915'),
('Penguin Random House', '375 Hudson St, New York, NY 10014', '1-800-726-0600'),
('Scholastic', '557 Broadway, New York, NY 10012', '1-800-724-6527'),
('Ace Books', '375 Hudson St, New York, NY 10014', '1-800-726-0600'),
('G.P. Putnams Sons', '375 Hudson St, New York, NY 10014',	'1-800-726-0600'),
('Dutton', '375 Hudson St, New York, NY 10014', '1-800-726-0600'),
('Picador USA', '175 5th Ave, New York, NY 10010', '1-800-221-7945');



CREATE TABLE BOOK (
BookID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
Title VARCHAR (50) NOT NULL,
PublisherName VARCHAR (50) CONSTRAINT FK_BOOK_PublisherName
FOREIGN KEY (PublisherName) REFERENCES PUBLISHER(Name) 
ON DELETE CASCADE ON UPDATE CASCADE, 
);

INSERT INTO BOOK (Title, PublisherName)
VALUES ('The Shining', 'Scribner'),
('Liseys Story', 'Scribner'),
('The Green Mile', 'Scribner'),
('Pet Sematary', 'Scribner'),
	
('The Lost Tribe', 'Picador USA'),
	
('Dracula', 'Penguin Classics'),
('The Lady of the Shroud', 'Penguin Classics'),
('The Lair of the White Worm', 'Penguin Classics'),
	
('The Hobbit', 'HarperCollins'),
('The Silmarillion', 'HarperCollins'),
('The Lord of the Rings Anthology', 'HarperCollins'),
	
('Journey to the Center of the Earth', 'Penguin Classics'),
('Twenty Thousand Leagues Under the Sea', 'Penguin Classics'),
('Around the World in Eighty Days', 'Penguin Classics'),
	
('Trigger Warning', 'Simon & Schuster'),
('Good Omens', 'Simon & Schuster'),
('American Gods', 'Simon & Schuster'),
	
('Stranger in a Strange Land', 'Ace Books'),
('Starship Troopers', 'Ace Books'),
('The Cat Who Walks Through Walls', 'Ace Books'),
	
('The Hitchhikers Guide to the Galaxy', 'Simon & Schuster'),
('The Long Dark Tea-Time of the Soul', 'Simon & Schuster'),
	
('Ghost Story', 'G.P. Putnams Sons'),
('Koko', 'Dutton'),
	
('Shatterglass', 'Scholastic'),
('Lioness Rampant', 'Penguin Random House'),
('Dajas Book', 'Scholastic'),
	
('The Scent Of Magic', 'Simon & Schuster'),
('Garan The Eternal', 'Simon & Schuster'),
	
('The Color Of Magic', 'HarperCollins'),
('Thief Of Time', 'HarperCollins'),
('Wyrd Sisters', 'HarperCollins'),

('Murder on the Orient Express', 'HarperCollins'),
('The Murder of Roger Ackroyd', 'HarperCollins'),
	
('Fahrenheit 451', 'Simon & Schuster'),
('The Martian Chronicles', 'Simon & Schuster');


CREATE TABLE BOOK_AUTHORS (
BookID INT CONSTRAINT FK_AUTHORS_BookID
FOREIGN KEY (BookID) REFERENCES BOOK(BookID) 
ON DELETE CASCADE ON UPDATE CASCADE, 
AuthorName VARCHAR (50) NOT NULL
);


INSERT INTO BOOK_AUTHORS (BookID, AuthorName)
VALUES (1, 'Stephen King'),
(2, 'Stephen King'),
(3, 'Stephen King'),
(4, 'Stephen King'),
(5, 'Mark Lee'),
(6, 'Bram Stoker'),
(7, 'Bram Stoker'),
(8, 'Bram Stoker'),
(9, 'J.R.R. Tolkien'),
(10, 'J.R.R. Tolkien'),
(11, 'J.R.R. Tolkien'),
(12, 'Jules Verne'),
(13, 'Jules Verne'),
(14, 'Jules Verne'),
(15, 'Neil Gaiman'),
(16, 'Neil Gaiman'),
(17, 'Neil Gaiman'),
(18, 'Robert Heinlein'),
(19, 'Robert Heinlein'),
(20, 'Robert Heinlein'),
(21, 'Douglas Adams'),
(22, 'Douglas Adams'),
(23, 'Peter Straub'),
(24, 'Peter Straub'),
(25, 'Tamora Pierce'),
(26, 'Tamora Pierce'),
(27, 'Tamora Pierce'),
(28, 'Andre Norton'),
(29, 'Andre Norton'),
(30, 'Terry Pratchett'),
(31, 'Terry Pratchett'),
(32, 'Terry Pratchett'),
(33, 'Agatha Christie'),
(34, 'Agatha Christie'),
(35, 'Ray Bradbury'),
(36, 'Ray Bradbury');


CREATE TABLE BORROWER (
CardNo INT NOT NULL PRIMARY KEY IDENTITY (158379573,32),
Name VARCHAR (100) NOT NULL,
Address VARCHAR (200) NOT NULL,
Phone VARCHAR (50) NOT NULL
);

INSERT INTO BORROWER (Name, Address, Phone)
VALUES ('Kimber Mcninch', '685 Aspen St, Holland, OR 97423', '971-555-0167'),
('Kaitlyn Staub', '9780 Bohemia Dr, Maine, OR 97099', '503-555-0135'),
('Sally Mckendree', '119 Ann Ln, Circle Pines, OR 97014', '541-555-0102'),
('Marion Okafor', '9015 Pilgrim Cir, Fort Lee, OR 97024', '541-555-0120'),
('Loreta Rhynes', '965 Princess Dr, Newark, OR 97103', '971-555-0104'),
('Cleora Donovan', '9586 Albany St, Oxford, OR 97655', '971-555-0176'),
('Linnea Guo', '989 High Point Ave, Aberdeen, OR 97401', '541-555-0136'),
('Jonah Saunders', '673 Mill Dr, Sanford, OR 97330', '503-555-0176'),
('Reyes Steinberger', '66 Manor Station Ave, Austin, OR 97912', '971-555-0112'),
('Ignacio Morones', '86 Grove St, Janesville, OR 97546', '503-555-0160'),
('Carlton Kole', '7824 Devonshire Ln, Lithonia, OR 97038', '541-555-0178'),
('Lisbeth Herbst', '17 Harvey St, Ephrata, OR 97522', '971-555-0187'),
('Vanda Lewandowski', '8 Berkshire Dr, Hicksville, OR 97801', '971-555-0115'),
('Pearle Dion', '9 SE. Lantern Dr, Owensboro, OR 97301', '541-555-0159'),
('Sherill Kanode', '9854 Evergreen Dr, Chicopee, OR 97020', '503-555-0109'),
('Mollie Choquette', '75 Sunbeam Ln, Joliet, OR 97435', '541-555-0185'),
('Evelin Milani', '557 Trout Ave, Port Washington, OR 97050', '971-555-0192'),
('Hector Munro', '784 Newbridge Ave, Orange Park, OR 97065', '971-555-0169'),
('Luciana Didier', '714 Amherst Ct, Corona, OR 97368', '503-555-0177'),
('Christopher Fulton', '7240 Union St, Hamburg, OR 97075', '541-555-0196'),
('Minerva Boring', '9211 Cedar Swamp Ct, Huntington Station, OR 97746', '971-555-0196'),
('Barb Hermann', '8985 South Division Dr, Apopka, OR 97703', '503-555-0192');

CREATE TABLE BOOK_COPIES (
BookID INT CONSTRAINT FK_COPIES_BookID
FOREIGN KEY (BookID) REFERENCES BOOK(BookID) 
ON DELETE CASCADE ON UPDATE CASCADE, 
BranchID INT CONSTRAINT FK_COPIES_BranchID
FOREIGN KEY (BranchID) REFERENCES LIBRARY_BRANCH(BranchID) 
ON DELETE CASCADE ON UPDATE CASCADE, 
No_Of_Copies INT NOT NULL
);

INSERT INTO BOOK_COPIES (BookID, BranchID, No_Of_Copies)
VALUES (1, 1, 2),
(1, 2, 3),
(1, 4, 3),
(2, 2, 2),
(2, 5, 4),
(2, 1, 3),
(3, 1, 2),
(3, 3, 4),
(3, 4, 3),
(4, 1, 2),
(4, 2, 2),
(5, 1, 3),
(5, 3, 3),
(6, 4, 2),
(6, 5, 4),
(7, 2, 3),
(7, 5, 2),
(8, 3, 4),
(8, 4, 3),
(9, 1, 2),
(9, 2, 4),
(10, 5, 3),
(10, 2, 2),
(11, 2, 3),
(11, 4, 2),
(12, 3, 4),
(12, 5, 3),
(13, 1, 2),
(13, 4, 4),
(14, 5, 3),
(14, 3, 2),
(15, 3, 2),
(15, 4, 3),
(16, 2, 3),
(16, 5, 2),
(17, 1, 4),
(17, 3, 3),
(18, 5, 2),
(18, 1, 4),
(19, 4, 3),
(19, 2, 2),
(20, 1, 3),
(20, 2, 2),
(21, 3, 2),
(21, 4, 3),
(22, 5, 3),
(22, 3, 2),
(23, 1, 4),
(23, 3, 3),
(24, 1, 2),
(24, 2, 4),
(24, 4, 3),
(25, 5, 2),
(25, 1, 3),
(26, 2, 3),
(26, 3, 2),
(27, 1, 4),
(27, 5, 3),
(28, 4, 2),
(28, 2, 4),
(29, 3, 3),
(29, 5, 2),
(30, 2, 3),
(30, 5, 3),
(31, 5, 2),
(31, 4, 4),
(32, 1, 3),
(32, 3, 2),
(33, 1, 4),
(33, 2, 3),
(33, 4, 2),
(34, 5, 3),
(34, 3, 3),
(35, 2, 2),
(35, 4, 4),
(36, 1, 3),
(36, 3, 2);

CREATE TABLE BOOK_LOANS (
BookID INT CONSTRAINT FK_LOANS_BookID
FOREIGN KEY (BookID) REFERENCES BOOK(BookID) 
ON DELETE CASCADE ON UPDATE CASCADE, 
BranchID INT CONSTRAINT FK_LOANS_BranchID
FOREIGN KEY (BranchID) REFERENCES LIBRARY_BRANCH(BranchID) 
ON DELETE CASCADE ON UPDATE CASCADE, 
CardNo INT CONSTRAINT FK_LOANS_CardNo
FOREIGN KEY (CardNo) REFERENCES BORROWER(CardNo) 
ON DELETE CASCADE ON UPDATE CASCADE,
DateOut DATE NOT NULL,
DueDate DATE NOT NULL
);

INSERT INTO BOOK_LOANS (BookID, BranchID, CardNo, DateOut, DueDate)
VALUES (24, 1, 158379925, '2018-07-14', '2018-07-28'),
(3, 1, 158379925, '2018-07-08', '2018-07-22'),
(5, 1, 158379669, '2018-07-03', '2018-07-17'),
(17, 1, 158379669, '2018-07-16', '2018-07-30'),
(27, 1, 158379669, '2018-07-11', '2018-07-25'),
(33, 1, 158379669, '2018-07-10', '2018-07-24'),
(1, 1, 158380213, '2018-07-06', '2018-07-20'),
(13, 1, 158380213, '2018-07-12', '2018-07-26'),
(20, 1, 158380213, '2018-07-15', '2018-07-29'),
(25, 1, 158380213, '2018-07-10', '2018-07-24'),
(18, 1, 158380213, '2018-07-12', '2018-07-26'),
(30, 2, 158379797, '2018-07-03', '2018-07-17'),
(10, 2, 158379797, '2018-07-14', '2018-07-28'),
(26, 2, 158379989, '2018-07-04', '2018-07-18'),
(30, 2, 158379989, '2018-07-05', '2018-07-19'),
(28, 2, 158379989, '2018-07-11', '2018-07-25'),
(2, 2, 158379637, '2018-07-08', '2018-07-22'),
(20, 2, 158379637, '2018-07-04', '2018-07-18'),
(35, 2, 158379637, '2018-07-09', '2018-07-23'),
(16, 2, 158379637, '2018-07-13', '2018-07-27'),
(33, 2, 158379637, '2018-07-07', '2018-07-21'),
(9, 2, 158379637, '2018-07-08', '2018-07-22'),
(34, 3, 158380245, '2018-07-03', '2018-07-17'),
(32, 3, 158380245, '2018-07-11', '2018-07-25'),
(22, 3, 158379893, '2018-07-05', '2018-07-19'),
(5, 3, 158379893, '2018-07-04', '2018-07-18'),
(23, 3, 158379893, '2018-07-09', '2018-07-23'),
(12, 3, 158379893, '2018-07-14', '2018-07-28'),
(14, 3, 158379605, '2018-07-07', '2018-07-21'),
(21, 3, 158379605, '2018-07-05', '2018-07-19'),
(36, 3, 158379605, '2018-07-06', '2018-07-20'),
(5, 3, 158379605, '2018-07-11', '2018-07-25'),
(29, 3, 158379605, '2018-07-06', '2018-07-20'),
(8, 3, 158379605, '2018-07-07', '2018-07-21'),
(12, 3, 158379605, '2018-07-12', '2018-07-26'),
(31, 4, 158379765, '2018-07-15', '2018-07-29'),
(35, 4, 158379765, '2018-07-16', '2018-07-30'),
(19, 4, 158379765, '2018-07-05', '2018-07-19'),
(21, 4, 158380149, '2018-07-03', '2018-07-17'),
(1, 4, 158380149, '2018-07-12', '2018-07-26'),
(11, 4, 158380149, '2018-07-05', '2018-07-19'),
(11, 4, 158380181, '2018-07-10', '2018-07-24'),
(3, 4, 158380181, '2018-07-03', '2018-07-17'),
(19, 4, 158380181, '2018-07-06', '2018-07-20'),
(13, 4, 158380181, '2018-07-17', '2018-07-31'),
(31, 4, 158380181, '2018-07-16', '2018-07-30'),
(8, 4, 158380181, '2018-07-08', '2018-07-22'),
(6, 4, 158380053, '2018-07-04', '2018-07-18'),
(28, 4, 158380053, '2018-07-16', '2018-07-30'),
(1, 4, 158380053, '2018-07-09', '2018-07-23'),
(15, 4, 158380053, '2018-07-09', '2018-07-23'),
(24, 4, 158380053, '2018-07-13', '2018-07-27'),
(35, 4, 158380053, '2018-07-15', '2018-07-29'),
(31, 4, 158380053, '2018-07-07', '2018-07-21'),
(25, 5, 158379701, '2018-07-17', '2018-07-31'),
(27, 5, 158379701, '2018-07-06', '2018-07-20'),
(16, 5, 158380085, '2018-07-04', '2018-07-18'),
(31, 5, 158380085, '2018-07-14', '2018-07-28'),
(12, 5, 158380085, '2018-07-17', '2018-07-31'),
(34, 5, 158380085, '2018-07-10', '2018-07-24'),
(6, 5, 158380085, '2018-07-07', '2018-07-21'),
(7, 5, 158379829, '2018-07-15', '2018-07-29'),
(18, 5, 158379829, '2018-07-17', '2018-07-31'),
(14, 5, 158379829, '2018-07-08', '2018-07-22'),
(2, 5, 158379829, '2018-07-13', '2018-07-27'),
(27, 5, 158379829, '2018-07-09', '2018-07-23'),
(10, 5, 158379829, '2018-07-13', '2018-07-27');




/*----  1.) How many copies of the book titled "The Lost Tribe" are owned by the library branch whose name is "Sharpstown"?  -----*/
USE LibraryMS
GO

CREATE PROCEDURE Question1
AS

SELECT BranchName, Title, No_Of_Copies FROM BOOK 
INNER JOIN BOOK_COPIES ON BOOK_COPIES.BookID = BOOK.BookID
INNER JOIN LIBRARY_BRANCH ON LIBRARY_BRANCH.BranchID = BOOK_COPIES.BranchID
WHERE BranchName = 'Sharpstown' AND Title = 'The Lost Tribe'

GO


/*----  2.) How many copies of the book titled "The Lost Tribe" are owned by each library branch?  -----*/
USE LibraryMS
GO

CREATE PROCEDURE Question2
AS

SELECT BranchName, Title, No_Of_Copies FROM BOOK 
INNER JOIN BOOK_COPIES ON BOOK_COPIES.BookID = BOOK.BookID
INNER JOIN LIBRARY_BRANCH ON LIBRARY_BRANCH.BranchID = BOOK_COPIES.BranchID
WHERE Title = 'The Lost Tribe'

GO

/*----  3.) Retrieve the names of all borrowers who do not have any books checked out.  -----*/
USE LibraryMS
GO

CREATE PROCEDURE Question3
AS

SELECT Name FROM BORROWER 
WHERE CardNo NOT IN (SELECT CardNo FROM BOOK_LOANS)

GO

/*----  4.) For each book that is loaned out from the "Sharpstown" branch and whose DueDate is today, retrieve the book title, the borrower's name, and the borrower's address.  -----*/
USE LibraryMS
GO

CREATE PROCEDURE Question4
AS

SELECT Title, Name, BORROWER.Address FROM BORROWER 
INNER JOIN BOOK_LOANS ON BOOK_LOANS.CardNo = BORROWER.CardNo
INNER JOIN LIBRARY_BRANCH ON LIBRARY_BRANCH.BranchID = BOOK_LOANS.BranchID
INNER JOIN BOOK ON BOOK_LOANS.BookID = BOOK.BookID
WHERE BranchName = 'Sharpstown' AND DueDate = CAST(GETDATE() AS DATE)

GO

/*----  5.) For each library branch, retrieve the branch name and the total number of books loaned out from that branch.  -----*/
USE LibraryMS
GO

CREATE PROCEDURE Question5
AS

DECLARE @COUNT INT;
SET @COUNT = 1;
DECLARE @LOANS INT;

WHILE @COUNT <=5
BEGIN
SET @LOANS = (SELECT COUNT(*) FROM BOOK_LOANS WHERE BranchID = @COUNT);
SELECT BranchName, @LOANS AS COUNT FROM LIBRARY_BRANCH WHERE LIBRARY_BRANCH.BranchID = @COUNT
SET @COUNT = (@COUNT + 1)
END

GO

/*----  6.) Retrieve the names, addresses, and the number of books checked out for all borrowers who have more than five books checked out.  -----*/

USE LibraryMS
GO


CREATE PROCEDURE Question6
AS


DECLARE @COUNT INT;
SET @COUNT = 1;

DECLARE @CARD INT;
SET @CARD = 158379573

DECLARE @CHKBKS INT;
SET @CHKBKS = (SELECT COUNT(*) FROM BOOK_LOANS WHERE CardNo = @CARD)


WHILE @COUNT <=100 AND @CARD <= 158380245
IF
@CHKBKS >=5
BEGIN

SELECT Name, Address, @CHKBKS AS Checked_Books FROM BORROWER WHERE CardNo = @CARD
SET @COUNT = @COUNT + 1
SET @CARD = @CARD + 32
SET @CHKBKS = (SELECT COUNT(*) FROM BOOK_LOANS WHERE CardNo = @CARD)
END

ELSE
BEGIN
SET @COUNT = @COUNT + 1
SET @CARD = @CARD + 32
SET @CHKBKS = (SELECT COUNT(*) FROM BOOK_LOANS WHERE CardNo = @CARD)
END

GO

/*----  7.) For each book authored (or co-authored) by "Stephen King", retrieve the title and the number of copies owned by the library branch whose name is "Central".  -----*/

USE LibraryMS
GO

CREATE PROCEDURE Question7
AS

SELECT BranchName, Title, AuthorName, No_Of_Copies FROM BOOK 
INNER JOIN BOOK_COPIES ON BOOK.BookID = BOOK_COPIES.BookID
INNER JOIN BOOK_AUTHORS ON BOOK_AUTHORS.BookID = BOOK_COPIES.BookID
INNER JOIN LIBRARY_BRANCH ON BOOK_COPIES.BranchID = LIBRARY_BRANCH.BranchID
WHERE AuthorName = 'Stephen King' AND BranchName = 'Central'

GO



