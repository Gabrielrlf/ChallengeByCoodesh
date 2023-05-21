import React, { useEffect, useState } from 'react';
import axios from 'axios';
import DataGrid from 'react-data-grid';
import 'react-data-grid/lib/styles.css';

const GridComponent = () => {
    const [data, setData] = useState([]);
    const [sum, setSum] = useState(0);
    const columns = [
        { key: 'id', name: 'ID' },
        { key: 'productDescription', name: 'Produto' },
        { key: 'valueProduct', name: 'Valor' },
        { key: 'sellerName', name: 'Vendedor' },

    ];

    useEffect(() => {
        if(data.length > 0)
        {
            const total = data.reduce((valueTotal, item) => valueTotal + item.valueProduct, 0);
            setSum(total);
        }
    }, [data])

    useEffect(() => {
        axios.get(`https://localhost:44351/GetAll`).then(response => {
            setData(response.data)
            console.log("Success: ", response.data)
        }
        ).catch(error => {
            console.error('Erro:', error);
        });
    }, [])

    return (
        <>
            <DataGrid columns={columns} rows={data} />
            <h3>Valor total {sum.toFixed(2)} </h3>
        </>);
};

export default GridComponent;