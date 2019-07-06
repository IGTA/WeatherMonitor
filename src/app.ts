import express = require('express');
import { sequelize } from './sequelize';

const app = express();
const port = 3000; // default port to listen

// define a route handler for the default home page
app.get('/', (req: any, res: any) => {
    res.send('Hello world!');
});

app.get('/test', (req: any, res: any) => {
    res.send({
        data: ['Test data!',
            'Test data1', 'Test data2'],
        date: new Date(),
    });
});

sequelize.sync()
    .then(() => {
        console.log("db sync");
    });

// start the Express server
app.listen(port, () => {
    console.log(`server started at http://localhost:${ port }`);
});
