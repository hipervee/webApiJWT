Declare @userId varchar(100) = '0b3d4fea-ffce-4b02-8f3f-efb60f9d4e05'
--Select * From AspNetRoles
--Insert into AspNetRoles(Id,name) values(1, 'Admin')

--Select * From AspNetUserClaims
--Insert into AspNetUserClaims(UserId, ClaimType, ClaimValue)
--values(@userId, 'CType', 'CValue') 

--Select * from AspNetUserRoles

Insert into AspNetUserRoles values(@userId, 1)


Select * From AspNetUsers