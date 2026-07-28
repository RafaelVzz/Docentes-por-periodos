# Academic Management System - WinForms 📊

Desktop application developed in C# under a layered architecture, designed for the management, import, and export of academic data using Excel files and SQL Server.

## 📋 System Requirements
* **Framework:** .NET Framework 4.8
* **Database:** SQL Server 2014 or higher.
* **Libraries:** ClosedXML (Installed via NuGet).

## 🗄️ Database Configuration
1. **Script:** Run the `database_setup.sql` file included in the root of the repository to recreate the required table structure.
2. **Architecture:** Supports local or remote (Client-Server) connections. Workstations connect using the server PC's IP address.

## ⚙️ Dynamic Configuration (Config.ini)
The system uses an external configuration file managed by the `LectorIni` class in `CapaDatos` to decouple the infrastructure from the code:
* **Template:** Use the `Config.ini.example` file as a starting point.
* **Location:** The final `Config.ini` file must reside in the executable's folder (`bin/Release`, `bin/Debug`, or the installation folder).
* **Parameters:** Allows configuring the Server (IP), Database, Username, and Password without recompiling the application.

## 📄 Excel Handling (Rules)
To ensure import integrity and correct filter functionality:
* Excel files must maintain the predefined number and names of institutional headers.
* The application assumes this fixed format to process the information.
* Due to the above, the structure is rigid, and a complete code refactoring would be required to change the format of the Excel files.

## 🚀 Installation
1. Clone the repository.
2. Restore NuGet packages in Visual Studio.
3. Create the `Config.ini` file based on the example.
4. Build and run.