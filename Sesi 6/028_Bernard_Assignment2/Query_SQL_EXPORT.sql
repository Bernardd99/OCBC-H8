--membuat database
CREATE DATABASE db_bank;

--Soal No. 1. Customers => stores data customer
CREATE TABLE tb_customers(
	customerNumber int PRIMARY KEY IDENTITY(1,1),
	customerName varchar(25) NOT NULL,
	contactLastName varchar(15) NOT NULL,
	contactFirstName varchar(15) NOT NULL,
	phone varchar (15) NOT NULL,
	addressLine1 varchar(50) NOT NULL,
	addressLine2 varchar(50) NOT NULL,
	city varchar(15) NOT NULL,
	state varchar(15) NOT NULL,
	postalCode varchar(15) NOT NULL,
	country varchar(15) NOT NULL,
	salesRepEmployeeNumber varchar(15) NOT NULL,
	creditLimit int NOT NULL,
)

INSERT INTO  tb_customers(customerName, contactLastName, contactFirstName, phone, addressLine1, addressLine2, city, state, postalCode, country, salesRepEmployeeNumber, creditLimit)
VALUES
('Bernard', 'Nard', 'Ber', '081234567890', 'Jl. Sumatera', 'Jl. Jelutung', 'Kota Jambi', 'Jelutung', '12345', 'Indonesia', 'B123456789', 999999999),
('Andi Tama', 'Tama', 'Andi', '081234567891', 'Jl. Thehok', 'Jl. Jalan', 'Kota Jambi', 'Tambak Sari', '12344', 'Indonesia', 'A123456787', 888888888),
('Kenwus Go', 'Go', 'Kenwus', '081234567892', 'Jl. Telanai', 'Jl. Antasari', 'Kota Jambi', 'Telanai', '12343', 'Sydney', 'K123456785', 777777777),
('Bambang Suparman', 'Suparman', 'Bambang', '081234567893', 'Jl. Diponegoro', 'Jl. Jalan', 'Kota Jambi', 'Kebun Handil', '12342', 'Indonesia', 'B123456783', 777777777),
('Satrial Yakub', 'Yakub', 'Satrial', '081234567894', 'Jl. Thehok', 'Jl. Sudirman', 'Kota Jambi', 'Sipin', '12341', 'Indonesia', 'S123456781', 666666666);

--Soal No. 02. Products => stores daftar/list model product
CREATE TABLE tb_products(
	productCode int PRIMARY KEY IDENTITY(1,1),
	productName varchar(50) NOT NULL,
	productLine int NOT NULL,
	productScale int NOT NULL,
	productVendor varchar (15) NOT NULL,
	productDescription varchar(50) NOT NULL,
	quantityInStock int NOT NULL,
	buyPrice int NOT NULL,
	MSRP int NOT NULL,
)

INSERT INTO tb_products(productName, productLine, productScale, productVendor, productDescription, quantityInStock, buyPrice, MSRP)
VALUES
('Guitar', 9, 9, 'Yamaha', 'Ini adalah gitar', 999, 1500000, 1250000),
('Drum', 9, 9, 'Yamaha', 'Ini adalah drum', 888, 850000, 750000),
('Headphone', 9, 9, 'Razer', 'Ini adalah headphone', 777, 1500000, 1350000),
('Mouse', 9, 9, 'Logitech', 'Ini adalah mouse', 666, 600000, 450000),
('Handphone', 9, 9, 'Samsung', 'Ini adalah handphone', 555, 9000000, 7500000),
('Monitor', 9, 9, 'LG', 'Ini adalah drum', 444, 2400000, 2050000),
('Kulkas', 9, 9, 'Sharp', 'Ini adalah headphone', 333, 12000000, 11500000),
('Webcam', 9, 9, 'NYK', 'Ini adalah mouse', 222, 220000, 185000),
('Tissue', 9, 9, 'Paseo', 'Ini adalah handphone', 111, 35000, 25000);


--Soal No. 03. ProductLines => stores daftar/list kategori product
CREATE TABLE tb_productlines(
	productLine int PRIMARY KEY IDENTITY(1,1),
	textDescription varchar(50) NOT NULL,
	htmlDescription varchar(50) NOT NULL,
	Image varchar(50) NOT NULL,
)


INSERT INTO  tb_productlines(textDescription, htmlDescription, Image)
VALUES
('Ini adalah gitar', 'gitar.html', 'gitar.jpg'),
('Ini adalah drum', 'drum.html', 'drum.jpg'),
('Ini adalah headphone', 'headphone.html', 'headphone.jpg'),
('Ini adalah mouse', 'mouse.html', 'mouse.jpg'),
('Ini adalah handphone', 'handphone.html', 'handphone.jpg'),
('Ini adalah monitor', 'monitor.html', 'monitor.jpg'),
('Ini adalah kulkas', 'kulkas.html', 'kulkas.jpg'),
('Ini adalah webcam', 'webcam.html', 'webcam.jpg'),
('Ini adalah tissue', 'tissue.html', 'tissue.jpg');

--Soal No. 04. Orders => store Order Sales oleh customer
CREATE TABLE tb_orders(
	orderNumber int PRIMARY KEY IDENTITY(1,1),
	orderDate date NOT NULL,
	requiredDate date NOT NULL,
	shippedDate date NOT NULL,
	status varchar (15) NOT NULL,
	comments varchar(50) NOT NULL,
	customerNumber int NOT NULL,
)

