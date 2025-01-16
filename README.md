# Movie Management System

## Overview
The Movie Management System is a web application designed to help users manage their movie collections. It allows users to add, edit, delete, and view movies in a user-friendly interface.

## Features
- **Add Movies**: Users can add new movies with details such as title, genre, release year, and rating.
- **Edit Movies**: Update existing movie details.
- **Delete Movies**: Remove movies from the collection.
- **Search & Filter**: Easily search for movies and filter by genre or rating.
- **User Authentication**: Secure login for users to manage their personal movie lists.

## Technologies Used
- **Frontend**: HTML, CSS, JavaScript, Bootstrap, jQuery
- **Backend**: .NET Core, Entity Framework
- **Database**: SQL Server

## Project Structure
MovieMangment/
│
├── Controllers/
│   ├── HomeController.cs
│   └── MovieController.cs
│
├── Migrations/
│   ├── 20240530090428_sunbeam.Designer.cs
│   └── 20240530090428_sunbeam.cs
│
├── Models/
│   ├── User.cs
│   └── MovieMangment.csproj
│
├── Views/
│   ├── Home/
│   │   ├── Create.cshtml
│   │   ├── Details.cshtml
│   │   ├── Edit.cshtml
│   │   └── Index.cshtml
│   └── Movie/
│       ├── Allmovie.cshtml
│       ├── CreateMovie.cshtml
│       └── EditMovie.cshtml
│
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── lib/
│
├── appsettings.Development.json
├── appsettings.json
└── Program.cs

Copy

## Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/Movie-mangemnt-system.git
Navigate to the project directory:
Copy
cd Movie-mangemnt-system
Install the dependencies:
Copy
dotnet restore
Run the migrations:
Copy
dotnet ef database update
Start the server:
Copy
dotnet run
Usage
Open your browser and go to http://localhost:5000 to access the application.
Follow the on-screen instructions to manage your movie collection.
Contributing
Contributions are welcome! Please fork the repository and submit a pull request. i want reame file to fithbu
