namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAllTables : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO[dbo].[AspNetUsers]
            ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'52a2e616-1152-4919-bc49-2bc47b2070eb', N'email@email.com', 0, N'AKhn32/gXp1i314yVHhUpOPR7MTGurs1IEGPyv7krwJuQ7Z0J7711NyE8BimJc/TwA==', N'd2911d84-df2d-45ef-bf58-d50635ed9cb1', NULL, 0, 0, NULL, 1, 0, N'user')");


            Sql("SET IDENTITY_INSERT Employees ON");
            Sql("INSERT INTO Employees (Id, FirstName, LastName, Specialty) VALUES (1, 'Susan', 'Wise', 'Geriatrics')");
            Sql("INSERT INTO Employees (Id, FirstName, LastName, Specialty) VALUES (2, 'Frederick', 'Rosario', 'Orthopedics')");
            Sql("INSERT INTO Employees (Id, FirstName, LastName, Specialty) VALUES (3, 'Uma', 'Garcia', 'Cardiology')");
            Sql("INSERT INTO Employees (Id, FirstName, LastName, Specialty) VALUES (4, 'Bryan', 'Kaseem', 'Oncology')");
            Sql("INSERT INTO Employees (Id, FirstName, LastName, Specialty) VALUES (5, 'Simone', 'Fields', 'Neurosciences')");
            Sql("INSERT INTO Employees (Id, FirstName, LastName, Specialty) VALUES (6, 'Mira', 'Pena', 'Oncology')");
            Sql("INSERT INTO Employees (Id, FirstName, LastName, Specialty) VALUES (7, 'Morgan', 'Woodward', 'Cardiology')");
            Sql("INSERT INTO Employees (Id, FirstName, LastName, Specialty) VALUES (8, 'Clay', 'Emerson', 'Orthopedics')");
            Sql("INSERT INTO Employees (Id, FirstName, LastName, Specialty) VALUES (9, 'Raja', 'Roth', 'Geriatrics')");
            Sql("INSERT INTO Employees (Id, FirstName, LastName, Specialty) VALUES (10, 'Darius', 'Byrd', 'Geriatrics')");
            Sql("SET IDENTITY_INSERT Employees OFF");

            Sql("SET IDENTITY_INSERT Clients ON");
            Sql("INSERT INTO Clients (Id, FirstName, LastName, Birthdate) VALUES (1, 'Drew', 'Soto', '04/06/1977')");
            Sql("INSERT INTO Clients (Id, FirstName, LastName, Birthdate) VALUES (2, 'Cora', 'Carney', '07/11/1974')");
            Sql("INSERT INTO Clients (Id, FirstName, LastName, Birthdate) VALUES (3, 'Ralph', 'Barr', '11/06/1933')");
            Sql("INSERT INTO Clients (Id, FirstName, LastName, Birthdate) VALUES (4, 'Octavia', 'Barr', '08/18/1952')");
            Sql("INSERT INTO Clients (Id, FirstName, LastName, Birthdate) VALUES (5, 'Alan', 'Small', '09/03/1925')");
            Sql("INSERT INTO Clients (Id, FirstName, LastName, Birthdate) VALUES (6, 'Abel', 'Riggs', '08/27/1945')");
            Sql("INSERT INTO Clients (Id, FirstName, LastName, Birthdate) VALUES (7, 'Jennifer', 'Howard', '07/30/1940')");
            Sql("INSERT INTO Clients (Id, FirstName, LastName, Birthdate) VALUES (8, 'Robert', 'Mendez', '02/10/1987')");
            Sql("INSERT INTO Clients (Id, FirstName, LastName, Birthdate) VALUES (9, 'Hyatt', 'Weeks', '08/26/1962')");
            Sql("INSERT INTO Clients (Id, FirstName, LastName, Birthdate) VALUES (10, 'Hashim', 'Burke', '01/06/1990')");
            Sql("INSERT INTO Clients (Id, FirstName, LastName, Birthdate) VALUES (11, 'Levi', 'Wallace', '04/26/1980')");
            Sql("SET IDENTITY_INSERT Clients OFF");

            Sql("SET IDENTITY_INSERT ServiceLines ON");
            Sql("INSERT INTO ServiceLines (Id, Service, ServiceType, StartTime, EndTime) VALUES (1, 'Geriatrics', 'Geriatrics', '07/30/2017','07/30/2017')");
            Sql("INSERT INTO ServiceLines (Id, Service, ServiceType, StartTime, EndTime) VALUES (2, 'Orthopedics', 'Orthopedics', '07/30/2017','07/30/2017')");
            Sql("INSERT INTO ServiceLines (Id, Service, ServiceType, StartTime, EndTime) VALUES (3, 'Cardiology', 'Cardiology', '07/30/2017','07/30/2017')");
            Sql("INSERT INTO ServiceLines (Id, Service, ServiceType, StartTime, EndTime) VALUES (4, 'Oncology', 'Oncology', '07/30/2017','07/30/2017')");
            Sql("INSERT INTO ServiceLines (Id, Service, ServiceType, StartTime, EndTime) VALUES (5, 'Neurosciences', 'Neurosciences', '07/30/2017','07/30/2017')");
            Sql("SET IDENTITY_INSERT ServiceLines ON");
        }
        
        public override void Down()
        {
        }
    }
}
