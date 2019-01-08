create PROC sp_Login @user nvarchar(50),@pass nvarchar(255)
as
begin
select * from DangNhap_ T where T.userr=@user and T.pass=@pass
end
go
exec sp_Login 'admin','33354741122871651676713774147412831195'
go
create proc sp_XoaTK @user nvarchar(50)
as
begin
delete from DangNhap_ where userr=@user
end
go
create proc sp_ThemTK @user nvarchar(50),@pass nvarchar(50),@rule nvarchar(50)
as
begin
insert into DangNhap_ values(@user,@pass,@rule)
end
go
create proc sp_SuaTK @user nvarchar(50),@pass nvarchar(50),@rule nvarchar(50)
as
begin
UPDATE DangNhap_ set pass=@pass,rulee=@rule where userr=@user
end