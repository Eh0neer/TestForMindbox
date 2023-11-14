# TestForMindbox

## Эта библиотека на C# предназначена для вычисления площади геометрических фигур. Библиотека обладает следующими возможностями:

### Реализованные фигуры

#### Круг

```csharp
Circle circle = new Circle(radius);
double circleArea = circle.CalculateArea();
```

#### Треугольник

```csharp
Triangle triangle = new Triangle(sideA, sideB, sideC);
double triangleArea = triangle.CalculateArea();
bool isRightTriangle = triangle.IsRightTriangle();
```

## Дополнительные возможности

### Юнит-тесты

Все основные функциональности библиотеки покрыты юнит-тестами для обеспечения их корректной работы.

### Легкость добавления других фигур

Библиотека разработана с учетом расширяемости. Добавление новых фигур требует минимальных изменений в коде.

### Вычисление площади фигуры без знания типа фигуры в compile-time

```csharp
IShape shape = new Circle(radius);
double area = ShapeCalculator.CalculateArea(shape);
```

Это позволяет вычислить площадь фигуры, не зная ее конкретного типа во время компиляции.

### Проверка на то, является ли треугольник прямоугольным

```csharp
bool isRightTriangle = triangle.IsRightTriangle();
```

## Использование

1. Подключите библиотеку к вашему проекту.
2. Создайте экземпляры фигур (круга, треугольника и др.).
3. Вызывайте методы для вычисления площади и проверки дополнительных свойств фигур.

# SQL скрипт
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

```sql
SELECT 
    P.ProductName,
    COALESCE(C.CategoryName, 'Без категории') AS CategoryName
FROM
    Products P
LEFT JOIN
    ProductCategory PC ON P.ProductID = PC.ProductID
LEFT JOIN
    Categories C ON PC.CategoryID = C.CategoryID;
