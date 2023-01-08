/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [id]
      ,[odemeMiktari]
      ,[odemeTarihi]
      ,[musteriID]
  FROM [omuGross].[dbo].[musteriOdeme]