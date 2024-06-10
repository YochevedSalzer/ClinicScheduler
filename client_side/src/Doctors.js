import React, { useEffect, useState } from 'react';

function Doctors() {
  const [data, setData] = useState(null);

  useEffect(() => {
    fetch('http://localhost:5058/api/doctors') 
      .then(response => response.json())
      .then(data => setData(data));
  }, []);

  return (
    <div>
      <h1>Doctors</h1>
      {data ? (
        <div>
          <h2>Data from Server:</h2>
          <pre>{JSON.stringify(data, null, 2)}</pre>
        </div>
      ) : (
        <p>Loading...</p>
      )}
    </div>
  );
}

export default Doctors;
