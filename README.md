# BattleSmile (фан-проект)

BattelSmile — это простая консольная игра на C#, где две команды смайликов сражаются друг против друга.

Игрок управляет командой Red Team и вручную задаёт порядок бойцов.  
Команда Blue Team генерируется автоматически в случайном порядке.

После этого игра запускает серию боёв: первый смайлик Red Team сражается с первым смайликом Blue Team, второй со вторым и так далее.

## Идея проекта

В игре есть 10 смайлик-героев:

| № | Герой | Тип |
|---|---|---|
| 0 | 😎 | SunglassesFace |
| 1 | 🐸 | Frog |
| 2 | 🚀 | Rocket |
| 3 | 🍕 | Pizza |
| 4 | 🧠 | Brain |
| 5 | ⚔️ | CrossedSwords |
| 6 | 🌙 | CrescentMoon |
| 7 | 🐉 | Dragon |
| 8 | 🎲 | GameDie |
| 9 | 🔥 | Fire |

Каждый герой имеет свою силу.  
Во время боя сравнивается сила двух героев:

- если сила героя Red Team больше — герой Blue Team погибает;
- если сила героя Blue Team больше — герой Red Team погибает;
- если силы равны — погибают оба героя.

После всех боёв программа считает, в какой команде осталось больше живых героев.

## Возможности

- создание двух команд: Red Team и Blue Team;
- ручной выбор порядка бойцов для Red Team;
- автоматическая генерация порядка бойцов для Blue Team;
- проверка некорректного ввода;
- запрет повторного выбора одного и того же бойца;
- пошаговые бои между смайликами;
- вывод результата каждого боя;
- подсчёт победившей команды;
- поддержка emoji в консоли через UTF-8.

## Как работает игра

Сначала программа выводит список бойцов Red Team:

```text
RED TEAM
😎    🐸    🚀    🍕    🧠    ⚔️    🌙    🐉    🎲    🔥
Arrange the order of emoticons


Игрок вводит номера смайликов от `0` до `9`, чтобы задать порядок боя.

Например:

```text
Input number from 0 to 9
3
Input number from 0 to 9
7
Input number from 0 to 9
0
```

Это значит, что Red Team будет сражаться в таком порядке:

```text
🍕 -> 🐉 -> 😎
```

После выбора всей команды программа автоматически генерирует порядок Blue Team.

Пример вывода:

```text
GENERATION BLUE TEAM
FIGHT
RED TEAM VS BLUE TEAM

3 - 🍕    7 - 🐉    0 - 😎
VS
8 - 🎲    1 - 🐸    5 - ⚔️

Fight #1
🍕 VS 🎲
🍕 DEAD

Fight #2
🐉 VS 🐸
🐸 DEAD

Fight #3
😎 VS ⚔️
😎 DEAD
```

В конце выводится результат:

```text
RED WIN
```

или:

```text
BLUE WIN
```

или:

```text
DRAW
```

## Логика боя

Базовая логика находится в классе `SmileHero`.

У каждого героя есть:

* `Image` — emoji героя;
* `SmileType` — тип героя;
* `SmileCommand` — команда героя;
* `Strong` — сила героя;
* `IsLive` — жив герой или нет.

Метод `Attack` сравнивает силу двух героев:

```csharp
public void Attack(SmileHero enemy)
{
    Console.WriteLine($"{Image} VS {enemy.Image}");

    if (Strong > enemy.Strong)
    {
        enemy.IsLive = false;
        Console.WriteLine($"{enemy.Image} DEAD");
    }
    else if (Strong < enemy.Strong)
    {
        IsLive = false;
        Console.WriteLine($"{Image} DEAD");
    }
    else
    {
        enemy.IsLive = false;
        IsLive = false;
        Console.WriteLine($"{Image} AND {enemy.Image} DEADS");
    }
}
```

## Герои

В проекте есть отдельные классы-наследники для каждого героя:

```text
SunglassesFaceSmileHero
FrogSmileHero
RocketSmileHero
PizzaSmileHero
BrainSmileHero
CrossedSwordsSmileHero
CrescentMoonSmileHero
DragonSmileHero
GameDieSmileHero
FireSmileHero
```

Пример героя:

```csharp
internal class DragonSmileHero : SmileHero
{
    public DragonSmileHero()
    {
        Image = "🐉";
        smileType = SmileType.Dragon;
        Strong = 100;
        IsLive = true;
    }
}
```

## Структура проекта

```text
BattelSmile/
│
├── Program.cs
├── ISmileHero.cs
├── SmileHeros.cs
├── BattelSmile.csproj
├── BattelSmile.slnx
├── .gitignore
└── .gitattributes
```

### Program.cs

Главный файл приложения.

Отвечает за:

* создание Red Team;
* создание Blue Team;
* выбор порядка Red Team;
* генерацию порядка Blue Team;
* запуск боёв;
* вывод победителя.

### ISmileHero.cs

Содержит:

* базовый абстрактный класс `SmileHero`;
* enum `SmileCommand`;
* enum `SmileType`.

### SmileHeros.cs

Содержит классы всех смайлик-героев.


## Запуск проекта

Склонируйте репозиторий:

```bash
git clone https://github.com/Archikey/BattelSmile.git
```

Перейдите в папку проекта:

```bash
cd BattelSmile
```

Запустите проект:

```bash
dotnet run
```

## Важно для отображения emoji

Для корректного отображения смайликов в консоли используется UTF-8:

```csharp
Console.OutputEncoding = Encoding.UTF8;
```

Если emoji отображаются как `??`, лучше запускать проект через Windows Terminal.

## Скриншоты
<img width="1280" height="809" alt="image" src="https://github.com/user-attachments/assets/ba349660-381c-4f91-8fa7-d7053b132e10" />
<img width="1280" height="1089" alt="image" src="https://github.com/user-attachments/assets/95aaf321-ec1f-4b28-ae52-bbcee47e790a" />


