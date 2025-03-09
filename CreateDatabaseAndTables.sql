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
 'Ýki mahkûm yýllar boyunca dostluk kurar, ortak bir dayanýþma ve insanlýk eylemleri aracýlýðýyla teselli ve sonunda kurtuluþ bulurlar.', 
 '1994-09-23', 
 'Drama', 
 'Frank Darabont'),

('https://upload.wikimedia.org/wikipedia/tr/7/7c/1972_yap%C4%B1m%C4%B1_Baba_film_afi%C5%9Fi.jpg', 
 'Baba', 
 'Yaþlanan bir suç örgütü lideri, gizli imparatorluðunun kontrolünü gönülsüz oðluna devreder.', 
 '1972-03-24', 
 'Suç - Drama', 
 'Francis Ford Coppola'),

('https://upload.wikimedia.org/wikipedia/tr/4/4d/Kara_%C5%9E%C3%B6valye_TR_film_afi%C5%9Fi.jpg', 
 'Kara Þövalye', 
 'Joker olarak bilinen tehdit geçmiþinden çýkýp Gotham halkýna kaos ve yýkým getirirken, Batman onunla yüzleþmek zorundadýr.', 
 '2008-07-18', 
 'Aksiyon - Suç', 
 'Christopher Nolan'),

('https://upload.wikimedia.org/wikipedia/tr/9/94/Ba%C5%9Flang%C4%B1%C3%A7.jpg', 
 'Baþlangýç', 
 'Rüya paylaþým teknolojisini kullanarak kurumsal sýrlarý çalan bir hýrsýz bir CEO nun zihnine bir fikir yerleþtirme görevini üstlenir.', 
 '2010-07-16', 
 'Aksiyon - Macera', 
 'Christopher Nolan'),

('https://upload.wikimedia.org/wikipedia/tr/f/fa/Pulp_Fiction_%28film%2C_1994%29.jpg', 
 'Ucuz Roman', 
 'Ýki tetikçi bir boksör bir gangster ve onun karýsý ile bir çift lokanta soyguncusunun hayatlarý þiddet ve kurtuluþ içeren dört hikayede kesiþir', 
 '1994-10-14', 
 'Suç - Drama', 
 'Quentin Tarantino');


INSERT INTO Movies (PosterImage, Title, MovieDescription, ReleaseDate, Genre, Director)
VALUES 
('https://upload.wikimedia.org/wikipedia/tr/b/bb/Forrest_Gump_%28film%2C_1994%29.jpg', 
 'Forrest Gump', 
 'Düþük IQ lu bir adam, tarihin birçok önemli olayýna dahil olurken gerçek aþkýný bulmaya çalýþýr.', 
 '1994-07-06', 
 'Drama - Romantik', 
 'Robert Zemeckis'),

('https://upload.wikimedia.org/wikipedia/tr/a/ab/D%C3%B6v%C3%BC%C5%9F_Kul%C3%BCb%C3%BC_film_afi%C5%9Fi.jpg', 
 'Dövüþ Kulübü', 
 'Hayatýndan sýkýlan bir beyaz yakalý ve karizmatik bir sabun satýcýsý birlikte yeraltý dövüþ kulübü kurar.', 
 '1999-10-15', 
 'Drama - Gerilim', 
 'David Fincher'),

('https://upload.wikimedia.org/wikipedia/tr/3/36/Matrix-film.jpg', 
 'Matrix', 
 'Bir bilgisayar korsaný, insanlýðýn simüle edilmiþ bir gerçeklikte hapsedildiðini öðrenir.', 
 '1999-03-31', 
 'Bilim Kurgu', 
 'Lana Wachowski, Lilly Wachowski'),

('https://upload.wikimedia.org/wikipedia/tr/b/bc/Interstellar_film_poster.jpg', 
 'Yýldýzlararasý', 
 'Bir grup astronot, insanlýk için yeni bir ev aramak üzere solucan deliðinden geçer.', 
 '2014-11-07', 
 'Bilim Kurgu', 
 'Christopher Nolan'),

('https://upload.wikimedia.org/wikipedia/tr/3/38/Schindler%27s_List_movie.jpg', 
 'Schindler in Listesi', 
 'Alman bir iþ adamý, yüzlerce Yahudinin Nazi toplama kamplarýndan kurtulmasýna yardým eder.', 
 '1993-12-15', 
 'Biyografi - Drama', 
 'Steven Spielberg'),

('https://upload.wikimedia.org/wikipedia/tr/7/7b/Goodfellas.jpg', 
 'Sýký Dostlar', 
 'Brooklyn de büyüyen bir gangster, hayatý boyunca suç dünyasýnda yükselmeye çalýþýr.', 
 '1990-09-19', 
 'Suç - Drama', 
 'Martin Scorsese'),

('https://upload.wikimedia.org/wikipedia/tr/a/af/386px-Seven_movie_poster.jpg', 
 'Yedi', 
 'Ýki dedektif, ölümcül günahlarla baðlantýlý bir seri katilin izini sürer.', 
 '1995-09-22', 
 'Gerilim - Suç', 
 'David Fincher'),

('https://upload.wikimedia.org/wikipedia/tr/c/c3/Inglourious_Basterds_poster.jpg', 
 'Soysuzlar Çetesi', 
 'II. Dünya Savaþý sýrasýnda, bir grup Yahudi asker, Nazileri yok etmek için bir plan yapar.', 
 '2009-08-21', 
 'Savaþ - Drama', 
 'Quentin Tarantino'),

('https://upload.wikimedia.org/wikipedia/tr/0/09/Sosyal_A%C4%9F_%28afi%C5%9F%29.jpg', 
 'Sosyal Að', 
 'Facebook un kuruluþ sürecinde yaþanan olaylar ve karmaþýk iliþkiler.', 
 '2010-10-01', 
 'Biyografi - Drama', 
 'David Fincher'),

('https://upload.wikimedia.org/wikipedia/tr/f/f9/TheAvengers2012Poster.jpg', 
 'Yenilmezler', 
 'Dünyayý tehdit eden bir güce karþý bir araya gelen süper kahramanlarýn hikayesi.', 
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
