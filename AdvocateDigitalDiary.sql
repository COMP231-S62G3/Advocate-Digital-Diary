USE [master]
GO
/****** Object:  Database [Advocate Digital Diary]    Script Date: 12/7/2014 6:56:44 PM ******/
CREATE DATABASE [Advocate Digital Diary]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'advocate', FILENAME = N'F:\Advocate''s Digital Diary\Advocate''s Digital Diary\advocate.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'advocate_log', FILENAME = N'F:\Advocate''s Digital Diary\Advocate''s Digital Diary\advocate_log.LDF' , SIZE = 3456KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Advocate Digital Diary] SET COMPATIBILITY_LEVEL = 90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Advocate Digital Diary].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Advocate Digital Diary] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Advocate Digital Diary] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Advocate Digital Diary] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Advocate Digital Diary] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Advocate Digital Diary] SET ARITHABORT OFF 
GO
ALTER DATABASE [Advocate Digital Diary] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Advocate Digital Diary] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Advocate Digital Diary] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Advocate Digital Diary] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Advocate Digital Diary] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Advocate Digital Diary] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Advocate Digital Diary] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Advocate Digital Diary] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Advocate Digital Diary] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Advocate Digital Diary] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Advocate Digital Diary] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Advocate Digital Diary] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Advocate Digital Diary] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Advocate Digital Diary] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Advocate Digital Diary] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Advocate Digital Diary] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Advocate Digital Diary] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Advocate Digital Diary] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Advocate Digital Diary] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Advocate Digital Diary] SET  MULTI_USER 
GO
ALTER DATABASE [Advocate Digital Diary] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Advocate Digital Diary] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Advocate Digital Diary] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Advocate Digital Diary] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Advocate Digital Diary]
GO
/****** Object:  StoredProcedure [dbo].[addacase]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[addacase] @title varchar(20), @filedate datetime, @courtid int, @judgeid int,@casetypeid int,@description varchar(100)
as 
begin
insert into cases values(@title, @filedate, @courtid,@judgeid,@casetypeid,@description)
end
GO
/****** Object:  StoredProcedure [dbo].[addact]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[addact] @Name varchar(20), @Description varchar(100)  
as  
begin  
insert into acts values(@Name,@Description)  
end
GO
/****** Object:  StoredProcedure [dbo].[addCase]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[addCase] @title varchar(20),@FileDate datetime,@CourtId int, @JudgeId int, @CaseTypeId int, @Description varchar(100) , @CaseNo int output
as  
begin  
	insert into cases values(@title,@FileDate,@CourtId,@JudgeId,@CaseTypeId,@Description)

	set @CaseNo=Scope_Identity()
  
end
GO
/****** Object:  StoredProcedure [dbo].[addcasetype]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[addcasetype] @Name varchar(30), @Description varchar(100)  
as  
begin  
insert into casetype values(@Name, @Description)  
end
GO
/****** Object:  StoredProcedure [dbo].[addcourt]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[addcourt] @Name varchar(30), @State varchar(30), @City varchar(30), @Description varchar(100)  
as   
begin  
insert into courts values(@Name, @State, @City, @Description)  
end
GO
/****** Object:  StoredProcedure [dbo].[Adddate]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Adddate] @Date datetime,@Description varchar(100),@CaseId int output
as
begin 
insert into HearingDates values(@Date,@Description,@CaseId)
set @CaseId = Scope_Identity()
end
GO
/****** Object:  StoredProcedure [dbo].[Adddefendant]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Adddefendant] @Name varchar(20),@Address varchar(20), @City varchar(20), @Pin int,@Phone int,@CaseNo int     
as       
begin      
insert into defendant values(@Name ,@Address , @City , @Pin,@Phone,@CaseNo)      
end

GO
/****** Object:  StoredProcedure [dbo].[AddDocument]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddDocument] @Name Varchar(20), @ReceivingDate datetime,@Description varchar(100),@CaseId int output
as
begin 
insert into Documents values(@Name,@ReceivingDate,@Description,@CaseId)
set @CaseId = Scope_Identity()
end
GO
/****** Object:  StoredProcedure [dbo].[addjudge]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[addjudge] @Name varchar(30), @Address varchar(50), @Gender varchar(10), @Phone int  
as   
begin  
insert into judge values(@Name, @Address, @Gender, @Phone)  
end
GO
/****** Object:  StoredProcedure [dbo].[Addparty]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Addparty] @Name varchar(20),@Address varchar(50), @City varchar(20), @PinCode int,@PhoneNo int, @PartyType int,@CaseId int
as 
begin
insert into Parties values(@Name ,@Address , @City , @PinCode,@PhoneNo, @PartyType,@CaseId)
end
GO
/****** Object:  StoredProcedure [dbo].[AddPayment]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddPayment] @Date datetime,@Amount float,@Mode varchar(20),@ParticularNo Varchar(20),@Bank Varchar(20),@CaseId int output
as
begin 
insert into Payments values(@Date,@Amount,@Mode, @ParticularNo,@Bank,@CaseId)
set @CaseId = Scope_Identity()
end
GO
/****** Object:  StoredProcedure [dbo].[AddPlantiff]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddPlantiff] @Name varchar(20),@Address varchar(20), @City varchar(20), @Pin int,@Phone int, @CaseNo int
as       
begin      
insert into Plantiff values(@Name ,@Address , @City , @Pin,@Phone,@CaseNo)      
end
GO
/****** Object:  StoredProcedure [dbo].[addstatement]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[addstatement] @statement varchar(200), @hearingdateno int,@witnessno int  
as  
begin  
insert into statements values(@statement,@witnessno,@Hearingdateno)  
end
GO
/****** Object:  StoredProcedure [dbo].[adduser]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[adduser] @username varchar(20), @password varchar(20)
as
begin
insert into login values(@username, @password)
end
GO
/****** Object:  StoredProcedure [dbo].[addusers]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[addusers] @userid varchar(20),@Password varchar(20),@Name varchar(20),@UserType varchar(20),@Permissions varchar(20)
as
begin
insert into users values(@userid,@password,@name,@Usertype,@permissions)
end
GO
/****** Object:  StoredProcedure [dbo].[AddWitness]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddWitness] @Name varchar(20),@Address varchar(50), @City varchar(20), @Pin int,@Phone int, @CaseId int output
as       
begin      
insert into Witnesses values(@Name ,@Address , @City , @Pin,@Phone,@CaseId)
set @CaseId = scope_identity()
end
GO
/****** Object:  StoredProcedure [dbo].[AuthenticateUser]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AuthenticateUser] @UserId varchar(20), @Password varchar(20)
as
begin
select * from users where UserId = @UserId and Password = @Password
end
GO
/****** Object:  StoredProcedure [dbo].[caseid]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[caseid]
as
begin
select caseid from cases
end
GO
/****** Object:  StoredProcedure [dbo].[deleteACase]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteACase] @CaseId int
as
begin
delete from cases where CaseId = @CaseId
end
GO
/****** Object:  StoredProcedure [dbo].[deleteact]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteact] @actid int
as
begin
delete from acts where actid = @actid
end
GO
/****** Object:  StoredProcedure [dbo].[deletecase]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deletecase] @casetypeid int
as
begin
delete from casetype where casetypeid = @casetypeid
end
GO
/****** Object:  StoredProcedure [dbo].[deletecasetype]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deletecasetype] @casetypeid int
as
begin
delete from casetype where casetypeid = @casetypeid
end
GO
/****** Object:  StoredProcedure [dbo].[deletecourt]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deletecourt] @courtid int
as
begin
delete from courts where courtid = @courtid
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteDate]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteDate] @HearingDateNo int
as
begin
delete from HearingDates where HearingDateNo = @HearingDateNo
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteDefendant]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteDefendant] @DefendantId int    
as    
begin    
delete from Defendant where DefendantId = @DefendantId    
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteDocument]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteDocument] @DocumentNo int
as
begin
delete from Documents where DocumentNo = @DocumentNo
end
GO
/****** Object:  StoredProcedure [dbo].[deletejudge]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deletejudge] @judgeid int
as
begin
delete from judge where judgeid = @judgeid
end
GO
/****** Object:  StoredProcedure [dbo].[deleteParty]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteParty] @PartyNo int
as
begin
delete from Parties where PartyNo = @PartyNo
end
GO
/****** Object:  StoredProcedure [dbo].[DeletePayment]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeletePayment] @PaymentNo int
as
begin
delete from Payments where PaymentNo = @PaymentNo
end
GO
/****** Object:  StoredProcedure [dbo].[DeletePlantiff]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeletePlantiff] @PlantiffId int  
as  
begin  
delete from Plantiff where PlantiffId = @PlantiffId  
end
GO
/****** Object:  StoredProcedure [dbo].[deletestatement]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deletestatement] @Statementno int
as
begin
delete from statements where statementno = @statementno
end
GO
/****** Object:  StoredProcedure [dbo].[deleteuser]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteuser] @Userno int
as
begin
delete from users where userno = @userno
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteWitness]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteWitness] @WitnessNo int
as
begin
delete from Witnesses where WitnessNo = @WitnessNo
end
GO
/****** Object:  StoredProcedure [dbo].[GetACase]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetACase] @CaseId int  
as  
begin  
select * from cases where CaseId = @CaseId  
end
GO
/****** Object:  StoredProcedure [dbo].[getact]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getact] @actid int
as
begin
select * from acts where actid = @actid
end
GO
/****** Object:  StoredProcedure [dbo].[getacts]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getacts]
as
begin
select * from acts
end
GO
/****** Object:  StoredProcedure [dbo].[GetAllCase]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllCase] 
as
begin
select C.CAseID, c.Title,convert(varchar,c.filedate,106) as [FileDate],o.name as [Court Name],j.name as [Judge Name],a.name as[Case Type],c.description from cases as [c],courts as [o],judge as [j],casetype as [a] where c.courtid = o.courtid and c.judgeid = j.judgeid and c.casetypeid = a.casetypeid
end
GO
/****** Object:  StoredProcedure [dbo].[GetAllCases]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllCases]
as
begin
select * from cases
end
GO
/****** Object:  StoredProcedure [dbo].[GetAllDates]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllDates]
as
begin
select h.HearingDateNo,h.Date,h.Description,c.Title from HearingDates as [h],cases as [c] where h.caseid = c.caseid
end
GO
/****** Object:  StoredProcedure [dbo].[GetAllDefendant]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllDefendant]  
as  
begin  
select * from Defendant  
end
GO
/****** Object:  StoredProcedure [dbo].[GetAllDocument]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllDocument] @Caseid int    
as    
begin    
select d.DocumentNo,d.Name,convert(varchar,d.ReceivingDate,103) as [ReceivingDate],d.Description,c.Title from documents as [d],cases as [c] where d.caseid = c.caseid and d.caseId = @caseid   
end
GO
/****** Object:  StoredProcedure [dbo].[GetAllDocuments]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllDocuments]
as
begin
select * from Documents
end
GO
/****** Object:  StoredProcedure [dbo].[GetAllParties]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllParties]
as
begin
select * from Parties
end
GO
/****** Object:  StoredProcedure [dbo].[GetAllPartyType]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllPartyType]
as
begin
select * from PartyType
end
GO
/****** Object:  StoredProcedure [dbo].[GetAllPayment]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllPayment] @Caseid int
as
begin
select d.PaymentNo,d.Date,d.Amount,d.Mode,d.ParticularNo,d.Bank,c.Title from Payments as [d],cases as [c] where d.caseid = c.caseid
end
GO
/****** Object:  StoredProcedure [dbo].[GetAllPayments]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllPayments]
as
begin
select * from Payments
end
GO
/****** Object:  StoredProcedure [dbo].[GetAllPlantiff]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllPlantiff]  
as  
begin  
select * from Plantiff  
end
GO
/****** Object:  StoredProcedure [dbo].[getallstatement]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getallstatement] 
as
begin
select * from statements
end
GO
/****** Object:  StoredProcedure [dbo].[getallusers]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getallusers]
as
begin
select * from users
end
GO
/****** Object:  StoredProcedure [dbo].[GetAllWitnesses]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllWitnesses]  
as  
begin  
select w.WitnessNo,w.Name,w.Address,w.City,w.Pin as [Pin Code], w.Phone as [Phone No],c.Title as [Case] from Witnesses as [w],Cases as[c] where w.caseid = c.caseid  
end
GO
/****** Object:  StoredProcedure [dbo].[GetAParty]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAParty] @PartyTypeId int
as
begin
select * from PartyType where PartyTypeId = @PartyTypeId
end
GO
/****** Object:  StoredProcedure [dbo].[getawitness]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getawitness] @Caseid int
as
begin
select witnessno,name from witnesses where caseid =@caseid 
end
GO
/****** Object:  StoredProcedure [dbo].[getcase]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getcase] @casetypeid int
as
begin
select * from casetype where casetypeid = @casetypeid
end
GO
/****** Object:  StoredProcedure [dbo].[getcases]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getcases] 
as 
begin
select *from casetype
end
GO
/****** Object:  StoredProcedure [dbo].[getcasetype]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getcasetype] @casetypeid int
as
begin
select * from casetype where casetypeid = @casetypeid
end
GO
/****** Object:  StoredProcedure [dbo].[getcasetypes]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getcasetypes]
as
begin
select * from casetype
end
GO
/****** Object:  StoredProcedure [dbo].[getcourt]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getcourt] @courtid int
as
begin
select * from courts where courtid = @courtid
end
GO
/****** Object:  StoredProcedure [dbo].[getcourts]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getcourts] 
as 
begin
select *from courts
end
GO
/****** Object:  StoredProcedure [dbo].[GetDate]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetDate] @CaseId int  
as  
begin  
select h.HearingDateNo,convert(varchar,h.Date,103) as [Date],h.Description,c.Title from HearingDates as [h],cases as [c] where h.caseid = c.caseid and h.CaseId = @caseId  
end
GO
/****** Object:  StoredProcedure [dbo].[GetDefendant]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetDefendant] @DefendantId int    
as    
begin    
select * from Defendant where DefendantId = @DefendantId    
end
GO
/****** Object:  StoredProcedure [dbo].[GetDefendants]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[GetDefendants] @CaseNo int
As
Begin
	Select * From Defendant Where CaseNo=@CaseNo
End
GO
/****** Object:  StoredProcedure [dbo].[GetDetailForCase]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetDetailForCase] @CaseId int    
as    
begin    
select c.CaseId,c.Title,convert(varchar, c.FileDate,103 ) as [File Date],o.Name as [Court Name],j.name as [Judge Name],a.name as [Case Type],c.description from cases as [c], Courts as [o], CaseType as [a], judge as [j] where c.CaseId = @CaseId and c.judgeid = j.judgeid and c.courtid = o.courtid and c.casetypeid = a.casetypeid   
end
GO
/****** Object:  StoredProcedure [dbo].[GetDocument]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetDocument] @DocumentNo int
as
begin
select * from Documents where DocumentNo = @DocumentNo
end
GO
/****** Object:  StoredProcedure [dbo].[getjudge]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getjudge] @judgeid int
as
begin
select * from judge where judgeid = @judgeid
end
GO
/****** Object:  StoredProcedure [dbo].[getjudges]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getjudges] 
as 
begin
select *from judge
end

GO
/****** Object:  StoredProcedure [dbo].[GetParty]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetParty] @PartyNo int
as
begin
select * from Parties where PartyNo = @PartyNo
end 
GO
/****** Object:  StoredProcedure [dbo].[GetPayment]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetPayment] @CaseId int  
as  
begin  
select convert(varchar, P.Date,103) as [Date],P.Amount,P.Bank,P.ParticularNo,P.Mode,P.PaymentNo,C.CaseId from Payments as [P],Cases as [C] where P.CaseId = C.CaseId  
end
GO
/****** Object:  StoredProcedure [dbo].[GetPlaintiffs]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[GetPlaintiffs] @CaseNo int
As
Begin
	Select * From Plantiff Where CaseNo=@CaseNo
End
GO
/****** Object:  StoredProcedure [dbo].[GetPlantiff]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetPlantiff] @PlantiffId int  
as  
begin  
select * from Plantiff where PlantiffId = @PlantiffId  
end 
GO
/****** Object:  StoredProcedure [dbo].[getstatement]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getstatement] @statementno int
as
begin 
select * from statements where statementno = @statementno
end
GO
/****** Object:  StoredProcedure [dbo].[getstatementforhearingdate]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getstatementforhearingdate] @hearingdateno int
as
begin 
select * from statements where hearingdateno = @hearingdateno
end
GO
/****** Object:  StoredProcedure [dbo].[getuser]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getuser] @userno int
as
begin
select * from users where userno = @userno
end
GO
/****** Object:  StoredProcedure [dbo].[GetWitness]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetWitness] @WitnessNo int
as
begin
select * from Witnesses where WitnessNo = @WitnessNo
end
GO
/****** Object:  StoredProcedure [dbo].[GetWitnesses]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetWitnesses] @CaseId int 
as
begin
select w.WitnessNo,w.Name,w.Address,w.City,w.Pin as [Pin Code], w.Phone as [Phone No.],c.Title as [Case] from Witnesses as [w],Cases as[c] where w.caseid = c.caseid
end
GO
/****** Object:  StoredProcedure [dbo].[GetWitnesses2]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetWitnesses2] @CaseId int 
as
begin
select w.WitnessNo,w.Name,w.Address,w.City,w.Pin as [Pin Code], w.Phone as [Phone No.],c.Title as [Case] from Witnesses as [w],Cases as[c] where w.caseid = c.caseid and w.caseid = @caseid
end
GO
/****** Object:  StoredProcedure [dbo].[GetWitnessesforhearings]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetWitnessesforhearings] @CaseId int
as
begin
select w.WitnessNo,w.Name,w.Address,w.City,w.Pin as [Pin Code], w.Phone as [Phone No.] from Witnesses as [w],hearingdates as[h] where w.caseid = h.caseid and w.caseid = @caseid
end
GO
/****** Object:  StoredProcedure [dbo].[GetWitnessStatements]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[GetWitnessStatements] @WitnessNo int
as
Begin
	Select * From Statements Where WitnessNo=@WitnessNo
End
GO
/****** Object:  StoredProcedure [dbo].[showCaseType]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[showCaseType] @casetypename varchar(20)
as 
begin
select * from casetype where casetypename = @casetypename
end
GO
/****** Object:  StoredProcedure [dbo].[upcoming]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[upcoming]
as
begin
select c.title as [Case],convert(varchar,h.date,103) as [Date] from hearingdates as [h],cases as [c] where date between getdate() and dateadd(month,1,getdate()) and c.caseid = h.caseid
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateACase]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateACase] @CaseId int, @Title varchar(20), @FileDate datetime, @CourtId int,@JudgeId int,@CasetypeId int, @Description varchar(100)  
as   
begin  
update cases set Title = @Title, FileDate = @FileDate, CourtId = @CourtId,JudgeId = @JudgeId,CasetypeId = @CasetypeId, Description = @Description where CaseId = @CaseId  
end
GO
/****** Object:  StoredProcedure [dbo].[updateact]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateact] @actid int, @Name varchar(20), @Description varchar(100)  
as  
begin  
update acts set Name = @Name, description = @Description where actid = @actid  
end
GO
/****** Object:  StoredProcedure [dbo].[updatecase]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updatecase] @casetypeid int, @casetypename varchar(30), @casetypedescription varchar(100)
as 
begin
update casetype set casetypename = @casetypename, casetypedescription = @casetypedescription
end
GO
/****** Object:  StoredProcedure [dbo].[updatecasetype]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updatecasetype] @casetypeid int, @Name varchar(30), @Description varchar(100)  
as  
begin  
update casetype set Name = @Name, Description = @Description where casetypeid = @casetypeid  
end
GO
/****** Object:  StoredProcedure [dbo].[updatecourt]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updatecourt] @courtid int, @Name varchar(30), @State varchar(30), @City varchar(30), @Description varchar(100)  
as   
begin  
update courts set Name = @Name, State = @State, City = @City, Description = @Description where courtid = @courtid  
end

GO
/****** Object:  StoredProcedure [dbo].[UpdateDate]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[UpdateDate] @HearingDateNo int, @Date datetime,@Description varchar(100), @CaseId int 
as
begin
update HearingDates set Date = @Date,Description = @Description,CaseId = @CaseId where HearingDateNo = @HearingDateNo
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateDefendant]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateDefendant] @DefendantId int,@Name varchar(20),@Address varchar(50), @City varchar(20), @Pin int,@Phone int      
as      
begin      
update Defendant set Name = @Name ,Address = @Address ,City = @City ,Pin = @Pin,Phone = @Phone where DefendantId = @DefendantId      
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateDocument]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[UpdateDocument] @DocumentNo int, @Name Varchar(20), @ReceivingDate datetime,@Description varchar(100),@CaseId int 
as
begin
update Documents set Name = @Name,ReceivingDate = @ReceivingDate,Description = @Description,CaseId = @CaseId where DocumentNo = @DocumentNo
end
GO
/****** Object:  StoredProcedure [dbo].[updatejudge]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updatejudge] @judgeid int, @Name varchar(30), @Address varchar(50), @Gender varchar(10), @Phone int    
as     
begin    
update judge set Name = @Name, Address = @Address, Gender = @Gender, Phone = @Phone where judgeid = @judgeid   
end
GO
/****** Object:  StoredProcedure [dbo].[updateParty]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateParty] @PartyNo int,@Name varchar(20),@Address varchar(50), @City varchar(20), @PinCode int,@PhoneNo int, @PartyType int,@CaseId int
as
begin
update Parties set Name = @Name ,Address = @Address ,City = @City ,pinCode = @PinCode,PhoneNo = @PhoneNo,PartyType = @PartyType,CaseId = @CaseId where PartyNo = @PartyNo
end
GO
/****** Object:  StoredProcedure [dbo].[UpdatePayment]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[UpdatePayment] @PaymentNo int, @Date datetime,@Amount float,@Mode varchar(20),@ParticularNo Varchar(20),@Bank Varchar(20),@CaseId int 
as
begin
update Payments set Date = @Date,Amount = @Amount,Mode = @Mode,ParticularNo = @ParticularNo,Bank = @Bank where PaymentNo = @PaymentNo
end
GO
/****** Object:  StoredProcedure [dbo].[UpdatePlantiff]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[UpdatePlantiff] @PlaintiffId int, @Name Varchar(20), @Address varchar(20),@City varchar(20),@Pin int,@Phone int 
as
begin
update Plantiff set Name = @Name,Address = @Address,City = @City,Pin = @Pin,Phone = @Phone where PlaintiffId = @PlaintiffId
end
GO
/****** Object:  StoredProcedure [dbo].[Updatestatement]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Updatestatement] @statementNo int, @statement varchar(200),@Hearingdateno int,@WitnessNo int
as
begin
update statements set statement = @statement,Hearingdateno = @Hearingdateno,witnessno = @WitnessNo
end
GO
/****** Object:  StoredProcedure [dbo].[updateuser]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateuser] @userno int,@userid varchar(20),@password varchar(20),@name varchar(20),@Usertype varchar(20),@permissions varchar(20)
as
begin
update users set userid = @userid,password = @password,name = @name,usertype = @Usertype,permissions = @permissions where userno = @userno
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateWitness]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[UpdateWitness] @WitnessNo int, @Name varchar(20),@Address varchar(50), @City varchar(20), @Pin int,@Phone int, @CaseId int 
as
begin
update witnesses set Name = @Name,Address = @Address,City = @City,Pin = @Pin,Phone = @Phone,CaseId = @CaseId where WitnessNo = @WitnessNo
end

GO
/****** Object:  Table [dbo].[acts]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acts](
	[actid] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NULL,
	[Description] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CaseMaster]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CaseMaster](
	[CaseId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](20) NULL,
	[FileDate] [datetime] NULL,
	[CourtId] [int] NULL,
	[JudgeId] [int] NULL,
	[CaseTypeId] [int] NULL,
	[Description] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[CaseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cases]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cases](
	[CaseId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](20) NULL,
	[FileDate] [datetime] NULL,
	[CourtId] [int] NULL,
	[JudgeId] [int] NULL,
	[CaseTypeId] [int] NULL,
	[Description] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[CaseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[casetype]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[casetype](
	[casetypeid] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](30) NULL,
	[Description] [varchar](100) NULL,
 CONSTRAINT [chk2] PRIMARY KEY CLUSTERED 
(
	[casetypeid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[courts]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[courts](
	[courtid] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](30) NULL,
	[State] [varchar](30) NULL,
	[City] [varchar](30) NULL,
	[Description] [varchar](100) NULL,
 CONSTRAINT [chk1] PRIMARY KEY CLUSTERED 
(
	[courtid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Defendant]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Defendant](
	[DefendantId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NULL,
	[Address] [varchar](20) NULL,
	[City] [varchar](20) NULL,
	[Pin] [int] NULL,
	[Phone] [int] NULL,
	[CaseNo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[DefendantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Documents]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Documents](
	[DocumentNo] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NULL,
	[ReceivingDate] [datetime] NULL,
	[Description] [varchar](100) NULL,
	[CaseId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[DocumentNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HearingDates]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HearingDates](
	[HearingDateNo] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NULL,
	[description] [varchar](100) NULL,
	[CaseId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[HearingDateNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[judge]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[judge](
	[judgeid] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](30) NULL,
	[Address] [varchar](50) NULL,
	[Gender] [varchar](10) NULL,
	[Phone] [int] NULL,
 CONSTRAINT [chk3] PRIMARY KEY CLUSTERED 
(
	[judgeid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[login]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[login](
	[username] [varchar](20) NULL,
	[password] [varchar](20) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Payments]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Payments](
	[PaymentNo] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NULL,
	[Amount] [float] NULL,
	[Mode] [varchar](20) NULL,
	[ParticularNo] [varchar](20) NULL,
	[Bank] [varchar](20) NULL,
	[CaseId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PaymentNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Plantiff]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Plantiff](
	[PlaintiffId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NULL,
	[Address] [varchar](20) NULL,
	[City] [varchar](20) NULL,
	[Pin] [int] NULL,
	[Phone] [int] NULL,
	[CaseNo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PlaintiffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Statements]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Statements](
	[statementno] [int] IDENTITY(1,1) NOT NULL,
	[statement] [varchar](200) NULL,
	[witnessno] [int] NULL,
	[hearingdateno] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[statementno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[users]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[users](
	[UserNo] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [varchar](20) NULL,
	[Password] [varchar](20) NULL,
	[Name] [varchar](20) NULL,
	[Usertype] [varchar](20) NULL,
	[Permissions] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Witnesses]    Script Date: 12/7/2014 6:56:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Witnesses](
	[WitnessNo] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NULL,
	[Address] [varchar](50) NULL,
	[City] [varchar](20) NULL,
	[Pin] [int] NULL,
	[Phone] [int] NULL,
	[CaseId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[WitnessNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[acts] ON 

INSERT [dbo].[acts] ([actid], [Name], [Description]) VALUES (13, N'400', N'Murder Case')
INSERT [dbo].[acts] ([actid], [Name], [Description]) VALUES (14, N'350', N'Vandalism')
INSERT [dbo].[acts] ([actid], [Name], [Description]) VALUES (12, N'420', N'Fraud Case')
SET IDENTITY_INSERT [dbo].[acts] OFF
SET IDENTITY_INSERT [dbo].[Cases] ON 

INSERT [dbo].[Cases] ([CaseId], [Title], [FileDate], [CourtId], [JudgeId], [CaseTypeId], [Description]) VALUES (2, N'm vs s', CAST(0x00009F9000000000 AS DateTime), 39, 19, 20, N'')
INSERT [dbo].[Cases] ([CaseId], [Title], [FileDate], [CourtId], [JudgeId], [CaseTypeId], [Description]) VALUES (3, N'jwbhu', CAST(0x00009F9000000000 AS DateTime), 39, 19, 20, N'hjgvu')
INSERT [dbo].[Cases] ([CaseId], [Title], [FileDate], [CourtId], [JudgeId], [CaseTypeId], [Description]) VALUES (4, N's vs s', CAST(0x00009F9000000000 AS DateTime), 39, 19, 20, N'')
INSERT [dbo].[Cases] ([CaseId], [Title], [FileDate], [CourtId], [JudgeId], [CaseTypeId], [Description]) VALUES (6, N'abc', CAST(0x00009FA700000000 AS DateTime), 39, 19, 20, N'no desc')
SET IDENTITY_INSERT [dbo].[Cases] OFF
SET IDENTITY_INSERT [dbo].[casetype] ON 

INSERT [dbo].[casetype] ([casetypeid], [Name], [Description]) VALUES (20, N'MURDER', N'400')
INSERT [dbo].[casetype] ([casetypeid], [Name], [Description]) VALUES (21, N'FRAUD', N'420')
SET IDENTITY_INSERT [dbo].[casetype] OFF
SET IDENTITY_INSERT [dbo].[courts] ON 

INSERT [dbo].[courts] ([courtid], [Name], [State], [City], [Description]) VALUES (39, N'High Court', N'ON', N'Toronto', N'hc')
INSERT [dbo].[courts] ([courtid], [Name], [State], [City], [Description]) VALUES (41, N'Supreme Court', N'ON', N'Ottawa', N'sc')
SET IDENTITY_INSERT [dbo].[courts] OFF
SET IDENTITY_INSERT [dbo].[Defendant] ON 

INSERT [dbo].[Defendant] ([DefendantId], [Name], [Address], [City], [Pin], [Phone], [CaseNo]) VALUES (2, N'Johnson', N'sec 15', N'chd', 132, 13232, 2)
INSERT [dbo].[Defendant] ([DefendantId], [Name], [Address], [City], [Pin], [Phone], [CaseNo]) VALUES (3, N'yygtc', N'ycfyc', N'hfcgfc', 675, 65656, 3)
INSERT [dbo].[Defendant] ([DefendantId], [Name], [Address], [City], [Pin], [Phone], [CaseNo]) VALUES (4, N'Ford', N'mm nmj', N'n jnj', 87, 87, 4)
INSERT [dbo].[Defendant] ([DefendantId], [Name], [Address], [City], [Pin], [Phone], [CaseNo]) VALUES (5, N'Smith', N'sec 20', N'scrbgh', 12345, 98765, 6)
SET IDENTITY_INSERT [dbo].[Defendant] OFF
SET IDENTITY_INSERT [dbo].[Documents] ON 

INSERT [dbo].[Documents] ([DocumentNo], [Name], [ReceivingDate], [Description], [CaseId]) VALUES (1, N'no 1', CAST(0x00009FA400000000 AS DateTime), N'abc', 2)
INSERT [dbo].[Documents] ([DocumentNo], [Name], [ReceivingDate], [Description], [CaseId]) VALUES (2, N'no1', CAST(0x00009FA400000000 AS DateTime), N'asdf', 3)
SET IDENTITY_INSERT [dbo].[Documents] OFF
SET IDENTITY_INSERT [dbo].[HearingDates] ON 

INSERT [dbo].[HearingDates] ([HearingDateNo], [Date], [description], [CaseId]) VALUES (1, CAST(0x00009FA400000000 AS DateTime), N'No desc', 2)
INSERT [dbo].[HearingDates] ([HearingDateNo], [Date], [description], [CaseId]) VALUES (2, CAST(0x00009FA400000000 AS DateTime), N'zakkas', 3)
INSERT [dbo].[HearingDates] ([HearingDateNo], [Date], [description], [CaseId]) VALUES (3, CAST(0x00009FA700000000 AS DateTime), N'strmnt', 2)
INSERT [dbo].[HearingDates] ([HearingDateNo], [Date], [description], [CaseId]) VALUES (4, CAST(0x00009FBA00000000 AS DateTime), N'abc', 2)
INSERT [dbo].[HearingDates] ([HearingDateNo], [Date], [description], [CaseId]) VALUES (5, CAST(0x00009FB900000000 AS DateTime), N'zxas', 4)
INSERT [dbo].[HearingDates] ([HearingDateNo], [Date], [description], [CaseId]) VALUES (6, CAST(0x00009FC500000000 AS DateTime), N'dasdon', 3)
SET IDENTITY_INSERT [dbo].[HearingDates] OFF
SET IDENTITY_INSERT [dbo].[judge] ON 

INSERT [dbo].[judge] ([judgeid], [Name], [Address], [Gender], [Phone]) VALUES (19, N'Mr. Rob', N'North York', N'Male', 647566)
INSERT [dbo].[judge] ([judgeid], [Name], [Address], [Gender], [Phone]) VALUES (20, N'Mr. Smith', N'Missisauga', N'Male', 416444)
INSERT [dbo].[judge] ([judgeid], [Name], [Address], [Gender], [Phone]) VALUES (22, N'Mrs. Passe', N'Toronto', N'Female', 416777)
INSERT [dbo].[judge] ([judgeid], [Name], [Address], [Gender], [Phone]) VALUES (23, N'Mr. Attesse', N'Etobicoke', N'Male', 416952)
INSERT [dbo].[judge] ([judgeid], [Name], [Address], [Gender], [Phone]) VALUES (24, N'Mr. Patel', N'Scarborough', N'Male', 647123)
INSERT [dbo].[judge] ([judgeid], [Name], [Address], [Gender], [Phone]) VALUES (25, N'Ms. Parekh', N'Markham', N'Female', 647852)
SET IDENTITY_INSERT [dbo].[judge] OFF
INSERT [dbo].[login] ([username], [password]) VALUES (N'bijal', N'patel')
INSERT [dbo].[login] ([username], [password]) VALUES (N'heli', N'parekh')
INSERT [dbo].[login] ([username], [password]) VALUES (N'parimal', N'patel')
INSERT [dbo].[login] ([username], [password]) VALUES (N'vipul', N'patel')
INSERT [dbo].[login] ([username], [password]) VALUES (N'nazneen', N'jahan')
SET IDENTITY_INSERT [dbo].[Payments] ON 

INSERT [dbo].[Payments] ([PaymentNo], [Date], [Amount], [Mode], [ParticularNo], [Bank], [CaseId]) VALUES (1, CAST(0x00009F9100000000 AS DateTime), 5000, N'Cheque', N'544454', N'RBC', 2)
SET IDENTITY_INSERT [dbo].[Payments] OFF
SET IDENTITY_INSERT [dbo].[Plantiff] ON 

INSERT [dbo].[Plantiff] ([PlaintiffId], [Name], [Address], [City], [Pin], [Phone], [CaseNo]) VALUES (2, N'Patrick', N'moh', N'moh', 123, 12121, 2)
INSERT [dbo].[Plantiff] ([PlaintiffId], [Name], [Address], [City], [Pin], [Phone], [CaseNo]) VALUES (3, N'kjbfjh', N'hvghv', N'ghvchgcv', 556, 656, 3)
INSERT [dbo].[Plantiff] ([PlaintiffId], [Name], [Address], [City], [Pin], [Phone], [CaseNo]) VALUES (4, N'Mohhamed', N'chd', N'chd', 765757, 76776, 4)
INSERT [dbo].[Plantiff] ([PlaintiffId], [Name], [Address], [City], [Pin], [Phone], [CaseNo]) VALUES (6, N'Artem', N'UT', N'chd', 123455, 113334, 6)
SET IDENTITY_INSERT [dbo].[Plantiff] OFF
SET IDENTITY_INSERT [dbo].[Statements] ON 

INSERT [dbo].[Statements] ([statementno], [statement], [witnessno], [hearingdateno]) VALUES (7, N'How r u?', 1, 1)
INSERT [dbo].[Statements] ([statementno], [statement], [witnessno], [hearingdateno]) VALUES (8, N'fgdf', 1, 2)
INSERT [dbo].[Statements] ([statementno], [statement], [witnessno], [hearingdateno]) VALUES (9, N'fcvgfxg', 1, 2)
INSERT [dbo].[Statements] ([statementno], [statement], [witnessno], [hearingdateno]) VALUES (10, N'fcgvxfc', 1, 2)
INSERT [dbo].[Statements] ([statementno], [statement], [witnessno], [hearingdateno]) VALUES (11, N'dfvxdf', 1, 2)
INSERT [dbo].[Statements] ([statementno], [statement], [witnessno], [hearingdateno]) VALUES (12, N'hello', 1, 2)
INSERT [dbo].[Statements] ([statementno], [statement], [witnessno], [hearingdateno]) VALUES (13, N'hi', 1, 2)
INSERT [dbo].[Statements] ([statementno], [statement], [witnessno], [hearingdateno]) VALUES (14, N'sijdik', 1, 1)
INSERT [dbo].[Statements] ([statementno], [statement], [witnessno], [hearingdateno]) VALUES (15, N'ksjndk', 1, 2)
INSERT [dbo].[Statements] ([statementno], [statement], [witnessno], [hearingdateno]) VALUES (16, N'asd', 1, 1)
INSERT [dbo].[Statements] ([statementno], [statement], [witnessno], [hearingdateno]) VALUES (17, N'Hello World', 1, 2)
INSERT [dbo].[Statements] ([statementno], [statement], [witnessno], [hearingdateno]) VALUES (18, N'hello world', 2, 1)
INSERT [dbo].[Statements] ([statementno], [statement], [witnessno], [hearingdateno]) VALUES (19, N'hello', 4, 2)
SET IDENTITY_INSERT [dbo].[Statements] OFF
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([UserNo], [UserId], [Password], [Name], [Usertype], [Permissions]) VALUES (1, N'Admin', N'admin', N'Administrator', N'Admin', N'11010111')
INSERT [dbo].[users] ([UserNo], [UserId], [Password], [Name], [Usertype], [Permissions]) VALUES (3, N'bijal', N'patel', N'Bijal Patel', N'Admin', N'11010110')
INSERT [dbo].[users] ([UserNo], [UserId], [Password], [Name], [Usertype], [Permissions]) VALUES (5, N'vipul', N'patel', N'Vipul Patel', N'Normal', N'11010111')
INSERT [dbo].[users] ([UserNo], [UserId], [Password], [Name], [Usertype], [Permissions]) VALUES (6, N'heli', N'parekh', N'Heli Parekh', N'Normal', N'11010111')
SET IDENTITY_INSERT [dbo].[users] OFF
SET IDENTITY_INSERT [dbo].[Witnesses] ON 

INSERT [dbo].[Witnesses] ([WitnessNo], [Name], [Address], [City], [Pin], [Phone], [CaseId]) VALUES (1, N'Randy', N'phase-7', N'mohali', 132345, 987654, 2)
INSERT [dbo].[Witnesses] ([WitnessNo], [Name], [Address], [City], [Pin], [Phone], [CaseId]) VALUES (2, N'Sandy', N'up', N'lacknow', 12345, 98765, 2)
INSERT [dbo].[Witnesses] ([WitnessNo], [Name], [Address], [City], [Pin], [Phone], [CaseId]) VALUES (3, N'manu', N'punjab', N'patiala', 324567, 9876, 2)
INSERT [dbo].[Witnesses] ([WitnessNo], [Name], [Address], [City], [Pin], [Phone], [CaseId]) VALUES (4, N'Mandy', N'pb', N'moh', 123432, 98765, 3)
SET IDENTITY_INSERT [dbo].[Witnesses] OFF
ALTER TABLE [dbo].[CaseMaster]  WITH CHECK ADD FOREIGN KEY([CaseTypeId])
REFERENCES [dbo].[casetype] ([casetypeid])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CaseMaster]  WITH CHECK ADD FOREIGN KEY([CourtId])
REFERENCES [dbo].[courts] ([courtid])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CaseMaster]  WITH CHECK ADD FOREIGN KEY([JudgeId])
REFERENCES [dbo].[judge] ([judgeid])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cases]  WITH CHECK ADD FOREIGN KEY([CaseTypeId])
REFERENCES [dbo].[casetype] ([casetypeid])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cases]  WITH CHECK ADD FOREIGN KEY([CourtId])
REFERENCES [dbo].[courts] ([courtid])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cases]  WITH CHECK ADD FOREIGN KEY([JudgeId])
REFERENCES [dbo].[judge] ([judgeid])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Defendant]  WITH CHECK ADD FOREIGN KEY([CaseNo])
REFERENCES [dbo].[Cases] ([CaseId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Documents]  WITH CHECK ADD FOREIGN KEY([CaseId])
REFERENCES [dbo].[Cases] ([CaseId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HearingDates]  WITH CHECK ADD FOREIGN KEY([CaseId])
REFERENCES [dbo].[Cases] ([CaseId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD FOREIGN KEY([CaseId])
REFERENCES [dbo].[Cases] ([CaseId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Plantiff]  WITH CHECK ADD FOREIGN KEY([CaseNo])
REFERENCES [dbo].[Cases] ([CaseId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Statements]  WITH CHECK ADD FOREIGN KEY([hearingdateno])
REFERENCES [dbo].[HearingDates] ([HearingDateNo])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Statements]  WITH CHECK ADD FOREIGN KEY([witnessno])
REFERENCES [dbo].[Witnesses] ([WitnessNo])
GO
ALTER TABLE [dbo].[Witnesses]  WITH CHECK ADD FOREIGN KEY([CaseId])
REFERENCES [dbo].[Cases] ([CaseId])
ON DELETE CASCADE
GO
USE [master]
GO
ALTER DATABASE [Advocate Digital Diary] SET  READ_WRITE 
GO
