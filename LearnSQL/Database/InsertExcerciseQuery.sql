INSERT INTO Excercises
VALUES
(
	1,
	N'Създайте таблица Континенти (Continents): код (ID)– точно 2 символа, име на континента(Name) – уникално, до 50 символа ',
	N'CREATE TABLE Continents(ID CHAR(2) PRIMARY KEY, Name NVARCHAR(50) UNIQUE  NOT NULL)'
),
(
	2,
	N'Създайте таблица Държави (Countries): код(ID) – точно 2 символа, име на държавата (Name) до 50 символа, уникално, име на столицата ѝ (Capital) ',
	N'CREATE TABLE Countries(ID CHAR(2) PRIMARY KEY, Name NVARCHAR(50) UNIQUE  NOT NULL, Capital NVARCHAR(50) NOT NULL)'
),
(
	3,
	N'Създайте таблица Планини (Mountains): номер (ID) – цяло число, име на планината (Name) – до 60 символа ',
	N'CREATE TABLE Mountains(ID INT PRIMARY KEY, Name NVARCHAR(60) NOT NULL)'
),
(
	4,
	N'Създайте таблица Върхове (Peaks): номер (ID) – цяло число, име на върха(Name)– до 50 символа, височона на върха (Height) –цяло число ',
	N'CREATE TABLE Peaks(ID INT PRIMARY KEY, Name NVARCHAR(50) UNIQUE NOT NULL, Height INT NOT NULL ) '
),
(
	5,
	N'Добавете чужд ключ на таблицата Държави, който реферира таблицата Континенти',
	N'ALTER TABLE Countries ADD ContinentID CHAR(2) NOT NULL FOREIGN KEY REFERENCES  Continents (ID) '
),
(
	6,
	N'Добавете чужд ключ на таблицата Върхове, който реферира таблицата Планини',
	N'ALTER TABLE Peaks ADD MountainID INT NOT NULL FOREIGN KEY REFERENCES Mountains(ID) '
),
(
	7,
	N'Създайте таблица CountriesMountains, която осъществява връзката много към много между таблиците Държави и Планини',
	N'CREATE TABLE CountriesMountains(CountryID CHAR(2) NOT NULL FOREIGN KEY REFERENCES Countries (ID), MountainID INT NOT NULL FOREIGN KEY REFERENCES Mountains (ID))'
),
(
	8,
	N'Напълнете таблицата континенти със следните имена на континенти: Africa, Antarctica, Asia, Europe, North America, Oceania, South America',
	N'INSERT continentes VALUES (^AF^, ^Africa^), (^AN^, ^Antarctica^), (^AS^, ^Asia^), (^EU^, ^Europe^), (^NA^, ^North America^), (^OC^, ^Oceania^), (^SA^, ^South America^);'
),
(
	9,
	N'Изведете пълна информация за всички върхове (ID, Name, Height)',
	N'SELECT * FROM Peaks '
),
(
	10,
	N'Изведете имената и столиците на всички държави',
	N'SELECT Name, Capital FROM Countries '
),
(
	11,
	N'Изведете кода и имената на всички държави с подходящи имена на кирилица',
	N'SELECT ID AS ^Код на държавата^, Name AS ^Име на държавата^ FROM Countries '
),
(
	12,
	N'Името на най-високия връх ',
	N'SELECT TOP 1 * FROM Peaks ORDER BY Height DESC '
),
(
	13,
	N'Броя на върховете по-високи от 8000 метра',
	N'SELECT COUNT(Height) FROM Peaks WHERE Height > 8000 '
),
(
	14,
	N'Името и височината на всички върхове, между 5000 и 8000 метра, сортирани възходящо по височина',
	N'SELECT Name, Height FROM Peaks WHERE Height BETWEEN 5000 AND 8000 ORDER BY Height ASC'
),
(
	15,
	N'Коя планина в кой континент се намира.',
	N'SELECT Mountains.Name, Continents.Name FROM Mountains INNER JOIN CountriesMountains ON  CountriesMountains.MountainID = Mountains.ID INNER JOIN Countries ON Countries.ID = CountriesMountains.CountryId INNER JOIN Continents ON Countries.ContinentID = Continents.ID'
),
(
	16,
	N'Кой връх в коя планина се намира и в коя държава.',
	N'SELECT Peaks.Name, Countries.Name FROM Peaks INNER JOIN Mountains ON  Peaks.MountainID = Mountains.ID INNER JOIN CountriesMountains ON  CountriesMountains.MountainID = Mountains.ID INNER JOIN Countries ON Countries.ID = CountriesMountains.CountryId '
),
(
	17,
	N'Всички върхове в България',
	N'SELECT Peaks.Name, Countries.Name FROM Peaks INNER JOIN Mountains ON  Peaks.MountainID = Mountains.ID INNER JOIN CountriesMountains ON  CountriesMountains.MountainID = Mountains.ID INNER JOIN Countries ON Countries.ID = CountriesMountains.CountryId WHERE Countries.Name = ^Bulgaria^'
)