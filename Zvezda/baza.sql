CREATE TABLE constellations (
    ID INT PRIMARY KEY,
    Name VARCHAR(255),
    Description TEXT
);

CREATE TABLE stars (
    ID_Zvezda INT PRIMARY KEY,
    Name_zvezda VARCHAR(255),
    Ox DECIMAL(10, 2),
    Oy DECIMAL(10, 2),
    Description TEXT,
    ID_Sozvezdie INT,
    Razmer VARCHAR(50),
    FOREIGN KEY (ID_Sozvezdie) REFERENCES созвездия(ID)
);

INSERT INTO constellations (ID, Name, Description) VALUES
(1, 'Орион', 'Созвездие Орион'),
(2, 'Большая Медведица', 'Созвездие Большая Медведица'),
(3, 'Лира', 'Созвездие Лира'),
(4, 'Кассиопея', 'Созвездие Кассиопея'),
(5, 'Скорпион', 'Созвездие Скорпион');

INSERT INTO stars (ID,    Name_zvezda, Ox, Oy, Description, ID_Sozvezdie, Razmer) VALUES
(1, 'Сириус', 12.34, 56.78, 'Яркая звезда', 1, 'Большая'),
(2, 'Альдебаран', 23.45, 67.89, 'Красная звезда', 1, 'Средняя'),
(3, 'Вега', 34.56, 78.90, 'Сверкающая звезда', 3, 'Большая'),
(4, 'Антарес', 45.67, 89.01, 'Красная сверкающая звезда', 5, 'Большая'),
(5, 'Полярная', 56.78, 90.12, 'Сияющая звезда', 2, 'Средняя');