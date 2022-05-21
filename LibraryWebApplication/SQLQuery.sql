CREATE TABLE [dbo].[__EFMigrationsHistory] (
    [MigrationId]    NVARCHAR (150) NOT NULL,
    [ProductVersion] NVARCHAR (32)  NOT NULL,
    CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED ([MigrationId] ASC)
);

CREATE TABLE [dbo].[Administrators] (
    [admin_id]   INT            IDENTITY (1, 1) NOT NULL,
    [library_id] INT            NOT NULL,
    [name]       NVARCHAR (MAX) NULL,
    [email]      NVARCHAR (MAX) NULL,
    [password]   NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Administrators] PRIMARY KEY CLUSTERED ([admin_id] ASC)
);

CREATE TABLE [dbo].[AspNetRoleClaims] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [RoleId]     NVARCHAR (450) NOT NULL,
    [ClaimType]  NVARCHAR (MAX) NULL,
    [ClaimValue] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[AspNetRoles] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId]
    ON [dbo].[AspNetRoleClaims]([RoleId] ASC);


CREATE TABLE [dbo].[AspNetRoles] (
    [Id]               NVARCHAR (450) NOT NULL,
    [Name]             NVARCHAR (256) NULL,
    [NormalizedName]   NVARCHAR (256) NULL,
    [ConcurrencyStamp] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex]
    ON [dbo].[AspNetRoles]([NormalizedName] ASC) WHERE ([NormalizedName] IS NOT NULL);



CREATE TABLE [dbo].[AspNetUserClaims] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [UserId]     NVARCHAR (450) NOT NULL,
    [ClaimType]  NVARCHAR (MAX) NULL,
    [ClaimValue] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId]
    ON [dbo].[AspNetUserClaims]([UserId] ASC);



CREATE TABLE [dbo].[AspNetUserLogins] (
    [LoginProvider]       NVARCHAR (450) NOT NULL,
    [ProviderKey]         NVARCHAR (450) NOT NULL,
    [ProviderDisplayName] NVARCHAR (MAX) NULL,
    [UserId]              NVARCHAR (450) NOT NULL,
    CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED ([LoginProvider] ASC, [ProviderKey] ASC),
    CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId]
    ON [dbo].[AspNetUserLogins]([UserId] ASC);



