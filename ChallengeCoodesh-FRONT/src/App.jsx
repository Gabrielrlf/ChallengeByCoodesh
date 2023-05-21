import { useState } from 'react'
import './App.css'
import FileUploader from './components/FileUpload'
import GridComponent from './components/GridComponent'

function App() {
  return (
    <>
      <div>

      </div>
      <h1>Isso é um desafio by Coodesh</h1>
      <div className="card">
        <FileUploader />
      </div>
      <>
      <h3>Lista de importações</h3>
        <GridComponent />
      </>
      <p className="read-the-docs">
        By: Gabriel Fonsêca
      </p>
    </>
  )
}

export default App
