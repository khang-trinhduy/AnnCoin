IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116021625_initial')
BEGIN
    CREATE TABLE [Collaborators] (
        [ID] int NOT NULL IDENTITY,
        [email] nvarchar(max) NULL,
        [fullName] nvarchar(max) NULL,
        [password] nvarchar(max) NULL,
        [MyProperty] nvarchar(max) NULL,
        [office] nvarchar(max) NULL,
        [joinDate] datetime2 NOT NULL,
        [gender] nvarchar(max) NULL,
        CONSTRAINT [PK_Collaborators] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116021625_initial')
BEGIN
    CREATE TABLE [Contracts] (
        [ID] int NOT NULL IDENTITY,
        [MyProperty] nvarchar(max) NULL,
        [CollaboratorsID] int NULL,
        CONSTRAINT [PK_Contracts] PRIMARY KEY ([ID]),
        CONSTRAINT [FK_Contracts_Collaborators_CollaboratorsID] FOREIGN KEY ([CollaboratorsID]) REFERENCES [Collaborators] ([ID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116021625_initial')
BEGIN
    CREATE TABLE [Customers] (
        [ID] int NOT NULL IDENTITY,
        [name] nvarchar(max) NULL,
        [phone] nvarchar(max) NULL,
        [email] nvarchar(max) NULL,
        [note] nvarchar(max) NULL,
        [condition] nvarchar(max) NULL,
        [cNumber] int NOT NULL,
        [pNumber] int NOT NULL,
        [ch] nvarchar(max) NULL,
        [price] float NOT NULL,
        [policy] nvarchar(max) NULL,
        [charges] float NOT NULL,
        [totals] float NOT NULL,
        [CollaboratorsID] int NULL,
        CONSTRAINT [PK_Customers] PRIMARY KEY ([ID]),
        CONSTRAINT [FK_Customers_Collaborators_CollaboratorsID] FOREIGN KEY ([CollaboratorsID]) REFERENCES [Collaborators] ([ID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116021625_initial')
BEGIN
    CREATE INDEX [IX_Contracts_CollaboratorsID] ON [Contracts] ([CollaboratorsID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116021625_initial')
BEGIN
    CREATE INDEX [IX_Customers_CollaboratorsID] ON [Customers] ([CollaboratorsID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116021625_initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181116021625_initial', N'2.1.4-rtm-31024');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    EXEC sp_rename N'[Contracts].[MyProperty]', N's3', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customers]') AND [c].[name] = N'phone');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Customers] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Customers] ALTER COLUMN [phone] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customers]') AND [c].[name] = N'name');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Customers] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Customers] ALTER COLUMN [name] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Customers] ADD [pDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [c1] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [c2] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [c3] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [code] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [collabor] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [condition] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [customer] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [d1] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [d2] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [d3] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [day1] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [day2] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [day3] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [dl1] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [dl2] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [dl3] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [email] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [f1] float NOT NULL DEFAULT 0E0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [f2] float NOT NULL DEFAULT 0E0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [f3] float NOT NULL DEFAULT 0E0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [note] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [pDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [phone] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [r1] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [r2] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [r3] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [s1] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [s2] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116030142_add_contract')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181116030142_add_contract', N'2.1.4-rtm-31024');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116033700_administrator')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Collaborators]') AND [c].[name] = N'MyProperty');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Collaborators] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [Collaborators] DROP COLUMN [MyProperty];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116033700_administrator')
BEGIN
    CREATE TABLE [Administrator] (
        [ID] int NOT NULL IDENTITY,
        [email] nvarchar(max) NULL,
        [password] nvarchar(max) NULL,
        [fullName] nvarchar(max) NULL,
        CONSTRAINT [PK_Administrator] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181116033700_administrator')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181116033700_administrator', N'2.1.4-rtm-31024');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120073247_new')
BEGIN
    ALTER TABLE [Customers] ADD [q4] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120073247_new')
BEGIN
    ALTER TABLE [Customers] ADD [q5a] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120073247_new')
BEGIN
    ALTER TABLE [Customers] ADD [q5b] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120073247_new')
BEGIN
    ALTER TABLE [Customers] ADD [q5c] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120073247_new')
BEGIN
    ALTER TABLE [Customers] ADD [q6a] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120073247_new')
BEGIN
    ALTER TABLE [Customers] ADD [q6b] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120073247_new')
BEGIN
    ALTER TABLE [Customers] ADD [q6c] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120073247_new')
BEGIN
    ALTER TABLE [Customers] ADD [q6d] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120073247_new')
BEGIN
    ALTER TABLE [Customers] ADD [q7a] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120073247_new')
BEGIN
    ALTER TABLE [Customers] ADD [q7b] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120073247_new')
BEGIN
    ALTER TABLE [Customers] ADD [q7c] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120073247_new')
BEGIN
    ALTER TABLE [Customers] ADD [q7d] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120073247_new')
BEGIN
    ALTER TABLE [Customers] ADD [q7e] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120073247_new')
BEGIN
    ALTER TABLE [Customers] ADD [q8a] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120073247_new')
BEGIN
    ALTER TABLE [Customers] ADD [q8b] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120073247_new')
BEGIN
    ALTER TABLE [Customers] ADD [q8c] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120073247_new')
BEGIN
    ALTER TABLE [Customers] ADD [q8d] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120073247_new')
BEGIN
    ALTER TABLE [Customers] ADD [q8e] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120073247_new')
BEGIN
    ALTER TABLE [Customers] ADD [q8f] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120073247_new')
BEGIN
    ALTER TABLE [Customers] ADD [supporter] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120073247_new')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181120073247_new', N'2.1.4-rtm-31024');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120094004_template')
BEGIN
    EXEC sp_rename N'[Customers].[q8f]', N'q6m', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120094004_template')
BEGIN
    EXEC sp_rename N'[Customers].[q8e]', N'q6l', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120094004_template')
BEGIN
    EXEC sp_rename N'[Customers].[q8d]', N'q6k', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120094004_template')
BEGIN
    EXEC sp_rename N'[Customers].[q8c]', N'q6j', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120094004_template')
BEGIN
    EXEC sp_rename N'[Customers].[q8b]', N'q6i', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120094004_template')
BEGIN
    EXEC sp_rename N'[Customers].[q8a]', N'q6h', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120094004_template')
BEGIN
    EXEC sp_rename N'[Customers].[q7e]', N'q6g', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120094004_template')
BEGIN
    EXEC sp_rename N'[Customers].[q7d]', N'q6f', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120094004_template')
BEGIN
    EXEC sp_rename N'[Customers].[q7c]', N'q6e', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120094004_template')
BEGIN
    EXEC sp_rename N'[Customers].[q7b]', N'q5j', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120094004_template')
BEGIN
    EXEC sp_rename N'[Customers].[q7a]', N'q5i', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120094004_template')
BEGIN
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customers]') AND [c].[name] = N'q4');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Customers] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [Customers] ALTER COLUMN [q4] bit NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120094004_template')
BEGIN
    ALTER TABLE [Customers] ADD [q5d] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120094004_template')