CREATE TABLE [dbo].[AspNetUserRoles] (
    [UserId] NVARCHAR (450) NOT NULL,
    [RoleId] NVARCHAR (450) NOT NULL,
    CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED ([UserId] ASC, [RoleId] ASC),
    CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[AspNetRoles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId]
    ON [dbo].[AspNetUserRoles]([RoleId] ASC);



CREATE TABLE [dbo].[AspNetUsers] (
    [Id]                   NVARCHAR (450)     NOT NULL,
    [UserName]             NVARCHAR (256)     NULL,
    [NormalizedUserName]   NVARCHAR (256)     NULL,
    [Email]                NVARCHAR (256)     NULL,
    [NormalizedEmail]      NVARCHAR (256)     NULL,
    [EmailConfirmed]       BIT                NOT NULL,
    [PasswordHash]         NVARCHAR (MAX)     NULL,
    [SecurityStamp]        NVARCHAR (MAX)     NULL,
    [ConcurrencyStamp]     NVARCHAR (MAX)     NULL,
    [PhoneNumber]          NVARCHAR (MAX)     NULL,
    [PhoneNumberConfirmed] BIT                NOT NULL,
    [TwoFactorEnabled]     BIT                NOT NULL,
    [LockoutEnd]           DATETIMEOFFSET (7) NULL,
    [LockoutEnabled]       BIT                NOT NULL,
    [AccessFailedCount]    INT                NOT NULL,
    CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [EmailIndex]
    ON [dbo].[AspNetUsers]([NormalizedEmail] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex]
    ON [dbo].[AspNetUsers]([NormalizedUserName] ASC) WHERE ([NormalizedUserName] IS NOT NULL);



CREATE TABLE [dbo].[AspNetUserTokens] (
    [UserId]        NVARCHAR (450) NOT NULL,
    [LoginProvider] NVARCHAR (450) NOT NULL,
    [Name]          NVARCHAR (450) NOT NULL,
    [Value]         NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED ([UserId] ASC, [LoginProvider] ASC, [Name] ASC),
    CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE
);



CREATE TABLE [dbo].[Author] (
    [author_id]     INT            IDENTITY (1, 1) NOT NULL,
    [name]          NVARCHAR (MAX) NULL,
    [authorBooksid] INT            NULL,
    CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED ([author_id] ASC),
    CONSTRAINT [FK_Author_AuthorBooks_authorBooksid] FOREIGN KEY ([authorBooksid]) REFERENCES [dbo].[AuthorBooks] ([id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Author_authorBooksid]
    ON [dbo].[Author]([authorBooksid] ASC);



CREATE TABLE [dbo].[AuthorBooks] (
    [id]        INT IDENTITY (1, 1) NOT NULL,
    [author_id] INT NOT NULL,
    [book_id]   INT NOT NULL,
    CONSTRAINT [PK_AuthorBooks] PRIMARY KEY CLUSTERED ([id] ASC)
);



CREATE TABLE [dbo].[Books] (
    [book_id]        INT            IDENTITY (1, 1) NOT NULL,
    [title]          NVARCHAR (MAX) NULL,
    [genre]          NVARCHAR (MAX) NULL,
    [release_year]   NVARCHAR (MAX) NULL,
    [publisher_name] NVARCHAR (MAX) NULL,
    [library_id]     INT            NOT NULL,
    [AuthorBookid]   INT            NULL,
    CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED ([book_id] ASC),
    CONSTRAINT [FK_Books_AuthorBooks_AuthorBookid] FOREIGN KEY ([AuthorBookid]) REFERENCES [dbo].[AuthorBooks] ([id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Books_AuthorBookid]
    ON [dbo].[Books]([AuthorBookid] ASC);



CREATE TABLE [dbo].[Contacts] (
    [message_id] INT            IDENTITY (1, 1) NOT NULL,
    [first_name] NVARCHAR (MAX) NULL,
    [last_name]  NVARCHAR (MAX) NULL,
    [email]      NVARCHAR (MAX) NULL,
    [subject]    NVARCHAR (MAX) NULL,
    [library_id] INT            NULL,
    [TempId]     INT            NOT NULL,
    CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED ([message_id] ASC),
    CONSTRAINT [AK_Contacts_TempId] UNIQUE NONCLUSTERED ([TempId] ASC),
    CONSTRAINT [FK_Contacts_Library_library_id] FOREIGN KEY ([library_id]) REFERENCES [dbo].[Library] ([library_id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Contacts_library_id]
    ON [dbo].[Contacts]([library_id] ASC);



CREATE TABLE [dbo].[Library] (
    [library_id]            INT            IDENTITY (1, 1) NOT NULL,
    [borrowed_book]         INT            NOT NULL,
    [total_nr_of_books]     INT            NOT NULL,
    [return_date]           NVARCHAR (MAX) NULL,
    [book_id]               INT            NULL,
    [administratoradmin_id] INT            NULL,
    [message_id]            INT            NOT NULL,
    CONSTRAINT [PK_Library] PRIMARY KEY CLUSTERED ([library_id] ASC),
    CONSTRAINT [FK_Library_Administrators_administratoradmin_id] FOREIGN KEY ([administratoradmin_id]) REFERENCES [dbo].[Administrators] ([admin_id]),
    CONSTRAINT [FK_Library_Books_book_id] FOREIGN KEY ([book_id]) REFERENCES [dbo].[Books] ([book_id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Library_administratoradmin_id]
    ON [dbo].[Library]([administratoradmin_id] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Library_book_id]
    ON [dbo].[Library]([book_id] ASC);



CREATE TABLE [dbo].[Publisher] (
    [publisher_name] NVARCHAR (450) NOT NULL,
    [address]        NVARCHAR (MAX) NULL,
    [book_id]        INT            NULL,
    CONSTRAINT [PK_Publisher] PRIMARY KEY CLUSTERED ([publisher_name] ASC),
    CONSTRAINT [FK_Publisher_Books_book_id] FOREIGN KEY ([book_id]) REFERENCES [dbo].[Books] ([book_id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Publisher_book_id]
    ON [dbo].[Publisher]([book_id] ASC);


