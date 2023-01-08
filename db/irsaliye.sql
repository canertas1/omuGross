/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [irsaliyeNo]
      ,[urunID]
      ,[tedarikciID]
      ,[urunGirdiMiktar]
      ,[urunGirdiFiyat]
  FROM [omuGross].[dbo].[irsaliye]