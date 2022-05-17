# Sirius2022
Soluzione Progetto Sirius del 2022

Istruzioni per la migration https://docs.google.com/document/d/1Q5NEJlM1pmxp0yg21PMDJPVtcnYo9ciG7owhRH5CH5I/edit

Link documentazione Annotation  https://www.learnentityframeworkcore.com/configuration/data-annotation-attributes

Link documentazione per creare classi da DB https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/models-data/creating-model-classes-with-the-entity-framework-cs   https://docs.microsoft.com/en-us/answers/questions/357012/can39t-find-adonet-entity-data-model-missing-visua.html

I solved the same problem by following these:

1)While Creating project don't select class Library(.NET Standard) Choose Class Library (.NET Framework)

2)Choose ASP.NET Web Application (.NET Framework)

3) Go to Tools -> Get Tools and features.
Select Individual components tab and check Entity Framework 6 tools under SDK's, libraries, and framework section

4)Remember you can't make an ADO.net Entity Data Model with an interface with .NET Core, its only possible with .NET Framework.

Hope these will solve yours too.