BEGIN
    ALTER TABLE [Customers] ADD [q5e] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120094004_template')
BEGIN
    ALTER TABLE [Customers] ADD [q5f] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120094004_template')
BEGIN
    ALTER TABLE [Customers] ADD [q5g] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120094004_template')
BEGIN
    ALTER TABLE [Customers] ADD [q5h] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181120094004_template')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181120094004_template', N'2.1.4-rtm-31024');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181123062907_ff')
BEGIN
    DECLARE @var4 sysname;
    SELECT @var4 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customers]') AND [c].[name] = N'q4');
    IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Customers] DROP CONSTRAINT [' + @var4 + '];');
    ALTER TABLE [Customers] DROP COLUMN [q4];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181123062907_ff')
BEGIN
    EXEC sp_rename N'[Customers].[q6m]', N'q7m', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181123062907_ff')
BEGIN
    EXEC sp_rename N'[Customers].[q6l]', N'q7l', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181123062907_ff')
BEGIN
    EXEC sp_rename N'[Customers].[q6k]', N'q7k', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181123062907_ff')
BEGIN
    EXEC sp_rename N'[Customers].[q6j]', N'q7j', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181123062907_ff')
BEGIN
    EXEC sp_rename N'[Customers].[q6i]', N'q7i', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181123062907_ff')
BEGIN
    EXEC sp_rename N'[Customers].[q6h]', N'q7h', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181123062907_ff')
BEGIN
    EXEC sp_rename N'[Customers].[q6g]', N'q7g', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181123062907_ff')
BEGIN
    EXEC sp_rename N'[Customers].[q6f]', N'q7f', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181123062907_ff')
BEGIN
    EXEC sp_rename N'[Customers].[q6e]', N'q7e', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181123062907_ff')
BEGIN
    EXEC sp_rename N'[Customers].[q6d]', N'q7d', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181123062907_ff')
