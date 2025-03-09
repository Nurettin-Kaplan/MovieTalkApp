create database MovieTalkApp

use MovieTalkApp;

CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
	ProfilePicture NVARCHAR(255),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Email NVARCHAR(100) NOT NULL UNIQUE,
	Phone NVARCHAR(10) NOT NULL UNIQUE,
    UserPassword NVARCHAR(255) NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE(),
	Author BIT
);

insert into Users (ProfilePicture, Username, Email, Phone, UserPassword, CreatedAt, Author)
values ('C:\\MovieTalkApp\\UserPictures\\nurettinkaplaan.jpg', 'nurettinkaplan', 'nurettinkaplaan@gmail.com', '5437226130','123456', GETDATE() ,1);

insert into Users (ProfilePicture, Username, Email, Phone, UserPassword, CreatedAt, Author)
values ('C:\\MovieTalkApp\\UserPictures\\aslierbasi.jpg', 'aslierbasi', 'aslierbasi@stu.topkapi.edu.tr', '5300990104', 'sifre123', GETDATE() ,1);

insert into Users (ProfilePicture, Username, Email, Phone, UserPassword, CreatedAt, Author)
values ('C:\\MovieTalkApp\\UserPictures\\sergenyalcin.jpg', 'sergen1903', 'sergenyalcin@outlook.com', '5368807017', 'kartal1903', GETDATE() ,0);

insert into Users (ProfilePicture, Username, Email, Phone, UserPassword, CreatedAt, Author)
values ('C:\\MovieTalkApp\\UserPictures\\feyyazucar.jpg', 'feyyaz1903', 'feyyazucar@gmail.com', '5438807017', 'besiktas1903', GETDATE() ,0);

insert into Users (ProfilePicture, Username, Email, Phone, UserPassword, CreatedAt, Author)
values ('C:\\MovieTalkApp\\UserPictures\\rizacalimbay.jpg', 'riza1903', 'rizacalimbay@gmail.com', '5435982817', 'carsi1903', GETDATE() ,0);

INSERT INTO Users (ProfilePicture, Username, Email, Phone, UserPassword, CreatedAt, Author)
VALUES
('https://randomuser.me/api/portraits/men/1.jpg', 'emrecan', 'emrecan@gmail.com', '5551234567', 'password123', DEFAULT, 0),

('https://randomuser.me/api/portraits/women/2.jpg', 'aysegul', 'aysegul@gmail.com', '5552345678', 'securepass456', DEFAULT, 0),

('https://randomuser.me/api/portraits/men/3.jpg', 'mehmetali', 'mehmetali@hotmail.com', '5553456789', 'mypassword789', DEFAULT, 0),

('https://randomuser.me/api/portraits/women/4.jpg', 'fatma', 'fatma@gmail.com', '5554567890', 'helloWorld123', DEFAULT, 0),

('https://randomuser.me/api/portraits/men/5.jpg', 'ahmet', 'ahmet@gmail.com', '5555678901', 'pass2024', DEFAULT, 0),

('https://randomuser.me/api/portraits/women/6.jpg', 'elif', 'elif@hotmail.com', '5556789012', 'securePass123', DEFAULT, 0),

('https://randomuser.me/api/portraits/men/7.jpg', 'burak', 'burak@gmail.com', '5557890123', 'topsecret', DEFAULT, 0),

('https://randomuser.me/api/portraits/women/8.jpg', 'selin', 'selin@gmail.com', '5558901234', 'mypasswd', DEFAULT, 0),

('https://randomuser.me/api/portraits/men/9.jpg', 'onur', 'onur@gmail.com', '5559012345', 'hard2guess', DEFAULT, 0),

('https://randomuser.me/api/portraits/women/10.jpg', 'melike', 'melike@hotmail.com', '5551234560', 'strongPass!@#', DEFAULT, 0),

('https://randomuser.me/api/portraits/men/11.jpg', 'kadir', 'kadir@gmail.com', '5552345671', 'Qwerty123', DEFAULT, 0),

('https://randomuser.me/api/portraits/women/12.jpg', 'ece', 'ece@gmail.com', '5553456782', 'password2024', DEFAULT, 0),

