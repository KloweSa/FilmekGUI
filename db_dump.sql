CREATE DATABASE cinema;
USE cinema;

CREATE TABLE movies (
  movieId INT PRIMARY KEY IDENTITY,
  title VARCHAR(128) NOT NULL,
  director VARCHAR(128) NOT NULL,
  publicationYear INT NOT NULL,
  genreId INT NOT NULL,
  rating FLOAT NOT NULL,
  img VARCHAR(128) NOT NULL);

CREATE TABLE genres (
  genreId INT PRIMARY KEY,
  genre VARCHAR(128) NOT NULL);

CREATE TABLE users (
  userId INT PRIMARY KEY IDENTITY,
  userName VARCHAR(128) NOT NULL,
  userPassword VARCHAR(128) NOT NULL);

INSERT INTO movies VALUES
('A keresztapa', 'Francis Ford Coppola', 1972, 2, 4.6, 'gf'),
('A sötét lovag', 'Christopher Nolan', 2008, 1, 4.5, 'darkk'),
('A bárányok hallgatnak', 'Jonathan Demme', 1991, 9, 4.3, 'silentlambs'),
('A Mester és Margarita', 'Ibolya Fekete', 2005, 4, 3.4, 'mestermargarita'),
('Black Adam', 'Jaume Collet-Serra', 2022, 8, 3.3, 'blackadam'),
('Mátrix', 'Lana Wachowski, Lilly Wachowski', 1999, 1, 4.4, 'matrix'),
('Terminátor 2. - Az ítélet napja', 'James Cameron', 1991, 1, 4.3, 'terminator2'),
('Truman Show', 'Peter Weir', 1998, 5, 4.1, 'truman'),
('Jurassic Park', 'Steven Spielberg', 1993, 8, 4.1, 'jpark'),
('A Jó, a Rossz és a Csúf', 'Sergio Leone', 1966, 10, 4.4, 'jorosszcsuf'),
('A nyolcadik utas: a Halál', 'Ridley Scott', 1979, 6, 4.3, 'alien'),
('Katasztrófafilm', 'Jason Friedberg, Aaron Seltzer', 2008, 5, 1.9, 'katasztrofa');

INSERT INTO genres VALUES
(1, 'Akciófilm'),
(2, 'Bűnügyi film'),
(3, 'Dokumentumfilm'),
(4, 'Filmdráma'),
(5, 'Filmvígjáték'),
(6, 'Horrorfilm'),
(7, 'Játékfilm'),
(8, 'Kalandfilm'),
(9, 'Thriller'),
(10, 'Westernfilm');

INSERT INTO users VALUES
('admin', 'admin');