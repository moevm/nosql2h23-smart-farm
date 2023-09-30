1) Для запуска контейнеров: 
переходим в nosql2h23-smart-farm/SmartFarm.Web и пишем команду:
docker-compose up --build
2) переходим на localhost:8080
 
Для того, чтобы применились изменения, особенно те, что в Blazor, необходимо пересобрать проект и перезапустить контейнер сервера

2 вариант для разработчиков: 
1) в appsettings.json меняем ConnectionString на mongodb://localhost:27017/TestDb"
2) Запускаем контейнер mongo:  docker run -d -p 27017:27017 --name mongo mongo:latest
3) Запускаем через Visual studio сервер.

# nosql_template


## Предварительная проверка заданий

<a href=" ./../../../actions/workflows/1_helloworld.yml" >![1. Установка и настройка выбранной БД + ЯП]( ./../../actions/workflows/1_helloworld.yml/badge.svg)</a>

<a href=" ./../../../actions/workflows/2_usecase.yml" >![2. Usecase]( ./../../actions/workflows/2_usecase.yml/badge.svg)</a>

<a href=" ./../../../actions/workflows/3_data_model.yml" >![3. Модель данных]( ./../../actions/workflows/3_data_model.yml/badge.svg)</a>

<a href=" ./../../../actions/workflows/4_prototype_store_and_view.yml" >![4. Прототип хранение и представление]( ./../../actions/workflows/4_prototype_store_and_view.yml/badge.svg)</a>

<a href=" ./../../../actions/workflows/5_prototype_analysis.yml" >![5. Прототип анализ]( ./../../actions/workflows/5_prototype_analysis.yml/badge.svg)</a> 

<a href=" ./../../../actions/workflows/6_report.yml" >![6. Пояснительная записка]( ./../../actions/workflows/6_report.yml/badge.svg)</a>

<a href=" ./../../../actions/workflows/7_app_is_ready.yml" >![7. App is ready]( ./../../actions/workflows/7_app_is_ready.yml/badge.svg)</a>