('https://randomuser.me/api/portraits/men/13.jpg', 'umut', 'umut@gmail.com', '5554567893', 'passme!@', DEFAULT, 0),

('https://randomuser.me/api/portraits/women/14.jpg', 'irem', 'irem@gmail.com', '5555678904', 'admin2024', DEFAULT, 0),

('https://randomuser.me/api/portraits/men/15.jpg', 'murat', 'murat@hotmail.com', '5556789015', 'mySecureKey', DEFAULT, 0);

select * from Users

update Users set ProfilePicture = 'C:\\MovieTalkApp\\UserPictures\\sergenyalcin.jpg' where Username= 'sergen1903'
update Users set ProfilePicture = 'C:\\MovieTalkApp\\UserPictures\\feyyazucar.jpg' where Username= 'feyyaz1903'

DELETE FROM Users
WHERE UserID = 6;

CREATE TABLE Movies (
    MovieID INT PRIMARY KEY IDENTITY(1,1),
	PosterImage NVARCHAR(255),
    Title NVARCHAR(100) NOT NULL,
    MovieDescription NVARCHAR(MAX),
    ReleaseDate DATE,
    Genre NVARCHAR(50),
    Director NVARCHAR(100),
);

select * from Movies

INSERT INTO Movies (PosterImage, Title, MovieDescription, ReleaseDate, Genre, Director)
VALUES 
('https://upload.wikimedia.org/wikipedia/tr/e/e6/Esaretin-bedeli.jpg', 
 'Esaretin Bedeli', 
 '�ki mahk�m y�llar boyunca dostluk kurar, ortak bir dayan��ma ve insanl�k eylemleri arac�l���yla teselli ve sonunda kurtulu� bulurlar.', 
 '1994-09-23', 
 'Drama', 
 'Frank Darabont'),

('https://upload.wikimedia.org/wikipedia/tr/7/7c/1972_yap%C4%B1m%C4%B1_Baba_film_afi%C5%9Fi.jpg', 
 'Baba', 
 'Ya�lanan bir su� �rg�t� lideri, gizli imparatorlu�unun kontrol�n� g�n�ls�z o�luna devreder.', 
 '1972-03-24', 
 'Su� - Drama', 
 'Francis Ford Coppola'),

('https://upload.wikimedia.org/wikipedia/tr/4/4d/Kara_%C5%9E%C3%B6valye_TR_film_afi%C5%9Fi.jpg', 
 'Kara ��valye', 
 'Joker olarak bilinen tehdit ge�mi�inden ��k�p Gotham halk�na kaos ve y�k�m getirirken, Batman onunla y�zle�mek zorundad�r.', 
 '2008-07-18', 
 'Aksiyon - Su�', 
 'Christopher Nolan'),

('https://upload.wikimedia.org/wikipedia/tr/9/94/Ba%C5%9Flang%C4%B1%C3%A7.jpg', 
 'Ba�lang��', 
 'R�ya payla��m teknolojisini kullanarak kurumsal s�rlar� �alan bir h�rs�z bir CEO nun zihnine bir fikir yerle�tirme g�revini �stlenir.', 
 '2010-07-16', 
 'Aksiyon - Macera', 
 'Christopher Nolan'),

('https://upload.wikimedia.org/wikipedia/tr/f/fa/Pulp_Fiction_%28film%2C_1994%29.jpg', 
 'Ucuz Roman', 
 '�ki tetik�i bir boks�r bir gangster ve onun kar�s� ile bir �ift lokanta soyguncusunun hayatlar� �iddet ve kurtulu� i�eren d�rt hikayede kesi�ir', 
 '1994-10-14', 
 'Su� - Drama', 
 'Quentin Tarantino');


INSERT INTO Movies (PosterImage, Title, MovieDescription, ReleaseDate, Genre, Director)
VALUES 
('https://upload.wikimedia.org/wikipedia/tr/b/bb/Forrest_Gump_%28film%2C_1994%29.jpg', 
 'Forrest Gump', 
 'D���k IQ lu bir adam, tarihin bir�ok �nemli olay�na dahil olurken ger�ek a�k�n� bulmaya �al���r.', 
 '1994-07-06', 
 'Drama - Romantik', 
 'Robert Zemeckis'),

