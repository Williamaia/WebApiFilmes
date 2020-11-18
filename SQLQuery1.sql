CREATE DATABASE DB_ESTUDO_DOTNETCORE;

CREATE TABLE FILMES(
	ID INT NOT NULL PRIMARY KEY IDENTITY,
	RANK INT NOT NULL,
	TITULO VARCHAR(250) NOT NULL
);

CREATE TABLE DIRETORES(
	ID INT NOT NULL PRIMARY KEY IDENTITY,
	NOME VARCHAR(200) NOT NULL,
	QUANTIDADE_FILMES INT NOT NULL
);


INSERT INTO [dbo].[DIRETORES](NOME,QUANTIDADE_FILMES) VALUES ('Alfred Hitchcock',9);
INSERT INTO [dbo].[DIRETORES](NOME,QUANTIDADE_FILMES) VALUES ('Stanley Kubrick',8);
INSERT INTO [dbo].[DIRETORES](NOME,QUANTIDADE_FILMES) VALUES ('Christopher Nolan',6);
INSERT INTO [dbo].[DIRETORES](NOME,QUANTIDADE_FILMES) VALUES ('Martin Scorsese',6);
INSERT INTO [dbo].[DIRETORES](NOME,QUANTIDADE_FILMES) VALUES ('Billy Wilder',6);
INSERT INTO [dbo].[DIRETORES](NOME,QUANTIDADE_FILMES) VALUES ('Luiz',16);
INSERT INTO [dbo].[DIRETORES](NOME,QUANTIDADE_FILMES) VALUES ('FernandoZZ',21);
INSERT INTO [dbo].[DIRETORES](NOME,QUANTIDADE_FILMES) VALUES ('Elma',2);


