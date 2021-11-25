use BD_Hotel

INSERT INTO Produtos VALUES
('Coca-Cola 350ml',1.79,2.79,'1','1'),
('Kero Coco 1L', 8.00,10.00,'1','1'),
('Toddynho 200ml', 1.50, 2.50,'4','1'),
('Coca-Cola Zero 350ml',2.10,3.10,'1','1'),
('Cerveja HEINEKEN LongNeck 330ml',4.10,5.20,'2','1'),
('Suco de Laranja 200ml',1.50,2.50,'1','1'),
('Suco de Uva 200ml',1.50,2.50,'1','1'),
('Suco de Maracuja 200ml',1.50,2.50,'1','1')
GO
INSERT INTO Quartos VALUES
(89,'Solteiro'),
(15,'Duplo Solterio'),
(37,'Casal'),
(29,'Dormitorios'),
(13,'Solteiro')
GO
INSERT INTO Hospedes VALUES
('Sergio Gomes','sergiogomes@outlook.com','14536724698','1995-03-16','119998734','123145161',1),
('Ingrid Lopes','grilopes@gmail.com','23514165345','2001-09-26','98922335813',null,1),
('Mauricio da Silva','mrcsilva@gmail.com','78620314978','1999-11-19','11923473742',null,1),
('Claudia Mendes','claudia03@hotmail.com','98278912732','1970-12-02','25974373701',null,1),
('Cleber Pratos', 'cleberesco@outlook.com','11990099865','1999-02-04','13984988596','13983239683',0)
GO
INSERT INTO Reservas VALUES
('2021-04-30','2021-05-02',1,4,1),
('2021-05-04','2021-05-10',3,1,1),
('2021-05-05','2021-05-07',4,2,1),
('2021-05-05','2021-05-13',2,4,1)
GO
INSERT INTO Funcionarios VALUES
('Janaina Ferraz','45612364542','868234972','janaferraz@outlook.com','balconista','11999774521',null,2000.00,'2020-12-10',1),
('Miguel Soares','57623463443','637286872','miguelsoares020@gmail.com','recepcionista','11923738734','11973268752',2000.00,'2020-10-21',1),
('Ana Beatriz','39117599679','403615483','anabeatrizzz@outlook.com','auxiliar de limpeza','67994505383', null, 2000.000,'2021-01-10',1)
GO
INSERT INTO Usuarios VALUES
('JanainaFerraz','S3NH@','Funcionario',null,1,1),
('MrcSilva','V@P0','Hospede',3,null,1)
GO
INSERT INTO Fornecedores VALUES
(3,'Quaker Oats','11912353987', null,1),
(null,'HomeHotel','19934657823','11932653267',1)
GO
INSERT INTO Consumo VALUES
(2,5.0,'2021-05-01',1,3)
GO

SELECT *FROM Consumo
SELECT *FROM Fornecedores
SELECT *FROM Funcionarios
SELECT *FROM Hospedes 
SELECT *FROM Produtos
SELECT *FROM Quartos 
SELECT *FROM Reservas
SELECT *FROM Usuarios
