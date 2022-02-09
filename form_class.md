**8. Windows Forms. Создание библиотеки классов

1. Создадим библиотеку классов .Net Framework
![MinCostLibrary](./gifs/MinCostLibrary.gif)

2. Подключим библиотеку классов ```MinCostLibrary``` в проект
![LinkMinCostLibrary](./gifs/LinkMinCostLibrary.gif)

3. Создадим в библиотеке статический метод ```MaxCostProduct``` класса ```MinCost``` , который для примера просто будет выводить максимальную цену продукта

```Csharp

string connectionString = @"server=localhost;userid=root;password=root;database=vosmerka;charset=utf8";
            string sql = "select round(max(MinCostForAgent),2) from product";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sCommand = new MySqlCommand(sql, connection);
            string result = sCommand.ExecuteScalar().ToString();
            return result.Replace(",", "."); // из базы данных ,


```
4. Вывовим метод бибилиотеки в загрузчике формы ```ProductForm``` и поместим результат работы метода в Label.
![MaxCostProduct](./gifs/MaxCostProduct.gif)



