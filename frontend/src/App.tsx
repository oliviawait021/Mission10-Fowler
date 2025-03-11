import './App.css';
import BowlerList from './BowlerList';

function Header() {
  return (
    <>
      <h1>Welcome to the Bowling League Database</h1>
      <h2>Below displayed are the bowlers from the Marlins and the Sharks</h2>
      <br></br>
    </>
  );
}

function App() {
  return (
    <>
      <Header />
      <BowlerList />
    </>
  );
}

export default App;
