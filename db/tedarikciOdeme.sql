/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [tedarikciID]
      ,[odemeMiktar]
      ,[odemeTarih]
  FROM [omuGross].[dbo].[tedarikciOdeme]