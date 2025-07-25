3D Unity Game: Time Challenge
Простая 3D-игра, созданная в Unity, где игрок управляет персонажем, собирает объекты и проходит испытание на время.

Основные механики:
Управление персонажем (перемещение, физика, камера следует за игроком).

Система жизней: при столкновении с врагами или опасными объектами (например, шипы) здоровье уменьшается.

Сбор очков (UI Text отображает текущее количество).

Таймер-испытание: при взаимодействии с объектом A запускается корутина (60 секунд), за которые игрок должен добраться до объекта B.

Две панели с результатами:

"Вы победили" – если игрок успевает достичь цели.

"Вы проиграли" – если здоровье заканчивается или время истекает.

Кнопка перезапуска сцены.

Что реализовано:
 Персонаж с управлением и физикой
 Враги и опасные объекты (наносят урон)
 Система сбора очков
 Таймер-испытание (корутина)
 UI: отображение жизней, очков, финальные панели

Проект создан в рамках учебного задания, демонстрирует работу с Unity (C# скрипты, коллайдеры, корутины, UI).