INSERT INTO FILMES(titulo,rank) VALUES ('The Shawshank Redemption',1);
INSERT INTO FILMES(titulo,rank) VALUES ('The Godfather',2);
INSERT INTO FILMES(titulo,rank) VALUES ('The Godfather: Part II',3);
INSERT INTO FILMES(titulo,rank) VALUES ('Pulp Fiction',4);
INSERT INTO FILMES(titulo,rank) VALUES ('The Good, the Bad and the Ugly',5);
INSERT INTO FILMES(titulo,rank) VALUES ('The Dark Knight',6);
INSERT INTO FILMES(titulo,rank) VALUES ('12 Angry Men',7);
INSERT INTO FILMES(titulo,rank) VALUES ('Schindler''s List',8);
INSERT INTO FILMES(titulo,rank) VALUES ('The Lord of the Rings: The Return of the King',9);
INSERT INTO FILMES(titulo,rank) VALUES ('Fight Club',10);
INSERT INTO FILMES(titulo,rank) VALUES ('Star Wars: Episode V - The Empire Strikes Back',11);
INSERT INTO FILMES(titulo,rank) VALUES ('The Lord of the Rings: The Fellowship of the Ring',12);
INSERT INTO FILMES(titulo,rank) VALUES ('One Flew Over the Cuckoo''s Nest',13);
INSERT INTO FILMES(titulo,rank) VALUES ('Inception',14);
INSERT INTO FILMES(titulo,rank) VALUES ('Goodfellas',15);
INSERT INTO FILMES(titulo,rank) VALUES ('Star Wars',16);
INSERT INTO FILMES(titulo,rank) VALUES ('Seven Samurai',17);
INSERT INTO FILMES(titulo,rank) VALUES ('Forrest Gump',18);
INSERT INTO FILMES(titulo,rank) VALUES ('The Matrix',19);
INSERT INTO FILMES(titulo,rank) VALUES ('The Lord of the Rings: The Two Towers',20);
INSERT INTO FILMES(titulo,rank) VALUES ('City of God',21);
INSERT INTO FILMES(titulo,rank) VALUES ('Se7en',22);
INSERT INTO FILMES(titulo,rank) VALUES ('The Silence of the Lambs',23);
INSERT INTO FILMES(titulo,rank) VALUES ('Once Upon a Time in the West',24);
INSERT INTO FILMES(titulo,rank) VALUES ('Casablanca',25);
INSERT INTO FILMES(titulo,rank) VALUES ('The Usual Suspects',26);
INSERT INTO FILMES(titulo,rank) VALUES ('Raiders of the Lost Ark',27);
INSERT INTO FILMES(titulo,rank) VALUES ('Rear Window',28);
INSERT INTO FILMES(titulo,rank) VALUES ('It''s a Wonderful Life',29);
INSERT INTO FILMES(titulo,rank) VALUES ('Psycho',30);
INSERT INTO FILMES(titulo,rank) VALUES ('Léon: The Professional',31);
INSERT INTO FILMES(titulo,rank) VALUES ('Sunset Blvd.',32);
INSERT INTO FILMES(titulo,rank) VALUES ('American History X',33);
INSERT INTO FILMES(titulo,rank) VALUES ('Apocalypse Now',34);
INSERT INTO FILMES(titulo,rank) VALUES ('Terminator 2: Judgment Day',35);
INSERT INTO FILMES(titulo,rank) VALUES ('Saving Private Ryan',36);
INSERT INTO FILMES(titulo,rank) VALUES ('Memento',37);
INSERT INTO FILMES(titulo,rank) VALUES ('City Lights',38);
INSERT INTO FILMES(titulo,rank) VALUES ('Dr. Strangelove or: How I Learned to Stop Worrying and Love the Bomb',39);
INSERT INTO FILMES(titulo,rank) VALUES ('Alien',40);
INSERT INTO FILMES(titulo,rank) VALUES ('Modern Times',41);
INSERT INTO FILMES(titulo,rank) VALUES ('Spirited Away',42);
INSERT INTO FILMES(titulo,rank) VALUES ('North by Northwest',43);
INSERT INTO FILMES(titulo,rank) VALUES ('Back to the Future',44);
INSERT INTO FILMES(titulo,rank) VALUES ('Life Is Beautiful',45);
INSERT INTO FILMES(titulo,rank) VALUES ('The Shining',46);
INSERT INTO FILMES(titulo,rank) VALUES ('The Pianist',47);
INSERT INTO FILMES(titulo,rank) VALUES ('Citizen Kane',48);
INSERT INTO FILMES(titulo,rank) VALUES ('The Departed',49);
INSERT INTO FILMES(titulo,rank) VALUES ('M',50);
INSERT INTO FILMES(titulo,rank) VALUES ('Paths of Glory',51);
INSERT INTO FILMES(titulo,rank) VALUES ('Vertigo',52);
INSERT INTO FILMES(titulo,rank) VALUES ('Django Unchained',53);
INSERT INTO FILMES(titulo,rank) VALUES ('Double Indemnity',54);
INSERT INTO FILMES(titulo,rank) VALUES ('The Dark Knight Rises',55);
INSERT INTO FILMES(titulo,rank) VALUES ('Aliens',56);
INSERT INTO FILMES(titulo,rank) VALUES ('Taxi Driver',57);
INSERT INTO FILMES(titulo,rank) VALUES ('American Beauty',58);
INSERT INTO FILMES(titulo,rank) VALUES ('The Green Mile',59);
INSERT INTO FILMES(titulo,rank) VALUES ('Gladiator',60);
INSERT INTO FILMES(titulo,rank) VALUES ('The Intouchables',61);
INSERT INTO FILMES(titulo,rank) VALUES ('WALL·E',62);
INSERT INTO FILMES(titulo,rank) VALUES ('The Lives of Others',63);
INSERT INTO FILMES(titulo,rank) VALUES ('Toy Story 3',64);
INSERT INTO FILMES(titulo,rank) VALUES ('The Great Dictator',65);
INSERT INTO FILMES(titulo,rank) VALUES ('The Prestige',66);
INSERT INTO FILMES(titulo,rank) VALUES ('A Clockwork Orange',67);
INSERT INTO FILMES(titulo,rank) VALUES ('Lawrence of Arabia',68);
INSERT INTO FILMES(titulo,rank) VALUES ('Amélie',69);
INSERT INTO FILMES(titulo,rank) VALUES ('To Kill a Mockingbird',70);
INSERT INTO FILMES(titulo,rank) VALUES ('Reservoir Dogs',71);
INSERT INTO FILMES(titulo,rank) VALUES ('Das Boot',72);
INSERT INTO FILMES(titulo,rank) VALUES ('The Lion King',73);
INSERT INTO FILMES(titulo,rank) VALUES ('Cinema Paradiso',74);
INSERT INTO FILMES(titulo,rank) VALUES ('Star Wars: Episode VI - Return of the Jedi',75);
INSERT INTO FILMES(titulo,rank) VALUES ('The Treasure of the Sierra Madre',76);
INSERT INTO FILMES(titulo,rank) VALUES ('The Third Man',77);
INSERT INTO FILMES(titulo,rank) VALUES ('Once Upon a Time in America',78);
INSERT INTO FILMES(titulo,rank) VALUES ('Requiem for a Dream',79);
INSERT INTO FILMES(titulo,rank) VALUES ('Eternal Sunshine of the Spotless Mind',80);
INSERT INTO FILMES(titulo,rank) VALUES ('Full Metal Jacket',81);
INSERT INTO FILMES(titulo,rank) VALUES ('Oldboy',82);
INSERT INTO FILMES(titulo,rank) VALUES ('Braveheart',83);
INSERT INTO FILMES(titulo,rank) VALUES ('L.A. Confidential',84);
INSERT INTO FILMES(titulo,rank) VALUES ('Bicycle Thieves',85);
INSERT INTO FILMES(titulo,rank) VALUES ('Chinatown',86);
INSERT INTO FILMES(titulo,rank) VALUES ('Singin'' in the Rain',87);
INSERT INTO FILMES(titulo,rank) VALUES ('Princess Mononoke',88);
INSERT INTO FILMES(titulo,rank) VALUES ('Monty Python and the Holy Grail',89);
INSERT INTO FILMES(titulo,rank) VALUES ('Metropolis',90);
INSERT INTO FILMES(titulo,rank) VALUES ('Rashomon',91);
INSERT INTO FILMES(titulo,rank) VALUES ('Some Like It Hot',92);
INSERT INTO FILMES(titulo,rank) VALUES ('Amadeus',93);
INSERT INTO FILMES(titulo,rank) VALUES ('2001: A Space Odyssey',94);
INSERT INTO FILMES(titulo,rank) VALUES ('All About Eve',95);
INSERT INTO FILMES(titulo,rank) VALUES ('Witness for the Prosecution',96);
INSERT INTO FILMES(titulo,rank) VALUES ('The Sting',97);
INSERT INTO FILMES(titulo,rank) VALUES ('The Apartment',98);
INSERT INTO FILMES(titulo,rank) VALUES ('Grave of the Fireflies',99);
INSERT INTO FILMES(titulo,rank) VALUES ('Indiana Jones and the Last Crusade',100);