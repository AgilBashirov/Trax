USE [TraxDb]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name]) VALUES (1, N'Web Design')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (2, N'Network')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (3, N'Marketing')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (4, N'Event')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (5, N'Website')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (6, N'Themeforest')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [Name], [Position], [Image], [IsTeamMember], [Gender]) VALUES (1, N'Jessica Twain', N'Agency Owner', N'c3e2b852-6136-4b0b-987a-22f5d82c4549-27032021042806-team-1.jpg', 1, 0)
INSERT [dbo].[User] ([Id], [Name], [Position], [Image], [IsTeamMember], [Gender]) VALUES (2, N'Jason Wudex ', N'Designer', N'64a3e17a-b525-41b3-826e-b3d34f0a896b-27032021042821-team-2.jpg', 1, 1)
INSERT [dbo].[User] ([Id], [Name], [Position], [Image], [IsTeamMember], [Gender]) VALUES (3, N'Thomas Shelby', N'Gangster', N'6c245c55-2a27-4bf9-b676-7a6dc30a0d6a-27032021042833-team-3.jpg', 1, 1)
INSERT [dbo].[User] ([Id], [Name], [Position], [Image], [IsTeamMember], [Gender]) VALUES (4, N'Hayden Wood', N'Marketing', N'b29567fb-e8eb-4e35-b28c-19268cc439ef-27032021042844-team-4.jpg', 1, 0)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET IDENTITY_INSERT [dbo].[Blogs] ON 

