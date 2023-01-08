/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [urunID]
      ,[urunAd]
      ,[urunFiyat]
      ,[barkodNo]
  FROM [omuGross].[dbo].[urun]