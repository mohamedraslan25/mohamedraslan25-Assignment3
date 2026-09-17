# Part A — Project & Structure

## `.csproj`

ده ملف إعدادات المشروع، وبيحتوي على إعدادات المشروع الأساسية
زي نوع الـ Output وإصدار الـ .NET المستخدم.

مثال على محتوى ملف `.csproj`:

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
```


- `OutputType`: `Exe`  
  Executable application.

- `TargetFramework`: `net10.0`  
  المشروع ده يشتغل ويتبنى باستخدام .NET 10.

- `ImplicitUsings`: `enable`  
  زي `using System;`، الـ .NET بيضيف مجموعة من الـ common namespaces تلقائيًا.

- `Nullable`: `enable`  
  معناها إن Nullable Reference Types متفعلة.

---

## `Program.cs`

ده الملف الأساسي اللي بنكتب فيه كود الـ C# الخاص بالبرنامج.

---

## `obj/`

ده فولدر بيحتوي على الملفات المؤقتة والـ Intermediate Files  
اللي بيستخدمها .NET أثناء عملية الـ Build.

---

## `bin/`

ده فولدر بيحتوي على الملفات الناتجة بعد عملية الـ Build  
زي الـ DLL والملفات المطلوبة لتشغيل البرنامج.

---

## File-scoped namespace

الـ File-scoped namespace بيخلينا نكتب الـ namespace من غير `{ }`  
وده بيشيل مستوى من الـ indentation ويخلي الكود أبسط في الشكل.

---

## Solution format

المشروع ده بيستخدم الـ `.slnx` وهو الـ Solution Format الأحدث.

من مميزات الـ `.sln` القديم إنه متوافق بشكل أفضل مع الأدوات والبيئات القديمة.
