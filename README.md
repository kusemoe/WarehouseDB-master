# WarehouseDB-master
<!--
 * @Description: 
 * @Author: kusemoe
 * @Github: @kusemoe
 * @Date: 2020-05-27 09:10:37
 * @LastEditTime: 2020-06-08 11:49:10
-->
# 部门管理表(department)
| 字段名称       | 类型         | 字段注释 | 默认值 | 非空 | 说明 |
| -------------- | ------------ | -------- | ------ | ---- | ---- |
| departmentId   | int          | 部门编号 |        | y    | 无   |
| departmentName | nvarchar(50) | 部门名称 |        | y    | 无   |

# 员工表(staff)
| 字段名称       | 类型         | 字段注释 | 默认值      | 非空 | 说明 |
| -------------- | ------------ | -------- | ----------- | ---- | ---- |
| StaffId        | int          | 员工编号 |             | y    | 无   |
| EntryTime      | datetime     | 入职时间 |             | y    | 无   |
| StaffName      | nvarchar(50) | 员工姓名 |             | y    | 无   |
| departmentType | int          | 部门类型 |             | y    | 无   |
| StaffSex       | bit          | 性别     | (0:女,1:男) | y    | 无   |

# 管理员表(admini)
| 字段名称       | 类型         | 字段注释 | 默认值 | 非空 | 说明 |
| -------------- | ------------ | -------- | ------ | ---- | ---- |
| adminiId       | int          | 编号     |        | y    | 无   |
| adminiName     | nvarchar(50) | 用户名   |        | y    | 无   |
| adminiPassword | varchar(50)  | 密码     |        | y    | 无   |

# 订单管理表(Order)
| 字段名称  | 类型         | 字段注释 | 默认值 | 非空 | 说明 |
| --------- | ------------ | -------- | ------ | ---- | ---- |
| OrderId   | int          | 编号     |        | y    | 无   |
| BarCode   | char(13)     | 产品条码 |        | y    | 无   |
| OrderTime | datetime     | 订单时间 |        | y    | 无   |
| address   | nvarchar(50) | 所在地   |        | y    | 无   |
| Remarks   | text         | 备注     |        | y    | 无   |


# 供应商表 (supplier)
| 字段名称     | 类型         | 字段注释   | 默认值 | 非空 | 说明 |
| ------------ | ------------ | ---------- | ------ | ---- | ---- |
| supplierName | nvarchar(50) | 供应商名称 |        | y    | 无   |
| Address      | nvarchar(50) | 地址       |        | y    | 无   |
| phone        | varchar(15)  | 电话       |        | y    | 无   |
| supplierId   | int          | 编号       |        | y    | 无   |
| principal    | nvarchar(50) | 负责人     |        | y    | 无   |
| Emli         | nvarchar(50) | 邮箱       |        | y    | 无   |

# 进货表(Purchase) 

| 字段名称     | 类型     | 字段注释   | 默认值 | 非空 | 说明 |
| ------------ | -------- | ---------- | ------ | ---- | ---- |
| PurchaseId   | int      | 进货编号   |        | y    | 无   |
| ProductId    | int      | 产品编号   |        | y    | 无   |
| supplierId   | int      | 供应商编号 |        | y    | 无   |
| number       | int      | 数量       |        | y    | 无   |
| status       | int      | 状态       |        | y    | 无   |
| PurchaseTime | datetime | 进货时间   |        | y    | 无   |
（待审核，审核成功，审核失败）

# 出货表(Shipping)  

| 字段名称     | 类型     | 字段注释   | 默认值 | 非空 | 说明 |
| ------------ | -------- | ---------- | ------ | ---- | ---- |
| ShippingId   | int      | 出货编号   |        | y    | 无   |
| ProductId    | int      | 产品编号   |        | y    | 无   |
| supplierId   | int      | 供应商编号 |        | y    | 无   |
| number       | int      | 数量       |        | y    | 无   |
| status       | int      | 状态       |        | y    | 无   |
| ShippingTime | datetime | 出货时间   |        | y    | 无   |
（待审核，审核成功，审核失败）


# 类型表(type)
| 字段名称 | 类型         | 字段注释 | 默认值 | 非空 | 说明 |
| -------- | ------------ | -------- | ------ | ---- | ---- |
| typeID   | int          | 类型编号 |        | y    | 无   |
| typeName | nvarchar(50) | 类型名称 |        | y    | 无   |

# 客户表(client) 

| 字段名称   | 类型         | 字段注释 | 默认值 | 非空 | 说明 |
| ---------- | ------------ | -------- | ------ | ---- | ---- |
| ClientId   | int          | 编号     |        | y    | 无   |
| ClientName | nvarchar(50) | 姓名     |        | y    | 无   |
| Emli       | nvarchar(50) | 邮箱     |        | y    | 无   |
| Phone      | varchar(15)  | 电话     |        | y    | 无   |
| Address    | nvarchar(50) | 地址     |        | y    | 无   |

# 产品表 (product)
| 字段名称    | 类型         | 字段注释 | 默认值 | 非空 | 说明 |
| ----------- | ------------ | -------- | ------ | ---- | ---- |
| ProductId   | int          | 产品编号 |        | y    | 无   |
| Barcode     | char(13)     | 产品条码 |        | y    | 无   |
| ProductName | nvarchar(50) | 产品名称 |        | y    | 无   |
| money       | money        | 价格     |        | y    | 无   |
| type        | nvarchar(50) | 类型     |        | y    | 无   |
| Remarks     | text         | 备注     |        | y    | 无   |

# 账单表(Bill) 
| 字段名称  | 类型         | 字段注释 | 默认值 | 非空 | 说明 |
| --------- | ------------ | -------- | ------ | ---- | ---- |
| BillId    | int          | 编号     |        | y    | 无   |
| ProductId | int          | 产品编号 |        | y    | 无   |
| BillNum   | int          | 数量     |        | y    | 无   |
| BillType  | nvarchar(50) | 类型     |        | y    | 无   |
| BillTime  | nvarchar(50) | 时间     |        | y    | 无   |


# 数据库设计

1.员工表-staff
- 员工编号 入职时间 员工姓名 性别 部门类型

2.管理员表-admini
- 编号 用户名 密码
  
3.订单管理表-Order
- 编号 产品条码 订单时间 所在地 备注

4.供应商表-supplier
- 编号 供应商名称 负责人 邮箱 地址 电话

5.进货表-Purchase 
- 产品编号 供应商编号 数量 状态 进货时间

6.出货表-Shipping  
- 产品编号 供应商编号 数量 状态 出货时间

7.类型表-type
- 类型编号 类型名称

8.客户表-client 
- 编号 姓名 邮箱 电话 地址

9.产品表-product
- 产品编号 产品条码 产品名称 价格 类型 备注

10.部门管理表-department
- 部门编号 部门名称

11.账单表-Bill
- 编号 产品编号 数量 类型 时间

- [x] 员工表
- [x] 账单表
- [x] 类型表
- [x] 产品表
- [x] 进货表
- [x] 出货表
- [x] 客户表
- [x] 管理员表
- [x] 供应商表
- [x] 订单管理表
- [x] 部门管理表


