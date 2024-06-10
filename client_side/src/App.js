import React from 'react';
import { BrowserRouter as Router, Route, Routes, Link } from 'react-router-dom';
import Doctors from './Doctors';
import Patients from './Patients';

function App() {
  return (
    <Router>
      <div>
        <nav>
          <ul>
            <li><Link to="/doctors">Doctors</Link></li>
            <li><Link to="/patients">Patients</Link></li>
          </ul>
        </nav>
        <Routes>
          <Route path="/doctors" element={<Doctors />} />
          <Route path="/patients" element={<Patients />} />
        </Routes>
      </div>
    </Router>
  );
}

export default App;