BEGIN
    EXEC sp_rename N'[Customers].[q5j]', N'q7c', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181123062907_ff')
BEGIN
    EXEC sp_rename N'[Customers].[q5i]', N'q7b', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181123062907_ff')
BEGIN
    EXEC sp_rename N'[Customers].[q5h]', N'q7a', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181123062907_ff')
BEGIN
    EXEC sp_rename N'[Customers].[q5g]', N'q4c', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181123062907_ff')
BEGIN
    EXEC sp_rename N'[Customers].[q5f]', N'q4b', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181123062907_ff')
BEGIN
    EXEC sp_rename N'[Customers].[q5e]', N'q4a', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181123062907_ff')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181123062907_ff', N'2.1.4-rtm-31024');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181123063813_fu')
BEGIN
    DECLARE @var5 sysname;
    SELECT @var5 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customers]') AND [c].[name] = N'q4b');
    IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Customers] DROP CONSTRAINT [' + @var5 + '];');
    ALTER TABLE [Customers] DROP COLUMN [q4b];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181123063813_fu')
BEGIN
    DECLARE @var6 sysname;
    SELECT @var6 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customers]') AND [c].[name] = N'q4c');
    IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Customers] DROP CONSTRAINT [' + @var6 + '];');
    ALTER TABLE [Customers] DROP COLUMN [q4c];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181123063813_fu')
BEGIN
    DECLARE @var7 sysname;
    SELECT @var7 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customers]') AND [c].[name] = N'q4a');
    IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Customers] DROP CONSTRAINT [' + @var7 + '];');
    ALTER TABLE [Customers] ALTER COLUMN [q4a] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181123063813_fu')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181123063813_fu', N'2.1.4-rtm-31024');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181125040323_galaxy')
BEGIN
    DROP INDEX [IX_Customers_CollaboratorsID] ON [Customers];
    DECLARE @var8 sysname;
    SELECT @var8 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customers]') AND [c].[name] = N'CollaboratorsID');
    IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Customers] DROP CONSTRAINT [' + @var8 + '];');
    ALTER TABLE [Customers] ALTER COLUMN [CollaboratorsID] int NOT NULL;
    CREATE INDEX [IX_Customers_CollaboratorsID] ON [Customers] ([CollaboratorsID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181125040323_galaxy')
BEGIN
    ALTER TABLE [Collaborators] ADD [birthday] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181125040323_galaxy')
BEGIN
    ALTER TABLE [Collaborators] ADD [city] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181125040323_galaxy')
BEGIN
    ALTER TABLE [Collaborators] ADD [cmnd] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181125040323_galaxy')
BEGIN
    ALTER TABLE [Collaborators] ADD [day] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181125040323_galaxy')
BEGIN
    ALTER TABLE [Collaborators] ADD [district] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181125040323_galaxy')
BEGIN
    ALTER TABLE [Collaborators] ADD [field] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181125040323_galaxy')
BEGIN
    ALTER TABLE [Collaborators] ADD [house] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181125040323_galaxy')
BEGIN
    ALTER TABLE [Collaborators] ADD [nation] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181125040323_galaxy')
BEGIN
    ALTER TABLE [Collaborators] ADD [office_name] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181125040323_galaxy')
BEGIN
    ALTER TABLE [Collaborators] ADD [place] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181125040323_galaxy')
BEGIN
    ALTER TABLE [Collaborators] ADD [position] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181125040323_galaxy')
BEGIN
    ALTER TABLE [Collaborators] ADD [town] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181125040323_galaxy')
BEGIN
    ALTER TABLE [Collaborators] ADD [zip] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181125040323_galaxy')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181125040323_galaxy', N'2.1.4-rtm-31024');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181126034935_venus')
BEGIN
    ALTER TABLE [Customers] ADD [signed] bit NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181126034935_venus')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181126034935_venus', N'2.1.4-rtm-31024');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181127040355_nebula')
BEGIN
    ALTER TABLE [sale] ADD [type] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181127040355_nebula')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181127040355_nebula', N'2.1.4-rtm-31024');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181127080147_policy')
BEGIN
    ALTER TABLE [Collaborators] ADD [policy] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181127080147_policy')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181127080147_policy', N'2.1.4-rtm-31024');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181127080840_policy_contract')
BEGIN
    ALTER TABLE [Contracts] ADD [policy] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181127080840_policy_contract')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181127080840_policy_contract', N'2.1.4-rtm-31024');
END;

GO

