-- Tạo Database
CREATE DATABASE QLBH;
GO

USE QLBH;
GO

-- Bảng Customers
CREATE TABLE customers (
    customer_id VARCHAR(50)  PRIMARY KEY,
    first_name VARCHAR(255),
	last_name VARCHAR(255),
	customer_username VARCHAR(50),
	customer_password VARCHAR(255),
    phone VARCHAR(20),
    email VARCHAR(100),
    avatar_path VARCHAR(255)
)

GO

-- Bảng Users
CREATE TABLE users (
    username VARCHAR(50) PRIMARY KEY,
    password VARCHAR(255),
    role VARCHAR(50) DEFAULT 'staff',
    avatar_path VARCHAR(255),
    created_at SMALLDATETIME DEFAULT GETDATE()
)
GO
drop table orders 

-- Bảng Products
CREATE TABLE products (
    product_id VARCHAR(50)  PRIMARY KEY,
    p_name VARCHAR(255) ,
	brand VARCHAR(255) ,
	color VARCHAR(255) ,
    type VARCHAR(255),
    price DECIMAL(20,2) ,
    stock_quantity INT DEFAULT 0,
    image_path VARCHAR(255),
    created_at SMALLDATETIME DEFAULT GETDATE(),
    updated_at SMALLDATETIME DEFAULT GETDATE()
)


GO


CREATE TABLE orders (
    OrderID VARCHAR(50) PRIMARY KEY,
    Username VARCHAR(50) ,
    OrderDate DATETIME ,
    ProductID VARCHAR(50) ,
    PName VARCHAR(100) ,
    Brand VARCHAR(50) ,
    Color VARCHAR(50) ,
    Quantity INT ,
    UnitPrice DECIMAL(18, 2),
    ImagePath VARCHAR(255),
    PStatus VARCHAR(50)
);



INSERT INTO customers (customer_id, first_name, last_name, customer_username, customer_password, phone, email, avatar_path)
VALUES 
(1, 'John', 'Doe','jd', 'password123', '1234567890', 'john.doe@example.com', '/images/avatars/john_doe.jpg')


INSERT INTO users (username, password, role, avatar_path, created_at)
VALUES 
('admin', '123', 'staff', 'C:\Users\VINH QUI\OneDrive\Pictures\logo-truong-dai-hoc-ton-duc-thang.png', GETDATE())

INSERT INTO products (product_id, p_name, brand, color, type, price, stock_quantity, image_path)
VALUES 
    ('P001', 'Áo Bóng Đá', 'Nike', 'Red', 'Football', 29.99, 50, 'C:\Users\VINH QUI\OneDrive\Pictures\Anime wallpaper.jpg')