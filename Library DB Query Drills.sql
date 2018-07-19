
/*----  1.) How many copies of the book titled "The Lost Tribe" are owned by the library branch whose name is "Sharpstown"?  -----*/
USE LibraryMS
GO

SELECT BranchName, Title, No_Of_Copies FROM BOOK 
INNER JOIN BOOK_COPIES ON BOOK_COPIES.BookID = BOOK.BookID
INNER JOIN LIBRARY_BRANCH ON LIBRARY_BRANCH.BranchID = BOOK_COPIES.BranchID
WHERE BranchName = 'Sharpstown' AND Title = 'The Lost Tribe'

/*----  2.) How many copies of the book titled "The Lost Tribe" are owned by each library branch?  -----*/
USE LibraryMS
GO

SELECT BranchName, Title, No_Of_Copies FROM BOOK 
INNER JOIN BOOK_COPIES ON BOOK_COPIES.BookID = BOOK.BookID
INNER JOIN LIBRARY_BRANCH ON LIBRARY_BRANCH.BranchID = BOOK_COPIES.BranchID
WHERE Title = 'The Lost Tribe'

/*----  3.) Retrieve the names of all borrowers who do not have any books checked out.  -----*/
USE LibraryMS
GO

SELECT Name FROM BORROWER 
WHERE CardNo NOT IN (SELECT CardNo FROM BOOK_LOANS)


/*----  4.) For each book that is loaned out from the "Sharpstown" branch and whose DueDate is today, retrieve the book title, the borrower's name, and the borrower's address.  -----*/
USE LibraryMS
GO

SELECT Title, Name, BORROWER.Address FROM BORROWER 
INNER JOIN BOOK_LOANS ON BOOK_LOANS.CardNo = BORROWER.CardNo
INNER JOIN LIBRARY_BRANCH ON LIBRARY_BRANCH.BranchID = BOOK_LOANS.BranchID
INNER JOIN BOOK ON BOOK_LOANS.BookID = BOOK.BookID
WHERE BranchName = 'Sharpstown' AND DueDate = CAST(GETDATE() AS DATE)

/*----  5.) For each library branch, retrieve the branch name and the total number of books loaned out from that branch.  -----*/
USE LibraryMS
GO

DECLARE @COUNT INT;
SET @COUNT = 1;
DECLARE @LOANS INT;

WHILE @COUNT <=5
BEGIN
SET @LOANS = (SELECT COUNT(*) FROM BOOK_LOANS WHERE BranchID = @COUNT);
SELECT BranchName, @LOANS AS COUNT FROM LIBRARY_BRANCH WHERE LIBRARY_BRANCH.BranchID = @COUNT
SET @COUNT = (@COUNT + 1)
END


/*----  6.) Retrieve the names, addresses, and the number of books checked out for all borrowers who have more than five books checked out.  -----*/

USE LibraryMS
GO

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

/*----  7.) For each book authored (or co-authored) by "Stephen King", retrieve the title and the number of copies owned by the library branch whose name is "Central".  -----*/

USE LibraryMS
GO

SELECT BranchName, Title, AuthorName, No_Of_Copies FROM BOOK 
INNER JOIN BOOK_COPIES ON BOOK.BookID = BOOK_COPIES.BookID
INNER JOIN BOOK_AUTHORS ON BOOK_AUTHORS.BookID = BOOK_COPIES.BookID
INNER JOIN LIBRARY_BRANCH ON BOOK_COPIES.BranchID = LIBRARY_BRANCH.BranchID
WHERE AuthorName = 'Stephen King' AND BranchName = 'Central'