INSERT INTO tb_orders(orderDate, requiredDate, shippedDate, status, comments, customerNumber)
VALUES
('2021-09-09', '2021-09-10', '2021-09-09', 'Shipped', 'Order is shipped', 999),
('2021-09-08', '2021-09-11', '2021-09-10', 'Not Shipped', 'Order is Not shipped', 998),
('2021-09-07', '2021-09-12', '2021-09-11', 'Not Shipped', 'Order is Not shipped', 997),
('2021-09-06', '2021-09-13', '2021-09-12', 'Shipped', 'Order is shipped', 996),
('2021-09-05', '2021-09-14', '2021-09-13', 'Shipped', 'Order is shipped', 995),
('2021-09-04', '2021-09-13', '2021-09-12', 'Not Shipped', 'Order is Not shipped', 994),
('2021-09-03', '2021-09-12', '2021-09-11', 'Not Shipped', 'Order is Not shipped', 993),
('2021-09-02', '2021-09-11', '2021-09-10', 'Shipped', 'Order is shipped', 992),
('2021-09-01', '2021-09-10', '2021-09-09', 'Not Shipped', 'Order is Not shipped', 991);

--Soal No. 05. OrderDetails => store item Order sales dalam setiap order sales
CREATE TABLE tb_orderdetails(
	orderNumber int IDENTITY(1,1),
	productCode int,
	quantityOrdered int NOT NULL,
	priceEach int NOT NULL,
	orderLineNumber int NOT NULL,
	PRIMARY KEY(orderNumber, productCode)
)

INSERT INTO tb_orderdetails(productCode, quantityOrdered, priceEach, orderLineNumber)
VALUES
(98765, 9, 90000, 99),
(87654, 8, 80000, 89),
(76543, 7, 70000, 79),
(65432, 6, 60000, 69),
(54321, 5, 50000, 59),
(43219, 4, 40000, 49),
(32198, 3, 30000, 39),
(21987, 2, 20000, 29),
(19876, 1, 10000, 19);

--Soal No. 06. Payments => store Pembayaran oleh customer sesuai dengan akun pembayaran
CREATE TABLE tb_payments(
	customerNumber int IDENTITY(1,1),
	checkNumber int NOT NULL,
	paymentDate date NOT NULL,
	amount int NOT NULL,
	PRIMARY KEY(customerNumber, checkNumber)
)

INSERT INTO tb_payments(checkNumber, paymentDate, amount)
VALUES
(999, '2021-9-9', 99),
(998, '2021-9-8', 89),
(997, '2021-9-7', 79),
(996, '2021-9-6', 69),
(995, '2021-9-5', 59),
(994, '2021-9-4', 49),
(993, '2021-9-3', 39),
(992, '2021-9-2', 29),
(991, '2021-9-1', 19);

--Soal No. 07. Employee => store informasi karyawan dalam sebuah organisasi struktur
CREATE TABLE tb_employee(
	employeeNumber int PRIMARY KEY IDENTITY(1,1),
	lastName varchar(15) NOT NULL,
	firstName varchar(15) NOT NULL,
	extension varchar(25) NOT NULL,
	email varchar(25) NOT NULL,
	officeCode varchar(15) NOT NULL,
	reportsTo varchar(25) NOT NULL,
	jobTitle varchar(25) NOT NULL,
)

INSERT INTO tb_employee(lastName, firstName, extension, email, officeCode, reportsTo, jobTitle)
VALUES
('Nard', 'Ber', 'Yes', 'bernard@gmail.com', 'B01234', 'Bernard', 'CEO'),
('Tama', 'Andi', 'Yes', 'Andi@gmail.com', 'A01233', 'Andi', 'Sales'),
('Go', 'Kenwus', 'No', 'Kenwus@gmail.com', 'K01232', 'Kenwus', 'Developer'),
('Suparman', 'Bambang', 'No', 'Bambang@gmail.com', 'B01231', 'Bambang', 'HRD'),
('Yakub', 'Satrial', 'Yes', 'Satrial@gmail.com', 'S01230', 'Satrial', 'Staff');

--Soal No. 08. Offices => store data sales office
CREATE TABLE tb_offices(
	officeCode int PRIMARY KEY IDENTITY(1,1),
	city varchar(15) NOT NULL,
	phone varchar (15) NOT NULL,
	addressLine1 varchar(50) NOT NULL,
	addressLine2 varchar(50) NOT NULL,
	state varchar(15) NOT NULL,
	country varchar(15) NOT NULL,
	postalCode varchar(15) NOT NULL,
	territory varchar(15) NOT NULL,
)

INSERT INTO tb_offices
VALUES
('Kota Jambi', '081234567890', 'Jl. Sumatera', 'Jl. Jelutung', 'Jelutung', 'Indonesia', '12345', 'Jelutung'),
('Kota Jambi', '081234567891', 'Jl. Thehok', 'Jl. Jalan', 'Tambak Sari', 'Indonesia', '12344', 'Tambak Sari'),
('Kota Jambi', '081234567892', 'Jl. Telanai', 'Jl. Antasari', 'Telanai', 'Sydney', '12343', 'Telanai'),
('Kota Jambi', '081234567893', 'Jl. Diponegoro', 'Jl. Diponegoro', 'Kebun Handil', 'Indonesia', '12342', 'Kebun Handil'),
('Kota Jambi', '081234567894', 'Jl. Thehok', 'Jl. Sudirman', 'Sipin', 'Indonesia', '12341', 'Sipin');