INSERT [dbo].[Blogs] ([Id], [Title], [AddedDate], [Content], [Image], [UserId], [CategoryId]) VALUES (4, N'28 Ways To Boost Your Content Confidence', CAST(N'2021-03-21T00:00:00.0000000' AS DateTime2), N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis nec facilisis nullano volutpat justo. Nulla tempus ultricies feugiat. Duis magna risus, luctus id urna dapibus condimentum dui. Maecenas tempor non ex eu vehicula. Sed sit placerat velit, Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley Lorem Ipsum has been the industry''s standard dummy text ever Lorem Ipsum has been the industry''s standard dummy text ever Lorem Ipsum has been the industry''s standard dummy text ever Lorem Ipsum has been the industry''s standard dummy text ever Lorem Ipsum has been the industry''s standard dummy text ever', N'69c0f45d-1982-48cf-af2b-d02b8875c104-27032021042140-blog-measonry1.jpg', 1, 1)
INSERT [dbo].[Blogs] ([Id], [Title], [AddedDate], [Content], [Image], [UserId], [CategoryId]) VALUES (5, N'28 Ways To Boost Your Content Confidence', CAST(N'2020-05-26T00:00:00.0000000' AS DateTime2), N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis nec facilisis nullano volutpat justo. Nulla tempus ultricies feugiat. Duis magna risus, luctus id urna dapibus condimentum dui. Maecenas tempor non ex eu vehicula. Sed sit placerat velit, Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley Lorem Ipsum has been the industry''s standard dummy text ever Lorem Ipsum has been the industry''s standard dummy text ever Lorem Ipsum has been the industry''s standard dummy text ever Lorem Ipsum has been the industry''s standard dummy text ever Lorem Ipsum has been the industry''s standard dummy text ever', N'f4b15b16-bf3c-4a82-8029-bac11b4dbdd2-27032021042153-blog-measonry2.jpg', 2, 2)
INSERT [dbo].[Blogs] ([Id], [Title], [AddedDate], [Content], [Image], [UserId], [CategoryId]) VALUES (6, N'Smart Choices That Lead To Success', CAST(N'2019-02-18T00:00:00.0000000' AS DateTime2), N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis nec facilisis nullano volutpat justo. Nulla tempus ultricies feugiat. Duis magna risus, luctus id urna dapibus condimentum dui. Maecenas tempor non ex eu vehicula. Sed sit placerat velit, Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley Lorem Ipsum has been the industry''s standard dummy text ever Lorem Ipsum has been the industry''s standard dummy text ever Lorem Ipsum has been the industry''s standard dummy text ever Lorem Ipsum has been the industry''s standard dummy text ever Lorem Ipsum has been the industry''s standard dummy text ever', N'9d61ba7f-ccf6-440b-98e3-2b1688abe0f2-27032021042204-blog-measonry3.jpg', 3, 3)
INSERT [dbo].[Blogs] ([Id], [Title], [AddedDate], [Content], [Image], [UserId], [CategoryId]) VALUES (7, N'5 Practical Time Management Tips', CAST(N'2018-08-29T00:00:00.0000000' AS DateTime2), N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis nec facilisis nullano volutpat justo. Nulla tempus ultricies feugiat. Duis magna risus, luctus id urna dapibus condimentum dui. Maecenas tempor non ex eu vehicula. Sed sit placerat velit, Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley Lorem Ipsum has been the industry''s standard dummy text ever Lorem Ipsum has been the industry''s standard dummy text ever Lorem Ipsum has been the industry''s standard dummy text ever Lorem Ipsum has been the industry''s standard dummy text ever Lorem Ipsum has been the industry''s standard dummy text ever', N'7d13ab6c-5938-4f72-a48d-e41f11d382d7-27032021042222-blog-measonry4.jpg', 4, 4)
INSERT [dbo].[Blogs] ([Id], [Title], [AddedDate], [Content], [Image], [UserId], [CategoryId]) VALUES (8, N'11 Ways To Stay An Alert Copywriter', CAST(N'2017-09-15T00:00:00.0000000' AS DateTime2), N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis nec facilisis nullano volutpat justo. Nulla tempus ultricies feugiat. Duis magna risus, luctus id urna dapibus condimentum dui. Maecenas tempor non ex eu vehicula. Sed sit placerat velit, Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley Lorem Ipsum has been the industry''s standard dummy text ever Lorem Ipsum has been the industry''s standard dummy text ever Lorem Ipsum has been the industry''s standard dummy text ever Lorem Ipsum has been the industry''s standard dummy text ever Lorem Ipsum has been the industry''s standard dummy text ever', N'4b4270fc-dcbd-42ae-9cb4-d2f1c02475a5-27032021042240-blog-measonry5.jpg', 1, 5)
INSERT [dbo].[Blogs] ([Id], [Title], [AddedDate], [Content], [Image], [UserId], [CategoryId]) VALUES (9, N'Creative Self-Care To Keep Your Writing', CAST(N'2016-07-10T00:00:00.0000000' AS DateTime2), N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis nec facilisis nullano volutpat justo. Nulla tempus ultricies feugiat. Duis magna risus, luctus id urna dapibus condimentum dui. Maecenas tempor non ex eu vehicula. Sed sit placerat velit, Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley Lorem Ipsum has been the industry''s standard dummy text ever Lorem Ipsum has been the industry''s standard dummy text ever Lorem Ipsum has been the industry''s standard dummy text ever Lorem Ipsum has been the industry''s standard dummy text ever Lorem Ipsum has been the industry''s standard dummy text ever', N'ef3bfaca-713f-4f4d-a452-598bfe62061d-27032021042252-blog-measonry6.jpg', 2, 6)
SET IDENTITY_INSERT [dbo].[Blogs] OFF
GO
SET IDENTITY_INSERT [dbo].[GalleryTypes] ON 

INSERT [dbo].[GalleryTypes] ([Id], [Name]) VALUES (1, N'Digital')
INSERT [dbo].[GalleryTypes] ([Id], [Name]) VALUES (2, N'Design')
INSERT [dbo].[GalleryTypes] ([Id], [Name]) VALUES (3, N'Brand')
INSERT [dbo].[GalleryTypes] ([Id], [Name]) VALUES (4, N'Graphics')
SET IDENTITY_INSERT [dbo].[GalleryTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Galleries] ON 

INSERT [dbo].[Galleries] ([Id], [Name], [Image], [Link]) VALUES (1, N'Rainy Outdoor', N'gallery-1.jpg', NULL)
INSERT [dbo].[Galleries] ([Id], [Name], [Image], [Link]) VALUES (2, N'Classic Interior', N'gallery-4.jpg', NULL)
INSERT [dbo].[Galleries] ([Id], [Name], [Image], [Link]) VALUES (3, N'Shadow Smoke', N'gallery-11.jpg', NULL)
INSERT [dbo].[Galleries] ([Id], [Name], [Image], [Link]) VALUES (4, N'Eiffel Model', N'gallery-2.jpg', NULL)
INSERT [dbo].[Galleries] ([Id], [Name], [Image], [Link]) VALUES (5, N'Clean Bike', N'gallery-18.jpg', NULL)
INSERT [dbo].[Galleries] ([Id], [Name], [Image], [Link]) VALUES (6, N'Game Mode', N'gallery-9.jpg', NULL)
SET IDENTITY_INSERT [dbo].[Galleries] OFF
GO
SET IDENTITY_INSERT [dbo].[GalleryToTypes] ON 

INSERT [dbo].[GalleryToTypes] ([Id], [GalleryTypeId], [GalleryId]) VALUES (1, 3, 1)
INSERT [dbo].[GalleryToTypes] ([Id], [GalleryTypeId], [GalleryId]) VALUES (2, 4, 1)
INSERT [dbo].[GalleryToTypes] ([Id], [GalleryTypeId], [GalleryId]) VALUES (3, 3, 2)
INSERT [dbo].[GalleryToTypes] ([Id], [GalleryTypeId], [GalleryId]) VALUES (4, 4, 2)
INSERT [dbo].[GalleryToTypes] ([Id], [GalleryTypeId], [GalleryId]) VALUES (5, 2, 2)
INSERT [dbo].[GalleryToTypes] ([Id], [GalleryTypeId], [GalleryId]) VALUES (6, 1, 3)
INSERT [dbo].[GalleryToTypes] ([Id], [GalleryTypeId], [GalleryId]) VALUES (7, 4, 3)
INSERT [dbo].[GalleryToTypes] ([Id], [GalleryTypeId], [GalleryId]) VALUES (8, 3, 4)
INSERT [dbo].[GalleryToTypes] ([Id], [GalleryTypeId], [GalleryId]) VALUES (9, 4, 4)
INSERT [dbo].[GalleryToTypes] ([Id], [GalleryTypeId], [GalleryId]) VALUES (10, 3, 5)
INSERT [dbo].[GalleryToTypes] ([Id], [GalleryTypeId], [GalleryId]) VALUES (11, 4, 5)
INSERT [dbo].[GalleryToTypes] ([Id], [GalleryTypeId], [GalleryId]) VALUES (12, 2, 5)
INSERT [dbo].[GalleryToTypes] ([Id], [GalleryTypeId], [GalleryId]) VALUES (13, 2, 5)
INSERT [dbo].[GalleryToTypes] ([Id], [GalleryTypeId], [GalleryId]) VALUES (14, 3, 6)
INSERT [dbo].[GalleryToTypes] ([Id], [GalleryTypeId], [GalleryId]) VALUES (15, 1, 6)
INSERT [dbo].[GalleryToTypes] ([Id], [GalleryTypeId], [GalleryId]) VALUES (16, 2, 6)
SET IDENTITY_INSERT [dbo].[GalleryToTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Pricings] ON 

INSERT [dbo].[Pricings] ([Id], [Title], [Subtitle], [Price], [Discount], [IsYearly]) VALUES (2, N'Basic', N'The standard version', 9.9500, N'-60%', 0)
INSERT [dbo].[Pricings] ([Id], [Title], [Subtitle], [Price], [Discount], [IsYearly]) VALUES (3, N'Popular', N'The standard version', 19.9500, N'-40%', 0)
INSERT [dbo].[Pricings] ([Id], [Title], [Subtitle], [Price], [Discount], [IsYearly]) VALUES (4, N'Enterprise', N'The standard version', 29.9500, N'-30%', 0)
INSERT [dbo].[Pricings] ([Id], [Title], [Subtitle], [Price], [Discount], [IsYearly]) VALUES (5, N'Basic', N'The standard version', 89.5500, N'-60%', 1)
INSERT [dbo].[Pricings] ([Id], [Title], [Subtitle], [Price], [Discount], [IsYearly]) VALUES (6, N'Popular', N'The standard version', 179.5500, N'-40%', 1)
INSERT [dbo].[Pricings] ([Id], [Title], [Subtitle], [Price], [Discount], [IsYearly]) VALUES (7, N'Enterprise', N'The standard version', 269.5500, N'-30%', 1)
SET IDENTITY_INSERT [dbo].[Pricings] OFF
GO
SET IDENTITY_INSERT [dbo].[PricingTables] ON 

INSERT [dbo].[PricingTables] ([Id], [Info], [Icon], [PricingId]) VALUES (2, N'Support forum', N' ', 2)
INSERT [dbo].[PricingTables] ([Id], [Info], [Icon], [PricingId]) VALUES (3, N'Free hosting', N' ', 2)
INSERT [dbo].[PricingTables] ([Id], [Info], [Icon], [PricingId]) VALUES (5, N'40MB of storage space', N'price-not', 2)
INSERT [dbo].[PricingTables] ([Id], [Info], [Icon], [PricingId]) VALUES (6, N'Social media integration', N'price-not', 2)
INSERT [dbo].[PricingTables] ([Id], [Info], [Icon], [PricingId]) VALUES (7, N'10GB of storage space', N'price-not', 2)
SET IDENTITY_INSERT [dbo].[PricingTables] OFF
GO
SET IDENTITY_INSERT [dbo].[Socials] ON 

INSERT [dbo].[Socials] ([Id], [Icon], [Link], [Section]) VALUES (1, N'fab fa-facebook-f', NULL, N'Footer')
INSERT [dbo].[Socials] ([Id], [Icon], [Link], [Section]) VALUES (2, N'fab fa-twitter', NULL, N'Footer')
INSERT [dbo].[Socials] ([Id], [Icon], [Link], [Section]) VALUES (3, N'fab fa-linkedin-in', NULL, N'Footer')
INSERT [dbo].[Socials] ([Id], [Icon], [Link], [Section]) VALUES (4, N'fab fa-instagram', NULL, N'Footer')
SET IDENTITY_INSERT [dbo].[Socials] OFF
GO
SET IDENTITY_INSERT [dbo].[SocialToUser] ON 

INSERT [dbo].[SocialToUser] ([Id], [UserId], [SocialId]) VALUES (1, 1, 1)
INSERT [dbo].[SocialToUser] ([Id], [UserId], [SocialId]) VALUES (2, 1, 2)
INSERT [dbo].[SocialToUser] ([Id], [UserId], [SocialId]) VALUES (3, 1, 4)
INSERT [dbo].[SocialToUser] ([Id], [UserId], [SocialId]) VALUES (4, 2, 1)
INSERT [dbo].[SocialToUser] ([Id], [UserId], [SocialId]) VALUES (5, 2, 2)
INSERT [dbo].[SocialToUser] ([Id], [UserId], [SocialId]) VALUES (6, 2, 4)
INSERT [dbo].[SocialToUser] ([Id], [UserId], [SocialId]) VALUES (7, 3, 1)
INSERT [dbo].[SocialToUser] ([Id], [UserId], [SocialId]) VALUES (8, 3, 2)
INSERT [dbo].[SocialToUser] ([Id], [UserId], [SocialId]) VALUES (9, 3, 4)
INSERT [dbo].[SocialToUser] ([Id], [UserId], [SocialId]) VALUES (10, 4, 1)
INSERT [dbo].[SocialToUser] ([Id], [UserId], [SocialId]) VALUES (11, 4, 2)
INSERT [dbo].[SocialToUser] ([Id], [UserId], [SocialId]) VALUES (12, 4, 4)
SET IDENTITY_INSERT [dbo].[SocialToUser] OFF
GO
SET IDENTITY_INSERT [dbo].[Tags] ON 

INSERT [dbo].[Tags] ([Id], [Name]) VALUES (1, N'web design')
INSERT [dbo].[Tags] ([Id], [Name]) VALUES (2, N'network')
INSERT [dbo].[Tags] ([Id], [Name]) VALUES (3, N'marketing')
INSERT [dbo].[Tags] ([Id], [Name]) VALUES (4, N'posts')
INSERT [dbo].[Tags] ([Id], [Name]) VALUES (5, N'event')
INSERT [dbo].[Tags] ([Id], [Name]) VALUES (6, N'website')
INSERT [dbo].[Tags] ([Id], [Name]) VALUES (7, N'social')
INSERT [dbo].[Tags] ([Id], [Name]) VALUES (8, N'themeforest')
INSERT [dbo].[Tags] ([Id], [Name]) VALUES (9, N'creative')
INSERT [dbo].[Tags] ([Id], [Name]) VALUES (10, N'best solutions')
SET IDENTITY_INSERT [dbo].[Tags] OFF
GO
SET IDENTITY_INSERT [dbo].[TagToBlog] ON 

INSERT [dbo].[TagToBlog] ([Id], [BlogId], [TagId]) VALUES (47, 4, 1)
INSERT [dbo].[TagToBlog] ([Id], [BlogId], [TagId]) VALUES (48, 4, 3)
INSERT [dbo].[TagToBlog] ([Id], [BlogId], [TagId]) VALUES (49, 5, 2)
INSERT [dbo].[TagToBlog] ([Id], [BlogId], [TagId]) VALUES (50, 5, 5)
INSERT [dbo].[TagToBlog] ([Id], [BlogId], [TagId]) VALUES (51, 6, 1)
INSERT [dbo].[TagToBlog] ([Id], [BlogId], [TagId]) VALUES (52, 6, 2)
INSERT [dbo].[TagToBlog] ([Id], [BlogId], [TagId]) VALUES (53, 6, 3)
INSERT [dbo].[TagToBlog] ([Id], [BlogId], [TagId]) VALUES (54, 6, 4)
INSERT [dbo].[TagToBlog] ([Id], [BlogId], [TagId]) VALUES (55, 7, 1)
INSERT [dbo].[TagToBlog] ([Id], [BlogId], [TagId]) VALUES (56, 7, 10)
INSERT [dbo].[TagToBlog] ([Id], [BlogId], [TagId]) VALUES (57, 8, 6)
INSERT [dbo].[TagToBlog] ([Id], [BlogId], [TagId]) VALUES (58, 8, 7)
INSERT [dbo].[TagToBlog] ([Id], [BlogId], [TagId]) VALUES (59, 8, 8)
INSERT [dbo].[TagToBlog] ([Id], [BlogId], [TagId]) VALUES (60, 8, 9)
INSERT [dbo].[TagToBlog] ([Id], [BlogId], [TagId]) VALUES (61, 9, 2)
INSERT [dbo].[TagToBlog] ([Id], [BlogId], [TagId]) VALUES (62, 9, 4)
INSERT [dbo].[TagToBlog] ([Id], [BlogId], [TagId]) VALUES (63, 9, 6)
INSERT [dbo].[TagToBlog] ([Id], [BlogId], [TagId]) VALUES (64, 9, 8)
INSERT [dbo].[TagToBlog] ([Id], [BlogId], [TagId]) VALUES (65, 9, 10)
SET IDENTITY_INSERT [dbo].[TagToBlog] OFF
GO
SET IDENTITY_INSERT [dbo].[Comment] ON 

INSERT [dbo].[Comment] ([Id], [Desc], [BlogId], [CommentId]) VALUES (1, N'Podcasting operational change management inside of workflows to establish a framework. Taking seamless key performance indicators offline to maximise.', 6, NULL)
INSERT [dbo].[Comment] ([Id], [Desc], [BlogId], [CommentId]) VALUES (2, N'Keeping your eye on the ball while performing. Podcasting operational change management inside of workflows to establish a framework.', 6, NULL)
INSERT [dbo].[Comment] ([Id], [Desc], [BlogId], [CommentId]) VALUES (4, N'Podcasting operational change management inside of workflows to establish a framework. Taking seamless key performance indicators offline to maximise.', 6, 2)
INSERT [dbo].[Comment] ([Id], [Desc], [BlogId], [CommentId]) VALUES (5, N'Keeping your eye on the ball while performing. Podcasting operational change management inside of workflows to establish a framework.', 6, 4)
INSERT [dbo].[Comment] ([Id], [Desc], [BlogId], [CommentId]) VALUES (6, N'Podcasting operational change management inside of workflows to establish a framework. Taking seamless key performance indicators offline to maximise.', 6, NULL)
SET IDENTITY_INSERT [dbo].[Comment] OFF
GO
SET IDENTITY_INSERT [dbo].[Address] ON 

INSERT [dbo].[Address] ([Id], [Icon], [Info1], [Info2]) VALUES (1, N'fas fa-mobile-alt', N'+14046000396', N'+43720778972')
INSERT [dbo].[Address] ([Id], [Icon], [Info1], [Info2]) VALUES (2, N'fas fa-map-marker-alt', N'123 Street NYC , USA', N'123 Street New Yolo , Austria')
INSERT [dbo].[Address] ([Id], [Icon], [Info1], [Info2]) VALUES (3, N'far fa-envelope', N'admin@website.com', N'email@website.com')
INSERT [dbo].[Address] ([Id], [Icon], [Info1], [Info2]) VALUES (4, N'far fa-clock', N'UTC−05:00', N'UTC+01:00')
SET IDENTITY_INSERT [dbo].[Address] OFF
GO
SET IDENTITY_INSERT [dbo].[BusinessHours] ON 

INSERT [dbo].[BusinessHours] ([Id], [Info], [Date]) VALUES (1, N'Monday-Saturday:', N'8.00-18.00')
INSERT [dbo].[BusinessHours] ([Id], [Info], [Date]) VALUES (2, N'Friday:', N'09:00-21:00')
INSERT [dbo].[BusinessHours] ([Id], [Info], [Date]) VALUES (3, N'Sunday:', N'09:00-20:00')
INSERT [dbo].[BusinessHours] ([Id], [Info], [Date]) VALUES (4, N'Calendar Events:', N'24-Hour Shift')
SET IDENTITY_INSERT [dbo].[BusinessHours] OFF
GO
SET IDENTITY_INSERT [dbo].[Contacts] ON 

INSERT [dbo].[Contacts] ([Id], [Title], [SubTitle], [Address], [Phone], [Email], [WorkTime]) VALUES (1, N'Trax Agency Worldwide', N'Our Agency Office In London', N'Address: 309, New Cavendish St, EC1Y 3WK', N'0800 214 5252', N'polpo@traxagency.co.au', N'Mon-Fri: 9am-5pm')
SET IDENTITY_INSERT [dbo].[Contacts] OFF
GO
SET IDENTITY_INSERT [dbo].[Counter] ON 

INSERT [dbo].[Counter] ([Id], [StartNum], [StartTitle], [Desc], [EndNum], [EndTitle]) VALUES (1, 2010, N'Since We Started', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc mauris arcu, lobortis id interdum vitae, interdum eget elit.', 895, N'Since We Started')
SET IDENTITY_INSERT [dbo].[Counter] OFF
GO
SET IDENTITY_INSERT [dbo].[Mobiles] ON 

INSERT [dbo].[Mobiles] ([Id], [Icon], [Title], [Desc]) VALUES (1, N'fas fa-cog', N'Theme Options', N'This is Photoshop''s version of Lorem Ipsum. Proin gravida nibh vel velit auctor aliquet')
INSERT [dbo].[Mobiles] ([Id], [Icon], [Title], [Desc]) VALUES (2, N'fas fa-edit', N'Customization', N'This is Photoshop''s version of Lorem Ipsum. Proin gravida nibh vel velit auctor aliquet')
INSERT [dbo].[Mobiles] ([Id], [Icon], [Title], [Desc]) VALUES (3, N'fas fa-code', N'Powerful Code', N'This is Photoshop''s version of Lorem Ipsum. Proin gravida nibh vel velit auctor aliquet')
INSERT [dbo].[Mobiles] ([Id], [Icon], [Title], [Desc]) VALUES (4, N'far fa-folder-open', N'Documentation', N'This is Photoshop''s version of Lorem Ipsum. Proin gravida nibh vel velit auctor aliquet')
SET IDENTITY_INSERT [dbo].[Mobiles] OFF
GO
SET IDENTITY_INSERT [dbo].[Partners] ON 

INSERT [dbo].[Partners] ([Id], [Image], [Link]) VALUES (11, N'f33e4351-cc42-4d4a-a07b-3ebea6ce0e60-27032021052638-microsoft.new.jpg', N'https://www.microsoft.com/en-us/?ql=1')
INSERT [dbo].[Partners] ([Id], [Image], [Link]) VALUES (12, N'4d6b0fc3-7999-45ed-9e1c-ab473c07544f-27032021052723-Autodesk.new.jpg', N'https://www.autodesk.com/')
INSERT [dbo].[Partners] ([Id], [Image], [Link]) VALUES (13, N'9f050aba-f46f-4ac0-9a35-eb66c5d6147f-27032021052837-Microsoft-logo-2.jpg', N'https://digitalmarketinginstitute.com/')
SET IDENTITY_INSERT [dbo].[Partners] OFF
GO
SET IDENTITY_INSERT [dbo].[PeopleSays] ON 

INSERT [dbo].[PeopleSays] ([Id], [Name], [Company], [Country], [Content], [StarScore], [Image]) VALUES (1, N'John Smith', N'UPWORK', N'New York', N'We have a number of different teams within our agency that specialise in different areas of business so you can be sure that you won’t receive a generic service and although we boast a years and years of service.', 5, N'testimonial-1.jpg')
INSERT [dbo].[PeopleSays] ([Id], [Name], [Company], [Country], [Content], [StarScore], [Image]) VALUES (3, N'Hayden Wood', N'FIVERR', N'Italy', N'Trax’s customer testimonial page is another beauty. Its simple design focuses on videos and standout quotes from customers. This approach is clean, straightforward, text that can be overwhelming and easy to skip.', 4, N'testimonial-2.jpg')
INSERT [dbo].[PeopleSays] ([Id], [Name], [Company], [Country], [Content], [StarScore], [Image]) VALUES (4, N'Kevin Miller', N'ENVATO', N'Australia', N'Trax is a company that provides tools to help professional event planning and execution, and their customers are very happy folks! The thing I love about their customer testimonial page provides content formats.

    ', 5, N'testimonial-3.jpg')
INSERT [dbo].[PeopleSays] ([Id], [Name], [Company], [Country], [Content], [StarScore], [Image]) VALUES (5, N'Alina Johanson', N'INTEL', N'Sidney', N'Startup Institute is a career accelerator that allows professionals to learn new skills, take their careers in a different direction, and pursue a career they are passionate about that have completed the program.

    ', 4, N'testimonial-4.jpg')
SET IDENTITY_INSERT [dbo].[PeopleSays] OFF
GO
SET IDENTITY_INSERT [dbo].[Process] ON 

INSERT [dbo].[Process] ([Id], [Title], [SubTitle]) VALUES (1, N'Concept', N'Quisque tellus risus, adipisci viverra bibendum urna.')
INSERT [dbo].[Process] ([Id], [Title], [SubTitle]) VALUES (2, N'Plan', N'Quisque tellus risus, adipisci viverra bibendum urna.')
INSERT [dbo].[Process] ([Id], [Title], [SubTitle]) VALUES (3, N'Design', N'Quisque tellus risus, adipisci viverra bibendum urna.')
INSERT [dbo].[Process] ([Id], [Title], [SubTitle]) VALUES (4, N'Development', N'Quisque tellus risus, adipisci viverra bibendum urna.')
INSERT [dbo].[Process] ([Id], [Title], [SubTitle]) VALUES (5, N'Quality Check', N'Quisque tellus risus, adipisci viverra bibendum urna.')
SET IDENTITY_INSERT [dbo].[Process] OFF
GO
SET IDENTITY_INSERT [dbo].[Services] ON 

INSERT [dbo].[Services] ([Id], [Name], [Link]) VALUES (1, N'Home', N'index.html')
INSERT [dbo].[Services] ([Id], [Name], [Link]) VALUES (2, N'About Us', N'about.html')
INSERT [dbo].[Services] ([Id], [Name], [Link]) VALUES (3, N'Lastest News', N'blog-1.html')
INSERT [dbo].[Services] ([Id], [Name], [Link]) VALUES (4, N'Business Planing', N'pricing.html')
INSERT [dbo].[Services] ([Id], [Name], [Link]) VALUES (5, N'Contact Us', N'contact.html')
INSERT [dbo].[Services] ([Id], [Name], [Link]) VALUES (6, N'Faq''s', N'faq.html')
SET IDENTITY_INSERT [dbo].[Services] OFF
GO
SET IDENTITY_INSERT [dbo].[Settings] ON 

INSERT [dbo].[Settings] ([Id], [Logo1], [Logo2], [Content], [Icon], [FooterPhone], [FooterEmail]) VALUES (1, N'logo.png', N'logo-transparent.png', N'Keep away from people who try to belittle your ambitions Small people always do that but the really great Friendly.', N'fas fa-mobile-alt', N'	+01 - 123 - 4567', N'web@support.com')
SET IDENTITY_INSERT [dbo].[Settings] OFF
GO
SET IDENTITY_INSERT [dbo].[SkillSets] ON 

INSERT [dbo].[SkillSets] ([Id], [Name], [Persentage]) VALUES (1, N'Adobe Photoshop', 94)
INSERT [dbo].[SkillSets] ([Id], [Name], [Persentage]) VALUES (2, N'HTML / WordPress', 92)
INSERT [dbo].[SkillSets] ([Id], [Name], [Persentage]) VALUES (19, N'Development', 86)
SET IDENTITY_INSERT [dbo].[SkillSets] OFF
GO
SET IDENTITY_INSERT [dbo].[Sliders] ON 

INSERT [dbo].[Sliders] ([Id], [Title], [SubTitle], [Desc], [Image], [UpTitle]) VALUES (1, N'Leading Design', N'Our Trax', N'Is a New Design Studio founded in NewYork', N'banner6.jpg', N'We Make')
INSERT [dbo].[Sliders] ([Id], [Title], [SubTitle], [Desc], [Image], [UpTitle]) VALUES (2, N'Creative Business', N'In Market', N'The Best Multipurpose Multi Page Template in Market', N'banner8.jpg', N'The Ultimate')
INSERT [dbo].[Sliders] ([Id], [Title], [SubTitle], [Desc], [Image], [UpTitle]) VALUES (3, N'Deep Creativity', N'In Market', N'Responsive and Retina Ready for All Devices', N'banner7.jpg', N'Let''s Create')
SET IDENTITY_INSERT [dbo].[Sliders] OFF
GO
SET IDENTITY_INSERT [dbo].[Universal] ON 

INSERT [dbo].[Universal] ([Id], [Title], [Subtitle], [Desc], [Image], [Section], [UpTitle]) VALUES (1, N'Inspires Us To Make', N'Great Works', N'The Best Multipurpose Template In Market
', N'bg-about-header.jpg', N'AboutHeader', N'Great Works')
INSERT [dbo].[Universal] ([Id], [Title], [Subtitle], [Desc], [Image], [Section], [UpTitle]) VALUES (2, N'The Job Free Income', N'With Blog', N'The Best Multipurpose Template in Market', NULL, N'BlogInHeader', N'Let''s Get')
INSERT [dbo].[Universal] ([Id], [Title], [Subtitle], [Desc], [Image], [Section], [UpTitle]) VALUES (3, N'Most Popular Blogs', N'In The Market', N'The Best Multipurpose Parallax Template', NULL, N'BlogDeHeader', N'One Of The')
INSERT [dbo].[Universal] ([Id], [Title], [Subtitle], [Desc], [Image], [Section], [UpTitle]) VALUES (4, N'To Our Portfolio Work', N'Let''s Build', N'It More Creative With Your Slight Attention', NULL, N'GalleryHeader', N'Welcome')
INSERT [dbo].[Universal] ([Id], [Title], [Subtitle], [Desc], [Image], [Section], [UpTitle]) VALUES (5, NULL, NULL, N'We''d Love To Here From You.', NULL, N'ContactHeader', N'Contact Us')
INSERT [dbo].[Universal] ([Id], [Title], [Subtitle], [Desc], [Image], [Section], [UpTitle]) VALUES (6, N'Business', N'to Next Level', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc mauris arcu, lobortis id interdum vitae, interdum eget elit. Curabitur quis urna nulla. Suspendisse potenti. Duis suscipit ultrices maximus.

Learn More', N'awesome-feature.png', N'Business', N'Lets take your')
INSERT [dbo].[Universal] ([Id], [Title], [Subtitle], [Desc], [Image], [Section], [UpTitle]) VALUES (7, N'Mobile App Designs', NULL, N'Curabitur mollis bibendum luctus. Duis suscipit vitae dui sed suscipit. Vestibulum auctor nunc vitae diam eleifend, in maximus metus sollicitudin. Quisque vitae sodales lectus.', NULL, N'Mobile', N'Quisque tellus risus, adipisci viverra')
INSERT [dbo].[Universal] ([Id], [Title], [Subtitle], [Desc], [Image], [Section], [UpTitle]) VALUES (8, N'Meet Our Experts', NULL, N'Curabitur mollis bibendum luctus. Duis suscipit vitae dui sed suscipit. Vestibulum auctor nunc vitae diam eleifend, in maximus metus sollicitudin. Quisque vitae sodales lectus.', NULL, N'Team', N'Quisque tellus risus, adipisci')
INSERT [dbo].[Universal] ([Id], [Title], [Subtitle], [Desc], [Image], [Section], [UpTitle]) VALUES (9, N'Pricing Offers', NULL, NULL, NULL, N'Pricing', N'Quisque tellus risus, adipisci')
INSERT [dbo].[Universal] ([Id], [Title], [Subtitle], [Desc], [Image], [Section], [UpTitle]) VALUES (10, N'What People Say', NULL, NULL, NULL, N'PeopleSays', N'Quisque tellus risus, adipisci')
INSERT [dbo].[Universal] ([Id], [Title], [Subtitle], [Desc], [Image], [Section], [UpTitle]) VALUES (11, NULL, NULL, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc mauris arcu, lobortis id interdum vitae, interdum eget elit. Curabitur quis urna nulla. Suspendisse potenti. Duis suscipit ultrices maximus.', NULL, N'SkillSets', N'The Best Skillset Available in')
SET IDENTITY_INSERT [dbo].[Universal] OFF
GO
