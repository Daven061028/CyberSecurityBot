CREATE DATABASE CyberSecurityBotDB;

USE CyberSecurityBotDB;

CREATE TABLE Tasks
(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Title VARCHAR(100) NOT NULL,
    Description TEXT,
    ReminderDate DATETIME NULL,
    IsCompleted BOOLEAN DEFAULT FALSE
);
