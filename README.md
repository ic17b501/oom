<<<<<<< HEAD
#  Alle Tasks wurden in einem eigenen branch gepushed, und halten nur die fuer den Task relevanten Dateien. (ic17b501) 

=======
# informationen zur Abgabe 
  * Es wurde fuer die Tests (condition-constraints von NUnit) eine Abstracte Methode declariert, welche eine NotSupportedException wirft, rein fuer diese Uebung. (Methode Student:DoNothing());
  * Die Klasse Assistant erbt nun von Student wie vorgesehen (bei der vorherigen Uebeung mussten 2 Separate Klassen das Interface implementieren. Daher wurde diese damals anders geschrieben.
  * Nach dem Deserializieren der Objekte in einer Liste werden diese iteriert, und fuer jedes Objekt dessen Methode print() aufgerufen.  

  * Zu **T4.1** -> **nuget und json** werden ueber nuget.config und packages.config abgehandelt und in external geladen
  * Zu **T4.2** -> **tasks/Task4/tests/testcases.cs** enthaelt einige Tests. Assertrs wurden mit mehr als 8 unterschiedlichen **condition-constraints** erstellt. Es gibt jedoch nur 5 Test-Cases da die Funktionalitaet der Classen recht eingeschreankt ist, und es so gesehen *wenig* zum Testen gibt.
  * Zu **T4.3** -> **/tmp/task4_data.json** enthaelt den JSON String. Es wird nach der Datei gescuht und nur geprueft ob diese vorhanden ist. Falls ja, so werden alle Objecte in eine Liste List<Student> geladen. Falls nicht, so werden die Objekte erstellt, und anschlieszend serializiert und in diese Datei geschrieben. Bei jedem Vorgang wird der JSON String bzw. der Inhalt der Datei ausgegeben.


## Objektorientierte Methoden (OOM)
  Object-Oriented Design (OOD) and Programming (OOP)

### [Lesson 1 - Kick Off](https://github.com/bicoom/oom/wiki/Lesson-1)
  * Introduction and Guidelines
    * [Wiki](https://github.com/bicoom/oom/wiki)
    * [Issues](https://github.com/bicoom/oom/issues)
  * Setting up your development environment
    * C#
    * Git
  * Hello World
    * basic console app
    * C# for C programmers - first steps

### [Lesson 2 - Fundamentals I](https://github.com/bicoom/oom/wiki/Lesson-2)
  * Concepts
    * classes
    * methods
    * fields and properties
    * visibility and encapsulation
  * Toolkit
    * web requests

### [Lesson 3 - Fundamentals II](https://github.com/bicoom/oom/wiki/Lesson-3)
  * Concepts
    * methods as values
    * lambda expressions
    * inheritance
    * interfaces
    * polymorphism

### [Lesson 4 - Software Quality](https://github.com/bicoom/oom/wiki/Lesson-4)
  * Concepts
    * refactoring
    * unit tests
    * continuous integration [![Build status](https://ci.appveyor.com/api/projects/status/6e5h7fiyhtwdpbce/branch/master?svg=true)](https://ci.appveyor.com/project/bicoom/oom/branch/master)
  * Toolkit
    * package managers (NuGet)
    * serialization (JSON)
    * files
      
### [Lesson 5 - Code Review](https://github.com/bicoom/oom/wiki/Lesson-5)
  * review of student projects
  * definition of tasks/issues
  * time for questions, bugfixing, problem solving

### [Lesson 6 - Sequences, Queries and Combinators](https://github.com/bicoom/oom/wiki/Lesson-6)
  * IEnumerable, foreach, yield return
  * queries and combinators

### [Lesson 7 - Threads, Tasks, Promises and Continuations](https://github.com/bicoom/oom/wiki/Lesson-7)
  * threads and tasks
  * promises and continuations
  * reactive programming, async/await

### [Lesson 8 - Final Evaluation](https://github.com/bicoom/oom/wiki/Lesson-8)
  * final evaluation of student projects
