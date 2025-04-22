import { useEffect } from 'react';
import { useState } from 'react';

const Card = ({ title }) => {
  const [hasLiked, setHasLiked] = useState(false);
  return (
    <div className="card">
      <h2>{title}</h2>
      <button onClick={() => setHasLiked(!hasLiked)}>
        {hasLiked ? '✨' : '⭐'}
      </button>
    </div>
  );
};

const App = () => {
  return (
    <div className="card-container">
      <h2>My first react App</h2>
      <Card title="Star wars" />
      <Card title="The Lion King" />
      <Card title="Avatar" />
    </div>
  );
};

export default App;
