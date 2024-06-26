﻿## هدف
این پروژه براساس مقاله 
1. [معماری تمیز (Clean Architecture) چیست ؟ ۵ مرحله راه اندازی آن](https://nikamooz.com/what-is-clean-architecture/)

2. [پیاده سازی معماری Domain Driven Design و تست نویسی + راهنمای گام به گام](https://nikamooz.com/implementation-of-domain-driven-design-architecture/)

برای یادگیری خودم ایجاد شده است

## لایه بندی ها

### Domain
آنچه معمولاً در پروژه Domain تعریف می‌کنید، قوانین اصلی مربوط به کسب و کار، Enumerations ،Value Object ها، Custom Exception و چنین مواردی است. توجه کنید که در این آموزش، تمام این موارد انجام نمی‌شوند؛ بلکه تنها روی Setup ساختار پروژه براساس Clean Architecture تمرکز خواهد شد.

### Aplication
پروژه Application یک Orchestrator از سایر لایه‌ها و Use Case ها تلقی می‌شود. این یعنی در این لایه، ماژول‌های مختلف فراخوانی و مورد استفاده قرار می‌گیرند و هیچ منطقی مرتبط با کسب و کار تعریف نخواهد شد. همچنین، در این لایه می‌توانید Service های گوناگون را فراخوانی و به‌کار ببرید.

#### روش نام گذاری 
 - Command  : [Action][Feature]Command
	- Action : {Create,Delete,Update,...}
	- Feature :  نام مصدری یک موجودیت، یا یک موضوع که روی آن کاری انجام می شود
