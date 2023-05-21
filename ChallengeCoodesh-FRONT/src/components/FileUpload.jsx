import React, { useState } from 'react';
import axios from 'axios';

const FileUploader = () => {
  const [selectedFile, setSelectedFile] = useState(null);

  const handleFileChange = (event) => {
    const file = event.target.files[0];
    setSelectedFile(file);
  };

  const handleUpload = () => {
    if (selectedFile) {
      const reader = new FileReader();

      reader.onload = (event) => {
        const fileData = event.target.result;
        const base64Data = btoa(fileData);

        const jsonData = {
          file: base64Data
        };

        axios({
            method: 'post',
            url: `https://localhost:44351/Save`,
            data: JSON.stringify(jsonData.file),
            headers: {
                'Content-Type': "application/json"
            }
      })
          .then(response => {
            console.log('Sucesso:', response.data);
          })
          .catch(error => {
            console.error('Erro:', error);
          });
      };

      reader.readAsText(selectedFile);
    }
  };

  return (
    <div>
      <input type="file" onChange={handleFileChange} />
      <button onClick={handleUpload}>Enviar</button>
    </div>
  );
};

export default FileUploader;