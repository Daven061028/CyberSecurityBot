# Cyber-Security-Awareness-Chatbot
## Student Information

**Student Name:** Dakalo Mahoma

**Student Number:** ST10485799

**Module:** PROG6221

**Project:** Cyber Security Awareness Chatbot

**Version:** 1.0


# Project Overview

The Cyber Security Awareness Chatbot is a Windows Presentation Foundation (WPF) application developed using C# and .NET Framework 4.8.

The purpose of this chatbot is to educate users about cybersecurity concepts and promote safe online behaviour through interactive conversations.

The chatbot allows users to log in securely, learn about cybersecurity topics, receive voice feedback, and track their cybersecurity awareness progress.


# Project Objectives

The objectives of this project are:

- Educate users about cybersecurity threats.
- Promote safe online practices.
- Provide an interactive chatbot experience.
- Demonstrate object-oriented programming principles.
- Implement memory, sentiment detection, and conversation flow.
- Create a user-friendly graphical user interface.


# Features

## User Login System

The application includes a login system that requires users to enter:

- Username
- Password

### Password Requirements

Passwords must:

- Be between 8 and 13 characters long.
- Contain at least one uppercase letter.
- Contain at least one number.
- Contain at least one special character.

Example:

Cyber@123


## User Memory

The chatbot remembers:

- Username
- Favourite cybersecurity topic
- Security awareness score

Returning users are greeted by name and reminded of their previous interests.

Example:

Welcome back John!

Last time you were interested in Phishing.


## Keyword Recognition

The chatbot can recognise cybersecurity-related keywords including:

- Password
- Privacy
- Phishing
- Scam
- Malware
- Virus
- VPN
- Firewall
- Authentication

The chatbot responds with relevant cybersecurity information based on the keyword detected.


## Random Responses

The chatbot uses randomised responses to create a more natural conversational experience.

Example:

For the keyword "Phishing", the chatbot may return different responses each time.


## Conversation Flow

The chatbot supports conversation continuation.

Example:

User: Tell me about phishing.

Bot: Phishing emails often attempt to steal personal information.

User: Tell me more.

Bot: Always verify the sender's email address before clicking links.


## Sentiment Detection

The chatbot detects user emotions and responds appropriately.

Supported sentiments include:

- Worried
- Curious
- Frustrated
- Confused

Example:

User: I am worried about phishing.

Bot: I understand your concern. Staying informed is a great first step.

## Voice Output

The chatbot uses the System.Speech library to provide voice feedback.

Voice functionality includes:

- Welcome message
- Chatbot responses
- Logout message


## Security Awareness Progress

The application tracks the user's cybersecurity awareness level using a progress bar.

Levels include:

- Beginner
- Learning
- Improving
- Advanced
- Cyber Expert


## Logout System

The chatbot includes a logout feature.

When the user logs out, the chatbot displays and speaks a personalised goodbye message.

Example:

Goodbye John!

Thank you for using the Cyber Security Awareness Chatbot.

Stay safe online and see you next time!


# Technologies Used

The following technologies were used:

- C#
- WPF (Windows Presentation Foundation)
- XAML
- .NET Framework 4.8
- System.Speech
- Visual Studio 2022


# Object-Oriented Programming Concepts

The project demonstrates the following OOP principles:

## Classes

Examples:

- UserProfile
- UserManager
- ChatBotEngine
- VoiceManager
- SentimentDetector
- ResponseManager

## Encapsulation

Data is stored and managed through dedicated classes and methods.

## Abstraction

Complex processes are handled through service classes.

## Modularity

The application is separated into Models, Services, and User Interface components.


# Project Structure

```text
CyberSecurityBot
│
├── Models
│   ├── UserProfile.cs
│   └── UserMemory.cs
│
├── Services
│   ├── UserManager.cs
│   ├── ChatBotEngine.cs
│   ├── ResponseManager.cs
│   ├── SentimentDetector.cs
│   └── VoiceManager.cs
│
├── LoginWindow.xaml
├── LoginWindow.xaml.cs
│
├── MainWindow.xaml
├── MainWindow.xaml.cs
│
├── App.xaml
├── App.xaml.cs
│
└── README.md


# Installation Instructions

1. Download or clone the repository.
2. Open the project in Visual Studio.
3. Open the solution file:

CyberSecurityBot.sln

4. Build the solution.
5. Run the application.

# How To Use The Application

## Step 1

Launch the application.

## Step 2

Enter:

- Username
- Valid password

## Step 3

Login to access the chatbot.

## Step 4

Ask cybersecurity-related questions.

Examples:


Tell me about phishing.

What is privacy?

How can I create a strong password?

Tell me more.

## Step 5

Review your cybersecurity awareness progress.

## Step 6

Click Logout when finished.



# GitHub Repository

GitHub Repository Link:


https://github.com/Daven061028/Cyber-Security-Awareness-Chatbot

# GitHub Release

Release Version:


v1.0 Final Submission


The GitHub repository contains:

- Complete source code
- Commit history
- Documentation
- Final project release


# Future Improvements

Future enhancements may include:

- AI-powered chatbot responses
- Database integration
- Additional cybersecurity topics
- User statistics dashboard
- Multiple user accounts
- Dark and Light themes
- Improved sentiment analysis


# Video Demonstration

The video presentation demonstrates:

- Login functionality
- Password validation
- Keyword recognition
- Conversation flow
- Memory and recall
- Sentiment detection
- Voice output
- Logout functionality


# Declaration

This project was developed as part of the PROG6221 Programming Module and demonstrates the application of C#, WPF, object-oriented programming, and cybersecurity awareness concepts.


# Author

**Student Name:** dakalo Mahoma

**Student Number:** ST10485799

**Module:** PROG6221

**Project Version:** 1.0

**Submission Date:** 29-may-2026
