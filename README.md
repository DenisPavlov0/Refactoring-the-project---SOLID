# SOLID Refactoring Project

## 📖 Описание проекта

Этот проект представляет собой игру, разработанную с использованием Unity, которая демонстрирует базовые принципы разработки игр и применения архитектурных паттернов, таких как SOLID. Игра включает основные элементы управления, взаимодействие персонажей и игровой мир.

Рефакторинг был выполнен с целью улучшения читаемости, масштабируемости и соответствия современным стандартам разработки. Были добавлены интерфейсы, улучшены зависимости и разделение обязанностей, а также проведена реорганизация структуры проекта.

## 📝 Ветви репозитория

- **main**: Основная ветка, содержит код до рефакторинга.
- **refactor/game-architecture**: Ветка с результатами рефакторинга, выполненного в соответствии с принципами SOLID.

### Сравнение изменений

Для просмотра всех изменений между ветками [нажмите сюда](https://github.com/DenisPavlov0/SOLID-Refactoring/compare/main...refactor/game-architecture).

---

## 🗂️ Структура проекта

### Основные классы (до рефакторинга):
- `BoardManager` : `MonoBehaviour` — управление игровым полем.
- `Enemy` : `MovingObject` — логика врагов.
- `GameManager` : `MonoBehaviour` — управление основным игровым процессом.
- `Loader` : `MonoBehaviour` — начальная загрузка.
- `MovingObject` : `MonoBehaviour` — базовый класс для объектов, способных перемещаться.
- `Player` : `MovingObject` — логика игрока.
- `SoundManager` : `MonoBehaviour` — управление звуком.
- `Wall` : `MonoBehaviour` — элемент окружения.

### Добавленные классы (после рефакторинга):
- **Интерфейсы:**
  - `ICharacterAnimations` : `ICharacterHitAnimations`, `ICharacterAttackAnimations` 
  - `ICharacterHitAnimations`
  - `ICharacterAttackAnimations` 
  - `IGetInput`

- **Реализации интерфейсов:**
  - `KeyboardInput` : `IGetInput` 
  - `TouchInput` : `IGetInput` 
  - `EnemyAnimations` : `ICharacterAttackAnimations` 
  - `PlayerAnimations` : `ICharacterAnimations` 

- **Менеджеры и вспомогательные классы:**
  - `Food` 
  - `FoodManager` 
  - `GameConfig` 

---

## 🔧 Основные изменения при рефакторинге

1. **Реорганизация структуры папок**:  
   Все скрипты были распределены по папкам в соответствии с их функционалом:  
   - **Core**: базовые системы игры (`GameManager`, `Loader`, `GameConfig`).  
   - **Characters**: логика и анимации для игрока и врагов (`Player`, `Enemy`, `PlayerAnimations`, `EnemyAnimations`).  
   - **Input**: обработка пользовательского ввода (`KeyboardInput`, `TouchInput`).  
   - **Interfaces**: интерфейсы для абстракций (`ICharacterAnimations`, `IGetInput`, и др.).  
   - **Environment**: игровые объекты (`Wall`, `Food`, `FoodManager`).  
   - **Managers**: управление системами игры (`BoardManager`, `SoundManager`).

2. **Инкапсуляция и стиль кода**:  
   - Приватные переменные теперь начинаются с `_` для единообразия.  
   - Добавлены интерфейсы для уменьшения зависимости от конкретных реализаций.  

3. **Рефакторинг методов**:  
   Методы разделены на более мелкие и читаемые части, обеспечивая лучшее соответствие принципам SRP и OCP.

4. **Добавление новых классов и интерфейсов**:  
   - Введены интерфейсы (`ICharacterAnimations`, `IGetInput`) для повышения гибкости.  
   - Реализована система ввода, которая легко адаптируется под новые устройства.

---

## 📌 Как запустить проект

1. Убедитесь, что установлен **Unity Editor** (версии 2021.3 или выше).  
2. Клонируйте репозиторий:  
   ```bash
   git clone https://github.com/DenisPavlov0/SOLID-Refactoring.git
