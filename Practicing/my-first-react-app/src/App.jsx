const Card = ({ title }) => {
  return (
    <div className="card">
      <h2>{title}</h2>
    </div>
  );
};

const App = () => {
  return (
    <div className="card-container">
      <h2>My first react App</h2>
      <Card title="Star wars" />
      <Card title="The lion king" />
      <Card title="Avatar" />
    </div>
  );
};

export default App;
