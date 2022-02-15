/****** Script to create AccountMaster table ******/

USE [Firm]
GO

CREATE TABLE [dbo].[AccountMaster](
[ID] [int] IDENTITY(1,1) NOT NULL,
[Account_ID] [varchar](50) NOT NULL,
[Name] [varchar](100) NOT NULL,
[Description] [varchar](max) NULL,
[Company_logo] [varbinary](max) NULL,
[Planned_Start_Date] [datetime] NOT NULL,
[Planned_End_Date] [datetime] NOT NULL,
[Actual_Start_Date] [datetime] NULL,
[Actual_End_Date] [datetime] NULL,
[Primary_Contact_Name] [varchar](100) NOT NULL,
[Primary_contact_Email] [varchar](50) NOT NULL,
[Secondary_Contact_Name] [varchar](100) NULL,
[Secondary_Contact_Email] [varchar](50) NULL,
[Address_1] [varchar](100) NULL,
[Address_2] [varchar](100) NULL,
[City] [varchar](100) NULL,
[State] [varchar](100) NULL,
[Country] [varchar](100) NULL,
[Region] [varchar](100) NULL,
[Type] [varchar](50) NOT NULL,
[isActive] [int] NOT NULL,
[Flag] [varchar](10) NOT NULL,
[Status] [varchar](50) NOT NULL,
[Comments] [varchar](max) NULL,
[Created] [datetime] NOT NULL,
[last_modified] [datetime] NOT NULL,
CONSTRAINT [PK_AccountMaster_ID] PRIMARY KEY CLUSTERED
(
[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
CONSTRAINT [UK_ACCOUNTID] UNIQUE NONCLUSTERED
(
[Account_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO



ALTER TABLE [dbo].[AccountMaster] ADD DEFAULT (getdate()) FOR [Created]
GO



ALTER TABLE [dbo].[AccountMaster] ADD DEFAULT (getdate()) FOR [last_modified]
GO
