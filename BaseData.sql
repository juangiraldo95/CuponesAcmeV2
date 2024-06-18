-- Active: 1718653685050@@bcn41dsu49ho4y93mkrx-mysql.services.clever-cloud.com@3306
CREATE DATABASE 
    DEFAULT CHARACTER SET = 'utf8mb4';

DROP TABLE Coupon;
DROP TABLE CouponUsage;
DROP TABLE CouponHistory;
DROP TABLE PurchaseCoupon;
DROP TABLE Purchase;
DROP TABLE MarketplaceUser;
DROP TABLE MarketingUser;
DROP TABLE Role;


CouponUsage
CouponHistory
PurchaseCoupon
Purchase
MarketplaceUser
MarketingUser
Role

CREATE TABLE Coupones (
  Id INT PRIMARY KEY,
  Name VARCHAR(255),
  Description VARCHAR(255),
  StartDate DATE,
  EndDate DATE,
  DiscountType ENUM("percentage","net"),
  DiscountValue DECIMAL,
  UsageLimit INT,
  MinPurchaseAmount DECIMAL,
  MaxPurchaseAmount DECIMAL,
  Status ENUM("Active","Inactive"),
  CreatedBy INT,
  FOREIGN KEY (CreatedBy) REFERENCES MarketingUsers(Id)
);

CREATE TABLE CouponesUsages (
  Id INT PRIMARY KEY,
  CouponId INT,
  UserId INT,
  UsageDate DATE,
  TransactionAmount DECIMAL,
  FOREIGN KEY (CouponId) REFERENCES Coupones(Id),
  FOREIGN KEY (UserId) REFERENCES MarketplaceUsers(Id)
);

CREATE TABLE CouponesHistories (
  Id INT PRIMARY KEY,
  CouponId INT,
  ChangeDate DATE,
  FieldChanged VARCHAR(255),
  OldValue VARCHAR(255),
  NewValue VARCHAR(255),
  FOREIGN KEY (CouponId) REFERENCES Coupones(Id)
);

CREATE TABLE PurchasesCoupones (
  Id INT PRIMARY KEY,
  PurchaseId INT,
  CouponId INT,
  FOREIGN KEY (PurchaseId) REFERENCES Purchases(Id),
  FOREIGN KEY (CouponId) REFERENCES Coupones(Id)
);

CREATE TABLE Purchases (
  Id INT PRIMARY KEY,
  UserId INT,
  Date DATE,
  Amount DECIMAL,
  FOREIGN KEY (UserId) REFERENCES MarketplaceUsers(Id)
);

CREATE TABLE MarketplaceUsers (
  Id INT PRIMARY KEY,
  UserName VARCHAR(255),
  Password VARCHAR(255),
  Email VARCHAR(255)
);

CREATE TABLE MarketingUsers (
  Id INT PRIMARY KEY,
  UserName VARCHAR(255),
  Password VARCHAR(255),
  Email VARCHAR(255)
);

CREATE TABLE UsersRoles (
  Id INT PRIMARY KEY,
  UserId INT,
  RoleId INT,
  FOREIGN KEY (UserId) REFERENCES MarketplaceUsers(Id),
  FOREIGN KEY (RoleId) REFERENCES Role(Id)
);

CREATE TABLE Roles (
  Id INT PRIMARY KEY,
  Name VARCHAR(255)
);

/*________________________________  Registros________________________________ */

INSERT INTO MarketplaceUser (username, email)
VALUES ('john.doe', 'johndoe@example.com'),
       ('jane.smith', 'janesmith@example.com'),
       ('michael.lee', 'michaellee@example.com');


INSERT INTO MarketingUser (username, email)
VALUES ('marketing1', 'marketing1@example.com'),
       ('marketing2', 'marketing2@example.com');


INSERT INTO Role (name)
VALUES ('Customer'),
       ('Marketing Manager');

INSERT INTO UserRole (user_id, role_id)
VALUES (1, 1),  -- John Doe (Customer)
       (2, 1),  -- Jane Smith (Customer)
       (3, 1),  -- Michael Lee (Customer)
       (1, 2);  -- John Doe (Marketing Manager)


INSERT INTO Coupon (name, description, start_date, end_date, discount_type, discount_value, usage_limit, min_purchase_amount, max_purchase_amount, status, created_by)
VALUES ('Summer Sale', '15% off your entire purchase!', '2024-06-01', '2024-06-30', 'percentage', 0.15, 2, 25.00, NULL, 'Active', 1),
       ('Free Shipping', 'Get free shipping on all orders over $50!', '2024-06-10', '2024-06-20', 'net', 0.00, 1, 50.01, NULL, 'Active', 2),
       ('Back-to-School Bonus', 'Buy 2 school supplies, get 1 free!', '2024-06-15', '2024-07-15', 'net', NULL, 1, NULL, NULL, 'Active', 1);
