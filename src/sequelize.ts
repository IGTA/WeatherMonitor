import { Sequelize } from 'sequelize';
import {DB_PASSWORD, DB_USERNAME, DB_ADDRESS, DB_NAME} from '../config/config'
console.log(`postgres://${DB_USERNAME}:${DB_PASSWORD}@${DB_ADDRESS}/${DB_NAME}`)
export const sequelize = new Sequelize(`postgres://${DB_USERNAME}:${DB_PASSWORD}@${DB_ADDRESS}/${DB_NAME}`);

sequelize.authenticate()
    .then(() => {
        console.log('Connection has been established successfully.');
    })
    .catch((err) => {
        console.error('Unable to connect to the database:', err);
    });
