# WeatherMonitor
Weather monitoring product

разработка (задачи) описываются в https://github.com/IGTA/WeatherMonitor/projects

## ORM

Для работы с базой используется ORM sequelize 

пример записи сущности в базу

```typescript

import { Measurment } from './Models/Measurments';
import { Model } from 'sequelize/types';

stuff();

const stuff = (async () => {
    try {
        const measurment = Measurment.create({ 
            note: 'Some note'
        });
        console.log(badge);
    } catch (err) {
        console.log(err);
    }
})

```
