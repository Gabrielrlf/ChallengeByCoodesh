import { useState } from 'react'
import './App.css'
import FileUploader from './components/FileUpload'

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
      <div>

      </div>
      <h1>This is Challenger by Coodesh</h1>
      <div className="card">
        <FileUploader />
      </div>
      <p className="read-the-docs">
        By: Gabriel Fonsêca
      </p>
    </>
  )
}

export default App
