USE [ContactBusinessCard]
GO
/****** Object:  Table [dbo].[address]    Script Date: 8/14/2019 4:33:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[address](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[address_type] [uniqueidentifier] NULL,
	[street] [varchar](255) NULL,
	[street_2] [varchar](255) NULL,
	[state_id] [int] NULL,
	[pincode] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AddressType]    Script Date: 8/14/2019 4:33:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AddressType](
	[AddressTypeID] [uniqueidentifier] NOT NULL,
	[Name] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[AddressTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[country]    Script Date: 8/14/2019 4:33:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[country](
	[id] [int] NOT NULL,
	[name] [varchar](255) NULL,
	[code] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[organisation]    Script Date: 8/14/2019 4:33:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[organisation](
	[id] [int] NOT NULL,
	[name] [varchar](255) NULL,
	[slogan_id] [int] NULL,
	[address_id] [int] NULL,
	[contact_no] [varchar](1) NULL,
	[email] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[position]    Script Date: 8/14/2019 4:33:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[position](
	[id] [int] NOT NULL,
	[name] [varchar](255) NULL,
	[organisation_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[slogan]    Script Date: 8/14/2019 4:33:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[slogan](
	[id] [int] NOT NULL,
	[message] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[state]    Script Date: 8/14/2019 4:33:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[state](
	[id] [int] NOT NULL,
	[name] [varchar](255) NULL,
	[country_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 8/14/2019 4:33:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](255) NULL,
	[last_name] [varchar](255) NULL,
	[position_id] [int] NULL,
	[organisation_id] [int] NULL,
	[address_id] [int] NULL,
	[mob_no] [varchar](255) NULL,
	[alt_mob_no] [varchar](255) NULL,
	[email] [varchar](255) NULL,
	[isDeleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[address] ON 
GO
INSERT [dbo].[address] ([id], [address_type], [street], [street_2], [state_id], [pincode]) VALUES (1, N'6411641c-f93c-4923-8d28-21fd0f36add6', N'noida', N'noida', 1, N'123456')
GO
INSERT [dbo].[address] ([id], [address_type], [street], [street_2], [state_id], [pincode]) VALUES (2, N'6411641c-f93c-4923-8d28-21fd0f36add6', N'gggg', N'gggggg', 3, N'123456')
GO
INSERT [dbo].[address] ([id], [address_type], [street], [street_2], [state_id], [pincode]) VALUES (3, N'6411641c-f93c-4923-8d28-21fd0f36add6', N'asdesfssffsfsfs', N'aqwed', 3, N'121212')
GO
INSERT [dbo].[address] ([id], [address_type], [street], [street_2], [state_id], [pincode]) VALUES (4, N'5d4a13fb-58c9-443f-9cd3-30e0e2f4f407', N'sdcs', NULL, 1, N'121212')
GO
SET IDENTITY_INSERT [dbo].[address] OFF
GO
INSERT [dbo].[AddressType] ([AddressTypeID], [Name]) VALUES (N'6411641c-f93c-4923-8d28-21fd0f36add6', N'Organisation')
GO
INSERT [dbo].[AddressType] ([AddressTypeID], [Name]) VALUES (N'5d4a13fb-58c9-443f-9cd3-30e0e2f4f407', N'Residential')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (1, N'Afghanistan', N'AFG')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (2, N'Aland Islands', N'ALA')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (3, N'Albania', N'ALB')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (4, N'Algeria', N'DZA')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (5, N'American Samoa', N'ASM')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (6, N'Andorra', N'AND')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (7, N'Angola', N'AGO')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (8, N'Anguilla', N'AIA')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (9, N'Antarctica', N'ATA')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (10, N'Antigua and Barbuda', N'ATG')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (11, N'Argentina', N'ARG')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (12, N'Armenia', N'ARM')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (13, N'Aruba', N'ABW')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (14, N'Australia', N'AUS')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (15, N'Austria', N'AUT')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (16, N'Azerbaijan', N'AZE')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (17, N'Bahamas', N'BHS')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (18, N'Bahrain', N'BHR')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (19, N'Bangladesh', N'BGD')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (20, N'Barbados', N'BRB')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (21, N'Belarus', N'BLR')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (22, N'Belgium', N'BEL')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (23, N'Belize', N'BLZ')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (24, N'Benin', N'BEN')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (25, N'Bermuda', N'BMU')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (26, N'Bhutan', N'BTN')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (27, N'Bolivia', N'BOL')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (28, N'Bonaire, Sint Eustatius and Saba', N'BES')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (29, N'Bosnia and Herzegovina', N'BIH')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (30, N'Botswana', N'BWA')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (31, N'Bouvet Island', N'BVT')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (32, N'Brazil', N'BRA')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (33, N'British Indian Ocean Territory', N'IOT')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (34, N'Brunei', N'BRN')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (35, N'Bulgaria', N'BGR')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (36, N'Burkina Faso', N'BFA')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (37, N'Burundi', N'BDI')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (38, N'Cambodia', N'KHM')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (39, N'Cameroon', N'CMR')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (40, N'Canada', N'CAN')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (41, N'Cape Verde', N'CPV')
GO
INSERT [dbo].[country] ([id], [name], [code]) VALUES (102, N'India', N'IND')
GO
INSERT [dbo].[organisation] ([id], [name], [slogan_id], [address_id], [contact_no], [email]) VALUES (1, N'Global Logic', 1, NULL, N'1', N'h@gmail.com')
GO
INSERT [dbo].[position] ([id], [name], [organisation_id]) VALUES (1, N'Manager', 1)
GO
INSERT [dbo].[position] ([id], [name], [organisation_id]) VALUES (2, N'Lead', 1)
GO
INSERT [dbo].[slogan] ([id], [message]) VALUES (1, N'We are Good')
GO
INSERT [dbo].[state] ([id], [name], [country_id]) VALUES (1, N'Uttar Pradesh', 102)
GO
INSERT [dbo].[state] ([id], [name], [country_id]) VALUES (2, N'Andhra Pradesh', 102)
GO
INSERT [dbo].[state] ([id], [name], [country_id]) VALUES (3, N'Arunachal Pradesh', 102)
GO
SET IDENTITY_INSERT [dbo].[user] ON 
GO
INSERT [dbo].[user] ([id], [first_name], [last_name], [position_id], [organisation_id], [address_id], [mob_no], [alt_mob_no], [email], [isDeleted]) VALUES (2, N'Kunal', N'Goellllllll', 1, 1, 2, N'2323232', N'454535', N'kg@gmail.com', NULL)
GO
INSERT [dbo].[user] ([id], [first_name], [last_name], [position_id], [organisation_id], [address_id], [mob_no], [alt_mob_no], [email], [isDeleted]) VALUES (3, N'Pranab', N'Kumar', 2, 1, 3, N'9087656777', N'123', N'pk@gmail.com', NULL)
GO
INSERT [dbo].[user] ([id], [first_name], [last_name], [position_id], [organisation_id], [address_id], [mob_no], [alt_mob_no], [email], [isDeleted]) VALUES (4, N'Pranab', N'Nayak', 1, 1, 4, N'9087656777', N'7877688878', N'p@gmail.com', NULL)
GO
SET IDENTITY_INSERT [dbo].[user] OFF
GO
ALTER TABLE [dbo].[organisation]  WITH CHECK ADD FOREIGN KEY([address_id])
REFERENCES [dbo].[address] ([id])
GO
ALTER TABLE [dbo].[organisation]  WITH CHECK ADD FOREIGN KEY([address_id])
REFERENCES [dbo].[address] ([id])
GO
ALTER TABLE [dbo].[organisation]  WITH CHECK ADD FOREIGN KEY([slogan_id])
REFERENCES [dbo].[slogan] ([id])
GO
ALTER TABLE [dbo].[organisation]  WITH CHECK ADD FOREIGN KEY([slogan_id])
REFERENCES [dbo].[slogan] ([id])
GO
ALTER TABLE [dbo].[position]  WITH CHECK ADD FOREIGN KEY([organisation_id])
REFERENCES [dbo].[organisation] ([id])
GO
ALTER TABLE [dbo].[user]  WITH CHECK ADD FOREIGN KEY([address_id])
REFERENCES [dbo].[address] ([id])
GO
ALTER TABLE [dbo].[user]  WITH CHECK ADD FOREIGN KEY([address_id])
REFERENCES [dbo].[address] ([id])
GO
