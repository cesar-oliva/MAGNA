import React, { useEffect } from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import axios from 'axios';
import { Modal, ModalBody, ModalFooter, ModalHeader } from 'reactstrap';


function App() {
    const baseUrl="https://localhost:5001/api/Employee";
    const [data, setData] = useState([]);


    const peticionGet = () => {
        await axios.get(baseUrl)
            .then(response => {
                setData(response.data);
            }).cath(error => {
                console.log(error);
            })
    }

    useEffect(() => {
        peticionGet();
    },[])


    return (
        <div className="App">
            <table className="Table table-bordered">
                <thead>
                    <tr>
                        <th scope="col">Id</th>
                        <th scope="col">Code</th>
                        <th scope="col">First Name</th>
                        <th scope="col">Last Name</th>
                        <th scope="col">Start Date</th>
                        <th>Acciones</th>

                    </tr>
                </thead>
                <tbody>
                    {data.map(employee => (
                        <tr key={employee.Id}>
                            <td>{employee.Code}</td>
                            <td>{employee.FirstName}</td>
                            <td>{employee.LasName}</td>
                            <td>{employee.StartDate}</td>
                            <td>
                                <button className="btn btn-primary">Editar</button> {" "}
                                <button className="btn btn-danger">Eliminar</button> {" "}
                            </td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>       
    );
}




ReactDOM.render(<CommentBox />, document.getElementById('content'));