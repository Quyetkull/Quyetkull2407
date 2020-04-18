create database QuanLyChiTieu2
go

use QuanLyChiTieu2
go

--account
create table Account
(
	--id int identity primary key,
	--DisplayName nvarchar(100) not null,
	--UserName nvarchar(100) not null,
	--PassWord nvarchar(1000) not null,
	--Type int not null	
	UserName nvarchar(100) primary key,
	DisplayName nvarchar(100) not null default N'Chưa đặt tên',
	PassWord nvarchar(1000) not null default 0,
	Type int not null default 0 --1:admin & 0:user
)
go

insert into dbo.Account
(
	UserName,
	DisplayName,
	PassWord,
	Type
)
values 
(
	N'admin',  --UserName
	N'admin',  --DisplayName
	N'admin',  --PassWord
	1	  --Type
)		
go

insert into dbo.Account
(
	UserName,
	DisplayName,
	PassWord,
	Type
)
values 
(
	N'linhxinh',  --UserName
	N'Linhxinh',  --DisplayName
	N'1',  --PassWord
	0	  --Type
)		
go

create proc USP_GetAccountByUserName
@userName nvarchar(100)
as
begin
	select * from dbo.Account where UserName = @userName
end
go

exec dbo.USP_GetAccountByUserName @userName = N'admin' --nvarchar(100)
go

create proc USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
as
begin
	select * from dbo.Account where UserName = @userName and PassWord = @passWord
end
go

create proc USP_UpdateAccount
@userName nvarchar(100), @displayName nvarchar(100), @password nvarchar(100), @newPassword nvarchar(100)
as
begin
	declare @isRightPass int = 0

	select @isRightPass = count(*) from dbo.Account where UserName = @userName and PassWord = @password

	if (@isRightPass = 1)
	begin
		if (@newPassword = null or @newPassword = ' ')
		begin
			update dbo.Account set DisplayName = @displayName where UserName = @userName
		end
		else
			update dbo.Account set DisplayName = @displayName, PassWord = @newPassword where UserName = @userName
	end
end
go

select * from dbo.Account
