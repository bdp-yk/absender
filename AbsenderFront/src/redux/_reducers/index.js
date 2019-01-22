import { combineReducers } from 'redux';
import { users } from './users.reducer';


const rootReducer = combineReducers({
  users,
  // otherReducers
});

export default rootReducer;