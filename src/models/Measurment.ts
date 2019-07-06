import { Sequelize, Model, DataTypes, BuildOptions  } from 'sequelize';
import { sequelize } from '../sequelize';

export class Measurment extends Model {
  public id!: number; 
  public note!: string;
}

Measurment.init({
    id: {
      type: DataTypes.UUID,
      allowNull: false,
      primaryKey: true,
      defaultValue: DataTypes.UUIDV4
    },
    note: {
      type: DataTypes.STRING,
    },
  },
   {
    tableName: 'measurments',
    sequelize: sequelize, // this bit is important
  }
);