('https://upload.wikimedia.org/wikipedia/tr/a/ab/D%C3%B6v%C3%BC%C5%9F_Kul%C3%BCb%C3%BC_film_afi%C5%9Fi.jpg', 
 'D�v�� Kul�b�', 
 'Hayat�ndan s�k�lan bir beyaz yakal� ve karizmatik bir sabun sat�c�s� birlikte yeralt� d�v�� kul�b� kurar.', 
 '1999-10-15', 
 'Drama - Gerilim', 
 'David Fincher'),

('https://upload.wikimedia.org/wikipedia/tr/3/36/Matrix-film.jpg', 
 'Matrix', 
 'Bir bilgisayar korsan�, insanl���n sim�le edilmi� bir ger�eklikte hapsedildi�ini ��renir.', 
 '1999-03-31', 
 'Bilim Kurgu', 
 'Lana Wachowski, Lilly Wachowski'),

('https://upload.wikimedia.org/wikipedia/tr/b/bc/Interstellar_film_poster.jpg', 
 'Y�ld�zlararas�', 
 'Bir grup astronot, insanl�k i�in yeni bir ev aramak �zere solucan deli�inden ge�er.', 
 '2014-11-07', 
 'Bilim Kurgu', 
 'Christopher Nolan'),

('https://upload.wikimedia.org/wikipedia/tr/3/38/Schindler%27s_List_movie.jpg', 
 'Schindler in Listesi', 
 'Alman bir i� adam�, y�zlerce Yahudinin Nazi toplama kamplar�ndan kurtulmas�na yard�m eder.', 
 '1993-12-15', 
 'Biyografi - Drama', 
 'Steven Spielberg'),

('https://upload.wikimedia.org/wikipedia/tr/7/7b/Goodfellas.jpg', 
 'S�k� Dostlar', 
 'Brooklyn de b�y�yen bir gangster, hayat� boyunca su� d�nyas�nda y�kselmeye �al���r.', 
 '1990-09-19', 
 'Su� - Drama', 
 'Martin Scorsese'),

('https://upload.wikimedia.org/wikipedia/tr/a/af/386px-Seven_movie_poster.jpg', 
 'Yedi', 
 '�ki dedektif, �l�mc�l g�nahlarla ba�lant�l� bir seri katilin izini s�rer.', 
 '1995-09-22', 
 'Gerilim - Su�', 
 'David Fincher'),

('https://upload.wikimedia.org/wikipedia/tr/c/c3/Inglourious_Basterds_poster.jpg', 
 'Soysuzlar �etesi', 
 'II. D�nya Sava�� s�ras�nda, bir grup Yahudi asker, Nazileri yok etmek i�in bir plan yapar.', 
 '2009-08-21', 
 'Sava� - Drama', 
 'Quentin Tarantino'),

('https://upload.wikimedia.org/wikipedia/tr/0/09/Sosyal_A%C4%9F_%28afi%C5%9F%29.jpg', 
 'Sosyal A�', 
 'Facebook un kurulu� s�recinde ya�anan olaylar ve karma��k ili�kiler.', 
 '2010-10-01', 
 'Biyografi - Drama', 
 'David Fincher'),

('https://upload.wikimedia.org/wikipedia/tr/f/f9/TheAvengers2012Poster.jpg', 
 'Yenilmezler', 
 'D�nyay� tehdit eden bir g�ce kar�� bir araya gelen s�per kahramanlar�n hikayesi.', 
 '2012-05-04', 
 'Aksiyon - Macera', 
 'Joss Whedon');

CREATE TABLE Reviews (
    ReviewID INT PRIMARY KEY IDENTITY(1,1),
	Rating INT CHECK (Rating BETWEEN 1 AND 5),
	ReviewText NVARCHAR(MAX),
	CreatedAt DATETIME DEFAULT GETDATE(),
    UserID INT NOT NULL,
    MovieID INT NOT NULL,
);

select * from Reviews

SELECT r.ReviewText, r.Rating, r.CreatedAt, u.Username, u.ProfilePicture FROM Reviews r INNER JOIN Users u ON r.UserID = u.UserID WHERE r.MovieID = 3;
