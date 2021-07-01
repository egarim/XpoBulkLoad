# XpoBulkLoad

Without bulk load

01.07.21 22:46:17.571 Executing sql 'select N0.[OID],N0.[Code],N0.[Name],N0.[OptimisticLockField],N0.[GCRecord] from [Customer] N0 where N0.[GCRecord] is null'
01.07.21 22:46:17.573 Result: rowcount = 5, total = 186, N0.{OID,Int32} = 20, N0.{Code,String} = 50, N0.{Name,String} = 76, N0.{OptimisticLockField,Int32} = 20, N0.{GCRecord,Int32} = 20
total database trips:1
001 Javier
002 Hector
003 Oniel
004 Hismel
005 Joche
01.07.21 22:46:17.585 Executing sql 'select N0.[OID],N0.[Code],N0.[Name],N0.[OptimisticLockField],N0.[GCRecord] from [Product] N0 where N0.[GCRecord] is null'
01.07.21 22:46:17.586 Result: rowcount = 3, total = 124, N0.{OID,Int32} = 12, N0.{Code,String} = 30, N0.{Name,String} = 58, N0.{OptimisticLockField,Int32} = 12, N0.{GCRecord,Int32} = 12
total database trips:2
001 Computer
002 Cellphone
003 Laptop
total database trips:2

with bulk load

01.07.21 22:47:05.042 Executing sql 'select N0.[OID],N0.[Code],N0.[Name],N0.[OptimisticLockField],N0.[GCRecord] from [Customer] N0 where N0.[GCRecord] is null'
01.07.21 22:47:05.044 Result: rowcount = 5, total = 186, N0.{OID,Int32} = 20, N0.{Code,String} = 50, N0.{Name,String} = 76, N0.{OptimisticLockField,Int32} = 20, N0.{GCRecord,Int32} = 20
01.07.21 22:47:05.045 Executing sql 'select N0.[OID],N0.[Code],N0.[Name],N0.[OptimisticLockField],N0.[GCRecord] from [Product] N0 where N0.[GCRecord] is null'
01.07.21 22:47:05.047 Result: rowcount = 3, total = 124, N0.{OID,Int32} = 12, N0.{Code,String} = 30, N0.{Name,String} = 58, N0.{OptimisticLockField,Int32} = 12, N0.{GCRecord,Int32} = 12
total database trips:1
001 Javier
002 Hector
003 Oniel
004 Hismel
005 Joche
001 Computer
002 Cellphone
003 Laptop
total database trips:1



