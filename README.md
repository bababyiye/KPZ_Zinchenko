# Лабораторна Робота: Зоопарк

## Опис Проекту
Цей проект є симуляцією управління зоопарком з використанням мов програмування C#. Він включає класи для тварин, працівників, вольєрів та інвентаризації зоопарку.

## Класи та Їх Опис
### Animal
- **Атрибути:**
  - string Name
  - string Species
  - string Diet
- **Методи:**
  - DisplayInfo()

### Employee
- **Атрибути:**
  - string Name
  - string Position
- **Методи:**
  - DisplayEmployeeInfo()

### Enclosure
- **Атрибути:**
  - string Type
  - int Capacity
  - List<Animal> Animals
- **Методи:**
  - AddAnimal(Animal animal)
  - DisplayEnclosureInfo()

### ZooInventory
- **Атрибути:**
  - List<Animal> Animals
  - List<Employee> Employees
  - List<Enclosure> Enclosures
- **Методи:**
  - DisplayInventory()

## Принципи Програмування

### DRY (Don't Repeat Yourself)
Принцип DRY в даному коді застосовується завдяки використанню методів та класів, що дозволяє уникнути дублювання коду. Наприклад, метод [DisplayInfo()](./GlobalClass/Animal.cs#L15) в класі [Animal](./GlobalClass/Animal.cs) використовується для виведення інформації про тварину.

### KISS (Keep It Simple, Stupid)
Код структурований просто та зрозуміло, з чітким розділенням відповідальності між класами. Наприклад, клас [ZooInventory](./GlobalClass/ZooInventory.cs) відповідає за зберігання та виведення інформації про тварин, працівників та вол'єри.

### SOLID
- **S**ingle Responsibility Principle: Кожен клас має одну відповідальність, наприклад, клас [Animal](./GlobalClass/Animal.cs) відповідає тільки за опис тварини.
- **O**pen/Closed Principle: Класи відкриті для розширення, але закриті для модифікації. Наприклад, можна додати нові методи до класу [Enclosure](./GlobalClass/Enclosure.cs), не змінюючи його основної структури.
- **L**iskov Substitution Principle: Класи-нащадки повинні мати можливість замінювати свої базові класи без порушення роботи програми. Наприклад, можна створити клас-нащадок `CarnivoreAnimal`, який успадковується від класу [Animal](./GlobalClass/Animal.cs).
- **I**nterface Segregation Principle: Принцип дотриманий шляхом чіткого розподілу функцій між класами без зайвих інтерфейсів.
- **D**ependency Inversion Principle: Використання залежностей вказується через конструктори, що дозволяє легко підміняти об'єкти.

### YAGNI (You Ain't Gonna Need It)
В даному коді використовується лише необхідний функціонал без зайвих ускладнень та функцій.

### Composition Over Inheritance
Код демонструє використання композиції замість наслідування, наприклад, клас [ZooInventory](./GlobalClass/ZooInventory.cs) містить об'єкти [Animal](./GlobalClass/Animal.cs), [Employee](./GlobalClass/Employee.cs) та [Enclosure](./GlobalClass/Enclosure.cs) без створення класів-нащадків.

### Program to Interfaces not Implementations
Використання інтерфейсів уможливлює гнучкість та розширюваність коду.

### Fail Fast
Клас [Enclosure](./GlobalClass/Enclosure.cs) перевіряє кількість тварин перед додаванням нового, і виводить повідомлення, якщо вольєр переповнений.

## Посилання на код
- [Main метод](./Console/Program.cs#L10)
- [Animal клас](./GlobalClass/Animal.cs)
- [Enclosure клас](./GlobalClass/Enclosure.cs)
- [Employee клас](./GlobalClass/Employee.cs)
- [ZooInventory клас](./GlobalClass/ZooInventory.cs)
